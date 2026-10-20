# Tibia 10.76 memory map (what external bots read)

Client: CipSoft Tibia **10.76**, `Tibia.exe` SHA256 `1b47ab0e…efffcb`, ImageBase `0x400000`.
The PE has `DYNAMIC_BASE` set and a reloc directory (DllCharacteristics `0x8140`). Classic bots
use these as absolute VAs, which only holds if ASLR maps the image at its preferred base, as Wine and most 2015-era setups did.
Otherwise, add `(module base - 0x400000)`. iBot's `MemoryHelper.FindBaseAddress()` exists for exactly this.

## Source and verification
The address set comes from the public BlackD Proxy "AUTOMATIC UPDATE ZONE" for 10.76 (reposted on OTLand).
`tools/verify_offsets_1076.py` checks it statically against our binary. Every data address lands in `.data`/`.bss1`
and is referenced as an imm32 by `.text` code. Code-patch sites have zero imm32 references, which is expected because they are instruction addresses.

| name | VA | section | imm32 refs in .text |
|---|---|---|---|
| LoginServerStartPointer | `0x88f5ec` | .data | 11 |
| adrMulticlient | `0x5585a5` | .text | 0 |
| LEVELSPY_NOP | `0x517090` | .text | 0 |
| LIGHT_TRICK_ADR | `0x537072` | .text | 0 |
| tibiachatlog_base | `0x8386cc` | .data | 103 |
| tibia_popup_base | `0x8386c8` | .data | 110 |
| MAP_POINTER_ADDR | `0xa72128` | .bss1 | 3 |
| OFFSET_POINTER_ADDR | `0xa76c50` | .bss1 | 3 |
| adrConnectionKey(XTEA) | `0x82b9c4` | .data | 3 |
| adrXOR | `0x8380d0` | .data | 9 |
| adrMyHP | `0x9d5000` | .bss1 | 5 |
| adrMyMaxHP | `0x9d502c` | .bss1 | 3 |
| adrMyMana | `0x838100` | .data | 4 |
| adrMyMaxMana | `0x8380d4` | .data | 3 |
| adrMySoul | `0x8380ec` | .data | 3 |
| adrBattleListStart | `0xa2c0a0` | .bss1 | 11 |
| adrNum(PlayerId) | `0x9d5034` | .bss1 | 67 |
| adrXPos | `0x9d5038` | .bss1 | 22 |
| adrYPos | `0x9d503c` | .bss1 | 22 |
| adrZPos | `0x9d5040` | .bss1 | 23 |
| adrConnected | `0x849eec` | .data | 30 |
| RedSquare | `0x8380fc` | .data | 25 |
| adrLastPacket | `0x848b32` | .data | 1 |
| adrSelectedCharIndex | `0x9d2424` | .data | 2 |
| adrCharListPtr | `0x9d2398` | .data | 10 |
| adrXgo | `0x9d5030` | .bss1 | 8 |
| adrYgo | `0x9d5028` | .bss1 | 3 |
| adrZgo | `0x9d5004` | .bss1 | 3 |
| adrGo | `0xa2c0f0` | .bss1 | 2 |
| adrNumberOfAttackClick | `0x9d7df0` | .bss1 | 5 |

## Structures
| Struct | Layout |
|---|---|
| Battle list | base `0xA2C0A0`, stride **`0xDC`** (220 B), last index 1299 (1300 slots) |
| Login server table | `*0x88F5EC`, stride `0x30`; hostname ptr +`0x4`, IP +`0x20`, port +`0x28` (runtime IP-changer alternative to the file patch) |
| Chat log | `[[0x8386CC]+0x40]+0x3C`; selected channel `[[[0x8386CC]+0x40]+0x30]+0x30` |
| Map / tiles | `MAP_POINTER_ADDR 0xA72128`, `OFFSET_POINTER_ADDR 0xA76C50` |
| XTEA session key | `0x82B9C4` (16 B) |
| HP/mana obfuscation | `adrXOR 0x8380D0`: real value = stored ^ [XOR] for HP, max HP, mana, max mana. Soul is NOT XORed (live-verified) |

### Creature (battle-list entry), inferred
The order of iBot's `iBot.Game.Creature` properties tracks the client struct the way bots of this era mirrored it:
`Id, Type, Name, Z, Y, X, Walking, Direction, Previous, Next, Outfit, …, HpPerc, Speed, Skull, Party, WarIcon, Visible`.
Combining that with the BlackD convention (`NameDist=4`, id at +0) gives:

| Off | Field | Confidence |
|---|---|---|
| +0x00 | id (u32) | high (BlackD) |
| +0x04 | name (char[32]) | high (BlackD `NameDist=4`) |
| +0x24..+0x2C | z, y, x (u32 each, as ordered by iBot) | medium |
| … | walking, direction, prev/next links, outfit block | medium (order only) |
| tail | hp%, speed, skull, party, war icon, visible | medium (order only) |

**Superseded by the live validation below** (+0x24 onward closed).

