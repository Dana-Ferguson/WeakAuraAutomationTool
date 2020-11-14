function ()
  -- Positions all active auras on the screen
  -- Scripts used to be distributed to each AURA, but performance was heavily degraded

  -- Player Info
  local playerClassSpec = GetSpecializationInfo(GetSpecialization())
  local playerSpecGroup = GetActiveSpecGroup()
  local playerTalents = {}

  playerTalents[0] = true
  for i=1, 21 do
    local talent = i;
    local col = (talent-1)%3+1;
    local row = math.floor((talent-col)/3)+1;

    local talentKnown = select(4, GetTalentInfo(row, col, playerSpecGroup, false))
    if talentKnown then
        playerTalents[talent] = true
    end
  end

  -- Aura Class
  Aura = {
    id='', classSpec=0, talent=0, grid=1, advance=false
  }

  -- Accumulator variables to trim some space off of the imported aura database
  local _auraClassSpec = 0;
  local _auraTalent = 0;
  local _auraGrid = 0;

  Aura.__index = Aura
  function Aura:create(id, advance, grid, talent, classSpec)
    advance = advance or false
    grid = grid or _auraGrid
    talent = talent or _auraTalent
    classSpec = classSpec or _auraClassSpec

    local aura = {id=id, classSpec=classSpec, talent=talent, grid=grid, advance=advance}
    setmetatable(aura, Aura)

    _auraGrid = grid
    _auraTalent = talent
    _auraClassSpec = classSpec

    return aura
  end

  -- todo: is there anyway I can get this data without dropping it in this script?
  -- Aura Database, inserted during build time
  local auras = {
-- %auras%
  }

  -- Do we want to query IsPlayerSpell()?
  function Aura:enabled()
    if (playerClassSpec ~= self.classSpec) then
      return false
    end
    return playerTalents[self.talent]
  end

  -- Direction Enum
  local direction = { up=0, down=1, right=2, left=3 }

  -- Grid Class
  Grid = {
    -- location and dimensions
    x=0, y=0, w=0, h=0, size=50, limit=100, id=0,
    -- direction of the next aura placement
    inLine=direction.right, nextLine=direction.down,
    -- current location in grid
    px=0, py=0, p=0,
    -- advance to next element, function table
    move = {
      [direction.up] = function(grid) grid.py = grid.py + 1 end,
      [direction.down] = function(grid) grid.py = grid.py - 1 end,
      [direction.right] = function(grid) grid.px = grid.px + 1 end,
      [direction.left] = function(grid) grid.px = grid.px - 1 end
    },
    -- is position in grid out of bounds?, function table
    bounds = {
      [direction.up] = function(grid) return grid.py >= grid.h end,
      [direction.down] = function(grid) return grid.py <= -grid.h end,
      [direction.right] = function(grid) return grid.px >= grid.w end,
      [direction.left] = function(grid) return grid.px <= -grid.w end
    },
    -- move position in grid to next line, function table
    resetLine = {
      [direction.up] = function(grid) grid.py = 0 end,
      [direction.down] = function(grid) grid.py = 0 end,
      [direction.right] = function(grid) grid.px = 0 end,
      [direction.left] = function(grid) grid.px = 0 end
    }
  }

  Grid.__index = Grid
  function Grid:create(o)
    setmetatable(o, Grid)
    return o
  end

  function Grid:moveNext()
    self.move[self.inLine](self)
    if self.bounds[self.inLine](self) then
      self.move[self.nextLine](self)
      self.resetLine[self.inLine](self)
    end

    self.p = self.p + 1
  end

  function Grid:auraX()
    return (self.x + self.px)*self.size
  end

  function Grid:auraY()
    return (self.y + self.py)*self.size
  end

  function Grid:positionAura(id)
    local r = WeakAuras.GetRegion(id);

    -- Abort early, this happens sometimes (heisenbug) and will cause the script to crash
    if r == nil then
      print('Unable to load aura: ', id);
      return false
    end

    local x = self:auraX()
    local y = self:auraY()

    local xR = r:GetXOffsetRelative();
    local yR = r:GetYOffsetRelative();

    if xR ~= x or yR ~= y then
      r:SetOffsetRelative(x, y)
    end
  end

  -- Default Grids
  local overflow = Grid:create({
    x=0, y=-2, w=8, h=5, id=1, inLine=direction.right, nextLine=direction.down
  })

  local coreRotation = Grid:create({
    x=-1, y=5, w=2, h=5, id=2, inLine=direction.right, nextLine=direction.down, limit = 8
  })

  local coreCooldowns = Grid:create({
    x=0, y=2, w=2, h=5, id=3, inLine=direction.left, nextLine=direction.up, limit = 8
  })

  local bottom = Grid:create({
    x=2, y=0, w=5, h=5, id=4, inLine=direction.right, nextLine=direction.down, limit = 10
  })

  local top = Grid:create({
    x=3, y=6, w=5, h=2, id=5, inLine=direction.right, nextLine=direction.down, limit = 5
  })

  local right = Grid:create({
    x=7, y=5, w=1, h=4, id=6, inLine=direction.down, nextLine=direction.right, limit = 4
  })

  local grids = {
    overflow, coreRotation, coreCooldowns, bottom, top, right
  }

  -- Once a grid is full, they always get pushed to the Overflow grid
  function Grid:isFull()
    if (self.id == overflow.id) then return false end

    -- the core grids grow towards each other
    if (self.id == coreRotation.id or self.id == coreCooldowns.id) then
      if (coreRotation.p + coreCooldowns.p > coreRotation.limit) then return true end
      return false
    end

    if (self.p > self.limit) then return true end

    return false;
  end

  function Aura:getGrid()
    local grid = grids[self.grid]
    if (grid:isFull()) then return overflow end;
    return grid
  end

  -- Main Loop
  for _, aura in ipairs(auras) do
    if aura:enabled() then
      local grid = aura:getGrid()
      grid:positionAura(aura.id)
      if aura.advance then
        grid:moveNext()
      end
    end
  end

  print('Auras positioned! CoreRotation:', coreRotation.p,
    ', CoreCDs:', coreCooldowns.p,
    ', Right:', right.p,
    ', Bottom:', bottom.p,
    ', Top:', top.p,
    ', Overflow:', overflow.p)

  return false;
end