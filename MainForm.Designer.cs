namespace CameraCTRL
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.label4 = new System.Windows.Forms.Label();
            this.heightText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.tb_cameraUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_compose = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.button_Right = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Up = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_ZoomOut = new System.Windows.Forms.Button();
            this.button_ZoomIn = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button_ScanStop = new System.Windows.Forms.Button();
            this.button_ScanStart = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_Duration = new System.Windows.Forms.TextBox();
            this.comboBox_Direction = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.StreamCombo = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.videoViewerWF2 = new Ozeki.Media.VideoViewerWF();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logListBox);
            this.groupBox3.Location = new System.Drawing.Point(713, 506);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 123);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Event log";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.HorizontalScrollbar = true;
            this.logListBox.Location = new System.Drawing.Point(6, 19);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(438, 95);
            this.logListBox.TabIndex = 0;
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.ForeColor = System.Drawing.Color.Transparent;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(12, 12);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(640, 480);
            this.videoViewerWF1.TabIndex = 0;
            this.videoViewerWF1.Text = "videoViewerWF1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Height";
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(761, 451);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(100, 20);
            this.heightText.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(866, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Width";
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(915, 451);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(100, 20);
            this.widthText.TabIndex = 13;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(1022, 449);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 14;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.button_Disconnect);
            this.groupBox1.Controls.Add(this.tb_cameraUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_compose);
            this.groupBox1.Location = new System.Drawing.Point(713, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 86);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PTZ Camera";
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Connect.ForeColor = System.Drawing.Color.Black;
            this.button_Connect.Location = new System.Drawing.Point(147, 43);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(80, 23);
            this.button_Connect.TabIndex = 18;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(233, 43);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_Disconnect.TabIndex = 22;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // tb_cameraUrl
            // 
            this.tb_cameraUrl.Location = new System.Drawing.Point(83, 17);
            this.tb_cameraUrl.Name = "tb_cameraUrl";
            this.tb_cameraUrl.ReadOnly = true;
            this.tb_cameraUrl.Size = new System.Drawing.Size(280, 20);
            this.tb_cameraUrl.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Camera URL:";
            // 
            // btn_compose
            // 
            this.btn_compose.Location = new System.Drawing.Point(369, 15);
            this.btn_compose.Name = "btn_compose";
            this.btn_compose.Size = new System.Drawing.Size(75, 23);
            this.btn_compose.TabIndex = 19;
            this.btn_compose.Text = "Compose";
            this.btn_compose.UseVisualStyleBackColor = true;
            this.btn_compose.Click += new System.EventHandler(this.btn_compose_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.button_Right);
            this.groupBox12.Controls.Add(this.button_Down);
            this.groupBox12.Controls.Add(this.button_Home);
            this.groupBox12.Controls.Add(this.button_Left);
            this.groupBox12.Controls.Add(this.button_Up);
            this.groupBox12.Location = new System.Drawing.Point(913, 196);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(194, 176);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Control";
            // 
            // button_Right
            // 
            this.button_Right.Location = new System.Drawing.Point(109, 71);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(45, 45);
            this.button_Right.TabIndex = 7;
            this.button_Right.Text = "Right";
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_Down
            // 
            this.button_Down.Location = new System.Drawing.Point(58, 122);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(45, 45);
            this.button_Down.TabIndex = 5;
            this.button_Down.Text = "Down";
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_Down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_Home
            // 
            this.button_Home.Location = new System.Drawing.Point(58, 71);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(45, 45);
            this.button_Home.TabIndex = 4;
            this.button_Home.Text = "Home";
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // button_Left
            // 
            this.button_Left.Location = new System.Drawing.Point(6, 71);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(45, 45);
            this.button_Left.TabIndex = 2;
            this.button_Left.Text = "Left";
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_Left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_Up
            // 
            this.button_Up.Location = new System.Drawing.Point(58, 20);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(45, 45);
            this.button_Up.TabIndex = 1;
            this.button_Up.Text = "Up";
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_Up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_ZoomOut);
            this.groupBox4.Controls.Add(this.button_ZoomIn);
            this.groupBox4.Location = new System.Drawing.Point(913, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 50);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zoom";
            // 
            // button_ZoomOut
            // 
            this.button_ZoomOut.Location = new System.Drawing.Point(109, 19);
            this.button_ZoomOut.Name = "button_ZoomOut";
            this.button_ZoomOut.Size = new System.Drawing.Size(45, 21);
            this.button_ZoomOut.TabIndex = 1;
            this.button_ZoomOut.Text = "Out";
            this.button_ZoomOut.UseVisualStyleBackColor = true;
            this.button_ZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_ZoomOut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // button_ZoomIn
            // 
            this.button_ZoomIn.Location = new System.Drawing.Point(6, 19);
            this.button_ZoomIn.Name = "button_ZoomIn";
            this.button_ZoomIn.Size = new System.Drawing.Size(45, 21);
            this.button_ZoomIn.TabIndex = 0;
            this.button_ZoomIn.Text = "In";
            this.button_ZoomIn.UseVisualStyleBackColor = true;
            this.button_ZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownMove);
            this.button_ZoomIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpMove);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button_ScanStop);
            this.groupBox11.Controls.Add(this.button_ScanStart);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.textBox_Duration);
            this.groupBox11.Controls.Add(this.comboBox_Direction);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.label17);
            this.groupBox11.Location = new System.Drawing.Point(713, 196);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(194, 176);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Scanner";
            // 
            // button_ScanStop
            // 
            this.button_ScanStop.Location = new System.Drawing.Point(104, 116);
            this.button_ScanStop.Name = "button_ScanStop";
            this.button_ScanStop.Size = new System.Drawing.Size(75, 23);
            this.button_ScanStop.TabIndex = 6;
            this.button_ScanStop.Text = "Stop";
            this.button_ScanStop.UseVisualStyleBackColor = true;
            this.button_ScanStop.Click += new System.EventHandler(this.button_ScanStop_Click);
            // 
            // button_ScanStart
            // 
            this.button_ScanStart.Location = new System.Drawing.Point(10, 116);
            this.button_ScanStart.Name = "button_ScanStart";
            this.button_ScanStart.Size = new System.Drawing.Size(75, 23);
            this.button_ScanStart.TabIndex = 5;
            this.button_ScanStart.Text = "Scan";
            this.button_ScanStart.UseVisualStyleBackColor = true;
            this.button_ScanStart.Click += new System.EventHandler(this.button_ScanStart_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "seconds";
            // 
            // textBox_Duration
            // 
            this.textBox_Duration.Location = new System.Drawing.Point(65, 63);
            this.textBox_Duration.Name = "textBox_Duration";
            this.textBox_Duration.Size = new System.Drawing.Size(26, 20);
            this.textBox_Duration.TabIndex = 3;
            // 
            // comboBox_Direction
            // 
            this.comboBox_Direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Direction.FormattingEnabled = true;
            this.comboBox_Direction.Location = new System.Drawing.Point(65, 26);
            this.comboBox_Direction.Name = "comboBox_Direction";
            this.comboBox_Direction.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Direction.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Duration:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Direction:";
            // 
            // StreamCombo
            // 
            this.StreamCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StreamCombo.FormattingEnabled = true;
            this.StreamCombo.Location = new System.Drawing.Point(6, 19);
            this.StreamCombo.Name = "StreamCombo";
            this.StreamCombo.Size = new System.Drawing.Size(180, 21);
            this.StreamCombo.TabIndex = 0;
            this.StreamCombo.SelectedIndexChanged += new System.EventHandler(this.StreamCombo_SelectedIndexChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.StreamCombo);
            this.groupBox13.Location = new System.Drawing.Point(713, 378);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(194, 50);
            this.groupBox13.TabIndex = 16;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Available";
            // 
            // videoViewerWF2
            // 
            this.videoViewerWF2.BackColor = System.Drawing.Color.Gray;
            this.videoViewerWF2.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF2.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF2.FullScreenEnabled = true;
            this.videoViewerWF2.Location = new System.Drawing.Point(472, 12);
            this.videoViewerWF2.Name = "videoViewerWF2";
            this.videoViewerWF2.RotateAngle = 0;
            this.videoViewerWF2.Size = new System.Drawing.Size(180, 135);
            this.videoViewerWF2.TabIndex = 17;
            this.videoViewerWF2.Text = "videoViewerWF2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(713, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 86);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Static Camera";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(147, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(233, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Camera URL:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Compose";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(470, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 89);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 557);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 20);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 641);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.videoViewerWF2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.videoViewerWF1);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTZ camera motion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.ListBox logListBox;
        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.TextBox tb_cameraUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_compose;

        #endregion
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button_ScanStop;
        private System.Windows.Forms.Button button_ScanStart;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_Duration;
        private System.Windows.Forms.ComboBox comboBox_Direction;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_ZoomOut;
        private System.Windows.Forms.Button button_ZoomIn;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.ComboBox StreamCombo;
        private System.Windows.Forms.GroupBox groupBox13;
        private Ozeki.Media.VideoViewerWF videoViewerWF2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

