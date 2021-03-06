﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using SlimDXKeys;

using WindowsKey = System.Windows.Forms.Keys;
using SlimDXKey = SlimDXKeys.Key;

namespace FDK
{
	public class DeviceConstantConverter
	{
		// メソッド
		public static Keys KeyToKeyCode(SlimDXKey key )
		{
			switch ( key )
			{
				case Key.D0:
					return Keys.D0;

				case Key.D1:
					return Keys.D1;

				case Key.D2:
					return Keys.D2;

				case Key.D3:
					return Keys.D3;

				case Key.D4:
					return Keys.D4;

				case Key.D5:
					return Keys.D5;

				case Key.D6:
					return Keys.D6;

				case Key.D7:
					return Keys.D7;

				case Key.D8:
					return Keys.D8;

				case Key.D9:
					return Keys.D9;

				case Key.A:
					return Keys.A;

				case Key.B:
					return Keys.B;

				case Key.C:
					return Keys.C;

				case Key.D:
					return Keys.D;

				case Key.E:
					return Keys.E;

				case Key.F:
					return Keys.F;

				case Key.G:
					return Keys.G;

				case Key.H:
					return Keys.H;

				case Key.I:
					return Keys.I;

				case Key.J:
					return Keys.J;

				case Key.K:
					return Keys.K;

				case Key.L:
					return Keys.L;

				case Key.M:
					return Keys.M;

				case Key.N:
					return Keys.N;

				case Key.O:
					return Keys.O;

				case Key.P:
					return Keys.P;

				case Key.Q:
					return Keys.Q;

				case Key.R:
					return Keys.R;

				case Key.S:
					return Keys.S;

				case Key.T:
					return Keys.T;

				case Key.U:
					return Keys.U;

				case Key.V:
					return Keys.V;

				case Key.W:
					return Keys.W;

				case Key.X:
					return Keys.X;

				case Key.Y:
					return Keys.Y;

				case Key.Z:
					return Keys.Z;

//				case Key.AbntC1:
//					return Keys.A; //0x73;
					//147
//				case Key.AbntC2:
//					return Keys.A; //0x7e;

//				case Key.Apostrophe:
//					return Keys.A;			///

				case Key.Applications:
					return Keys.Apps;

				case Key.AT:
					return Keys.Oem3;

//				case Key.AX:
//					return Keys.A;			///

				case Key.Backspace:
					return Keys.Back;

				case Key.Backslash:
					return Keys.Oem5;

//				case Key.Calculator:
//					return Keys.A;			///

				case Key.CapsLock:
					return Keys.CapsLock;

				case Key.Colon:
					return Keys.Oem1;

				case Key.Comma:
					return Keys.Oemcomma;

				case Key.Convert:
					return Keys.IMEConvert;

				case Key.Delete:
					return Keys.Delete;

				case Key.DownArrow:
					return Keys.Down;

				case Key.End:
					return Keys.End;

				case Key.Equals:
					return Keys.A;			///

				case Key.Escape:
					return Keys.Escape;

				case Key.F1:
					return Keys.F1;

				case Key.F2:
					return Keys.F2;

				case Key.F3:
					return Keys.F3;

				case Key.F4:
					return Keys.F4;

				case Key.F5:
					return Keys.F5;

				case Key.F6:
					return Keys.F6;

				case Key.F7:
					return Keys.F7;

				case Key.F8:
					return Keys.F8;

				case Key.F9:
					return Keys.F9;

				case Key.F10:
					return Keys.F10;

				case Key.F11:
					return Keys.F11;

				case Key.F12:
					return Keys.F12;

				case Key.F13:
					return Keys.F13;

				case Key.F14:
					return Keys.F14;

				case Key.F15:
					return Keys.F15;

				case Key.Grave:
					return Keys.A;			///

				case Key.Home:
					return Keys.Home;

				case Key.Insert:
					return Keys.Insert;

				case Key.Kana:
					return Keys.KanaMode;

				case Key.Kanji:
					return Keys.KanjiMode;

				case Key.LeftBracket:
					return Keys.Oem4;

				case Key.LeftControl:
					return Keys.LControlKey;

				case Key.LeftArrow:
					return Keys.Left;

				case Key.LeftAlt:
					return Keys.LMenu;

				case Key.LeftShift:
					return Keys.LShiftKey;

				case Key.LeftWindowsKey:
					return Keys.LWin;

				case Key.Mail:
					return Keys.LaunchMail;

				case Key.MediaSelect:
					return Keys.SelectMedia;

				case Key.MediaStop:
					return Keys.MediaStop;

				case Key.Minus:
					return Keys.OemMinus;

				case Key.Mute:
					return Keys.VolumeMute;

				case Key.MyComputer:			///
					return Keys.A;

				case Key.NextTrack:
					return Keys.MediaNextTrack;

				case Key.NoConvert:
					return Keys.IMENonconvert;

				case Key.NumberLock:
					return Keys.NumLock;

				case Key.NumberPad0:
					return Keys.NumPad0;

				case Key.NumberPad1:
					return Keys.NumPad1;

				case Key.NumberPad2:
					return Keys.NumPad2;

				case Key.NumberPad3:
					return Keys.NumPad3;

				case Key.NumberPad4:
					return Keys.NumPad4;

				case Key.NumberPad5:
					return Keys.NumPad5;

				case Key.NumberPad6:
					return Keys.NumPad6;

				case Key.NumberPad7:
					return Keys.NumPad7;

				case Key.NumberPad8:
					return Keys.NumPad8;

				case Key.NumberPad9:
					return Keys.NumPad9;

				case Key.NumberPadComma:
					return Keys.Separator;

				case Key.NumberPadEnter:
					return Keys.A;				//

				case Key.NumberPadEquals:
					return Keys.A;				//

				case Key.NumberPadMinus:
					return Keys.Subtract;

				case Key.NumberPadPeriod:
					return Keys.Decimal;

				case Key.NumberPadPlus:
					return Keys.Add;

				case Key.NumberPadSlash:
					return Keys.Divide;

				case Key.NumberPadStar:
					return Keys.Multiply;		//

				case Key.Oem102:
					return Keys.Oem102;

				case Key.PageDown:
					return Keys.PageDown;

				case Key.PageUp:
					return Keys.PageUp;

				case Key.Pause:
					return Keys.Pause;

				case Key.Period:
					return Keys.OemPeriod;

				case Key.PlayPause:
					return Keys.MediaPlayPause;

				case Key.Power:
					return Keys.A;				///

				case Key.PreviousTrack:
					return Keys.MediaPreviousTrack;

				case Key.RightBracket:
					return Keys.Oem6;

				case Key.RightControl:
					return Keys.RControlKey;

				case Key.Return:
					return Keys.Return;

				case Key.RightArrow:
					return Keys.Right;

				case Key.RightAlt:
					return Keys.RMenu;

				case Key.RightShift:
					return Keys.A;

				case Key.RightWindowsKey:
					return Keys.RWin;

				case Key.ScrollLock:
					return Keys.Scroll;

				case Key.Semicolon:
					return Keys.Oemplus;		///??

				case Key.Slash:
					return Keys.Oem2;

				case Key.Sleep:
					return Keys.Sleep;

				case Key.Space:
					return Keys.Space;

				case Key.Stop:
					return Keys.MediaStop;

				case Key.PrintScreen:
					return Keys.PrintScreen;

				case Key.Tab:
					return Keys.Tab;

				case Key.Underline:
					return Keys.Oem102;

//				case Key.Unlabeled:				///
//					return Keys.A;

				case Key.UpArrow:
					return Keys.Up;

				case Key.VolumeDown:
					return Keys.VolumeDown;

				case Key.VolumeUp:
					return Keys.VolumeUp;

				case Key.Wake:
					return Keys.A;				///

				case Key.WebBack:
					return Keys.BrowserBack;

				case Key.WebFavorites:
					return Keys.BrowserFavorites;

				case Key.WebForward:
					return Keys.BrowserForward;

				case Key.WebHome:
					return Keys.BrowserHome;

				case Key.WebRefresh:
					return Keys.BrowserRefresh;

				case Key.WebSearch:
					return Keys.BrowserSearch;

				case Key.WebStop:
					return Keys.BrowserStop;

				case Key.Yen:
					return Keys.OemBackslash;
			}
			return 0;
		}

