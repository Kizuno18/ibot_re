# iBot Reverse Engineering

**Architecture, auth surface, scripting model, and a live-validated Tibia 10.76 memory map for iBot.**

[Start here](docs/02-overview.md) · [Documentation](#documentation) · [Status](docs/00-status.md) · [Memory map](docs/shared/client-1076-memory-map.md) · [History](docs/history.md)

`ibot_re` documents **iBot** (tibiaibot.com, 2012–2015), a .NET external bot for the
classic Tibia client that drives the game through input simulation and process
memory reads. The repository holds research notes, hashes, tooling and runtime
evidence; vendor binaries are referenced by SHA256 and archive links only.

## Research highlights

- **Complete battle-list layout for client 10.76.** Every field of the 220-byte entry is
  identified and checked against a local server with two clients, party, PvP skulls and
  guild war. See the [shared memory map](docs/shared/client-1076-memory-map.md).
- **Product history from primary sources.** Release dates, licence terms and the end of
  support are reconstructed from archived pages and forum threads ([history](docs/history.md)).
- **Auth surface mapped without contacting the vendor.** SOAP/WCF contracts and the HWID
  export are documented from metadata ([05](docs/05-auth-protocol.md)).

## Architecture at a glance

```text
Launcher.exe  --renames-->  <random7>.exe  (Dotfuscated stub)
                              |
                              v
                           iBot.exe  (.NET 4, Dotfuscator + Agile.NET runtime)
                              |
              +---------------+----------------+
              |               |                |
         ibotlib.dll     Lua stack         Win32 P/Invoke
       getHardwareID    Lua.Secure.dll      user32/gdi32
       (HWID)           lua51.dll           Read/WriteProcessMemory
                              |             SendInput / mouse_event
                              v
                    SOAP login @ tibiaibot.com
                 Login6 / Login6a / Login7 / LoginX
```

Under Wine the runtime reaches the Login window (e-mail / password / hardware id). The
vendor auth host is offline, so sessions end there; feature engines are documented from
static metadata.

## Analyzed components and coverage

| Item | Value |
| --- | --- |
| Primary build | iBot **v2.7.2** (Wayback of tibiaibot.com, 2015-03-23) |
| Companion | iBot Plus **10.76.1** (Qt) |
| Matched client | CipSoft **Tibia 10.76** (`FileVersion 10.7.6.0`) |
| Local OT | The Forgotten Server **1.1** (protocol 10.76–10.77) on `127.0.0.1:7171/7172` |
| Wine prefix | `/workspace/wine/ibot` (win32, isolated) |

Coverage per area is tracked in [00-status](docs/00-status.md).

## Documentation

### Choose a reading path

| Goal | Start with |
| --- | --- |
| Understand the product | [Overview](docs/02-overview.md) → [History](docs/history.md) → [Provenance](docs/01-provenance.md) |
| Read client memory | [Shared memory map](docs/shared/client-1076-memory-map.md) → [14 validation log](docs/14-client-1076-offsets.md) → [Client patch](docs/09-client-patch.md) |
| Explore the bot model | [Game model](docs/07-game-model.md) → [Type model](docs/13-type-model.md) → [Scripting](docs/08-scripting.md) |
| Assess coverage | [Status](docs/00-status.md) → [Static analysis](docs/03-static-analysis.md) → [REA analysis](docs/15-rea-analysis.md) |

<details>
<summary><strong>Complete documentation index</strong></summary>

| Chapter | Subject |
| --- | --- |
| [00 — Status](docs/00-status.md) | Done, coverage, out of scope, follow-ups |
| [01 — Provenance](docs/01-provenance.md) | Download URLs, SHA256, dates |
| [02 — Overview](docs/02-overview.md) | Product and design claims |
| [03 — Static analysis](docs/03-static-analysis.md) | PE / .NET / packers |
| [04 — Protection](docs/04-protection.md) | Dotfuscator, Agile.NET, HWID (identification only) |
| [05 — Auth protocol](docs/05-auth-protocol.md) | SOAP/WCF login surface |
| [06 — WinAPI surface](docs/06-winapi-surface.md) | P/Invoke catalog |
| [07 — Game model](docs/07-game-model.md) | Decompiled namespaces |
| [08 — Scripting](docs/08-scripting.md) | Lua / library scripts |
| [09 — Client patch](docs/09-client-patch.md) | IP/RSA patch for 10.76 |
| [10 — Runtime](docs/10-runtime.md) | Wine session notes |
| [11 — iBot Plus](docs/11-ibotplus.md) | Qt companion |
| [13 — Type model](docs/13-type-model.md) | Declared types and members |
| [14 — Client 10.76 offsets](docs/14-client-1076-offsets.md) | Sources and live validation log |
| [15 — REA analysis](docs/15-rea-analysis.md) | Managed/native boundary |
| [History](docs/history.md) | Timeline, pricing, end of support, forum mentions |
| [Shared memory map](docs/shared/client-1076-memory-map.md) | Consolidated 10.76 player + battle-list map (same file in windbot_re) |

Number 12 is unused.
</details>

## Repository layout and tools

| Path | Content |
| --- | --- |
| `docs/` | Research chapters; `docs/shared/` is mirrored in windbot_re |
| `artifacts/` | Text dumps of fictional test entities |
| `tools/pe_recon.py` | PE triage |
| `tools/patch_client.py` | Hostname + RSA modulus patcher (local copies only) |
| `tools/verify_offsets_1076.py` | Static cross-check of the 10.76 address set |
| `tools/read_1076.py`, `tools/snap_1076.py` | Read-only `/proc/<pid>/mem` reader and diff snapshotter for a live client |

## Evidence and limitations

**Observed vs. inferred.** Memory fields marked live-validated were read from a running
client on a local server; others are static or taken from public lists, and are labelled as such.

**Protection.** Agile.NET-encrypted method bodies are not recovered. Unpacking, dumping
and licence bypass are out of scope.

**Historical observations.** Endpoints and download availability describe what was archived
or observed, not current service behaviour.

## Contributing research

Include the binary hash, build, address and evidence when proposing a correction, and keep
runtime observations separate from hypotheses. Documentation and commit messages use English,
UTF-8, LF endings and a final newline. Keep credentials, vendor binaries and personal data out.
