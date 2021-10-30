using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace GordoTAS
{
    class FileControl
    {
        public List<SaveData> saveInputList;
        private static string SAVEPATH = "Saves/";
        public FileControl()
        {
            saveInputList = new List<SaveData>();
        }

        public void AddInputToList(InputList inputList)
        {
            foreach (Input.InputStruct i in inputList.inputStructList)
            {
                if (inputList.inputStructList.Count() > 0)
                {
                    saveInputList.Add(new SaveData()
                    {
                        frame = inputList.Frame,
                        inputType = (int)i.inputType,
                        pressType = (int)i.pressType,
                        key = i.key,
                        mouseEvent = (int)i.mouseEvent,
                        mouseMovX = (int)i.mouseMovX,
                        mouseMovY = (int)i.mouseMovY

                    });
                }
            }
        }

        public void SaveInputDataTo(string fileName)
        {
            Console.WriteLine("[FileControl] Saving data to File: " + fileName);
            if (!Directory.Exists(SAVEPATH))
            {
                Directory.CreateDirectory(SAVEPATH);
            }

            if (!File.Exists(SAVEPATH + fileName))
            {
                File.Create(SAVEPATH + fileName).Close();
            }
            File.WriteAllText(SAVEPATH + fileName, JsonSerializer.Serialize(saveInputList.OrderBy(x => x.frame)));
            Console.WriteLine("[FileControl] Done!");
        }

        public bool LoadInputDataFrom(string fileName)
        {
            Console.WriteLine("[FileControl] Reading data from: " + fileName);

            if (!Directory.Exists(SAVEPATH))
            {
                return false;
            }

            if (!File.Exists(SAVEPATH + fileName))
            {
                return false;
            }

            var data = File.ReadAllText(SAVEPATH + fileName);
            saveInputList.Clear();
            saveInputList = JsonSerializer.Deserialize<List<SaveData>>(data);
            foreach (SaveData i in saveInputList)
            {
                AddDataToInputList(i);
            }

            Console.WriteLine("[FileControl] Done!");
            return true;

        }

        private void AddDataToInputList(SaveData data)
        {
            InputStorage.ins.AddInputToFrame(new Input.InputStruct()
            {
                inputType = (Input.InputType)data.inputType,
                //keyboard
                key = data.key,
                pressType = (Input.PressType)data.pressType,
                //mouse
                mouseEvent = (Input.MouseEvent)data.mouseEvent,
                mouseMovX = data.mouseMovX,
                mouseMovY = data.mouseMovY

            }, data.frame);
        }
    }

    public class SaveData
    {
        public int frame { get; set; }
        public int inputType { get; set; }
        //keyboard
        public int pressType { get; set; }
        public int key { get; set; }
        //Mouse
        public int mouseEvent { get; set; }
        public int mouseMovX { get; set; }
        public int mouseMovY { get; set; }
    }

}