		/// <returns>
		///		対応する値がなければ SlimDX.DirectInput.Unknown を返す。
		/// </returns>
		public static SlimDXKey TKKtoKey(OpenTK.Input.Key key)
		{
			if (_TKKtoKey.ContainsKey(key))
			{
				return _TKKtoKey[key];
			}
			else
			{
				return SlimDXKey.Unknown;
			}
		}

		/// <returns>
		///		対応する値がなければ System.Windows.Forms.Keys.None を返す。
		/// </returns>
		public static WindowsKey KeyToKeys(SlimDXKey key)
		{
			if (_KeyToKeys.ContainsKey(key))
			{
				return _KeyToKeys[key];
			}
			else
			{
				return WindowsKey.None;
			}
		}

		/// <summary>
		///		TKK (OpenTK.Input.Key) から SlimDX.DirectInput.Key への変換表。
		/// </summary>
		private static readonly Dictionary<OpenTK.Input.Key, SlimDXKey> _TKKtoKey = new Dictionary<OpenTK.Input.Key, SlimDXKey>() {
			#region [ *** ]
			{ OpenTK.Input.Key.Unknown, SlimDXKey.Unknown },
			{ OpenTK.Input.Key.ShiftLeft, SlimDXKey.LeftShift },
			{ OpenTK.Input.Key.ShiftRight, SlimDXKey.RightShift },
			{ OpenTK.Input.Key.ControlLeft, SlimDXKey.LeftControl },
			{ OpenTK.Input.Key.ControlRight, SlimDXKey.RightControl },
			{ OpenTK.Input.Key.AltLeft, SlimDXKey.LeftAlt },
			{ OpenTK.Input.Key.AltRight, SlimDXKey.RightAlt },
			{ OpenTK.Input.Key.WinLeft, SlimDXKey.LeftWindowsKey },
			{ OpenTK.Input.Key.WinRight, SlimDXKey.RightWindowsKey },
			{ OpenTK.Input.Key.F1, SlimDXKey.F1 },
			{ OpenTK.Input.Key.F2, SlimDXKey.F2 },
			{ OpenTK.Input.Key.F3, SlimDXKey.F3 },
			{ OpenTK.Input.Key.F4, SlimDXKey.F4 },
			{ OpenTK.Input.Key.F5, SlimDXKey.F5 },
			{ OpenTK.Input.Key.F6, SlimDXKey.F6 },
			{ OpenTK.Input.Key.F7, SlimDXKey.F7 },
			{ OpenTK.Input.Key.F8, SlimDXKey.F8 },
			{ OpenTK.Input.Key.F9, SlimDXKey.F9 },
			{ OpenTK.Input.Key.F10, SlimDXKey.F10 },
			{ OpenTK.Input.Key.F11, SlimDXKey.F11 },
			{ OpenTK.Input.Key.F12, SlimDXKey.F12 },
			{ OpenTK.Input.Key.F13, SlimDXKey.F13 },
			{ OpenTK.Input.Key.F14, SlimDXKey.F14 },
			{ OpenTK.Input.Key.F15, SlimDXKey.F15 },
			{ OpenTK.Input.Key.Up, SlimDXKey.UpArrow },
			{ OpenTK.Input.Key.Down, SlimDXKey.DownArrow },
			{ OpenTK.Input.Key.Left, SlimDXKey.LeftArrow },
			{ OpenTK.Input.Key.Right, SlimDXKey.RightArrow },
			{ OpenTK.Input.Key.Enter, SlimDXKey.Return },
			{ OpenTK.Input.Key.Escape, SlimDXKey.Escape },
			{ OpenTK.Input.Key.Space, SlimDXKey.Space },
			{ OpenTK.Input.Key.Tab, SlimDXKey.Tab },
			{ OpenTK.Input.Key.BackSpace, SlimDXKey.Backspace },
			{ OpenTK.Input.Key.Insert, SlimDXKey.Insert },
			{ OpenTK.Input.Key.Delete, SlimDXKey.Delete },
			{ OpenTK.Input.Key.PageUp, SlimDXKey.PageUp },
			{ OpenTK.Input.Key.PageDown, SlimDXKey.PageDown },
			{ OpenTK.Input.Key.Home, SlimDXKey.Home },
			{ OpenTK.Input.Key.End, SlimDXKey.End },
			{ OpenTK.Input.Key.CapsLock, SlimDXKey.CapsLock },
			{ OpenTK.Input.Key.ScrollLock, SlimDXKey.ScrollLock },
			{ OpenTK.Input.Key.PrintScreen, SlimDXKey.PrintScreen },
			{ OpenTK.Input.Key.Pause, SlimDXKey.Pause },
			{ OpenTK.Input.Key.NumLock, SlimDXKey.NumberLock },
			{ OpenTK.Input.Key.Sleep, SlimDXKey.Sleep },
			{ OpenTK.Input.Key.Keypad0, SlimDXKey.NumberPad0 },
			{ OpenTK.Input.Key.Keypad1, SlimDXKey.NumberPad1 },
			{ OpenTK.Input.Key.Keypad2, SlimDXKey.NumberPad2 },
			{ OpenTK.Input.Key.Keypad3, SlimDXKey.NumberPad3 },
			{ OpenTK.Input.Key.Keypad4, SlimDXKey.NumberPad4 },
			{ OpenTK.Input.Key.Keypad5, SlimDXKey.NumberPad5 },
			{ OpenTK.Input.Key.Keypad6, SlimDXKey.NumberPad6 },
			{ OpenTK.Input.Key.Keypad7, SlimDXKey.NumberPad7 },
			{ OpenTK.Input.Key.Keypad8, SlimDXKey.NumberPad8 },
			{ OpenTK.Input.Key.Keypad9, SlimDXKey.NumberPad9 },
			{ OpenTK.Input.Key.KeypadDivide, SlimDXKey.NumberPadSlash },
			{ OpenTK.Input.Key.KeypadMultiply, SlimDXKey.NumberPadStar },
			{ OpenTK.Input.Key.KeypadMinus, SlimDXKey.NumberPadMinus },
			{ OpenTK.Input.Key.KeypadPlus, SlimDXKey.NumberPadPlus },
			{ OpenTK.Input.Key.KeypadPeriod, SlimDXKey.NumberPadPeriod },
			{ OpenTK.Input.Key.KeypadEnter, SlimDXKey.NumberPadEnter },
			{ OpenTK.Input.Key.A, SlimDXKey.A },
			{ OpenTK.Input.Key.B, SlimDXKey.B },
			{ OpenTK.Input.Key.C, SlimDXKey.C },
			{ OpenTK.Input.Key.D, SlimDXKey.D },
			{ OpenTK.Input.Key.E, SlimDXKey.E },
			{ OpenTK.Input.Key.F, SlimDXKey.F },
			{ OpenTK.Input.Key.G, SlimDXKey.G },
			{ OpenTK.Input.Key.H, SlimDXKey.H },
			{ OpenTK.Input.Key.I, SlimDXKey.I },
			{ OpenTK.Input.Key.J, SlimDXKey.J },
			{ OpenTK.Input.Key.K, SlimDXKey.K },
			{ OpenTK.Input.Key.L, SlimDXKey.L },
			{ OpenTK.Input.Key.M, SlimDXKey.M },
			{ OpenTK.Input.Key.N, SlimDXKey.N },
			{ OpenTK.Input.Key.O, SlimDXKey.O },
			{ OpenTK.Input.Key.P, SlimDXKey.P },
			{ OpenTK.Input.Key.Q, SlimDXKey.Q },
			{ OpenTK.Input.Key.R, SlimDXKey.R },
			{ OpenTK.Input.Key.S, SlimDXKey.S },
			{ OpenTK.Input.Key.T, SlimDXKey.T },
			{ OpenTK.Input.Key.U, SlimDXKey.U },
			{ OpenTK.Input.Key.V, SlimDXKey.V },
			{ OpenTK.Input.Key.W, SlimDXKey.W },
			{ OpenTK.Input.Key.X, SlimDXKey.X },
			{ OpenTK.Input.Key.Y, SlimDXKey.Y },
			{ OpenTK.Input.Key.Z, SlimDXKey.Z },
			{ OpenTK.Input.Key.Number0, SlimDXKey.D0 },
			{ OpenTK.Input.Key.Number1, SlimDXKey.D1 },
			{ OpenTK.Input.Key.Number2, SlimDXKey.D2 },
			{ OpenTK.Input.Key.Number3, SlimDXKey.D3 },
			{ OpenTK.Input.Key.Number4, SlimDXKey.D4 },
			{ OpenTK.Input.Key.Number5, SlimDXKey.D5 },
			{ OpenTK.Input.Key.Number6, SlimDXKey.D6 },
			{ OpenTK.Input.Key.Number7, SlimDXKey.D7 },
			{ OpenTK.Input.Key.Number8, SlimDXKey.D8 },
			{ OpenTK.Input.Key.Number9, SlimDXKey.D9 },
			{ OpenTK.Input.Key.Grave, SlimDXKey.Grave },
			{ OpenTK.Input.Key.Minus, SlimDXKey.Minus },
			{ OpenTK.Input.Key.BracketLeft, SlimDXKey.LeftBracket },
			{ OpenTK.Input.Key.BracketRight, SlimDXKey.RightBracket },
			{ OpenTK.Input.Key.Semicolon, SlimDXKey.Semicolon },
			{ OpenTK.Input.Key.Quote, SlimDXKey.Apostrophe },
			{ OpenTK.Input.Key.Comma, SlimDXKey.Comma },
			{ OpenTK.Input.Key.Period, SlimDXKey.Period },
			{ OpenTK.Input.Key.Slash, SlimDXKey.Slash },
			{ OpenTK.Input.Key.BackSlash, SlimDXKey.Backslash },
			{ OpenTK.Input.Key.NonUSBackSlash, SlimDXKey.Yen },
			#endregion
		};

