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
        private int currentSelectedFrame;

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
            InputBackgroundWorker.DoWork += InputBackgroundWorker_DoWork;
            UpdateInputList();
        }

        private void FrameCheckBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            FPSSync.ins.Loop();
        }

        private void StartLoop_Click(object sender, EventArgs e)
        {
            GlobalVars.ins.gameHandler = WindowLogic.GetWindowHandlerByName("Sponge");
            Console.WriteLine("[Debug]Game Handler Ponter: " + GlobalVars.ins.gameHandler);
            if (GlobalVars.ins.gameHandler == IntPtr.Zero)
            {
                Console.WriteLine("[ERROR] Game not found! is the game open? ");
                return;
            }
            StartLoop.Enabled = false;
            GlobalVars.ins.currentFrame = 0;
            GlobalVars.ins.fpsLimit = (int)FPSAim.Value;
            FPSSync.ins.StartLoop();
            WinAPI.SetForegroundWindow(GlobalVars.ins.gameHandler);
            FrameCheckBackgroundWorker.RunWorkerAsync();
            InputBackgroundWorker.RunWorkerAsync();
        }

        private void StopLoop_Click(object sender, EventArgs e)
        {
            FPSSync.ins.StopLoop();
            FrameCheckBackgroundWorker.CancelAsync();
            InputBackgroundWorker.CancelAsync();
            StartLoop.Enabled = true;
        }

        private void InputType_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (InputType_ComboBox.Text)
            {
                case "KEYBOARD":
                    PressType_ComboBox.Visible = true;
                    label_PressType.Visible = true;

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
                    PressType_ComboBox.Visible = false;
                    label_PressType.Visible = false;

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

                    }, currentSelectedFrame);
                    break;

                case Input.InputType.MOUSE:
                    switch (keySlct)
                    {
                        case "MOVE":
                            InputStorage.ins.AddInputToFrame(new Input.InputStruct()
                            {
                                inputType = Input.InputType.MOUSE,
                                mouseEvent = Input.MouseEvent.MOVE,
                                mouseMovX = (int)number_PosX.Value,
                                mouseMovY = (int)number_PosY.Value
                                
                            }, currentSelectedFrame) ;
                            break;

                        case "LEFTDOWN":
                            InputStorage.ins.AddInputToFrame(new Input.InputStruct() 
                            {
                                inputType = Input.InputType.MOUSE,
                                mouseEvent = Input.MouseEvent.LEFTDOWN
                            },currentSelectedFrame);
                            break;
                        case "LEFTUP":
                            InputStorage.ins.AddInputToFrame(new Input.InputStruct()
                            {
                                inputType = Input.InputType.MOUSE,
                                mouseEvent = Input.MouseEvent.LEFTUP
                            }, currentSelectedFrame);
                            break;
                        case "RIGHTDOWN":
                            InputStorage.ins.AddInputToFrame(new Input.InputStruct()
                            {
                                inputType = Input.InputType.MOUSE,
                                mouseEvent = Input.MouseEvent.RIGHTDOWN
                            }, currentSelectedFrame);
                            break;
                        case "RIGHTUP":
                            InputStorage.ins.AddInputToFrame(new Input.InputStruct()
                            {
                                inputType = Input.InputType.MOUSE,
                                mouseEvent = Input.MouseEvent.RIGHTUP
                            }, currentSelectedFrame);
                            break;
                    }
                    break;
            }

            UpdateInputList();
        }

        public void UpdateInputList()
        {
            InputVisualList.Items.Clear();
            var inputStruckList = InputStorage.ins.GetStructListFromFrame(currentSelectedFrame);
            if (inputStruckList != null)
            {
                foreach (Input.InputStruct i in inputStruckList)
                {
                    InputVisualList.Items.Add(i);
                    InputVisualList.SelectedIndex = 0;
                }
            }

            TimeLineBar.Maximum = InputStorage.ins.Count();
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
            RemoveButton.Enabled = true;
        }

        private void FrameSelection_ValueChanged(object sender, EventArgs e)
        {
            currentSelectedFrame = (int)FrameSelection.Value;
            UpdateInputList();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            InputStorage.ins.RemoveInputFromFrame(selectedInputStruct, currentSelectedFrame);
            UpdateInputList();
        }

        private void InputBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           /* var texta = ("Current Frame: " + GlobalVars.ins.currentFrame);
            currentFrame_Label.Text = texta;
            Console.WriteLine(texta);*/
        }

        private void button1_Click(object sender, EventArgs e) //DEV_TEST
        {
            Console.WriteLine("DEV_TEST_START!");
            WinAPI.SetForegroundWindow(GlobalVars.ins.gameHandler);
            Thread.Sleep(1000);
            var teestebool =  InputSender.SendMoveMouse(-1000,-1000);
            Console.WriteLine(teestebool);
            Console.WriteLine("DEV_TEST_END!");
        }
  
        private void currentFrame_Label_Click(object sender, EventArgs e)
        {

        }

        private void TimeLineBar_Scroll(object sender, EventArgs e)
        {
        }

        private void Key_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Key_ComboBox.Text)
            {
                case "MOVE":
                    label_Pos_X.Visible = true;
                    label_Pos_Y.Visible = true;
                    number_PosX.Visible = true;
                    number_PosY.Visible = true;
                    break;
                default:
                    label_Pos_X.Visible = false;
                    label_Pos_Y.Visible = false;
                    number_PosX.Visible = false;
                    number_PosY.Visible = false;
                    return;
            }
        }
    }
}
