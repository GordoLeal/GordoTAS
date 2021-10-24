using System;
using System.Runtime.InteropServices;

namespace GordoTAS
{
    /// <summary>
    /// InputSender holds a few functions that integrate with windows SendInput Functions
    /// </summary>
    class InputSender
    {
        /// <summary>
        /// Add moviment to cursor
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        /// <returns></returns>
        public static bool SendMoveMouse(int dx, int dy)
        { 

            WinAPI.Input[] sInputs;
            sInputs = new WinAPI.Input[1];

            sInputs[0].mi.dx = dx;
            sInputs[0].mi.dy = dy;
            sInputs[0].mi.mouseData = 0;
            sInputs[0].mi.dwExtraInfo = WinAPI.GetMessageExtraInfo();
            sInputs[0].mi.dwFlags = (uint)Input.MouseEvent.MOVE;

            int cuj = WinAPI.SendInput((short)sInputs.Length, sInputs, Marshal.SizeOf(new WinAPI.Input()));
            if (cuj > 0) return true;

            return false;
        }

        /// <summary>
        /// Send Mouse Left/Right Inputs
        /// </summary>
        /// <param name="mouseClick"></param>
        /// <returns></returns>
        public static bool SendMouseClick(Input.MouseEvent mouseClick)
        {
            if (mouseClick == Input.MouseEvent.MOVE)
            {
                return false;
            }

            WinAPI.Input[] sInputs;
            sInputs = new WinAPI.Input[1];

            sInputs[0].type = (int)Input.InputType.MOUSE;
            sInputs[0].mi.dx = 0;
            sInputs[0].mi.dy = 0;
            switch (mouseClick)
            {
                case Input.MouseEvent.LEFTDOWN:
                    sInputs[0].mi.dwFlags = (uint)Input.MouseEvent.LEFTDOWN;
                    break;
                case Input.MouseEvent.LEFTUP:
                    sInputs[0].mi.dwFlags = (uint)Input.MouseEvent.LEFTUP;
                    break;
                case Input.MouseEvent.RIGHTDOWN:
                    sInputs[0].mi.dwFlags = (uint)Input.MouseEvent.RIGHTDOWN;
                    break;
                case Input.MouseEvent.RIGHTUP:
                    sInputs[0].mi.dwFlags = (uint)Input.MouseEvent.RIGHTUP;
                    break;
            }
            sInputs[0].mi.dwExtraInfo = WinAPI.GetMessageExtraInfo();
            int cuj = WinAPI.SendInput((short)sInputs.Length, sInputs, Marshal.SizeOf(new WinAPI.Input()));
            if (cuj > 0) return true;

            return false;
        }

        public static bool SendKeyboardInput(IntPtr winHandler,Input.Key key, Input.PressType pressType)
        {
            WinAPI.PostMessageA(winHandler, (uint)pressType, (int)key, 0);
            return false;
        }

        public static bool SendKeyboardInput(IntPtr winHandler, int key, Input.PressType pressType)
        {
            WinAPI.PostMessageA(winHandler, (uint)pressType, key, 0);
            return false;
        }
    }
}