		/// <summary>
		///		SlimDX.DirectInput.Key から System.Windows.Form.Keys への変換表。
		/// </summary>
		private static readonly Dictionary<SlimDXKey, WindowsKey> _KeyToKeys = new Dictionary<SlimDXKey, WindowsKey>() {
			#region [ *** ]
			{ SlimDXKey.D0, WindowsKey.D0 },
			{ SlimDXKey.D1, WindowsKey.D1 },
			{ SlimDXKey.D2, WindowsKey.D2 },
			{ SlimDXKey.D3, WindowsKey.D3 },
			{ SlimDXKey.D4, WindowsKey.D4 },
			{ SlimDXKey.D5, WindowsKey.D5 },
			{ SlimDXKey.D6, WindowsKey.D6 },
			{ SlimDXKey.D7, WindowsKey.D7 },
			{ SlimDXKey.D8, WindowsKey.D8 },
			{ SlimDXKey.D9, WindowsKey.D9 },
			{ SlimDXKey.A, WindowsKey.A },
			{ SlimDXKey.B, WindowsKey.B },
			{ SlimDXKey.C, WindowsKey.C },
			{ SlimDXKey.D, WindowsKey.D },
			{ SlimDXKey.E, WindowsKey.E },
			{ SlimDXKey.F, WindowsKey.F },
			{ SlimDXKey.G, WindowsKey.G },
			{ SlimDXKey.H, WindowsKey.H },
			{ SlimDXKey.I, WindowsKey.I },
			{ SlimDXKey.J, WindowsKey.J },
			{ SlimDXKey.K, WindowsKey.K },
			{ SlimDXKey.L, WindowsKey.L },
			{ SlimDXKey.M, WindowsKey.M },
			{ SlimDXKey.N, WindowsKey.N },
			{ SlimDXKey.O, WindowsKey.O },
			{ SlimDXKey.P, WindowsKey.P },
			{ SlimDXKey.Q, WindowsKey.Q },
			{ SlimDXKey.R, WindowsKey.R },
			{ SlimDXKey.S, WindowsKey.S },
			{ SlimDXKey.T, WindowsKey.T },
			{ SlimDXKey.U, WindowsKey.U },
			{ SlimDXKey.V, WindowsKey.V },
			{ SlimDXKey.W, WindowsKey.W },
			{ SlimDXKey.X, WindowsKey.X },
			{ SlimDXKey.Y, WindowsKey.Y },
			{ SlimDXKey.Z, WindowsKey.Z },
			//{ SlimDXKey.AbntC1, WindowsKey.A },
			//{ SlimDXKey.AbntC2, WindowsKey.A },
			{ SlimDXKey.Apostrophe, WindowsKey.OemQuotes },
			{ SlimDXKey.Applications, WindowsKey.Apps },
			{ SlimDXKey.AT, WindowsKey.Oem3 },	// OemTilde と同値
			//{ SlimDXKey.AX, WindowsKey.A },	// OemAX (225) は未定義
			{ SlimDXKey.Backspace, WindowsKey.Back },
			{ SlimDXKey.Backslash, WindowsKey.OemBackslash },
			//{ SlimDXKey.Calculator, WindowsKey.A },
			{ SlimDXKey.CapsLock, WindowsKey.CapsLock },
			{ SlimDXKey.Colon, WindowsKey.Oem1 },
			{ SlimDXKey.Comma, WindowsKey.Oemcomma },
			{ SlimDXKey.Convert, WindowsKey.IMEConvert },
			{ SlimDXKey.Delete, WindowsKey.Delete },
			{ SlimDXKey.DownArrow, WindowsKey.Down },
			{ SlimDXKey.End, WindowsKey.End },
			{ SlimDXKey.Equals, WindowsKey.A },		// ?
			{ SlimDXKey.Escape, WindowsKey.Escape },
			{ SlimDXKey.F1, WindowsKey.F1 },
			{ SlimDXKey.F2, WindowsKey.F2 },
			{ SlimDXKey.F3, WindowsKey.F3 },
			{ SlimDXKey.F4, WindowsKey.F4 },
			{ SlimDXKey.F5, WindowsKey.F5 },
			{ SlimDXKey.F6, WindowsKey.F6 },
			{ SlimDXKey.F7, WindowsKey.F7 },
			{ SlimDXKey.F8, WindowsKey.F8 },
			{ SlimDXKey.F9, WindowsKey.F9 },
			{ SlimDXKey.F10, WindowsKey.F10 },
			{ SlimDXKey.F11, WindowsKey.F11 },
			{ SlimDXKey.F12, WindowsKey.F12 },
			{ SlimDXKey.F13, WindowsKey.F13 },
			{ SlimDXKey.F14, WindowsKey.F14 },
			{ SlimDXKey.F15, WindowsKey.F15 },
			{ SlimDXKey.Grave, WindowsKey.A },		// ?
			{ SlimDXKey.Home, WindowsKey.Home },
			{ SlimDXKey.Insert, WindowsKey.Insert },
			{ SlimDXKey.Kana, WindowsKey.KanaMode },
			{ SlimDXKey.Kanji, WindowsKey.KanjiMode },
			{ SlimDXKey.LeftBracket, WindowsKey.Oem4 },
			{ SlimDXKey.LeftControl, WindowsKey.LControlKey },
			{ SlimDXKey.LeftArrow, WindowsKey.Left },
			{ SlimDXKey.LeftAlt, WindowsKey.LMenu },
			{ SlimDXKey.LeftShift, WindowsKey.LShiftKey },
			{ SlimDXKey.LeftWindowsKey, WindowsKey.LWin },
			{ SlimDXKey.Mail, WindowsKey.LaunchMail },
			{ SlimDXKey.MediaSelect, WindowsKey.SelectMedia },
			{ SlimDXKey.MediaStop, WindowsKey.MediaStop },
			{ SlimDXKey.Minus, WindowsKey.OemMinus },
			{ SlimDXKey.Mute, WindowsKey.VolumeMute },
			{ SlimDXKey.MyComputer, WindowsKey.A },		// ?
			{ SlimDXKey.NextTrack, WindowsKey.MediaNextTrack },
			{ SlimDXKey.NoConvert, WindowsKey.IMENonconvert },
			{ SlimDXKey.NumberLock, WindowsKey.NumLock },
			{ SlimDXKey.NumberPad0, WindowsKey.NumPad0 },
			{ SlimDXKey.NumberPad1, WindowsKey.NumPad1 },
			{ SlimDXKey.NumberPad2, WindowsKey.NumPad2 },
			{ SlimDXKey.NumberPad3, WindowsKey.NumPad3 },
			{ SlimDXKey.NumberPad4, WindowsKey.NumPad4 },
			{ SlimDXKey.NumberPad5, WindowsKey.NumPad5 },
			{ SlimDXKey.NumberPad6, WindowsKey.NumPad6 },
			{ SlimDXKey.NumberPad7, WindowsKey.NumPad7 },
			{ SlimDXKey.NumberPad8, WindowsKey.NumPad8 },
			{ SlimDXKey.NumberPad9, WindowsKey.NumPad9 },
			{ SlimDXKey.NumberPadComma, WindowsKey.Separator },
			{ SlimDXKey.NumberPadEnter, WindowsKey.A },		// ?
			{ SlimDXKey.NumberPadEquals, WindowsKey.A },		// ?
			{ SlimDXKey.NumberPadMinus, WindowsKey.Subtract },
			{ SlimDXKey.NumberPadPeriod, WindowsKey.Decimal },
			{ SlimDXKey.NumberPadPlus, WindowsKey.Add },
			{ SlimDXKey.NumberPadSlash, WindowsKey.Divide },
			{ SlimDXKey.NumberPadStar, WindowsKey.Multiply },
			{ SlimDXKey.Oem102, WindowsKey.Oem102 },
			{ SlimDXKey.PageDown, WindowsKey.PageDown },
			{ SlimDXKey.PageUp, WindowsKey.PageUp },
			{ SlimDXKey.Pause, WindowsKey.Pause },
			{ SlimDXKey.Period, WindowsKey.OemPeriod },
			{ SlimDXKey.PlayPause, WindowsKey.MediaPlayPause },
			{ SlimDXKey.Power, WindowsKey.A },		// ?
			{ SlimDXKey.PreviousTrack, WindowsKey.MediaPreviousTrack },
			{ SlimDXKey.RightBracket, WindowsKey.Oem6 },
			{ SlimDXKey.RightControl, WindowsKey.RControlKey },
			{ SlimDXKey.Return, WindowsKey.Return },
			{ SlimDXKey.RightArrow, WindowsKey.Right },
			{ SlimDXKey.RightAlt, WindowsKey.RMenu },
			{ SlimDXKey.RightShift, WindowsKey.A },		// ?
			{ SlimDXKey.RightWindowsKey, WindowsKey.RWin },
			{ SlimDXKey.ScrollLock, WindowsKey.Scroll },
			{ SlimDXKey.Semicolon, WindowsKey.Oemplus    },	// OemSemicolon じゃなくて？
			{ SlimDXKey.Slash, WindowsKey.Oem2 },
			{ SlimDXKey.Sleep, WindowsKey.Sleep },
			{ SlimDXKey.Space, WindowsKey.Space },
			{ SlimDXKey.Stop, WindowsKey.MediaStop },
			{ SlimDXKey.PrintScreen, WindowsKey.PrintScreen },
			{ SlimDXKey.Tab, WindowsKey.Tab },
			{ SlimDXKey.Underline, WindowsKey.Oem102 },
			//{ SlimDXKey.Unlabeled, WindowsKey.A },		// ?
			{ SlimDXKey.UpArrow, WindowsKey.Up },
			{ SlimDXKey.VolumeDown, WindowsKey.VolumeDown },
			{ SlimDXKey.VolumeUp, WindowsKey.VolumeUp },
			{ SlimDXKey.Wake, WindowsKey.A },		// ?
			{ SlimDXKey.WebBack, WindowsKey.BrowserBack },
			{ SlimDXKey.WebFavorites, WindowsKey.BrowserFavorites },
			{ SlimDXKey.WebForward, WindowsKey.BrowserForward },
			{ SlimDXKey.WebHome, WindowsKey.BrowserHome },
			{ SlimDXKey.WebRefresh, WindowsKey.BrowserRefresh },
			{ SlimDXKey.WebSearch, WindowsKey.BrowserSearch },
			{ SlimDXKey.WebStop, WindowsKey.BrowserStop },
			{ SlimDXKey.Yen, WindowsKey.OemBackslash },
			#endregion
		};
	}
}
