
namespace GordoTAS
{
    class InputProcessing
    {
        public static InputProcessing ins;

        public InputProcessing()
        {
            ins = this;
            FPSSync.ins.FrameTick += ins.Processor;
        }

        /// <summary>
        /// Look for inputs in that frame and execute them
        /// </summary>
        public void Processor()
        {

            if (InputStorage.ins.ExistInputListFromFrame(GlobalVars.ins.currentFrame))
            {
                foreach (Input.InputStruct i in InputStorage.ins.GetStructListFromFrame(GlobalVars.ins.currentFrame))
                {
                    InputSender.SendKeyboardInput(GlobalVars.ins.gameHandler, i.key, i.pressType);
                }
            }
        }
    }
}
