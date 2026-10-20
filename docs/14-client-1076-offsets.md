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
| HP/mana obfuscation | `adrXOR 0x8380D0`: real value = stored ^ [XOR] for HP, max HP, mana, max mana, soul |

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

Exact intra-struct offsets past +0x24 need a live memory dump of a logged-in character (see Next steps in 00-status).

## Player flags (from iBot `Player.PlayerFlags`)
Poisoned 0x1, Burning 0x2, Energized 0x4, Drunken 0x8, ManaShield 0x10, Paralyzed 0x20, Hasted 0x40, Battle 0x80,
Drowning 0x100, Freezing 0x200, Dazzled 0x400, Cursed 0x800, Buffed 0x1000, PZ-locked 0x2000, In PZ 0x4000, Bleeding 0x8000.
