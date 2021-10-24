using System.Collections.Generic;

namespace GordoTAS
{
    /// <summary>
    /// Each frame has a list, Input List holds the Inputs List and the Frame.
    /// </summary>
    class InputList
    {
        public InputList(int frame)
        {
            Frame = frame;
        }
        public int Frame;
        public List<Input.InputStruct> inputStructList;
    }
}
