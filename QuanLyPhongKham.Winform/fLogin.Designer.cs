namespace QuanLyPhongKham.Winform
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkRememberMe = new MetroFramework.Controls.MetroCheckBox();
            this.txbPassWord = new MetroFramework.Controls.MetroTextBox();
            this.txbUserName = new MetroFramework.Controls.MetroTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyPhongKham.Winform.Properties.Resources.lock_icon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.chkRememberMe);
            this.panel1.Controls.Add(this.txbPassWord);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(175, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 163);
            this.panel1.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(3, 133);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 30);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(3, 103);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(130, 15);
            this.chkRememberMe.TabIndex = 2;
            this.chkRememberMe.Text = "Ghi nhớ đăng nhập?";
            // 
            // txbPassWord
            // 
            this.txbPassWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txbPassWord.CustomButton.Image = null;
            this.txbPassWord.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txbPassWord.CustomButton.Name = "";
            this.txbPassWord.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txbPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbPassWord.CustomButton.TabIndex = 1;
            this.txbPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbPassWord.CustomButton.UseSelectable = true;
            this.txbPassWord.CustomButton.Visible = false;
            this.txbPassWord.DisplayIcon = true;
            this.txbPassWord.Icon = global::QuanLyPhongKham.Winform.Properties.Resources.User_Interface_Password_icon;
            this.txbPassWord.Lines = new string[0];
            this.txbPassWord.Location = new System.Drawing.Point(3, 60);
            this.txbPassWord.MaxLength = 32767;
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.PasswordChar = '●';
            //this.txbPassWord.PromptText = "Mật khẩu";
            this.txbPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPassWord.SelectedText = "";
            this.txbPassWord.SelectionLength = 0;
            this.txbPassWord.SelectionStart = 0;
            this.txbPassWord.ShortcutsEnabled = true;
            this.txbPassWord.Size = new System.Drawing.Size(255, 25);
            this.txbPassWord.TabIndex = 1;
            this.txbPassWord.UseSelectable = true;
            this.txbPassWord.UseSystemPasswordChar = true;
            this.txbPassWord.WaterMark = "Mật khẩu";
            this.txbPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbPassWord.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txbUserName
            // 
            this.txbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txbUserName.CustomButton.Image = null;
            this.txbUserName.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txbUserName.CustomButton.Name = "";
            this.txbUserName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txbUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbUserName.CustomButton.TabIndex = 1;
            this.txbUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbUserName.CustomButton.UseSelectable = true;
            this.txbUserName.CustomButton.Visible = false;
            this.txbUserName.DisplayIcon = true;
            this.txbUserName.Icon = global::QuanLyPhongKham.Winform.Properties.Resources.user_icon;
            this.txbUserName.Lines = new string[0];
            this.txbUserName.Location = new System.Drawing.Point(3, 17);
            this.txbUserName.MaxLength = 32767;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.PasswordChar = '\0';
            this.txbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUserName.SelectedText = "";
            this.txbUserName.SelectionLength = 0;
            this.txbUserName.SelectionStart = 0;
            this.txbUserName.ShortcutsEnabled = true;
            this.txbUserName.Size = new System.Drawing.Size(255, 25);
            this.txbUserName.TabIndex = 0;
            this.txbUserName.UseSelectable = true;
            this.txbUserName.WaterMark = "Tên đăng nhập";
            this.txbUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbUserName.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(139, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(459, 254);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private MetroFramework.Controls.MetroCheckBox chkRememberMe;
        private MetroFramework.Controls.MetroTextBox txbPassWord;
        private MetroFramework.Controls.MetroTextBox txbUserName;
        private System.Windows.Forms.Button btnExit;
    }
}