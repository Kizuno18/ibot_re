# Decompiled type model (iBot v2.7.2)

Auto-generated from ILSpy output. Type and member names survived Dotfuscator in these namespaces. **Method bodies are stubbed** (`return 0`/empty) because Agile.NET encrypts IL that is only decrypted at runtime, so this is the declared surface, not the logic.

## `iBot.Game`

### Container

- properties: `Name`, `ID`, `Index`, `pointer`, `UsedSlots`, `MaxSlots`, `Open`, `Page`, `PageMax`, `MaxUsed`, `Items`
- methods: `OnContainerFull()`, `OpenContainerByItemIndex(int itemIndex)`, `Preview()`, `GetItemIndex(int id)`, `isCorpse()`

### ContainerItem

- properties: `ID`, `Count`, `Volume`, `Index`

### Cooldown

- fields: `double attack`, `double healing`, `double summon`, `double supply`, `double support`
- properties: `Potion`
- methods: `UpdateCooldown()`, `Update(Spell.Category category, double value)`, `UpdateAttack(double value)`, `UpdateHealing(double value)`, `UpdateSummon(double value)`, `UpdateSupport(double value)`, `UpdateSupply(double value)`, `UpdatePotion(double value)`, `CanCast(Spell.Category category)`

### Corpse

- properties: `Id`, `Name`, `Z`, `Y`, `X`, `StartLoot`, `Time`, `TryLoot`, `GoUpStairs`, `LootMessage`, `Opened`, `TryOpenTimes`, `FindAnyLoot`, `FindCountItems`, `PickUpLoot`, `PickUpTryTimes`, `Looted`, `Announced`, `Finished`, `ForceBrowse`

### Creature

- enum **SkullType**: None Yellow Green White Red Black Orange
- enum **PartyType**: None Host Guest Member Leader MemberSharedExp LeaderSharedExp MemberSharedExpInactive LeaderSharedExpInactive MemberNoSharedExp LeaderNoSharedExp
- enum **WarIconType**: None Green Red Blue
- properties: `SkullType`, `PartyType`, `WarIconType`, `Index`, `Order`, `Id`, `Type`, `Name`, `Z`, `Y`, `X`, `Walking`, `Direction`, `Previous`, `Next`, `Outfit`, `IsPlayerAttack`, `AnyAttack`, `HitTime`, `BlackSquare`, `HpPerc`, `Speed`, `Skull`, `Party`, `WarIcon`, `Visible`, `CreatureType`, `Ignored`, `Looted`, `Summon`, `VisibleTime`, `Exist`
- methods: `IsPlayer()`, `IsMonster()`, `IsOnScreen()`, `IsSelf()`

### Equipaments

- properties: `Amulet`, `Weapon`, `WeaponAmount`, `Ring`, `Helmet`, `Armor`, `Legs`, `Boots`, `Container`, `Shield`, `Ammo`, `AmmoAmount`

### Item

- enum **_2iQ_003D**: _2yQ_003D _3CQ_003D _3SQ_003D _3iQ_003D _3yQ_003D _4CQ_003D _4SQ_003D _4iQ_003D _4yQ_003D _5CQ_003D _5SQ_003D _5iQ_003D _5yQ_003D _6CQ_003D _6SQ_003D _6iQ_003D _6yQ_003D _7CQ_003D
- enum **MarketCategory**: Armors = 1 Amulets Boots Containers Decoration Food Helmets_Hats Legs Others Potions Rings Runes Shields Tools Valuables Ammunition Axes Clubs DistanceWeapons Swords Wands_Rods MetaWeapons
- enum **Category**: None Liquid Rune Container ContestPrize CreatureProduct Club Axe Sword Book QuestItem Armor Helmet Legs Boots Shield Amulet Distance Ammo Ring Decoration Tool Food Rubbish Trophie Ddocument Token LightSource Valuable Furniture Doll Magical FluidContainer PlantHerb Instrument Rod Wand SpellBook Taming Others
- properties: `_2iQ_003D`, `MarketCategory`, `Category`, `ID`, `isBank`, `Waypoints`, `isClip`, `isBottom`, `isTop`, `isContainer`, `isCumulative`, `isForceUse`, `isMultiUse`, `isLiquidContainer`, `isLiquidPool`, `isUnpassable`, `isUnmoveable`, `isUnsight`, `isAvoid`, `isTakeable`, `isTranslucent`, `isHeight`, `isAutomapColor`, `isLensHelp`, `isFullBank`, `isIgnoreLook`, `isMarket`, `MarketCategoryValue`, `MarketTradeAs`, `MarketName`, `Width`, `Height`, `NumberOfSprites`, `Sprites`, `Name`, `NpcBuy`, `NpcSell`, `Custom`, `Weight`, `ItemCategory`, `OpenContainerCount`, `MessageCount`, `UsageMessage`, `LootMessage`

### ItemName

- properties: `Name`, `Id`
- methods: `Compare(ItemName x, ItemName y)`, `CompareTo(ItemName other)`

### ItemPos

- properties: `Index`, `X`, `Y`

### MapSpeedInfo

- properties: `Map`, `Color`, `x`, `y`, `z`

### Player

