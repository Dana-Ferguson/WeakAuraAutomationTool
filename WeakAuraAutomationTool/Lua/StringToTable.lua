  -- https://github.com/WeakAuras/WeakAuras2/blob/master/WeakAuras/Transmission.lua#L694
  local fromChat = true;
  
  -- encoding format:
  -- version 0: simple b64 string, compressed with LC and serialized with AS
  -- version 1: b64 string prepended with "!", compressed with LD and serialized with AS
  -- version 2+: b64 string prepended with !WA:N! (where N is encode version)
  --   compressed with LD and serialized with LS
  local _, _, encodeVersion, encoded = inString:find("^(!WA:%d+!)(.+)$")
  if encodeVersion then
    encodeVersion = tonumber(encodeVersion:match("%d+"))
  else
    encoded, encodeVersion = inString:gsub("^%!", "")
  end

  local decoded
  if(fromChat) then
    if encodeVersion > 0 then
      decoded = LibDeflate:DecodeForPrint(encoded)
    else
      decoded = decodeB64(encoded)
    end
  else
    decoded = LibDeflate:DecodeForWoWAddonChannel(encoded)
  end

  if not decoded then
    return "Error decoding."
  end

  local decompressed, errorMsg = nil, "unknown compression method"
  if encodeVersion > 0 then
    decompressed = LibDeflate:DecompressDeflate(decoded)
  else
    decompressed, errorMsg = Compresser:Decompress(decoded)
  end
  if not(decompressed) then
    return "Error decompressing: " .. errorMsg
  end

  local success, deserialized
  if encodeVersion < 2 then
    success, deserialized = Serializer:Deserialize(decompressed)
  else
    success, deserialized = LibSerialize:Deserialize(decompressed)
  end
  if not(success) then
    return "Error deserializing: "..deserialized
  end
  
  return deserialized