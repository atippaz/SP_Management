﻿namespace SP_Management
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PanelPictrue = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.PasswordLine = new System.Windows.Forms.Label();
            this.UsernameLine = new System.Windows.Forms.Label();
            this.checkShowPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.TimerUserIn = new System.Windows.Forms.Timer(this.components);
            this.TimerUserOut = new System.Windows.Forms.Timer(this.components);
            this.TimerPassIn = new System.Windows.Forms.Timer(this.components);
            this.TimerPassOut = new System.Windows.Forms.Timer(this.components);
            this.buttonExit = new System.Windows.Forms.Button();
            this.PanelPictrue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelPictrue
            // 
            this.PanelPictrue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelPictrue.Controls.Add(this.pictureBox1);
            this.PanelPictrue.Location = new System.Drawing.Point(0, 1);
            this.PanelPictrue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPictrue.Name = "PanelPictrue";
            this.PanelPictrue.Size = new System.Drawing.Size(431, 577);
            this.PanelPictrue.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-427, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1227, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.White;
            this.PanelLogin.Controls.Add(this.PasswordLine);
            this.PanelLogin.Controls.Add(this.UsernameLine);
            this.PanelLogin.Controls.Add(this.checkShowPassword);
            this.PanelLogin.Controls.Add(this.label3);
            this.PanelLogin.Controls.Add(this.label2);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Controls.Add(this.buttonExit);
            this.PanelLogin.Controls.Add(this.button1);
            this.PanelLogin.Controls.Add(this.PasswordText);
            this.PanelLogin.Controls.Add(this.UsernameText);
            this.PanelLogin.Location = new System.Drawing.Point(431, 0);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(394, 577);
            this.PanelLogin.TabIndex = 1;
            // 
            // PasswordLine
            // 
            this.PasswordLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasswordLine.Location = new System.Drawing.Point(84, 315);
            this.PasswordLine.Name = "PasswordLine";
            this.PasswordLine.Size = new System.Drawing.Size(232, 2);
            this.PasswordLine.TabIndex = 7;
            // 
            // UsernameLine
            // 
            this.UsernameLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsernameLine.Location = new System.Drawing.Point(84, 242);
            this.UsernameLine.Name = "UsernameLine";
            this.UsernameLine.Size = new System.Drawing.Size(232, 2);
            this.UsernameLine.TabIndex = 7;
            // 
            // checkShowPassword
            // 
            this.checkShowPassword.AutoSize = true;
            this.checkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.checkShowPassword.Location = new System.Drawing.Point(152, 327);
            this.checkShowPassword.Name = "checkShowPassword";
            this.checkShowPassword.Size = new System.Drawing.Size(164, 29);
            this.checkShowPassword.TabIndex = 6;
            this.checkShowPassword.Text = "ShowPassword";
            this.checkShowPassword.UseVisualStyleBackColor = true;
            this.checkShowPassword.CheckedChanged += new System.EventHandler(this.checkShowPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(79, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(79, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(33, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to SpManage";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(86, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Location = new System.Drawing.Point(84, 284);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '•';
            this.PasswordText.Size = new System.Drawing.Size(232, 29);
            this.PasswordText.TabIndex = 2;
            this.PasswordText.Click += new System.EventHandler(this.PasswordText_Click);
            this.PasswordText.MouseLeave += new System.EventHandler(this.PasswordText_MouseLeave);
            this.PasswordText.MouseHover += new System.EventHandler(this.PasswordText_MouseHover);
            // 
            // UsernameText
            // 
            this.UsernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.UsernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameText.Location = new System.Drawing.Point(85, 211);
            this.UsernameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameText.Multiline = true;
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(232, 29);
            this.UsernameText.TabIndex = 1;
            this.UsernameText.Click += new System.EventHandler(this.UsernameText_Click);
            this.UsernameText.MouseLeave += new System.EventHandler(this.UsernameText_MouseLeave);
            this.UsernameText.MouseHover += new System.EventHandler(this.UsernameText_MouseHover);
            // 
            // TimerUserIn
            // 
            this.TimerUserIn.Interval = 1;
            this.TimerUserIn.Tick += new System.EventHandler(this.TimerAnimatedUser_Tick);
            // 
            // TimerUserOut
            // 
            this.TimerUserOut.Interval = 1;
            this.TimerUserOut.Tick += new System.EventHandler(this.TimerUserOut_Tick);
            // 
            // TimerPassIn
            // 
            this.TimerPassIn.Interval = 1;
            this.TimerPassIn.Tick += new System.EventHandler(this.TimerPassIn_Tick);
            // 
            // TimerPassOut
            // 
            this.TimerPassOut.Interval = 1;
            this.TimerPassOut.Tick += new System.EventHandler(this.TimerPassOut_Tick);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.Location = new System.Drawing.Point(86, 450);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(231, 39);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 577);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.PanelPictrue);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelPictrue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPictrue;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkShowPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PasswordLine;
        private System.Windows.Forms.Label UsernameLine;
        private System.Windows.Forms.Timer TimerUserIn;
        private System.Windows.Forms.Timer TimerUserOut;
        private System.Windows.Forms.Timer TimerPassIn;
        private System.Windows.Forms.Timer TimerPassOut;
        private System.Windows.Forms.Button buttonExit;
    }
}