- enum **Direction**: North = 0 East = 1 South = 2 West = 3 NorthRight = 5 SouthRight = 6 SouthLeft = 7 NorthLeft = 8
- enum **PlayerFlags**: Poisoned = 1 Burning = 2 Energized = 4 Drunken = 8 Manashielded = 0x10 Paralyzed = 0x20 Hasted = 0x40 Battle = 0x80 Drowning = 0x100 Freezing = 0x200 Dazzled = 0x400 Cursed = 0x800 Buffed = 0x1000 CannotLogoutOrEnterProtectionZone = 0x2000 WithinProtectionZone = 0x4000 Bleeding = 0x8000
- fields: `int id`, `string name`, `int onLine`, `int direction`, `bool isWalk`, `int outfit`, `int skull`, `int stamina`, `bool visible`, `int mountId`, `bool mount`, `string account`, `string password`
- properties: `Direction`, `PlayerFlags`, `tickStart`, `expStart`, `PlayerHaveMount`, `expStartHour`, `tickStartHour`, `index`, `xor`, `Vocation`, `Account`, `Password`, `OffTrain`, `Soul`, `ExpGainedStart`, `TimeHuntStart`, `ExpHuntGained`, `TimeHunt`, `TimeToLevel`, `ExpHour`, `TibiaExpHour`, `Stamina`, `PlayerDirection`, `iD`, `Flags`, `xPos`, `yPos`, `zPos`, `Name`, `OnLine`, `Hp`, `HpPerc`, `HpMax`, `Mana`, `ManaPerc`, `ManaMax`, `Visible`, `RedSquare`, `GreenSquare`, `WhiteSquare`, `IsWalk`, `Speed`, `Skull`, `Outfit`, `Cap`, `UsedMouseItem`, `DragMouseItem`, `Mount`, `Level`, `Exp`, `mlevel`, `mlevelpc`, `fist`, `club`, `sword`, `axe`, `distance`, `shielding`, `fishing`, `fistpc`
- methods: `TickToString(long tick)`, `GetMemoryData()`, `GetPlayerName()`, `CheckFlag(PlayerFlags flag)`, `Proximidade(int x, int y)`, `IsVisible(Creature creature)`, `IsVisible(int x, int y, int z)`, `ExpToLevel()`, `ResetExpStart()`, `SetAccountPassword()`

### Spell

- enum **Category**: Attack Healing Summon Supply Support Potion Special
- enum **Type**: Instant ItemTransformation Creation Missile Strike Area Wave Beam
- properties: `Category`, `Type`, `Name`, `Cast`, `Mana`, `Level`, `Magic`, `Premium`, `Soul`, `StartCoolDown`, `Cooldown`, `CooldownCategory`, `CoolDownID`, `CooldownTimeStart`, `CooldownTimeEnd`, `SpellCategory`, `SpellType`, `Range`

### TileMap

- properties: `Id`, `index`, `Count`, `Order1`, `Order2`, `Order3`, `Order4`, `Order5`, `Order6`, `Order7`, `Order8`, `Order9`, `Order10`, `Items`

### VIP

- properties: `previous`, `next`, `id`, `icon`, `notifyOnLogin`, `name`, `description`, `isOnline`

### VipStruct

- properties: `name`, `description`, `icon`, `isonline`


## `iBot.CaveBot`

### LuaControl

- fields: `readonly object m_lock`, `readonly object _lockKey`, `readonly object _lockMsgs`, `int lastonto`, `int msgTime`, `bodies[] SkinBodies`, `bodies[] StakeBodies`, `bodies[] FishBodies`
- properties: `UpdateSetup`, `Name`, `newmsgs`, `lua`, `AllStart`
- methods: `DelegateWait(int time)`, `DelegateWaitRandom(int time1, int time2)`, `DelegateMessage(string value)`, `DelegateGotolabelS(string value)`, `DelegateGotolabelN(int value)`, `DelegateCountItem(string value, string origem, string liquid)`, `DelegateServerCountItem(string value)`, `DelegateIsLocation()`, `DelegateIsLocationDistance(int distance)`, `DelegateIsLocationxyz(int x, int y, int z, int distance)`, `DelegateGround(int x, int y, int z)`, `DelegateMoveItemsA(string item, string origem, string destino, int count)`, `DelegateMoveItemsB(string id, string destino, int count)`, `DelegateTopTileItem(int x, int y, int z)`, `DelegateLogout()`, `DelegateUpdateWorld()`, `DelegateFlashClient()`, `DelegateFocusClient()`, `DelegateScreenShot(string name)`, `DelegateItemId(string name)`, `DelegateItemName(int id)`, `DelegateGetSettings(string path)`, `DelegateWindowCount(string name)`, `DelegateSay(string value)`, `DelegateNPCSay(string value)`, `DelegateCloseWindows()`, `DelegateResizeWindow(object origem, int width)`, `DelegateResizeWindows()`, `DelegateOpenItem(string item, string origem, bool newWindow, int index)`, `DelegateCloseWindow(string origem)`, `DelegateIsFocused()`, `DelegateExpToLevel()`, `DelegateFormat(double value)`, `DelegateBuyItems(string item, int value)`, `DelegateSellItems(string item, int value)`, `DelegateItemWeight(string item)`, `DelegateSetTargeting(string value)`, `DelegateSetLooting(string value)`, `DelegateSetCaveBot(string value)`, `DelegateSetAlarms(string value)`, `DelegateUseItemOn(string name, int x, int y, int z)`, `DelegateUseItemGround(string name, int x, int y, int z)`, `DelegatePositive(int value)`, `DelegateTurn(string direction)`, `DelegateItemProperty(string item)`, `DelegateReachGroundItem(string item)`, `DelegateMoveItemsOnTo(string item, string origem, string destino, int count, int index)`, `DelegateCastSpell(string spell)`, `DelegateControlWindows(string origem, bool style)`, `DelegateFindCreature(string name)`, `DelegateReachCreature(string name)`, `DelegateCursorInfo()`, `DelegateShowBot()`, `DelegateShowSettings()`, `DelegateSetSettings(string xpath, string value)`, `DelegateMAround(int range, bool allfloors, string name)`, `DelegatePlaySound(string name)`, `DelegateAnySay(string value, string chat)`, `DelegateRandom(int min, int max)`, `DelegatePAround(int range, bool allfloors, string name)`

