using System;

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
                    switch (i.inputType)
                    {
                        case Input.InputType.KEYBOARD:
                            InputSender.SendKeyboardInput(GlobalVars.ins.gameHandler, i.key, i.pressType);
                            break;
                        case Input.InputType.MOUSE:
                            switch (i.mouseEvent)
                            {
                                case Input.MouseEvent.MOVE:
                                    InputSender.SendMoveMouse(i.mouseMovX,i.mouseMovY);
                                    break;
                                case Input.MouseEvent.RIGHTDOWN:
                                case Input.MouseEvent.RIGHTUP:
                                case Input.MouseEvent.LEFTDOWN:
                                case Input.MouseEvent.LEFTUP:
                                    InputSender.SendMouseClick(i.mouseEvent); 
                                    break;
                            }
                            break;
                    }
                }
            }
        }
    }
}
