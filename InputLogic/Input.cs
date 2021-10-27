
using System;

namespace GordoTAS
{
    // TODO: add mouse inputs
    class Input
    {

        public struct InputStruct
        {
            public InputType inputType;
            //Keyboard
            public int key;
            public PressType pressType;
            //Mouse
            public MouseEvent mouseEvent;
            public int mouseMovX;
            public int mouseMovY;

            public override string ToString()
            {
                switch (inputType)
                {
                    case InputType.KEYBOARD:
                        return $"InputType: KEYBOARD , Key: {key} , Press Type: {pressType}";
                    case InputType.MOUSE:
                        switch (mouseEvent)
                        {
                            case MouseEvent.MOVE:
                                return $"InputType: MOUSE, MouseEvent: MOVE , R/L: {mouseMovX} , D/U: {mouseMovY}";
                            case MouseEvent.LEFTDOWN:
                            case MouseEvent.LEFTUP:
                            case MouseEvent.RIGHTDOWN:
                            case MouseEvent.RIGHTUP:
                                return $"InputType: MOUSE, MouseEvent: {mouseEvent}";

                        }
                        break;
                }
                return null;
            }
        }

        public enum InputType
        {
            MOUSE = 0,
            KEYBOARD = 1
        }

        public enum Key
        {
            KEY_A = 0x41,
            KEY_B = 0x42,
            KEY_C = 0x43,
            KEY_D = 0x44,
            KEY_E = 0x45,
            KEY_F = 0x46,
            KEY_G = 0x47,
            KEY_H = 0x48,
            KEY_I = 0x49,
            KEY_J = 0x4A,
            KEY_K = 0x4B,
            KEY_L = 0x4C,
            KEY_M = 0x4D,
            KEY_N = 0x4E,
            KEY_O = 0x4F,
            KEY_P = 0x50,
            KEY_Q = 0x51,
            KEY_R = 0x52,
            KEY_S = 0x53,
            KEY_T = 0x54,
            KEY_U = 0x55,
            KEY_V = 0x56,
            KEY_W = 0x57,
            KEY_X = 0x58,
            KEY_Y = 0x59,
            KEY_Z = 0x5A,
            KEY_LEFTSHIFT = 0xA0,
            KEY_SPACE = 0x20,
            KEY_ESCAPE = 0x1B

        }

        public enum PressType
        {
            KEYDOWN = 0X0100,
            KEYUP = 0X0101
        }

        public enum MouseEvent
        {
            MOVE = 0x0001,
            LEFTDOWN = 0x0002,
            LEFTUP = 0x0004,
            RIGHTDOWN = 0x0008,
            RIGHTUP = 0x0010
        }

    }
}
