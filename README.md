WeakAuraAutomationTool

This currently produces some weak auras. Adding this macro to your toolbar will allow you to toggle them on and off.

`/run local cvar='BarbequeWeakaurasVisibilityToggle' SetCVar(cvar,1-GetCVar(cvar),cvar`

Todo:
- [ ] Race abilities
- [ ] PvP abilities
- [ ] Potions, blood lust \ heroism, and other major buffs
- [ ] Trinkets
- [ ] Covenant Abilities (class in CD group, signature in mobility group)
- [ ] Resource HuD (exists, but not as output from this tool)
- [ ] Groups + Max size --> Auto Overflow
- [ ] Look at behavior for leveling characters
- [ ] Author Info \ Wago Upload \ Link Here

Classes (1st Pass)
- [X] Druid
- [ ] Warrior
- [ ] Paladin
- [ ] Hunter
- [X] Rogue
- [X] Priest
- [X] Shaman
- [ ] Mage
- [ ] Warlock
- [ ] Monk
- [X] Demon Hunter
- [X] Death Knight

Classes (2nd Pass)
- [ ] Druid
  - [ ] Druid Affinities
  - [ ] Eclipse Graphic (requires model support)
  - [ ] There are too many things being tracked
    - [ ] Look at adding Customizations in Options \ WA Configuration Panel
    - [ ] Show only when on CD (how does this interact with the position_by_talents_lua?)


Encounters
- [ ] Torghast
- [ ] Dungeons
- [ ] Castle Nathria

Data
- [X] Extract Data from Game
  - [ ] I did good-ish work, but... I should have pulled from here: https://github.com/simulationcraft/simc/tree/shadowlands/SpellDataDump

Options
- [ ] Investigate how to add Options
  - [ ] examples: https://wago.io/SypgpjRSW, https://wago.io/1ctv3b91K