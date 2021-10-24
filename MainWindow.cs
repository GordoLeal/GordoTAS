using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace GordoTAS
{
    public partial class MainWindow : Form
    {
        public static MainWindow main;
        private Input.InputStruct selectedInputStruct;

        Input.InputType inpTypeEnumSlc;
        //keyboard Selection
        Input.Key keyEnumSLC;
        Input.PressType inpPressEnumSlc;

        public MainWindow()
        {
            main = this;
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            FPSSync.ins.FrameTick += UpdateCurrentFrame;
            GlobalVars.ins.gameHandler = WindowLogic.GetWindowHandlerByName("Sponge");


            foreach (String i in Enum.GetNames(typeof(Input.Key)))
            {
                Key_ComboBox.Items.Add(i);
            }
            Key_ComboBox.SelectedItem = Key_ComboBox.Items[0];

            foreach (String i in Enum.GetNames(typeof(Input.InputType)))
            {
                InputType_ComboBox.Items.Add(i);
            }
            InputType_ComboBox.SelectedItem = InputType_ComboBox.Items[1];

            PressType_ComboBox.Items.Clear();
            foreach (String i in Enum.GetNames(typeof(Input.PressType)))
            {
                PressType_ComboBox.Items.Add(i);
            }

            PressType_ComboBox.SelectedItem = PressType_ComboBox.Items[0];
            FrameSelection.Maximum = uint.MaxValue;
            FrameCheckBackgroundWorker.DoWork += FrameCheckBackgroundWorker_DoWork;
            //InputBackgroundWorker.DoWork += InputBackgroundWorker_DoWork;
            UpdateInputList();
        }

        public void UpdateCurrentFrame()
        {

        }

        private void FrameCheckBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FPSSync.ins.Loop();
        }

        private void StartLoop_Click(object sender, EventArgs e)
        {
            FPSSync.ins.StartLoop();
            GlobalVars.ins.gameHandler = WindowLogic.GetWindowHandlerByName("Sponge");
            WinAPI.SetForegroundWindow(GlobalVars.ins.gameHandler);
            FrameCheckBackgroundWorker.RunWorkerAsync();
            //InputBackgroundWorker.RunWorkerAsync();
        }

        private void StopLoop_Click(object sender, EventArgs e)
        {
            FPSSync.ins.StopLoop();
            FrameCheckBackgroundWorker.CancelAsync();
            //InputBackgroundWorker.CancelAsync();
        }

        private void InputType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (InputType_ComboBox.Text)
            {
                case "KEYBOARD":
                    PressType_ComboBox.Enabled = true;

                    Key_ComboBox.Items.Clear();
                    foreach (string i in Enum.GetNames(typeof(Input.Key)))
                    {
                        Key_ComboBox.Items.Add(i);
                    }
                    Key_ComboBox.SelectedItem = Key_ComboBox.Items[0];

                    PressType_ComboBox.Items.Clear();
                    foreach (string i in Enum.GetNames(typeof(Input.PressType)))
                    {
                        PressType_ComboBox.Items.Add(i);
                    }
                    PressType_ComboBox.SelectedItem = PressType_ComboBox.Items[0];

                    break;

                case "MOUSE":

                    Key_ComboBox.Items.Clear();
                    foreach (string i in Enum.GetNames(typeof(Input.MouseEvent)))
                    {
                        Key_ComboBox.Items.Add(i);
                    }
                    Key_ComboBox.SelectedItem = null;
                    Key_ComboBox.SelectedItem = Key_ComboBox.Items[0];
                    PressType_ComboBox.Enabled = false;

                    break;
            }
        }

        private void AddInputButton_Click(object sender, EventArgs e)
        {
            string pressTypeSlct = PressType_ComboBox.SelectedItem.ToString();
            string keySlct = Key_ComboBox.SelectedItem.ToString();
            string inputTypeSlct = InputType_ComboBox.SelectedItem.ToString();


            foreach (string i in Enum.GetNames(typeof(Input.InputType)))
            {
                if (i == inputTypeSlct)
                {
                    inpTypeEnumSlc = (Input.InputType)Enum.Parse(typeof(Input.InputType), i);
                    break;
                }
            }

            switch (inpTypeEnumSlc)
            {
                case Input.InputType.KEYBOARD:
                    foreach (string i in Enum.GetNames(typeof(Input.Key)))
                    {
                        if (i == keySlct)
                        {
                            keyEnumSLC = (Input.Key)Enum.Parse(typeof(Input.Key), i);
                            break;
                        }
                    }

                    foreach (string i in Enum.GetNames(typeof(Input.PressType)))
                    {
                        if (i == pressTypeSlct)
                        {
                            inpPressEnumSlc = (Input.PressType)Enum.Parse(typeof(Input.PressType), i);
                            break;
                        }
                    }


                    InputStorage.ins.AddInputToFrame(new Input.InputStruct()
                    {
                        key = (int)keyEnumSLC,
                        inputType = Input.InputType.KEYBOARD,
                        pressType = inpPressEnumSlc

                    }, GlobalVars.ins.currentFrame);
                    break;

                case Input.InputType.MOUSE:

                    break;
            }

            UpdateInputList();
        }

        public void UpdateInputList()
        {
            InputVisualList.Items.Clear();
            var inputStruckList = InputStorage.ins.GetStructListFromFrame(GlobalVars.ins.currentFrame);
            if (inputStruckList != null)
            {
                foreach (Input.InputStruct i in inputStruckList)
                {
                    InputVisualList.Items.Add(i);
                    InputVisualList.SelectedIndex = 0;
                }
            }
        }

        private void FPSAim_ValueChanged(object sender, EventArgs e)
        {
            GlobalVars.ins.fpsLimit = (int)FPSAim.Value;
        }

        private void InputVisualList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(InputVisualList.SelectedIndex < 0)
            {
                return;
            }
            selectedInputStruct = (Input.InputStruct)InputVisualList.SelectedItem;
        }

        private void FrameSelection_ValueChanged(object sender, EventArgs e)
        {
            GlobalVars.ins.currentFrame = (int)FrameSelection.Value;
            UpdateInputList();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            InputStorage.ins.RemoveInputFromFrame(selectedInputStruct, GlobalVars.ins.currentFrame);
            UpdateInputList();
        }

        private void InputBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void PressType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinAPI.PostMessageA(GlobalVars.ins.gameHandler, 0x0100, WinAPI.VkKeyScanA('a'), 0);
            //WinAPI.PostMessageA(GlobalVars.ins.gameHandler, 0x0101, 0x41, 0);
        }
    }
}