### SQM

- fields: `int x`, `int y`, `int z`

### SpecialArea

- properties: `Name`, `X`, `Y`, `Z`, `dimensionX`, `dimensionY`, `ConsideredBy`
- methods: `Update(XmlNode xNode)`, `UpdateParcial(XmlNode xNode)`

### SqmPoint

- properties: `Point`, `Avoid`, `Creature`, `Distance`, `Moves`, `Ramdon`
- methods: `CompareTo(SqmPoint other)`

### TargetOrder

- properties: `Creature`, `Target`, `Setting`, `Order`, `Health`, `Danger`, `Proximity`
- methods: `CompareTo(TargetOrder other)`, `FindOrder(int value)`

### Waypoint

- properties: `Name`, `Index`, `Type`, `Z`, `Y`, `X`, `Action`, `Random`
- methods: `Update(XmlNode xNode)`, `UpdateParcial(XmlNode xNode)`


## `iBot.Util`

### Connecting

- fields: `int start`, `IContainer components`, `Timer timer1`, `Label lvl_conec`
- methods: `timer1_Tick(object sender, EventArgs e)`, `Dispose(bool disposing)`, `InitializeComponent()`

### GetInfo

- methods: `GetCPUId()`, `GetHardDiskId()`, `GetMACAddress()`, `GetHardwareId()`, `ReturnChar(int value)`

### HeuristicFormula

- enum **HeuristicFormula**: Manhattan = 1 MaxDXDY DiagonalShortCut Euclidean EuclideanNoSQR Custom1

### IPathFinder


### IPriorityQueue


### LUA


### MemoryHelper

- fields: `Process ProcessTibia`, `IntPtr handleTibia`, `IntPtr mainHandleTibia`, `int idProcessTibia`, `int BaseAddressTibia`, `int versionTibia`, `bool Preview`
- properties: `processTibia`, `baseAddressTibia`
- methods: `WriteMemory(int Address, byte[] NewVal)`, `ReadMemory(int Address, int length)`, `ReadMemory(int Address, int length, IntPtr hnd)`, `ReadMemoryDouble(int Address)`, `ReadMemoryUInt64(int Address)`, `ReadMemoryInt(int Address)`, `ReadMemoryInt(int Address, IntPtr hnd)`, `ReadMemoryInt16(int Address)`, `ReadMemoryByte(int Address)`, `ReadMemoryString(int Address, int lenght)`, `ReadMemoryString(int Address, int lenght, IntPtr hnd)`, `ByteToString(byte[] value, int start, int count)`, `FindClientByName(string name)`, `FindClient()`, `SetVisible(bool value)`, `FindBaseAddress()`

### MiniMap

- fields: `byte[,] mMatrix`, `int xMatrix`, `int yMatrix`, `int zMatrix`
- properties: `MaxX`, `MaxY`, `Matrix`
- methods: `Start(int x, int y, int z)`, `CreateMatrix(int x, int y)`, `ResetMatrix()`, `UpdateMatrix(int xFinal, int yFinal, eCA_003D.jiE_003D sender)`, `UpdateMatrix(int xFinal, int yFinal, bool updatemap, eCA_003D.jiE_003D sender)`, `UpdateMatrix(int xFinal, int yFinal, bool updatemap, eCA_003D.jiE_003D sender, bool reach)`, `UpdateMatrix(int xFinal, int yFinal, bool updatemap, eCA_003D.jiE_003D sender, bool reach, bool nocreature)`, `MapToFile()`, `IsWalkeable(int x, int y, int z)`, `IsShootable(Point A, Point B)`, `PathFinder(int x, int y, bool diagonal, bool update, eCA_003D.jiE_003D sender)`, `PathFinder(int x, int y, bool diagonal, bool update, eCA_003D.jiE_003D sender, bool reach)`

### PathFinder

- fields: `byte[,] mGrid`, `PriorityQueueB<PathFinderNode> mOpen`, `List<PathFinderNode> mClose`, `bool mStop`, `bool mStopped`, `int mHoriz`, `HeuristicFormula mFormula`, `bool mDiagonals`, `int mHEstimate`, `bool mPunishChangeDirection`, `bool mTieBreaker`, `bool mHeavyDiagonals`, `int mSearchLimit`, `double mCompletedTime`, `bool mDebugProgress`, `bool mDebugFoundPath`
- properties: `Stopped`, `Formula`, `Diagonals`, `HeavyDiagonals`, `HeuristicEstimate`, `PunishChangeDirection`, `TieBreaker`, `SearchLimit`, `CompletedTime`, `DebugProgress`, `DebugFoundPath`
- methods: `FindPathStop()`, `FindPath(Point start, Point end)`

### PathFinderFast