## Player flags (from iBot `Player.PlayerFlags`)
Poisoned 0x1, Burning 0x2, Energized 0x4, Drunken 0x8, ManaShield 0x10, Paralyzed 0x20, Hasted 0x40, Battle 0x80,
Drowning 0x100, Freezing 0x200, Dazzled 0x400, Cursed 0x800, Buffed 0x1000, PZ-locked 0x2000, In PZ 0x4000, Bleeding 0x8000.

## Live validation (2026-10-20, local TFS 1.1 + patched 10.76 client under Wine)

**Setup.** Test account/char `Re Tester` (level 8, GM group for the outfit dialog) on local TFS 1.1. The password is stored only locally and is not published.
A spawn was added next to the temple (98,117,7): Rat, Cave Rat, Orc, Troll, NPC Riona; a wild Rabbit was nearby.
Login went through the **patched login hosts + RSA modulus** (MOTD "Welcome to The Forgotten Server!" → character list → in game).
Memory was read **read-only** from the Linux side via `/proc/<pid>/mem` of the Wine `Tibia.exe` process (`tools/read_1076.py`). The image was mapped at `0x400000` (Wine honoured the preferred base).

### Player globals: confirmed
| Addr | Field | Evidence |
|---|---|---|
| `0x9D5034` | player id | `0x10000000` = battle-list slot 0 id |
| `0x9D5038/3C/40` | x/y/z | (95,117,7) temple, then (97,117) → (97,115) after click-walking |
| `0x9D5000` ^ `[0x8380D0]` | HP | 185 (DB 185) |
| `0x9D502C` ^ XOR | max HP | 185 |
| `0x838100` ^ XOR | mana | 90 |
| `0x8380D4` ^ XOR | max mana | 90 |
| `0x8380EC` | **soul (plain, NOT XORed)** | 100. The public list implies XOR; that is wrong for 10.76 |
| `0x8380D8` | experience (plain) | 4200 (DB) — *new* |
| `0x8380E8` | level (plain) | 8 — *new* |
| `0x8380D0` | XOR key | random per process (differed across two sessions) |
| `0x8380FC` | attack target id ("RedSquare") | became `0x40000002` (Troll) after right-click → Attack |
| `0x849EEC` | connection state | 11 = in game |

### Battle-list entry (base `0xA2C0A0`, stride `0xDC`): closed layout
| Off | Field | Evidence |
|---|---|---|
| +0x00 | id | players `0x1…`, monsters `0x4…`, NPCs `0x8…` |
| +0x04 | name char[32] | |
| +0x24 / +0x28 / +0x2C | **z / y / x** (in that order) | matches the player globals for slot 0; monsters at expected spawn tiles |
| +0x30 / +0x34 | walk pixel offset (0 at rest) | |
| +0x38 | **direction** 0=N 1=E 2=S 3=W | 2 at login (south), 1 after walking east, 0 after walking north |
| +0x3C / +0x40 | walk start/end tick | non-zero only on a walking NPC (Riona) |
| +0x44 / +0x48 | walk animation state | 32 while stepping |
| +0x4C | step duration (ms) | 800 (NPC), 100 (GM player) |
| +0x54 | last turn direction (mirrors +0x38) | |
| +0x5C | 0x7FFFFFFF sentinel | constant across all entries |
| +0x60 | outfit looktype | 128 → 129 after changing outfit; Orc 5, Rat 21, Cave Rat 56, Troll 15, Rabbit 74, Riona 138 |
| +0x64/68/6C/70 | head / body / legs / feet | 78/68/58/76 = DB `lookhead/body/legs/feet` |
| +0x74 | addons | 0 → 3 after ticking addons |
| +0x78 | mount looktype | 0 (dismounted) |
| +0x7C / +0x80 | light (color 255 / intensity 0?) | constant in a lit temple. **Unconfirmed** |
| +0x8C | **HP %** | 100 for every entry. Not observed decreasing: the temple is PZ, so damage was impossible. *medium* |
| +0x90 | **speed** (protocol units) | Orc/CaveRat 75, Troll 85, Rabbit 90 = monster XML speed/2; GM 750 |
| +0x94 / +0x98 / +0x9C / +0xA0 | skull / party / war icon / guild-emblem | all 0. Order follows iBot's `Creature` (Speed→Skull→Party→WarIcon). **Not exercised** (needs a second player) |
| +0xA4 | visible | 1 for all on screen |
| +0xA8 / +0xB0 | 357 / 153 (constant) | unknown (UI/square related) |
| +0xBC | **creature type** 0=player 1=monster 2=NPC | exact match |
| +0xC0 | NPC speech/icon flag | 2 only on the NPC |
| +0xC8 / +0xD4 | heap pointers (per-creature, +0x30 apart) | probably name/text render cache |
| +0xCC | 1 (constant) | unknown |

Raw dump (fictional test entities only): `artifacts/battlelist_dump_live.txt`.

### Open items
Skull, party, war icon and the HP% decrease need a non-PZ fight or a second client. Light fields and +0xA8/+0xB0 need a light-changing scenario.
