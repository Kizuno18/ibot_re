using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace iBot.Util;

public static class WinApi
{
	[StructLayout(LayoutKind.Sequential)]
	public class _9CY_003D
	{
		public int _9SY_003D;

		public int _9iY_003D;

		public int _9yY_003D;

		public int _002FCY_003D;

		public int _002FSY_003D;

		public byte _002FiY_003D;

		public byte _002FyY_003D;

		public byte ACc_003D;

		public byte ASc_003D;

		public byte Aic_003D;

		public byte Ayc_003D;

		public byte BCc_003D;

		public byte BSc_003D;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string Bic_003D;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _9CY_003D()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static _9CY_003D()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public struct RECT
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static RECT()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public struct Byc_003D
	{
		public IntPtr CCc_003D;

		public bool CSc_003D;

		public RECT Cic_003D;

		public bool Cyc_003D;

		public bool DCc_003D;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] DSc_003D;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Byc_003D()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public struct Margins
	{
		public int Left;

		public int Right;

		public int Top;

		public int Bottom;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Margins()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public enum Dic_003D
	{
		Dyc_003D = 0,
		ECc_003D = 1,
		ESc_003D = 2,
		Eic_003D = 3,
		Eyc_003D = 3,
		FCc_003D = 4,
		FSc_003D = 5,
		Fic_003D = 6,
		Fyc_003D = 7,
		GCc_003D = 8,
		GSc_003D = 9,
		Gic_003D = 10,
		Gyc_003D = 11
	}

	public enum HCc_003D
	{
		HSc_003D = 0,
		Hic_003D = 1,
		Hyc_003D = 2,
		ICc_003D = 3,
		ISc_003D = 4,
		Iic_003D = 5,
		Iyc_003D = 5,
		JCc_003D = 6,
		JSc_003D = 7,
		Jic_003D = 8,
		Jyc_003D = 10,
		KCc_003D = 11,
		KSc_003D = 12,
		Kic_003D = 13,
		Kyc_003D = 14,
		LCc_003D = 15,
		LSc_003D = 16,
		Lic_003D = 17,
		Lyc_003D = 18,
		MCc_003D = 19
	}

	public enum MSc_003D
	{
		Mic_003D = 0,
		Myc_003D = 1,
		NCc_003D = 2,
		NSc_003D = 3,
		Nic_003D = 4,
		Nyc_003D = 5,
		OCc_003D = 6,
		OSc_003D = 7,
		Oic_003D = 8,
		Oyc_003D = 15,
		PCc_003D = 0,
		PSc_003D = 256,
		Pic_003D = 512,
		Pyc_003D = 3840,
		QCc_003D = 0,
		QSc_003D = 4096,
		Qic_003D = 8192,
		Qyc_003D = 61440,
		RCc_003D = 0,
		RSc_003D = 65536,
		Ric_003D = 983040
	}

	public enum Ryc_003D : uint
	{
		SCc_003D = 0u,
		SSc_003D = 1u,
		Sic_003D = 2u,
		Syc_003D = 4u,
		TCc_003D = 8u,
		TSc_003D = 0x10u,
		Tic_003D = 0x20u,
		Tyc_003D = 0x40u,
		UCc_003D = 0x80u,
		USc_003D = 0x100u,
		Uic_003D = 0x200u,
		Uyc_003D = 0x400u,
		VCc_003D = 0x800u,
		VSc_003D = 0x1000u,
		Vic_003D = 0x2000u,
		Vyc_003D = 0x4000u,
		WCc_003D = 0x8000u,
		WSc_003D = 0x10000u,
		Wic_003D = 0x20000u,
		Wyc_003D = 0x40000u,
		XCc_003D = 0x80000u,
		XSc_003D = 0x100000u,
		Xic_003D = 0x200000u
	}

	public enum Xyc_003D
	{
		YCc_003D = 0,
		YSc_003D = 100,
		Yic_003D = 200,
		Yyc_003D = 300,
		ZCc_003D = 400,
		ZSc_003D = 500,
		Zic_003D = 600,
		Zyc_003D = 700,
		aCc_003D = 800,
		aSc_003D = 900
	}

	public enum aic_003D : uint
	{
		ayc_003D = 0u,
		bCc_003D = 1u,
		bSc_003D = 2u,
		bic_003D = 128u,
		byc_003D = 129u,
		cCc_003D = 129u,
		cSc_003D = 134u,
		cic_003D = 136u,
		cyc_003D = 255u,
		dCc_003D = 130u,
		dSc_003D = 177u,
		dic_003D = 178u,
		dyc_003D = 161u,
		eCc_003D = 162u,
		eSc_003D = 163u,
		eic_003D = 222u,
		eyc_003D = 238u,
		fCc_003D = 204u,
		fSc_003D = 77u,
		fic_003D = 186u
	}

	public enum fyc_003D : uint
	{
		gCc_003D,
		gSc_003D,
		gic_003D,
		gyc_003D,
		hCc_003D,
		hSc_003D,
		hic_003D,
		hyc_003D,
		iCc_003D,
		iSc_003D,
		iic_003D
	}

	public enum iyc_003D : uint
	{
		jCc_003D = 0u,
		jSc_003D = 1u,
		jic_003D = 2u,
		jyc_003D = 15u,
		kCc_003D = 16u,
		kSc_003D = 32u,
		kic_003D = 64u,
		kyc_003D = 128u
	}

	public enum lCc_003D : uint
	{
		lSc_003D,
		lic_003D,
		lyc_003D,
		mCc_003D,
		mSc_003D,
		mic_003D,
		myc_003D
	}

	[Flags]
	public enum nCc_003D : uint
	{
		nSc_003D = 0u,
		nic_003D = 1u,
		nyc_003D = 2u,
		oCc_003D = 0u,
		oSc_003D = 0x10u,
		oic_003D = 0x20u,
		oyc_003D = 0x30u,
		pCc_003D = 0x40u,
		pSc_003D = 0x50u
	}

	public enum pic_003D
	{
		pyc_003D = 1,
		qCc_003D,
		qSc_003D,
		qic_003D,
		qyc_003D,
		rCc_003D,
		rSc_003D,
		ric_003D
	}

	public enum ryc_003D
	{
		sCc_003D = 0,
		sSc_003D = 2,
		sic_003D = 4,
		syc_003D = 6,
		tCc_003D = 8,
		tSc_003D = 10,
		tic_003D = 12,
		tyc_003D = 14,
		uCc_003D = 16,
		uSc_003D = 18,
		uic_003D = 20,
		uyc_003D = 22,
		vCc_003D = 24,
		vSc_003D = 26,
		vic_003D = 28,
		vyc_003D = 30,
		wCc_003D = 32,
		wSc_003D = 34,
		wic_003D = 36,
		wyc_003D = 38,
		xCc_003D = 40,
		xSc_003D = 42,
		xic_003D = 44,
		xyc_003D = 45,
		yCc_003D = 88,
		ySc_003D = 90,
		yic_003D = 104,
		yyc_003D = 106,
		zCc_003D = 108,
		zSc_003D = 110,
		zic_003D = 111,
		zyc_003D = 112,
		_0Cc_003D = 113,
		_0Sc_003D = 114,
		_0ic_003D = 115,
		_0yc_003D = 116,
		_1Cc_003D = 117,
		_1Sc_003D = 118,
		_1ic_003D = 119
	}

	[Flags]
	public enum _1yc_003D : uint
	{
		_2Cc_003D = 1u,
		_2Sc_003D = 2u,
		_2ic_003D = 4u,
		_2yc_003D = 8u,
		_3Cc_003D = 0x10u,
		_3Sc_003D = 0x20u,
		_3ic_003D = 0x40u,
		_3yc_003D = 0x80u,
		_4Cc_003D = 0x100u,
		_4Sc_003D = 0x200u,
		_4ic_003D = 0x400u,
		_4yc_003D = 0x800u
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct WNDCLASS
	{
		public uint style;

		public IntPtr lpfnWndProc;

		public int cbClsExtra;

		public int cbWndExtra;

		public IntPtr hInstance;

		public IntPtr hIcon;

		public IntPtr hCursor;

		public IntPtr hbrBackground;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lpszMenuName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lpszClassName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WNDCLASS()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public struct WINDOWPLACEMENT
	{
		public int length;

		public int flags;

		public int showCmd;

		public Point ptMinPosition;

		public Point ptMaxPosition;

		public Rectangle rcNormalPosition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WINDOWPLACEMENT()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public struct MOUSEINPUT
	{
		public int dx;

		public int dy;

		public uint mouseData;

		public uint dwFlags;

		public uint time;

		public IntPtr dwExtraInfo;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MOUSEINPUT()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public struct KEYBDINPUT
	{
		public ushort wVk;

		public ushort wScan;

		public uint dwFlags;

		public uint time;

		public IntPtr dwExtraInfo;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static KEYBDINPUT()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public struct HARDWAREINPUT
	{
		public uint uMsg;

		public ushort wParamL;

		public ushort wParamH;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static HARDWAREINPUT()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct INPUT
	{
		[FieldOffset(0)]
		public int type;

		[FieldOffset(4)]
		public MOUSEINPUT mi;

		[FieldOffset(4)]
		public KEYBDINPUT ki;

		[FieldOffset(4)]
		public HARDWAREINPUT hi;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static INPUT()
		{
			global::_003CAgileDotNetRT_003E.Initialize();
			global::_003CAgileDotNetRT_003E.PostInitialize();
		}
	}

	public enum _5Cc_003D
	{
		_5Sc_003D = -4,
		_5ic_003D = -6,
		_5yc_003D = -8,
		_6Cc_003D = -16,
		_6Sc_003D = -20,
		_6ic_003D = -21,
		_6yc_003D = -12
	}

	public const int ERROR_CLASS_ALREADY_EXISTS = 1410;

	public const int WM_SIZE = 5;

	public const int WM_KEYDOWN = 256;

	public const int WM_KEYUP = 257;

	public const int WM_CHAR = 258;

	public const int WM_SYSKEYDOWN = 260;

	public const int WM_SYSKEYUP = 261;

	public const int WM_HSCROLL = 276;

	public const int WM_VSCROLL = 277;

	public const int WM_MOUSEWHEEL = 522;

	public const int WM_SETCURSOR = 32;

	public const int WM_MOUSEACTIVATE = 33;

	public const int WM_MOUSEMOVE = 512;

	public const int WM_LBUTTONDOWN = 513;

	public const int WM_LBUTTONUP = 514;

	public const int WM_LBUTTONDBLCLK = 515;

	public const int WM_RBUTTONDOWN = 516;

	public const int WM_RBUTTONUP = 517;

	public const int WM_RBUTTONDBLCLK = 518;

	public const int SB_LINEUP = 0;

	public const int SB_LINELEFT = 0;

	public const int SB_LINEDOWN = 1;

	public const int SB_LINERIGHT = 1;

	public const int SB_PAGEUP = 2;

	public const int SB_PAGELEFT = 2;

	public const int SB_PAGEDOWN = 3;

	public const int SB_PAGERIGTH = 3;

	public const int SB_PAGETOP = 6;

	public const int SB_LEFT = 6;

	public const int SB_PAGEBOTTOM = 7;

	public const int SB_RIGHT = 7;

	public const int SB_ENDSCROLL = 8;

	public const int MK_LBUTTON = 1;

	public const int MK_RBUTTON = 2;

	public const int MK_CONTROL = 8;

	public const int MK_SHIFT = 4;

	public const int GWL_EXSTYLE = -20;

	public const int WS_EX_LAYERED = 524288;

	public const int LWA_ALPHA = 2;

	public const int LWA_COLORKEY = 1;

	public const uint SW_HIDE = 0u;

	public const uint SW_SHOWNORMAL = 1u;

	public const uint SW_NORMAL = 1u;

	public const uint SW_SHOWMINIMIZED = 2u;

	public const uint SW_SHOWMAXIMIZED = 3u;

	public const uint SW_MAXIMIZE = 3u;

	public const uint SW_SHOWNOACTIVATE = 4u;

	public const uint SW_SHOW = 5u;

	public const uint SW_MINIMIZE = 6u;

	public const uint SW_SHOWMINNOACTIVE = 7u;

	public const uint SW_SHOWNA = 8u;

	public const uint SW_RESTORE = 9u;

	public const byte VK_NUMLOCK = 144;

	public const int TRANSPARENT = 1;

	public const int OPAQUE = 2;

	public const int WS_MINIMIZE = 131072;

	public const int GWL_STYLE = -16;

	public const int INPUT_MOUSE = 0;

	private const int INPUT_KEYBOARD = 1;

	private const int INPUT_HARDWARE = 2;

	private const uint KEYEVENTF_EXTENDEDKEY = 1u;

	private const uint KEYEVENTF_KEYUP = 2u;

	private const uint KEYEVENTF_UNICODE = 4u;

	private const uint KEYEVENTF_SCANCODE = 8u;

	private const uint XBUTTON1 = 1u;

	private const uint XBUTTON2 = 2u;

	private const uint MOUSEEVENTF_MOVE = 1u;

	private const uint MOUSEEVENTF_LEFTDOWN = 2u;

	private const uint MOUSEEVENTF_LEFTUP = 4u;

	private const uint MOUSEEVENTF_RIGHTDOWN = 8u;

	private const uint MOUSEEVENTF_RIGHTUP = 16u;

	private const uint MOUSEEVENTF_MIDDLEDOWN = 32u;

	private const uint MOUSEEVENTF_MIDDLEUP = 64u;

	private const uint MOUSEEVENTF_XDOWN = 128u;

	private const uint MOUSEEVENTF_XUP = 256u;

	private const uint MOUSEEVENTF_WHEEL = 2048u;

	private const uint MOUSEEVENTF_VIRTUALDESK = 16384u;

	private const uint MOUSEEVENTF_ABSOLUTE = 32768u;

	public const int WH_KEYBOARD_LL = 13;

	[DllImport("dwmapi.dll", PreserveSig = false)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern void DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Margins pMargins);

	[DllImport("ibotlib.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern void getHardwareID(StringBuilder output);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr CreateFontIndirect([In][MarshalAs(UnmanagedType.LPStruct)] _9CY_003D lplf);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, uint flags);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool Rectangle(IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr CreateSolidBrush(uint crColor);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern uint SetDCPenColor(IntPtr hdc, uint crColor);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern uint SetDCBrushColor(IntPtr hdc, uint crColor);

	[DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetStockObject(HCc_003D fnObject);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int SetBkMode(IntPtr hdc, int iBkMode);

	[DllImport("gdi32.dll", CharSet = CharSet.Auto)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool TextOut(IntPtr hdc, int nXStart, int nYStart, string lpString, int cbString);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr CreateRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool InvertRgn(IntPtr hdc, IntPtr hrgn);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteObject([In] IntPtr hObject);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern uint SetTextColor(IntPtr hdc, uint crColor);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr CreatePen(MSc_003D fnPenStyle, int nWidth, uint crColor);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr CreateFont(int nHeight, int nWidth, int nEscapement, int nOrientation, int fnWeight, uint fdwItalic, uint fdwUnderline, uint fdwStrikeOut, uint fdwCharSet, uint fdwOutputPrecision, uint fdwClipPrecision, uint fdwQuality, uint fdwPitchAndFamily, string lpszFace);

	[DllImport("gdi32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int SetMapMode(IntPtr hdc, int fnMapMode);

	[DllImport("user32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr CreateWindowExW(uint dwExStyle, [MarshalAs(UnmanagedType.LPWStr)] string lpClassName, [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int FillRect(IntPtr hDC, [In] ref RECT lprc, IntPtr hbr);

	[DllImport("user32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr DefWindowProcW(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool DestroyWindow(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern ushort RegisterClassW([In] ref WNDCLASS lpWndClass);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr BeginPaint(IntPtr hwnd, out Byc_003D lpPaint);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool EndPaint(IntPtr hWnd, [In] ref Byc_003D lpPaint);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool UpdateWindow(IntPtr hWnd);

	[DllImport("kernel32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);

	[DllImport("User32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetDC(IntPtr hwnd);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

	[DllImport("User32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern void ReleaseDC(IntPtr dc);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetActiveWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetFocus();

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int DrawText(IntPtr hDC, string lpString, int nCount, ref RECT lpRect, uint uFormat);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern short GetKeyState(int keyCode);

	[DllImport("User32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern short GetAsyncKeyState(Keys vKey);

	[DllImport("kernel32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

	[DllImport("user32")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int SetWindowLong(int hwnd, int nIndex, int dwNew);

	[DllImport("user32")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int GetWindowLong(int hwnd, int nIndex);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

	[DllImport("User32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int SendInput(int nInputs, ref INPUT pInputs, int cbSize);

	[DllImport("USER32.DLL")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr SetFocus(IntPtr hwnd);

	[DllImport("user32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr SetActiveWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

	[DllImport("user32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("kernel32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

	[DllImport("kernel32.dll", SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out uint lpNumberOfBytesWritten);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

	[DllImport("User32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, long lParam);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool FlashWindow(IntPtr hWnd, bool invert);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetCursorPos(int X, int Y);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetCursorPos(out Point lpPoint);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool GetWindowRect(HandleRef handle, out RECT rct);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr WindowFromPoint(Point pt);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint MakeCOLORREF(byte r, byte g, byte b)
	{
		return 0u;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getOSArchitecture()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getOSInfo()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static WinApi()
	{
		global::_003CAgileDotNetRT_003E.Initialize();
		global::_003CAgileDotNetRT_003E.PostInitialize();
	}
}
