﻿function()
  local cvar = 'BarbequeWeakaurasVisibilityToggle'
  local value = GetCVarBool(cvar)

  if value then
    return true;
  elseif value == nil then
    RegisterCVar(cvar,0)
  end

  return false
end