  -- https://github.com/WeakAuras/WeakAuras2/blob/master/WeakAuras/Transmission.lua#L665
  local forChat = true;
  local compressedTablesCache = {}
  local configForDeflate = {level = 9} -- the biggest bottleneck by far is in transmission and printing; so use maximal compression
  local configForLS = {
    errorOnUnserializableType =  false
  }

  local time = os.time

  local serialized = LibSerialize:SerializeEx(configForLS, inTable)
  local compressed
  -- get from / add to cache
  if compressedTablesCache[serialized] then
    compressed = compressedTablesCache[serialized].compressed
    compressedTablesCache[serialized].lastAccess = time()
  else
    compressed = LibDeflate:CompressDeflate(serialized, configForDeflate)
    compressedTablesCache[serialized] = {
      compressed = compressed,
      lastAccess = time(),
    }
  end
  -- remove cache items after 5 minutes
  for k, v in pairs(compressedTablesCache) do
    if v.lastAccess < (time() - 300) then
      compressedTablesCache[k] = nil
    end
  end
  local encoded = "!WA:2!"
  if(forChat) then
    encoded = encoded .. LibDeflate:EncodeForPrint(compressed)
  else
    encoded = encoded .. LibDeflate:EncodeForWoWAddonChannel(compressed)
  end
  return encoded