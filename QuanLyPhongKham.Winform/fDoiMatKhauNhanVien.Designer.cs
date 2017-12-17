namespace QuanLyPhongKham.Winform
{
    partial class fDoiMatKhauNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassWordHienTai = new MetroFramework.Controls.MetroTextBox();
            this.txtnewPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtPassWordHienTai
            // 
            this.txtPassWordHienTai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPassWordHienTai.CustomButton.Image = null;
            this.txtPassWordHienTai.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtPassWordHienTai.CustomButton.Name = "";
            this.txtPassWordHienTai.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPassWordHienTai.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassWordHienTai.CustomButton.TabIndex = 1;
            this.txtPassWordHienTai.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassWordHienTai.CustomButton.UseSelectable = true;
            this.txtPassWordHienTai.CustomButton.Visible = false;
            this.txtPassWordHienTai.DisplayIcon = true;
            this.txtPassWordHienTai.Icon = global::QuanLyPhongKham.Winform.Properties.Resources.User_Interface_Password_icon;
            this.txtPassWordHienTai.Lines = new string[0];
            this.txtPassWordHienTai.Location = new System.Drawing.Point(177, 29);
            this.txtPassWordHienTai.MaxLength = 32767;
            this.txtPassWordHienTai.Name = "txtPassWordHienTai";
            this.txtPassWordHienTai.PasswordChar = '●';
            
            this.txtPassWordHienTai.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassWordHienTai.SelectedText = "";
            this.txtPassWordHienTai.SelectionLength = 0;
            this.txtPassWordHienTai.SelectionStart = 0;
            this.txtPassWordHienTai.ShortcutsEnabled = true;
            this.txtPassWordHienTai.Size = new System.Drawing.Size(210, 25);
            this.txtPassWordHienTai.TabIndex = 3;
            this.txtPassWordHienTai.UseSelectable = true;
            this.txtPassWordHienTai.UseSystemPasswordChar = true;
            this.txtPassWordHienTai.WaterMark = "Mật khẩu hiện tại";
            this.txtPassWordHienTai.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassWordHienTai.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtnewPassword
            // 
            this.txtnewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtnewPassword.CustomButton.Image = null;
            this.txtnewPassword.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtnewPassword.CustomButton.Name = "";
            this.txtnewPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtnewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnewPassword.CustomButton.TabIndex = 1;
            this.txtnewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnewPassword.CustomButton.UseSelectable = true;
            this.txtnewPassword.CustomButton.Visible = false;
            this.txtnewPassword.DisplayIcon = true;
            this.txtnewPassword.Icon = global::QuanLyPhongKham.Winform.Properties.Resources.User_Interface_Password_icon;
            this.txtnewPassword.Lines = new string[0];
            this.txtnewPassword.Location = new System.Drawing.Point(177, 66);
            this.txtnewPassword.MaxLength = 32767;
            this.txtnewPassword.Name = "txtnewPassword";
            this.txtnewPassword.PasswordChar = '●';
            this.txtnewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnewPassword.SelectedText = "";
            this.txtnewPassword.SelectionLength = 0;
            this.txtnewPassword.SelectionStart = 0;
            this.txtnewPassword.ShortcutsEnabled = true;
            this.txtnewPassword.Size = new System.Drawing.Size(210, 25);
            this.txtnewPassword.TabIndex = 4;
            this.txtnewPassword.UseSelectable = true;
            this.txtnewPassword.UseSystemPasswordChar = true;
            this.txtnewPassword.WaterMark = "Mật khẩu mới";
            this.txtnewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnewPassword.WaterMarkFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacnhan.BackColor = System.Drawing.Color.White;
            this.btnXacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.Location = new System.Drawing.Point(190, 111);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(87, 30);
            this.btnXacnhan.TabIndex = 5;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthoat.BackColor = System.Drawing.Color.White;
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(302, 111);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 30);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // fDoiMatKhauNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 160);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnXacnhan);
            this.Controls.Add(this.txtnewPassword);
            this.Controls.Add(this.txtPassWordHienTai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fDoiMatKhauNhanVien";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txtPassWordHienTai;
        private MetroFramework.Controls.MetroTextBox txtnewPassword;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.Button btnthoat;
    }
}