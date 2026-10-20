# Overview

iBot was the successor narrative to ElfBot from the same author circle: an
**external** automation tool that claimed not to inject DLLs into `Tibia.exe`,
instead reading process memory and synthesizing mouse/keyboard input
(`SendInput`, `mouse_event`, `keybd_event`, `PostMessage`).

Marketing text in contemporary forum mirrors emphasized:

- Isolation from the client process (crash independence)
- Human-like timing / randomization
- Scriptability (Lua via LuaInterface / Lua.Secure)

The analyzed v2.7.2 tree matches that model at the API surface (`WinApi.cs`) even
though identifier names are Dotfuscated. A parallel product line **iBot Plus**
shipped as a native Qt5 GUI (`ibotplus.exe`) with VM-like packing for the same
era client builds (10.71–10.76 in Wayback).

Target client for this study: **10.76**, contemporaneous with the March 2015
releases archived from tibiaibot.com.
