using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GordoTAS
{
    /// <summary>
    /// Holds the Vars that need to be read in a lot of places.
    /// </summary>
    class GlobalVars
    {
        public static GlobalVars ins;
        public GlobalVars()
        {
            ins = this;
            FPSSync.ins.FrameTick += AddFrame;
        }

        public void AddFrame()
        {
            currentFrame += 1;
        }

        public int currentFrame = 0;
        public int fpsLimit = 0;
        public IntPtr gameHandler;
    }
}