- fields: `byte[,] mGrid`, `PriorityQueueB<int> mOpen`, `List<PathFinderNode> mClose`, `bool mStop`, `bool mStopped`, `int mHoriz`, `HeuristicFormula mFormula`, `bool mDiagonals`, `int mHEstimate`, `bool mPunishChangeDirection`, `bool mTieBreaker`, `bool mHeavyDiagonals`, `int mSearchLimit`, `double mCompletedTime`, `bool mDebugProgress`, `bool mDebugFoundPath`, `PathFinderNodeFast[] mCalcGrid`, `byte mOpenNodeValue`, `byte mCloseNodeValue`, `int mH`, `int mLocation`, `int mNewLocation`, `ushort mLocationX`, `ushort mLocationY`, `ushort mNewLocationX`, `ushort mNewLocationY`, `int mCloseNodeCounter`, `ushort mGridX`, `ushort mGridY`, `ushort mGridXMinus1`, `ushort mGridYLog2`, `bool mFound`, `sbyte[,] mDirection`, `int mEndLocation`, `int mNewG`
- properties: `Stopped`, `Formula`, `Diagonals`, `HeavyDiagonals`, `HeuristicEstimate`, `PunishChangeDirection`, `TieBreaker`, `SearchLimit`, `CompletedTime`, `DebugProgress`, `DebugFoundPath`
- methods: `FindPathStop()`, `FindPath(Point start, Point end)`

### PathFinderNode

- fields: `int F`, `int G`, `int H`, `int X`, `int Y`, `int PX`, `int PY`, `int Peso`

### PathFinderNodeType

- enum **PathFinderNodeType**: Start = 1 End = 2 Open = 4 Close = 8 Current = 0x10 Path = 0x20

### Point3

- properties: `x`, `y`, `z`

### PointShoot

- properties: `x`, `y`, `amount`, `choise`

### PriorityQueueB

- fields: `List<T> InnerList`, `IComparer<T> mComparer`
- properties: `Count`
- methods: `SwitchElements(int i, int j)`, `OnCompare(int i, int j)`, `Push(T item)`, `Pop()`, `Update(int i)`, `Peek()`, `Clear()`, `RemoveLocation(T item)`

### SafeEnumerator

- fields: `readonly IEnumerator<T> _inner`, `readonly object _lock`
- properties: `Current`
- methods: `Dispose()`, `MoveNext()`, `Reset()`

### SafeList

- fields: `readonly List<T> _inner`, `readonly object _lock`
- properties: `Count`, `IsReadOnly`
- methods: `Add(T item)`, `Clear()`, `Contains(T item)`, `CopyTo(T[] array, int arrayIndex)`, `Remove(T item)`, `GetEnumerator()`, `IndexOf(T item)`, `Insert(int index, T item)`, `RemoveAt(int index)`, `AsReadOnly()`, `ForEach(Action<T> action)`, `Exists(Predicate<T> match)`

### Screen

- fields: `byte[,] mMatrix`, `int xMatrix`, `int yMatrix`, `int zMatrix`
- properties: `BlockedSQMs`, `Matrix`
- methods: `ResetMatrix()`, `UpdateMatrix()`, `UpdateMatrix(Creature creature, bool final)`, `UpdateMatrix(Creature creature, bool final, Point lastPoint, bool updateMap)`, `UpdateMatrix(Creature creature, bool final, Point lastPoint, bool updateMap, bool reach)`, `UpdateMatrix(Creature creature, bool final, Point lastPoint, bool updateMap, bool reach, bool nocreature)`, `AddBlockedSQM(SQM addSQM)`, `MapToFile()`, `PathFinderFast(int x, int y, bool diagonal, bool final, bool matrix, eCA_003D.jiE_003D sender)`, `PathFinderFast(int x, int y, bool diagonal, bool final, bool matrix, eCA_003D.jiE_003D sender, bool reach)`, `PathFinderFast(int x, int y, bool diagonal, bool final, bool matrix, eCA_003D.jiE_003D sender, bool reach, bool nocreature)`, `PathFinder(int x, int y, bool diagonal, bool final, bool matrix, eCA_003D.jiE_003D sender)`, `PathFinder(int x, int y, bool diagonal, bool final, bool matrix, eCA_003D.jiE_003D sender, bool last, bool updateMap)`, `PathFinder(int x, int y, bool diagonal, bool final, bool matrix, eCA_003D.jiE_003D sender, bool last, bool updateMap, bool reach)`, `IsWalkeable(int x, int y, int z)`, `IsTrapped()`, `IsShootable(Point A, Point B)`, `IsReachable(int x, int y, int z)`, `IsReachable(int x, int y, int z, bool update)`, `IsReachable(Creature creature, bool updateMap)`

### Util

- methods: `ToLowerFast(this string value)`, `Sleep(int min, int max)`

### WinApi

