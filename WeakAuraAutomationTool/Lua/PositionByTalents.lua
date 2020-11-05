function()
   local xOffset = 0;
   local yOffset = 0;
   local spec = GetActiveSpecGroup()
   local talents = {%talents%}
   local id = "%id%"

   -- aura_env is bugged;
   local r = WeakAuras.GetRegion(id);

   -- Abort early this happens sometimes and will just break the ability of the script to keep working
   if r == nil then
     print('Unable to load aura: ', id);
     return false
   end

   function update()
     %update%
   end
   function bounds()
     if %check% then
       %resetLine%
       %nextLine%
     end
   end

   -- for i=0, talents[1] do
   --   update();
   --   bounds();
   -- end

   for i=3, talents[2]+2 do
     local talent = talents[i];
     local col = (talent-1)%3+1;
     local row = math.floor((talent-col)/3)+1;
     
     local talentKnown = select(4, GetTalentInfo(row, col, spec, false))
     if talentKnown then
       update();
       bounds();
     end
   end

    local xR = r:GetXOffsetRelative();
    local yR = r:GetYOffsetRelative();
    
    if xR ~= xOffset or yR ~= yOffset then
      r:SetOffsetRelative(xOffset, yOffset)
    end

   return false;
end