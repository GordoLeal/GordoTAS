using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GordoTAS
{
    /// <summary>
    /// Responsible for creating the main loop for the program and sync the fps with the game
    /// </summary>
    class FPSSync
    {
        public static FPSSync ins;
        public  event Action FrameTick;
        private bool KeepLoop;
        private bool running;
        public FPSSync()
        {
            ins = this;
        }

        public void CallFramePast()
        {
            FrameTick?.Invoke();
        }

        public void StartLoop()
        {
            KeepLoop = true;
            running = true;
        }

        public void Loop()
        {
            while (KeepLoop)
            {
                CallFramePast();
                Console.WriteLine("Frame: " + GlobalVars.ins.currentFrame);
                Thread.Sleep(1000 / GlobalVars.ins.fpsLimit);
            }
        }

        public void StopLoop()
        {
            KeepLoop = false;
            running = false;
            GlobalVars.ins.currentFrame = 0;
        }

        public bool IsRunning()
        {
            return running;
        }
    }
}