- enum **Dic_003D**: Dyc_003D = 0 ECc_003D = 1 ESc_003D = 2 Eic_003D = 3 Eyc_003D = 3 FCc_003D = 4 FSc_003D = 5 Fic_003D = 6 Fyc_003D = 7 GCc_003D = 8 GSc_003D = 9 Gic_003D = 10 Gyc_003D = 11
- enum **HCc_003D**: HSc_003D = 0 Hic_003D = 1 Hyc_003D = 2 ICc_003D = 3 ISc_003D = 4 Iic_003D = 5 Iyc_003D = 5 JCc_003D = 6 JSc_003D = 7 Jic_003D = 8 Jyc_003D = 10 KCc_003D = 11 KSc_003D = 12 Kic_003D = 13 Kyc_003D = 14 LCc_003D = 15 LSc_003D = 16 Lic_003D = 17 Lyc_003D = 18 MCc_003D = 19
- enum **MSc_003D**: Mic_003D = 0 Myc_003D = 1 NCc_003D = 2 NSc_003D = 3 Nic_003D = 4 Nyc_003D = 5 OCc_003D = 6 OSc_003D = 7 Oic_003D = 8 Oyc_003D = 15 PCc_003D = 0 PSc_003D = 256 Pic_003D = 512 Pyc_003D = 3840 QCc_003D = 0 QSc_003D = 4096 Qic_003D = 8192 Qyc_003D = 61440 RCc_003D = 0 RSc_003D = 65536 Ric_003D = 983040
- enum **Xyc_003D**: YCc_003D = 0 YSc_003D = 100 Yic_003D = 200 Yyc_003D = 300 ZCc_003D = 400 ZSc_003D = 500 Zic_003D = 600 Zyc_003D = 700 aCc_003D = 800 aSc_003D = 900
- enum **pic_003D**: pyc_003D = 1 qCc_003D qSc_003D qic_003D qyc_003D rCc_003D rSc_003D ric_003D
- enum **ryc_003D**: sCc_003D = 0 sSc_003D = 2 sic_003D = 4 syc_003D = 6 tCc_003D = 8 tSc_003D = 10 tic_003D = 12 tyc_003D = 14 uCc_003D = 16 uSc_003D = 18 uic_003D = 20 uyc_003D = 22 vCc_003D = 24 vSc_003D = 26 vic_003D = 28 vyc_003D = 30 wCc_003D = 32 wSc_003D = 34 wic_003D = 36 wyc_003D = 38 xCc_003D = 40 xSc_003D = 42 xic_003D = 44 xyc_003D = 45 yCc_003D = 88 ySc_003D = 90 yic_003D = 104 yyc_003D = 106 zCc_003D = 108 zSc_003D = 110 zic_003D = 111 zyc_003D = 112 _0Cc_003D = 113 _0Sc_003D = 114 _0ic_003D = 115 _0yc_003D = 116 _1Cc_003D = 117 _1Sc_003D = 118 _1ic_003D = 119
- enum **_5Cc_003D**: _5Sc_003D = -4 _5ic_003D = -6 _5yc_003D = -8 _6Cc_003D = -16 _6Sc_003D = -20 _6ic_003D = -21 _6yc_003D = -12
- properties: `_9CY_003D`, `RECT`, `Byc_003D`, `Margins`, `Dic_003D`, `HCc_003D`, `MSc_003D`, `Xyc_003D`, `pic_003D`, `ryc_003D`, `WNDCLASS`, `WINDOWPLACEMENT`, `MOUSEINPUT`, `KEYBDINPUT`, `HARDWAREINPUT`, `INPUT`, `_5Cc_003D`
- methods: `DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Margins pMargins)`, `getHardwareID(StringBuilder output)`, `CreateFontIndirect([In][MarshalAs(UnmanagedType.LPStruct)`, `RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags)`, `GetDeviceCaps(IntPtr hdc, int nIndex)`, `Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect)`, `CreateSolidBrush(uint crColor)`, `SetDCPenColor(IntPtr hdc, uint crColor)`, `SetDCBrushColor(IntPtr hdc, uint crColor)`, `SelectObject(IntPtr hdc, IntPtr hgdiobj)`, `GetStockObject(HCc_003D fnObject)`, `SetBkMode(IntPtr hdc, int iBkMode)`, `TextOut(IntPtr hdc, int nXStart, int nYStart, string lpString, int cbString)`, `CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect)`, `InvertRgn(IntPtr hdc, IntPtr hrgn)`, `DeleteObject([In] IntPtr hObject)`, `SetTextColor(IntPtr hdc, uint crColor)`, `CreatePen(MSc_003D fnPenStyle, int nWidth, uint crColor)`, `CreateFont(int nHeight, int nWidth, int nEscapement, int nOrientation, int fnWeight, uint fdwItalic, uint fdwUnderline, uint fdwStrikeOut, uint fdwCharSet, uint fdwOutputPrecision, uint fdwClipPrecision, uint fdwQuality, uint fdwPitchAndFamily, string lpszFace)`, `SetMapMode(IntPtr hdc, int fnMapMode)`, `CreateWindowExW(uint dwExStyle, [MarshalAs(UnmanagedType.LPWStr)`, `FillRect(IntPtr hDC, [In] ref RECT lprc, IntPtr hbr)`, `DefWindowProcW(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)`, `DestroyWindow(IntPtr hWnd)`, `RegisterClassW([In] ref WNDCLASS lpWndClass)`, `GetClientRect(IntPtr hWnd, out RECT lpRect)`, `BeginPaint(IntPtr hwnd, out Byc_003D lpPaint)`, `EndPaint(IntPtr hWnd, [In] ref Byc_003D lpPaint)`, `SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw)`, `SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags)`, `ShowWindow(IntPtr hWnd, int nCmdShow)`, `UpdateWindow(IntPtr hWnd)`, `MulDiv(int nNumber, int nNumerator, int nDenominator)`, `GetDC(IntPtr hwnd)`, `InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase)`, `ReleaseDC(IntPtr dc)`, `GetForegroundWindow()`, `GetActiveWindow()`, `GetFocus()`, `DrawText(IntPtr hDC, string lpString, int nCount, ref RECT lpRect, uint uFormat)`, `keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo)`, `GetKeyState(int keyCode)`, `GetAsyncKeyState(Keys vKey)`, `VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect)`, `GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl)`, `SetWindowLong(int hwnd, int nIndex, int dwNew)`, `GetWindowLong(int hwnd, int nIndex)`, `mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo)`, `SendInput(int nInputs, ref INPUT pInputs, int cbSize)`, `SetForegroundWindow(IntPtr hWnd)`, `SetFocus(IntPtr hwnd)`, `SetActiveWindow(IntPtr hWnd)`, `SwitchToThisWindow(IntPtr hWnd, bool fAltTab)`, `IsWindowVisible(IntPtr hWnd)`, `GetWindow(IntPtr hWnd, uint uCmd)`, `FindWindow(string lpClassName, string lpWindowName)`, `GetWindowLongPtr(IntPtr hWnd, int nIndex)`, `GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount)`, `ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead)`, `WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesWritten)`

