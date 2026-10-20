# Client IP/RSA patch (Tibia 10.76)

Tool: `tools/patch_client.py`.

## What it does

1. Locates the 309-digit CipSoft RSA public modulus in `Tibia.exe` and replaces it with the classic OTServ/TFS modulus (`n = p*q` from TFS 1.1 `otserv.cpp`).
2. Replaces each of the ten login host strings (`login0N.tibia.com`, `tibia0N.cipsoft.com`) with a NUL-padded target host (e.g. `127.0.0.1`), preserving slot size.
3. Leaves TCP port **7171** unchanged (client default).

## Observed offsets (this 10.76 build)

| Item | File offset |
| --- | --- |
| RSA modulus | `0x3885a0` |
| `login01.tibia.com` … `login05` | `0x387ec8` … `0x387f18` (slot 17) |
| `tibia01.cipsoft.com` … `tibia05` | `0x387f2c` … `0x387f7c` (slot 19) |

## Hashes

| File | SHA256 |
| --- | --- |
| Original `Tibia.exe` | `1b47ab0ece110c5120e0c71fef071d02ae6af23d45ed351d14484ba819efffcb` |
| Patched `Tibia_ot.exe` | `addb0da28b85d338a180375bde1359bcfba0e4d3a65db233537f3f89495917e0` |

## Verification

TCP connect to local TFS with a junk packet elicited:
`Only clients with protocol 10.77 allowed!` (TFS `CLIENT_VERSION_STR`; versions 1076–1077 accepted per `definitions.h`). Confirms the login listener is reachable; full RSA login UI path not completed under Xvfb.
