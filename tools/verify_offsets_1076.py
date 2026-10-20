#!/usr/bin/env python3
"""Statically cross-check public Tibia 10.76 address set (BlackD 'AUTOMATIC UPDATE ZONE')
against a local Tibia.exe 10.76: section membership + count of imm32 code references in .text."""
import sys, struct, pefile
ADDR = {  # name: VA (ImageBase 0x400000, no ASLR in 10.76)
 'LoginServerStartPointer':0x88F5EC,'adrMulticlient':0x5585A5,'LEVELSPY_NOP':0x517090,
 'LIGHT_TRICK_ADR':0x537072,'tibiachatlog_base':0x8386CC,'tibia_popup_base':0x8386C8,
 'MAP_POINTER_ADDR':0xA72128,'OFFSET_POINTER_ADDR':0xA76C50,'adrConnectionKey(XTEA)':0x82B9C4,
 'adrXOR':0x8380D0,'adrMyHP':0x9D5000,'adrMyMaxHP':0x9D502C,'adrMyMana':0x838100,
 'adrMyMaxMana':0x8380D4,'adrMySoul':0x8380EC,'adrBattleListStart':0xA2C0A0,'adrNum(PlayerId)':0x9D5034,
 'adrXPos':0x9D5038,'adrYPos':0x9D503C,'adrZPos':0x9D5040,'adrConnected':0x849EEC,'RedSquare':0x8380FC,
 'adrLastPacket':0x848B32,'adrSelectedCharIndex':0x9D2424,'adrCharListPtr':0x9D2398,
 'adrXgo':0x9D5030,'adrYgo':0x9D5028,'adrZgo':0x9D5004,'adrGo':0xA2C0F0,'adrNumberOfAttackClick':0x9D7DF0,
}
pe=pefile.PE(sys.argv[1]); base=pe.OPTIONAL_HEADER.ImageBase
text=next(s for s in pe.sections if s.Name.startswith(b'.text')); code=text.get_data()
print(f"ImageBase {base:#x}  DllCharacteristics {pe.OPTIONAL_HEADER.DllCharacteristics:#x}")
print("| name | VA | section | imm32 refs in .text |\n|---|---|---|---|")
for n,va in ADDR.items():
    rva=va-base; sec=next((s.Name.rstrip(b'\0').decode() for s in pe.sections if s.VirtualAddress<=rva<s.VirtualAddress+max(s.Misc_VirtualSize,s.SizeOfRawData)),'?')
    print(f"| {n} | `{va:#x}` | {sec} | {code.count(struct.pack('<I',va))} |")