### WindowMessages


### WindowStyles

- fields: `static readonly uint WS_BORDER`, `static readonly uint WS_CAPTION`, `static readonly uint WS_CHILD`, `static readonly uint WS_CHILDWINDOW`, `static readonly uint WS_CLIPCHILDREN`, `static readonly uint WS_CLIPSIBLINGS`, `static readonly uint WS_DISABLED`, `static readonly uint WS_DLGFRAME`, `static readonly uint WS_GROUP`, `static readonly uint WS_HSCROLL`, `static readonly uint WS_ICONIC`, `static readonly uint WS_MAXIMIZE`, `static readonly uint WS_MAXIMIZEBOX`, `static readonly uint WS_MINIMIZE`, `static readonly uint WS_MINIMIZEBOX`, `static readonly uint WS_OVERLAPPED`, `static readonly uint WS_OVERLAPPEDWINDOW`, `static readonly uint WS_POPUP`, `static readonly uint WS_POPUPWINDOW`, `static readonly uint WS_SIZEBOX`, `static readonly uint WS_SYSMENU`, `static readonly uint WS_TABSTOP`, `static readonly uint WS_THICKFRAME`, `static readonly uint WS_TILED`, `static readonly uint WS_TILEDWINDOW`, `static readonly uint WS_VISIBLE`, `static readonly uint WS_VSCROLL`

### XmlHelper

- properties: `XmlDoc`, `XmlDocName`
- methods: `XmlNew()`, `XmlLoad(string docName)`, `XmlSave(XmlNode xmlNode)`, `FindNode(TreeNode node)`, `FindNode(TreeNode node, XmlNode inXmlNode)`, `CompareNode(XmlNode xNode1, XmlNode xNode2)`, `GetTopParent(XmlNode xNode, XmlNode xNode2)`, `GetXmlPath(XmlNode xNode)`, `CheckDuplicatedWpts()`, `RepairDuplicatedWpts()`, `BotToXml(eCA_003D caveBotManager)`

### bodies

- fields: `string name`, `int freshid`, `int id`

### infoLog

- fields: `string Rvalor`, `string Rname`, `string Rkey`, `int Rdays`, `int Rstrikes`, `string Rinfo`, `string Rmotivo`, `bool Rupdate`, `bool All`

### iteminfo

- properties: `name`, `id`, `usage`, `loot`, `sell`, `buy`

### target

- fields: `bool disposed`
- properties: `id`, `name`, `posx`, `posy`, `posz`, `hppc`, `dist`, `dir`, `isreachable`, `isshootable`, `blacksquare`, `isattackme`, `speed`, `walking`, `ignored`, `skull`, `party`, `warbanner`, `ismonster`, `isplayer`
- methods: `Dispose()`, `Dispose(bool disposing)`

### temp1

- properties: `x`, `y`, `z`, `id`, `cx`, `cy`

### wpt

- fields: `bool disposed`
- properties: `label`, `id`, `x`, `y`, `z`, `randx`, `randy`, `type`, `random`
- methods: `Dispose()`, `Dispose(bool disposing)`


## `iBot.GUI`

### Battle

- fields: `int posX`, `int posY`, `int width`, `int height`, `int maxItems`, `int heightBar`, `int positionBar`, `int areaVision`, `int valor`
- properties: `minimized`, `Open`, `PosX`, `PosY`, `Height`, `Width`, `Minimized`, `MinimiseButton`, `CloseButton`, `ScrollUpButton`, `ScrollDownButton`, `ScrollButton`, `Bottom`
- methods: `Update()`, `Item(int index)`, `Resize(int index)`, `Minimize()`

### Buttons

- fields: `int posX`, `int posY`, `int width`, `int height`, `bool skills`, `bool battle`, `bool vip`
- properties: `PosX`, `PosY`, `Height`, `Width`, `Skills`, `Battle`, `Vip`, `SkillsButton`, `BattleButton`, `VIPButton`, `LogOutButton`
- methods: `Update()`

### Channel

- fields: `readonly object _lock`
- properties: `Name`, `Pointer`, `Selected`, `MaxLines`, `Open`, `Messages`, `LastMsgPointer`
- methods: `RemoveOlderMessages()`, `Update()`, `CheckMessages(Message message)`, `CheckBalance(string msg)`, `ServerCountItem(string msg)`, `GetLootsFromMsg(string message)`

