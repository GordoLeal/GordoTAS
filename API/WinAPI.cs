using System;
using System.Runtime.InteropServices;

namespace GordoTAS
{
    class WinAPI
    {
        //Estrutura de input
        [StructLayout(LayoutKind.Sequential)]
        public struct HardwareInput //estrutura de input de hardware comum
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        };
        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardInput //estrutura de input de teclado
        {
            public short wVK;
            public short wScan;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        };
        [StructLayout(LayoutKind.Sequential)]
        public struct MouseInput // estrutura de input de mouse
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct Input
        {
            [FieldOffset(0)]
            public int type;
            [FieldOffset(8)] //se o programa for funcionar em hospedeiros x32 é recomendado o FieldOffset ser 4, em caso de x64 colocar 8
            public MouseInput mi;
            [FieldOffset(8)]//se o programa for funcionar em hospedeiros x32 é recomendado o FieldOffset ser 4, em caso de x64 colocar 8
            public KeyboardInput ki;
            [FieldOffset(8)]//se o programa for funcionar em hospedeiros x32 é recomendado o FieldOffset ser 4, em caso de x64 colocar 8
            public HardwareInput hi;
        };

        [DllImport("USER32.DLL", SetLastError = true)] //Função responsavel por mandar os inputs
        public static extern int SendInput(short cInputs, Input[] inputs, int cbSize); //inputs amount, inputs array, inputs in byte size. Marshal.SizeOf(typeof(Inputs))

     /*   [DllImport("user32.dll", CharSet = CharSet.Unicode)] //pegar um caractere Virtual (https://docs.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes) e transformar em ScanKey
        static extern short VkKeyScanExA(char ch, IntPtr dwhkl); */

        [DllImport("user32.dll", CharSet= CharSet.Unicode)]
        public static extern short VkKeyScanA( char ch );

        [DllImport("user32.dll")] //adaptar o ScanKey em char aceitavel pelo windows hospedeiro do programa
        static extern short MapVirtualKeyExA(int uCode, int uMapType, IntPtr dwhkl);

        [DllImport("user32.dll")] //necessario pegar o layout do primeiro teclado que estiver na maquina.
        static extern IntPtr GetKeyboardLayout(ushort idThread);
        [DllImport("user32.dll")] //só por ter mesmo, não sei o que faz. O documento pede para ter.
        public static extern IntPtr GetMessageExtraInfo();

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern bool PostMessageA(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

       /*
        public const int INPUTMOUSE = 0;
        public const int INPUT_KEYBOARD = 1;

        public const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        public const int KEYEVENTF_KEYUP = 0x0002;
        public const int KEYEVENTF_UNICODE = 0X0004;
        public const int KEYEVENTF_SCANCODE = 0x0008;
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;

        const int MAPVK_VK_TO_VSC = 0; //virtual key code -> Virtual Scan Code (https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-mapvirtualkeyexa)
        */
    }
}
