namespace DetekcijaUlaska
{
    partial class Form1
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
            this.startBt = new System.Windows.Forms.Button();
            this.stopBt = new System.Windows.Forms.Button();
            this.crossedText = new System.Windows.Forms.Label();
            this.videoViewerWF1 = new Ozeki.Media.VideoViewerWF();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.tb_cameraUrl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Compose = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.tripwire_groupBox = new System.Windows.Forms.GroupBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.tripwire_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startBt
            // 
            this.startBt.Location = new System.Drawing.Point(6, 16);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(75, 23);
            this.startBt.TabIndex = 2;
            this.startBt.Text = "Start";
            this.startBt.UseVisualStyleBackColor = true;
            this.startBt.Click += new System.EventHandler(this.startBt_Click);
            // 
            // stopBt
            // 
            this.stopBt.Location = new System.Drawing.Point(194, 16);
            this.stopBt.Name = "stopBt";
            this.stopBt.Size = new System.Drawing.Size(75, 23);
            this.stopBt.TabIndex = 3;
            this.stopBt.Text = "Stop";
            this.stopBt.UseVisualStyleBackColor = true;
            this.stopBt.Click += new System.EventHandler(this.stopBt_Click);
            // 
            // crossedText
            // 
            this.crossedText.AutoSize = true;
            this.crossedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.crossedText.ForeColor = System.Drawing.Color.Red;
            this.crossedText.Location = new System.Drawing.Point(114, 10);
            this.crossedText.Name = "crossedText";
            this.crossedText.Size = new System.Drawing.Size(43, 29);
            this.crossedText.TabIndex = 4;
            this.crossedText.Text = "     ";
            // 
            // videoViewerWF1
            // 
            this.videoViewerWF1.BackColor = System.Drawing.Color.Black;
            this.videoViewerWF1.FlipMode = Ozeki.Media.FlipMode.None;
            this.videoViewerWF1.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.videoViewerWF1.FullScreenEnabled = true;
            this.videoViewerWF1.Location = new System.Drawing.Point(12, 92);
            this.videoViewerWF1.Name = "videoViewerWF1";
            this.videoViewerWF1.RotateAngle = 0;
            this.videoViewerWF1.Size = new System.Drawing.Size(640, 480);
            this.videoViewerWF1.TabIndex = 1;
            this.videoViewerWF1.Text = "videoViewerWF1";
            this.videoViewerWF1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.videoViewerWF1_MouseDown);
            this.videoViewerWF1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.videoViewerWF1_MouseUp);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stateLabel);
            this.groupBox3.Controls.Add(this.button_Connect);
            this.groupBox3.Controls.Add(this.tb_cameraUrl);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button_Compose);
            this.groupBox3.Controls.Add(this.button_Disconnect);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 74);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect";
            // 
            // button_Connect
            // 
            this.button_Connect.Enabled = false;
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Connect.ForeColor = System.Drawing.Color.Black;
            this.button_Connect.Location = new System.Drawing.Point(83, 45);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(80, 23);
            this.button_Connect.TabIndex = 6;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // tb_cameraUrl
            // 
            this.tb_cameraUrl.Location = new System.Drawing.Point(83, 18);
            this.tb_cameraUrl.Name = "tb_cameraUrl";
            this.tb_cameraUrl.ReadOnly = true;
            this.tb_cameraUrl.Size = new System.Drawing.Size(188, 20);
            this.tb_cameraUrl.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Camera URL:";
            // 
            // button_Compose
            // 
            this.button_Compose.Location = new System.Drawing.Point(277, 16);
            this.button_Compose.Name = "button_Compose";
            this.button_Compose.Size = new System.Drawing.Size(75, 23);
            this.button_Compose.TabIndex = 24;
            this.button_Compose.Text = "Compose";
            this.button_Compose.UseVisualStyleBackColor = true;
            this.button_Compose.Click += new System.EventHandler(this.button_Compose_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Enabled = false;
            this.button_Disconnect.Location = new System.Drawing.Point(191, 45);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(80, 23);
            this.button_Disconnect.TabIndex = 7;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // tripwire_groupBox
            // 
            this.tripwire_groupBox.Controls.Add(this.startBt);
            this.tripwire_groupBox.Controls.Add(this.stopBt);
            this.tripwire_groupBox.Controls.Add(this.crossedText);
            this.tripwire_groupBox.Location = new System.Drawing.Point(377, 12);
            this.tripwire_groupBox.Name = "tripwire_groupBox";
            this.tripwire_groupBox.Size = new System.Drawing.Size(275, 74);
            this.tripwire_groupBox.TabIndex = 18;
            this.tripwire_groupBox.TabStop = false;
            this.tripwire_groupBox.Text = "Tripwire";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(277, 50);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 13);
            this.stateLabel.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 584);
            this.Controls.Add(this.tripwire_groupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.videoViewerWF1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tripwire";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tripwire_groupBox.ResumeLayout(false);
            this.tripwire_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Ozeki.Media.VideoViewerWF videoViewerWF1;
        private System.Windows.Forms.Button startBt;
        private System.Windows.Forms.Button stopBt;
        private System.Windows.Forms.Label crossedText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox tb_cameraUrl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Compose;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.GroupBox tripwire_groupBox;
        private System.Windows.Forms.Label stateLabel;
    }
}