### Channels

- fields: `readonly object _lock`, `string chatText`, `int posX`, `int posY`
- properties: `ChannelList`, `Private`, `Advanced`, `Raid`, `SafeBank`, `HealCreature`, `PlayerPK`, `Unjust`, `YourAttack`, `ChatText`
- methods: `TurnClosedAllChannels()`, `RemoveClosedChannels()`, `Update()`, `FindChannelByName(string name)`, `TurnUsedLootMsgs()`, `FindLastMessage(string name)`, `UpdateLootControl()`, `ChannelOpen(string name)`

### Container

- fields: `int posX`, `int posY`, `int width`, `int height`, `bool minimized`, `int heightBar`, `int positionBar`, `int areaVision`, `int valor`
- properties: `pointer`, `index`, `name`, `id`, `open`, `browse`, `Pointer`, `PosX`, `PosY`, `Height`, `Width`, `Minimized`, `MinimiseButton`, `CloseButton`, `ScrollUpButton`, `ScrollDownButton`, `BrowsePreviewButton`, `BrowseNextButton`, `ScrollButton`, `Bottom`
- methods: `Update()`, `Item(int itemindex)`, `Item(int x, int y)`, `Resize(int index)`, `Minimize(bool min)`, `Preview()`, `Close()`, `BrowsePreview()`, `BrowseNext()`, `BrowseSelectPage(int page)`

### CooldownBar

- properties: `CategoryAttackTimeStart`, `CategoryAttackTimeEnd`, `CategoryHealingTimeStart`, `CategoryHealingTimeEnd`, `CategorySupportTimeStart`, `CategorySupportTimeEnd`, `CategorySpecialTimeStart`, `CategorySpecialTimeEnd`, `TibiaTime`
- methods: `UpdateCooldown()`, `Update()`, `Cooldown(string spell)`, `CanCast(string spell)`

### Equipaments

- fields: `int posX`, `int posY`, `int width`, `int height`, `bool minimized`, `int fightMode`, `int chaseMode`, `bool safeMode`, `bool botaoE`, `int pvpMode`
- properties: `FightMode`, `ChaseMode`, `PvpMode`, `PosX`, `PosY`, `Height`, `Width`, `Minimized`, `MinimiseButton`, `AmuletSlot`, `WeaponSlot`, `RingSlot`, `HelmetSlot`, `ArmorSlot`, `LegsSlot`, `BootsSlot`, `BackPackSlot`, `ShieldSlot`, `ArrowSlot`, `StopButton`, `OffensiveButton`, `BalancedButton`, `DefensiveButton`, `StandingButton`, `ChaseButton`, `EButton`
- methods: `Update()`, `Minimize(bool min)`, `SetPvpMode(string value)`

### FormAuxiliar

- fields: `int posX`, `int posY`, `int AddressPosX`, `int AddressPosY`, `int width`, `int height`, `bool activate`, `string name`
- properties: `Amount`, `MaxAmount`, `PosX`, `PosY`, `Height`, `Width`, `Activate`, `SkillSelected`, `Name`, `Account`, `Password`, `SelectedIndex`, `QtdNames`, `ScrollLeftAmountButton`, `ScrollRightAmountButton`
- methods: `Update()`, `SetAmount(int value)`, `SetAmountScroll(int value)`, `SetAccount(string value)`, `SetPassword(string value)`, `CharsNames()`, `GetServerName()`

### GUI

- enum **ToolsType**: Minimap = 3 EquipamentsMax = 1 EquipamentsMin = 2 BarsHpMana = 4 Buttons = 5 Skills = 6 Battle = 7 Vip = 9 Trade = 10 BackPack = 64
- fields: `object thisLock`
- properties: `ToolsType`, `gameWindow`, `minimapa`, `equipaments`, `buttons`, `battle`, `listContainer`, `trade`, `Channels`, `FormAuxiliar`, `CooldownBar`, `Market`
- methods: `Update()`, `UpdateContainer()`, `MainWindowInfo()`

### GameWindow

- fields: `int posX`, `int posY`, `int width`, `int height`
- properties: `PosX`, `PosY`, `Height`, `Width`, `Graphic`
- methods: `Update()`, `GameWindowInfo()`

### Loot

- properties: `amount`, `name`

### Market

- fields: `int posX`, `int posY`, `int CategorySelect`, `List<string> Categorys`, `int ItemSelect`, `List<int> Items`, `string search`, `string piecePrice`, `int SellOfferSelect`, `List<Ah8_003D> SellOffers`, `int SellOfferValue`, `int SellOfferMax`, `int BuyOfferSelect`, `List<Ah8_003D> BuyOffers`, `int BuyOfferValue`, `int BuyOfferMax`, `bool BotaoBuy`, `bool BotaoSell`, `bool Anonymous`, `int OfferValue`, `int OfferMax`
- properties: `activate`, `Name`, `Search`, `PiecePrice`, `SellOfferButton`, `BuyOfferButton`, `CreateButton`, `AnonymousButton`, `OfferSellButton`, `OfferBuyButton`, `SearchLabel`, `ScrollLeftSellButton`, `ScrollRightSellButton`, `ScrollLeftBuyButton`, `ScrollRightBuyButton`, `ScrollLeftAmountButton`, `ScrollRightAmountButton`, `ScrollTopCategoryButton`, `ScrollBotCategoryButton`, `ScrollTopItemButton`, `ScrollBotItemButton`, `Activate`
- methods: `MouseMove(int x, int y)`, `SelectItem(int itemid)`, `SetSearchItem(string name)`, `SetPrice(int value)`, `SetSellOfferAmount(int value)`, `SetBuyOfferAmount(int value)`, `SetOfferAmount(int value)`, `SetAnonymous(bool state)`, `SetSellButton()`, `SetBuyButton()`, `BuyItemMarket(int id, int qtd, int value)`, `SellItemMarket(int id, int qtd, int value)`, `CreateSellOffer(int id, int qtd, int valor)`, `CreateBuyOffer(int id, int qtd, int valor)`, `CreateOffer(int id, int qtd, int valor)`, `Update()`, `GetStringMemory(int address)`

