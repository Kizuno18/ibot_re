# Game model namespaces (decompiled)

Meaningful namespaces survived renaming for types:

| Namespace | Types (examples) |
| --- | --- |
| `iBot.Game` | `Player`, `Creature`, `Container`, `Item`, `TileMap`, `Spell`, `VIP`, `Cooldown`, `MapSpeedInfo` |
| `iBot.CaveBot` | `Waypoint`, `SqmPoint`, `SpecialArea`, `TargetOrder`, `LuaControl` |
| `iBot.GUI` | `GameWindow`, `Battle`, `MiniMapa`, `Channels`, `Loot`, `Market`, `CooldownBar` |
| `iBot.Util` | `MemoryHelper`, `PathFinder*`, `LUA`, `Screen`, `Connecting`, `WinApi` |
| `iBot.Service*` | License SOAP proxies |

Index: `artifacts/decompiled_type_index.txt`.

Memory offsets and structure layouts remain largely encrypted behind Agile.NET; `MemoryHelper` is the hot spot for future offline decryption work.
