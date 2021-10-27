using System.Collections.Generic;

namespace GordoTAS
{
    /// <summary>
    /// Holds the List of lists of inputs. confusing? but hey, it works so...
    /// </summary>
    class InputStorage
    {
        public static InputStorage ins;
        List<InputList> inputLists = new List<InputList>();

        public InputStorage()
        {
            ins = this;
        }
        public void AddInputToFrame(Input.InputStruct inputStruct, int frame)
        {

            if (ExistInputListFromFrame(frame))
            {
                GetStructListFromFrame(frame).Add(inputStruct);
            }
            else
            {
                inputLists.Add(new InputList(frame) { inputStructList = new List<Input.InputStruct>() });
                GetStructListFromFrame(frame).Add(inputStruct);
            }

        }

        public void RemoveInputFromFrame(Input.InputStruct input, int frame)
        {
            GetStructListFromFrame(frame)?.Remove(input);

        }

        public List<Input.InputStruct> GetStructListFromFrame(int frame)
        {
            if (ExistInputListFromFrame(frame))
            {
                return inputLists.Find(X => X.Frame == frame).inputStructList;
            }
            else
            {
                return null;
            }

        }
        public int Count()
        {
            return inputLists.Count;
        }
        public bool ExistInputListFromFrame(int frame)
        {
            if (inputLists.Exists(X => X.Frame == frame))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