### Message

- enum **Messagetype**: STATUS = 0 DEFAULT = 1 WHISPER = 2 YELL = 3 NPCTOPLAYER = 6 PRIVATE = 7 CHANNEL = 8 REDALERT = 16 RAID_ADVANCE = 17 WELCOME = 18 STATUSLOG = 19 INFO = 20 SEND = 22
- properties: `Messagetype`, `Type`, `Time`, `Sender`, `Text`, `Tick`, `Pointer`, `UsedLoot`, `lootlist`

### MiniMapa

- fields: `int posX`, `int posY`, `int width`, `int height`, `int zoom`
- properties: `xPos`, `yPos`, `zPos`, `Center`, `PosX`, `PosY`, `Height`, `Width`, `Zoom`, `PlusZoomButton`, `MinusZoomButton`, `CentreZoomButton`
- methods: `Update()`

### Trade

- fields: `readonly object _lock`, `int posX`, `int posY`, `int width`, `int height`, `int ListposX`, `int ListposY`, `int ListWidth`, `int ListHeight`, `bool minimized`, `bool open`, `int tradeType`, `int amount`, `int maxAmount`, `int money`, `int selected`, `int maxItems`, `int typeItems`, `int heightBar`, `int positionBar`, `int areaVision`, `int valor`, `int heightAmountBar`, `int valorAmountBar`
- properties: `Items`, `PosX`, `PosY`, `Height`, `Width`, `Open`, `Minimized`, `MinimiseButton`, `CloseButton`, `ScrollUpButton`, `ScrollDownButton`, `ScrollLeftAmountButton`, `ScrollRightAmountButton`, `BuyButton`, `SellButton`, `OKButton`, `Bottom`
- methods: `Update()`, `Item(int index)`, `Resize(int index)`, `Minimize()`, `SetBuy()`, `SetSell()`, `FindTradeItem(string item)`, `SelectItem(int id, int index)`, `BuyItems(string item, int value)`, `SellItems(string item, int value)`, `SetAmount(int value)`, `tradecount(string tradetype, string item)`

### TradeItem

- properties: `id`, `name`, `peso`, `buy`, `sell`, `qtd`, `index`


## `iBot.Service2`

### Login6CompletedEventArgs

- fields: `object[] results`
- properties: `Result`

### Login6CompletedEventHandler


### Login7CompletedEventArgs

- fields: `object[] results`
- properties: `Result`

### Login7CompletedEventHandler


### LoginXCompletedEventArgs

- fields: `object[] results`
- properties: `Result`

### LoginXCompletedEventHandler


### serviceLogin7

- fields: `SendOrPostCallback Login7OperationCompleted`, `SendOrPostCallback Login6OperationCompleted`, `SendOrPostCallback LoginXOperationCompleted`, `bool useDefaultCredentialsSetExplicitly`
- properties: `Url`, `UseDefaultCredentials`, `Login7Completed`, `Login6Completed`, `LoginXCompleted`
- methods: `Login7(string strValue)`, `Login7Async(string strValue)`, `Login7Async(string strValue, object userState)`, `OnLogin7OperationCompleted(object arg)`, `Login6(string strValue)`, `Login6Async(string strValue)`, `Login6Async(string strValue, object userState)`, `OnLogin6OperationCompleted(object arg)`, `LoginX(string strValue)`, `LoginXAsync(string strValue)`, `LoginXAsync(string strValue, object userState)`, `OnLoginXOperationCompleted(object arg)`, `CancelAsync(object userState)`, `IsLocalFileSystemWebService(string url)`


## `iBot.ServiceReference1`

### Login6Request

- fields: `Login6RequestBody Body`

### Login6RequestBody

- fields: `string enterKey`

### Login6Response

- fields: `Login6ResponseBody Body`

### Login6ResponseBody

- fields: `string Login6Result`

### Login6aRequest

- fields: `Login6aRequestBody Body`

### Login6aRequestBody

- fields: `string enterKey`, `string hardware`, `string version`, `bool changehwdid`

### Login6aResponse

- fields: `Login6aResponseBody Body`

### Login6aResponseBody

- fields: `string Login6aResult`

### LoginXRequest

- fields: `LoginXRequestBody Body`

### LoginXRequestBody

- fields: `string value`

### LoginXResponse

- fields: `LoginXResponseBody Body`

### LoginXResponseBody

- fields: `bool LoginXResult`

### Service1Soap


### Service1SoapChannel


### Service1SoapClient

- methods: `Login6(string enterKey)`, `Login6a(string enterKey, string hardware, string version, bool changehwdid)`, `LoginX(string value)`

