namespace BotBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblProxy = new System.Windows.Forms.Label();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.txtProfile = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblInjectStatus = new System.Windows.Forms.Label();
            this.lblDriverState = new System.Windows.Forms.Label();
            this.lblTemporaryPath = new System.Windows.Forms.Label();
            this.lblInjectPath = new System.Windows.Forms.Label();
            this.gBoxCDriver = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.chBoxHeadless = new System.Windows.Forms.CheckBox();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.gBoxCDriver.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.Location = new System.Drawing.Point(13, 68);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(33, 13);
            this.lblProxy.TabIndex = 0;
            this.lblProxy.Text = "Proxy";
            // 
            // txtProxy
            // 
            this.txtProxy.Location = new System.Drawing.Point(52, 65);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(140, 20);
            this.txtProxy.TabIndex = 1;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(208, 68);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(36, 13);
            this.lblProfile.TabIndex = 2;
            this.lblProfile.Text = "Profile";
            // 
            // txtProfile
            // 
            this.txtProfile.Location = new System.Drawing.Point(250, 65);
            this.txtProfile.Name = "txtProfile";
            this.txtProfile.Size = new System.Drawing.Size(140, 20);
            this.txtProfile.TabIndex = 3;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(13, 101);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(20, 13);
            this.lblUrl.TabIndex = 4;
            this.lblUrl.Text = "Url";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(52, 98);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(736, 20);
            this.txtUrl.TabIndex = 5;
            // 
            // lblInjectStatus
            // 
            this.lblInjectStatus.AutoSize = true;
            this.lblInjectStatus.Location = new System.Drawing.Point(493, 21);
            this.lblInjectStatus.Name = "lblInjectStatus";
            this.lblInjectStatus.Size = new System.Drawing.Size(81, 13);
            this.lblInjectStatus.TabIndex = 6;
            this.lblInjectStatus.Text = "Injection status:";
            // 
            // lblDriverState
            // 
            this.lblDriverState.AutoSize = true;
            this.lblDriverState.Location = new System.Drawing.Point(575, 21);
            this.lblDriverState.Name = "lblDriverState";
            this.lblDriverState.Size = new System.Drawing.Size(32, 13);
            this.lblDriverState.TabIndex = 7;
            this.lblDriverState.Text = "State";
            // 
            // lblTemporaryPath
            // 
            this.lblTemporaryPath.AutoSize = true;
            this.lblTemporaryPath.Location = new System.Drawing.Point(82, 21);
            this.lblTemporaryPath.Name = "lblTemporaryPath";
            this.lblTemporaryPath.Size = new System.Drawing.Size(29, 13);
            this.lblTemporaryPath.TabIndex = 9;
            this.lblTemporaryPath.Text = "Path";
            // 
            // lblInjectPath
            // 
            this.lblInjectPath.AutoSize = true;
            this.lblInjectPath.Location = new System.Drawing.Point(6, 21);
            this.lblInjectPath.Name = "lblInjectPath";
            this.lblInjectPath.Size = new System.Drawing.Size(75, 13);
            this.lblInjectPath.TabIndex = 8;
            this.lblInjectPath.Text = "Injection Path:";
            // 
            // gBoxCDriver
            // 
            this.gBoxCDriver.Controls.Add(this.lblInjectPath);
            this.gBoxCDriver.Controls.Add(this.lblTemporaryPath);
            this.gBoxCDriver.Controls.Add(this.lblInjectStatus);
            this.gBoxCDriver.Controls.Add(this.lblDriverState);
            this.gBoxCDriver.Location = new System.Drawing.Point(16, 10);
            this.gBoxCDriver.Name = "gBoxCDriver";
            this.gBoxCDriver.Size = new System.Drawing.Size(772, 49);
            this.gBoxCDriver.TabIndex = 10;
            this.gBoxCDriver.TabStop = false;
            this.gBoxCDriver.Text = "ChromeDriver";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(713, 124);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chBoxHeadless
            // 
            this.chBoxHeadless.AutoSize = true;
            this.chBoxHeadless.Location = new System.Drawing.Point(426, 68);
            this.chBoxHeadless.Name = "chBoxHeadless";
            this.chBoxHeadless.Size = new System.Drawing.Size(70, 17);
            this.chBoxHeadless.TabIndex = 12;
            this.chBoxHeadless.Text = "Headless";
            this.chBoxHeadless.UseVisualStyleBackColor = true;
            this.chBoxHeadless.CheckedChanged += new System.EventHandler(this.chBoxHeadless_CheckedChanged);
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(713, 62);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(75, 23);
            this.btnScreenshot.TabIndex = 13;
            this.btnScreenshot.Text = "Screenshot";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 155);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.chBoxHeadless);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gBoxCDriver);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtProfile);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.txtProxy);
            this.Controls.Add(this.lblProxy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BotBrowser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxCDriver.ResumeLayout(false);
            this.gBoxCDriver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProxy;
        public System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.Label lblProfile;
        public System.Windows.Forms.TextBox txtProfile;
        private System.Windows.Forms.Label lblUrl;
        public System.Windows.Forms.TextBox txtUrl;
        public System.Windows.Forms.Label lblInjectStatus;
        public System.Windows.Forms.Label lblDriverState;
        public System.Windows.Forms.Label lblTemporaryPath;
        public System.Windows.Forms.Label lblInjectPath;
        public System.Windows.Forms.GroupBox gBoxCDriver;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.CheckBox chBoxHeadless;
        public System.Windows.Forms.Button btnScreenshot;
    }
}

