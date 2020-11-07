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
- [ ] Verify that the Rotation + Cooldown groups won't collide
- [ ] Look at behavior for leveling characters
- [ ] Author Info \ Wago Upload \ Link Here

Classes (1st Pass)
- [ ] Druid
  - [X] Balance
    - [ ] Eclipse Graphic (requires model support)
    - [ ] There are too many things being tracked ~ Options
  - [X] Feral
  - [ ] Restro
  - [ ] Guardian
  - [ ] Druid Affinities
- [ ] Warrior
- [ ] Paladin
- [ ] Hunter
- [ ] Rogue
- [ ] Priest
- [ ] Shaman
- [ ] Mage
- [ ] Warlock
- [ ] Monk
- [ ] Demon Hunter
- [ ] Death Knight

Encounters
- [ ] Torghast
- [ ] Dungeons
- [ ] Castle Nathria

Data
- [ ] Extract? from DB2
- [ ] WoW.Dev \ Wow.Tools
  - [ ] https://wow.tools/dbc/?dbc=spell&build=9.0.2.36512#page=1
  - [ ] https://marlam.in/obj/ --> https://wow.tools/export/

Options
- [ ] Investigate how to add Options
  - [ ] examples: https://wago.io/SypgpjRSW, https://wago.io/1ctv3b91K