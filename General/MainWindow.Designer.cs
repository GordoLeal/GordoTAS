
namespace GordoTAS
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.FrameCheckBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.StartLoop = new System.Windows.Forms.Button();
            this.StopLoop = new System.Windows.Forms.Button();
            this.FrameSelection = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AddInputButton = new System.Windows.Forms.Button();
            this.Key_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputType_ComboBox = new System.Windows.Forms.ComboBox();
            this.PressType_ComboBox = new System.Windows.Forms.ComboBox();
            this.label_PressType = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.InputVisualList = new System.Windows.Forms.ListBox();
            this.InputListLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.number_PosY = new System.Windows.Forms.NumericUpDown();
            this.label_Pos_Y = new System.Windows.Forms.Label();
            this.number_PosX = new System.Windows.Forms.NumericUpDown();
            this.label_Pos_X = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FPSAim = new System.Windows.Forms.NumericUpDown();
            this.InputBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.DEV_TEST = new System.Windows.Forms.Button();
            this.button_AddFrame = new System.Windows.Forms.Button();
            this.number_FrameAdd = new System.Windows.Forms.NumericUpDown();
            this.button_SubFrame = new System.Windows.Forms.Button();
            this.button_SaveData = new System.Windows.Forms.Button();
            this.button_LoadData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.number_SaveSlot = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FrameSelection)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_PosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_PosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSAim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_FrameAdd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_SaveSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // FrameCheckBackgroundWorker
            // 
            this.FrameCheckBackgroundWorker.WorkerSupportsCancellation = true;
            this.FrameCheckBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.FrameCheckBackgroundWorker_DoWork);
            // 
            // StartLoop
            // 
            this.StartLoop.Location = new System.Drawing.Point(268, 315);
            this.StartLoop.Name = "StartLoop";
            this.StartLoop.Size = new System.Drawing.Size(75, 23);
            this.StartLoop.TabIndex = 3;
            this.StartLoop.Text = "Play";
            this.StartLoop.UseVisualStyleBackColor = true;
            this.StartLoop.Click += new System.EventHandler(this.StartLoop_Click);
            // 
            // StopLoop
            // 
            this.StopLoop.Location = new System.Drawing.Point(349, 315);
            this.StopLoop.Name = "StopLoop";
            this.StopLoop.Size = new System.Drawing.Size(75, 23);
            this.StopLoop.TabIndex = 4;
            this.StopLoop.Text = "Stop";
            this.StopLoop.UseVisualStyleBackColor = true;
            this.StopLoop.Click += new System.EventHandler(this.StopLoop_Click);
            // 
            // FrameSelection
            // 
            this.FrameSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FrameSelection.Location = new System.Drawing.Point(511, 202);
            this.FrameSelection.Maximum = new decimal(new int[] {
            -1474836480,
            4,
            0,
            0});
            this.FrameSelection.Name = "FrameSelection";
            this.FrameSelection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FrameSelection.Size = new System.Drawing.Size(120, 20);
            this.FrameSelection.TabIndex = 5;
            this.FrameSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FrameSelection.ValueChanged += new System.EventHandler(this.FrameSelection_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frame:";
            // 
            // AddInputButton
            // 
            this.AddInputButton.Location = new System.Drawing.Point(239, 173);
            this.AddInputButton.Name = "AddInputButton";
            this.AddInputButton.Size = new System.Drawing.Size(75, 23);
            this.AddInputButton.TabIndex = 7;
            this.AddInputButton.Text = "Add Input";
            this.AddInputButton.UseVisualStyleBackColor = true;
            this.AddInputButton.Click += new System.EventHandler(this.AddInputButton_Click);
            // 
            // Key_ComboBox
            // 
            this.Key_ComboBox.FormattingEnabled = true;
            this.Key_ComboBox.Location = new System.Drawing.Point(34, 88);
            this.Key_ComboBox.Name = "Key_ComboBox";
            this.Key_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Key_ComboBox.TabIndex = 8;
            this.Key_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Key_ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input Type";
            // 
            // InputType_ComboBox
            // 
            this.InputType_ComboBox.FormattingEnabled = true;
            this.InputType_ComboBox.Location = new System.Drawing.Point(34, 40);
            this.InputType_ComboBox.Name = "InputType_ComboBox";
            this.InputType_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.InputType_ComboBox.TabIndex = 11;
            this.InputType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.InputType_ComboBox_SelectedIndexChanged);
            // 
            // PressType_ComboBox
            // 
            this.PressType_ComboBox.FormattingEnabled = true;
            this.PressType_ComboBox.Location = new System.Drawing.Point(32, 138);
            this.PressType_ComboBox.Name = "PressType_ComboBox";
            this.PressType_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.PressType_ComboBox.TabIndex = 12;
            // 
            // label_PressType
            // 
            this.label_PressType.AutoSize = true;
            this.label_PressType.Location = new System.Drawing.Point(29, 122);
            this.label_PressType.Name = "label_PressType";
            this.label_PressType.Size = new System.Drawing.Size(60, 13);
            this.label_PressType.TabIndex = 13;
            this.label_PressType.Text = "Press Type";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(380, 199);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 15;
            this.RemoveButton.Text = "Delete input";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // InputVisualList
            // 
            this.InputVisualList.FormattingEnabled = true;
            this.InputVisualList.Location = new System.Drawing.Point(356, 33);
            this.InputVisualList.Name = "InputVisualList";
            this.InputVisualList.Size = new System.Drawing.Size(422, 160);
            this.InputVisualList.TabIndex = 16;
            this.InputVisualList.SelectedIndexChanged += new System.EventHandler(this.InputVisualList_SelectedIndexChanged);
            // 
            // InputListLabel
            // 
            this.InputListLabel.AutoSize = true;
            this.InputListLabel.Location = new System.Drawing.Point(541, 17);
            this.InputListLabel.Name = "InputListLabel";
            this.InputListLabel.Size = new System.Drawing.Size(50, 13);
            this.InputListLabel.TabIndex = 17;
            this.InputListLabel.Text = "Input List";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.number_PosY);
            this.groupBox1.Controls.Add(this.label_Pos_Y);
            this.groupBox1.Controls.Add(this.number_PosX);
            this.groupBox1.Controls.Add(this.label_Pos_X);
            this.groupBox1.Controls.Add(this.AddInputButton);
            this.groupBox1.Controls.Add(this.Key_ComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.InputType_ComboBox);
            this.groupBox1.Controls.Add(this.label_PressType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PressType_ComboBox);
            this.groupBox1.Location = new System.Drawing.Point(18, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 214);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input options";
            // 
            // number_PosY
            // 
            this.number_PosY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.number_PosY.Location = new System.Drawing.Point(176, 138);
            this.number_PosY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_PosY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.number_PosY.Name = "number_PosY";
            this.number_PosY.Size = new System.Drawing.Size(120, 20);
            this.number_PosY.TabIndex = 17;
            // 
            // label_Pos_Y
            // 
            this.label_Pos_Y.AutoSize = true;
            this.label_Pos_Y.Location = new System.Drawing.Point(176, 122);
            this.label_Pos_Y.Name = "label_Pos_Y";
            this.label_Pos_Y.Size = new System.Drawing.Size(75, 13);
            this.label_Pos_Y.TabIndex = 16;
            this.label_Pos_Y.Text = "- Down / + Up";
            // 
            // number_PosX
            // 
            this.number_PosX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.number_PosX.Location = new System.Drawing.Point(176, 89);
            this.number_PosX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.number_PosX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.number_PosX.Name = "number_PosX";
            this.number_PosX.Size = new System.Drawing.Size(120, 20);
            this.number_PosX.TabIndex = 15;
            this.number_PosX.Visible = false;
            // 
            // label_Pos_X
            // 
            this.label_Pos_X.AutoSize = true;
            this.label_Pos_X.Location = new System.Drawing.Point(173, 72);
            this.label_Pos_X.Name = "label_Pos_X";
            this.label_Pos_X.Size = new System.Drawing.Size(76, 13);
            this.label_Pos_X.TabIndex = 14;
            this.label_Pos_X.Text = "- Left / + Right";
            this.label_Pos_X.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "FPS:";
            // 
            // FPSAim
            // 
            this.FPSAim.Location = new System.Drawing.Point(702, 202);
            this.FPSAim.Maximum = new decimal(new int[] {
            144,
            0,
            0,
            0});
            this.FPSAim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FPSAim.Name = "FPSAim";
            this.FPSAim.Size = new System.Drawing.Size(49, 20);
            this.FPSAim.TabIndex = 21;
            this.FPSAim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FPSAim.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.FPSAim.ValueChanged += new System.EventHandler(this.FPSAim_ValueChanged);
            // 
            // InputBackgroundWorker
            // 
            this.InputBackgroundWorker.WorkerReportsProgress = true;
            this.InputBackgroundWorker.WorkerSupportsCancellation = true;
            this.InputBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.InputBackgroundWorker_DoWork);
            // 
            // DEV_TEST
            // 
            this.DEV_TEST.Location = new System.Drawing.Point(430, 315);
            this.DEV_TEST.Name = "DEV_TEST";
            this.DEV_TEST.Size = new System.Drawing.Size(75, 23);
            this.DEV_TEST.TabIndex = 24;
            this.DEV_TEST.Text = "DEV_TEST";
            this.DEV_TEST.UseVisualStyleBackColor = true;
            this.DEV_TEST.Visible = false;
            this.DEV_TEST.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_AddFrame
            // 
            this.button_AddFrame.Location = new System.Drawing.Point(596, 228);
            this.button_AddFrame.Name = "button_AddFrame";
            this.button_AddFrame.Size = new System.Drawing.Size(35, 23);
            this.button_AddFrame.TabIndex = 25;
            this.button_AddFrame.Text = "+";
            this.button_AddFrame.UseVisualStyleBackColor = true;
            this.button_AddFrame.Click += new System.EventHandler(this.button_AddFrame_Click);
            // 
            // number_FrameAdd
            // 
            this.number_FrameAdd.Location = new System.Drawing.Point(548, 230);
            this.number_FrameAdd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.number_FrameAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number_FrameAdd.Name = "number_FrameAdd";
            this.number_FrameAdd.Size = new System.Drawing.Size(45, 20);
            this.number_FrameAdd.TabIndex = 27;
            this.number_FrameAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_SubFrame
            // 
            this.button_SubFrame.Location = new System.Drawing.Point(511, 228);
            this.button_SubFrame.Name = "button_SubFrame";
            this.button_SubFrame.Size = new System.Drawing.Size(35, 23);
            this.button_SubFrame.TabIndex = 28;
            this.button_SubFrame.Text = "-";
            this.button_SubFrame.UseVisualStyleBackColor = true;
            this.button_SubFrame.Click += new System.EventHandler(this.button_SubFrame_Click);
            // 
            // button_SaveData
            // 
            this.button_SaveData.Location = new System.Drawing.Point(6, 19);
            this.button_SaveData.Name = "button_SaveData";
            this.button_SaveData.Size = new System.Drawing.Size(75, 23);
            this.button_SaveData.TabIndex = 29;
            this.button_SaveData.Text = "Save";
            this.button_SaveData.UseVisualStyleBackColor = true;
            this.button_SaveData.Click += new System.EventHandler(this.button_SaveData_Click);
            // 
            // button_LoadData
            // 
            this.button_LoadData.Location = new System.Drawing.Point(87, 19);
            this.button_LoadData.Name = "button_LoadData";
            this.button_LoadData.Size = new System.Drawing.Size(75, 23);
            this.button_LoadData.TabIndex = 30;
            this.button_LoadData.Text = "Load";
            this.button_LoadData.UseVisualStyleBackColor = true;
            this.button_LoadData.Click += new System.EventHandler(this.button_LoadData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.number_SaveSlot);
            this.groupBox2.Controls.Add(this.button_LoadData);
            this.groupBox2.Controls.Add(this.button_SaveData);
            this.groupBox2.Location = new System.Drawing.Point(18, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 51);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save/Load";
            // 
            // number_SaveSlot
            // 
            this.number_SaveSlot.Location = new System.Drawing.Point(168, 22);
            this.number_SaveSlot.Name = "number_SaveSlot";
            this.number_SaveSlot.Size = new System.Drawing.Size(48, 20);
            this.number_SaveSlot.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_SubFrame);
            this.Controls.Add(this.number_FrameAdd);
            this.Controls.Add(this.button_AddFrame);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.DEV_TEST);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputListLabel);
            this.Controls.Add(this.FPSAim);
            this.Controls.Add(this.InputVisualList);
            this.Controls.Add(this.StopLoop);
            this.Controls.Add(this.StartLoop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FrameSelection);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Gordo TAS (BETA 0.1)";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FrameSelection)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_PosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_PosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSAim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_FrameAdd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.number_SaveSlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker FrameCheckBackgroundWorker;
        private System.Windows.Forms.Button StartLoop;
        private System.Windows.Forms.Button StopLoop;
        private System.Windows.Forms.NumericUpDown FrameSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddInputButton;
        private System.Windows.Forms.ComboBox Key_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox InputType_ComboBox;
        private System.Windows.Forms.ComboBox PressType_ComboBox;
        private System.Windows.Forms.Label label_PressType;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ListBox InputVisualList;
        private System.Windows.Forms.Label InputListLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker InputBackgroundWorker;
        private System.Windows.Forms.Button DEV_TEST;
        private System.Windows.Forms.Label label_Pos_X;
        private System.Windows.Forms.Label label_Pos_Y;
        private System.Windows.Forms.NumericUpDown number_PosX;
        private System.Windows.Forms.NumericUpDown FPSAim;
        private System.Windows.Forms.NumericUpDown number_PosY;
        private System.Windows.Forms.Button button_AddFrame;
        private System.Windows.Forms.NumericUpDown number_FrameAdd;
        private System.Windows.Forms.Button button_SubFrame;
        private System.Windows.Forms.Button button_SaveData;
        private System.Windows.Forms.Button button_LoadData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown number_SaveSlot;
    }
}