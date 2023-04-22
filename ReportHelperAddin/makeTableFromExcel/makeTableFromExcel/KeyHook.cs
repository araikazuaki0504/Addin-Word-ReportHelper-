﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace makeTableFromExcel
{
    class KeyHook
    {

    }

    public class KeyboardHook
    {
        private const int WH_KEYBOARD_LL = 0x0D;
        private const int WM_KEYBOARD_DOWN = 0x100;
        private const int WM_KEYBOARD_UP = 0x101;
        private const int WM_SYSKEY_DOWN = 0x104;
        private const int WM_SYSKEY_UP = 0x105;

        //イベントハンドラの定義
        public event EventHandler<KeyboardHookEventArgs> OnKeyDown = delegate { };
        public event EventHandler<KeyboardHookEventArgs> OnKeyUp = delegate { };

        //コールバック関数のdelegate 定義
        private delegate IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam);

        //キーボードフックに必要なDLLのインポート
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, HookCallback lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        //フックプロシージャのハンドル
        private static IntPtr _hookHandle = IntPtr.Zero;

        //フック時のコールバック関数
        private static HookCallback _callback;

        /// <summary>
        /// キーボードHook の開始
        /// </summary>
        /// <param name="callback"></param>
        public void Hook()
        {
            _callback = CallbackProc;
            using (Process process = Process.GetCurrentProcess())
            {
                using (ProcessModule module = process.MainModule)
                {
                    _hookHandle = SetWindowsHookEx(
                       WH_KEYBOARD_LL,                                          //フックするイベントの種類
                       _callback, //フック時のコールバック関数
                       GetModuleHandle(module.ModuleName),                      //インスタンスハンドル
                       0                                                        //スレッドID（0：全てのスレッドでフック）
                   );
                }
            }
        }
        /// <summary>
        /// コールバック関数
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        private IntPtr CallbackProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            var args = new KeyboardHookEventArgs();
            Keys key = (Keys)(short)Marshal.ReadInt32(lParam);
            args.Key = key;

            if ((int)wParam == WM_KEYBOARD_DOWN || (int)wParam == WM_SYSKEY_DOWN) OnKeyDown(this, args);
            if ((int)wParam == WM_KEYBOARD_UP || (int)wParam == WM_SYSKEY_UP) OnKeyUp(this, args);

            return (args.RetCode == 0) ? CallNextHookEx(_hookHandle, nCode, wParam, lParam) : (IntPtr)1;
        }
        /// <summary>
        /// キーボードHockの終了
        /// </summary>
        public void UnHook()
        {
            UnhookWindowsHookEx(_hookHandle);
            _hookHandle = IntPtr.Zero;
        }
    }

    /// <summary>
    /// キーボードフックのイベント引数
    /// </summary>
    public class KeyboardHookEventArgs
    {
        public Keys Key { get; set; }
        public int RetCode { get; set; } = 0;
    }
}
