namespace QuanLyPhongKham.Winform
{
    partial class fPhanQuyen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdstaikhoan = new System.Windows.Forms.DataGridView();
            this.chkhienthimk = new System.Windows.Forms.CheckBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttenhienthi = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.cbphanquyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbtrangthai);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.btncapnhat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dgvdstaikhoan);
            this.panel1.Controls.Add(this.chkhienthimk);
            this.panel1.Controls.Add(this.txtmatkhau);
            this.panel1.Controls.Add(this.txttenhienthi);
            this.panel1.Controls.Add(this.txttendangnhap);
            this.panel1.Controls.Add(this.txtmanv);
            this.panel1.Controls.Add(this.cbphanquyen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 551);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Phần quyền";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(439, 150);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 31);
            this.btnthem.TabIndex = 30;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(543, 150);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 31);
            this.btncapnhat.TabIndex = 29;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Bảng danh sách tài khoản";
            // 
            // dgvdstaikhoan
            // 
            this.dgvdstaikhoan.AllowUserToAddRows = false;
            this.dgvdstaikhoan.AllowUserToDeleteRows = false;
            this.dgvdstaikhoan.AllowUserToOrderColumns = true;
            this.dgvdstaikhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvdstaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdstaikhoan.Location = new System.Drawing.Point(29, 218);
            this.dgvdstaikhoan.MultiSelect = false;
            this.dgvdstaikhoan.Name = "dgvdstaikhoan";
            this.dgvdstaikhoan.ReadOnly = true;
            this.dgvdstaikhoan.RowHeadersVisible = false;
            this.dgvdstaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdstaikhoan.Size = new System.Drawing.Size(606, 305);
            this.dgvdstaikhoan.TabIndex = 26;
            this.dgvdstaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdstaikhoan_CellClick);
            // 
            // chkhienthimk
            // 
            this.chkhienthimk.AutoSize = true;
            this.chkhienthimk.Location = new System.Drawing.Point(509, 88);
            this.chkhienthimk.Name = "chkhienthimk";
            this.chkhienthimk.Size = new System.Drawing.Size(109, 17);
            this.chkhienthimk.TabIndex = 25;
            this.chkhienthimk.Text = "Hiện thị mật khẩu";
            this.chkhienthimk.UseVisualStyleBackColor = true;
            this.chkhienthimk.CheckedChanged += new System.EventHandler(this.chkhienthimk_CheckedChanged);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(418, 62);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(200, 20);
            this.txtmatkhau.TabIndex = 24;
            // 
            // txttenhienthi
            // 
            this.txttenhienthi.Location = new System.Drawing.Point(418, 27);
            this.txttenhienthi.Name = "txttenhienthi";
            this.txttenhienthi.Size = new System.Drawing.Size(200, 20);
            this.txttenhienthi.TabIndex = 23;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(121, 62);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(169, 20);
            this.txttendangnhap.TabIndex = 22;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(121, 27);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(169, 20);
            this.txtmanv.TabIndex = 21;
            // 
            // cbphanquyen
            // 
            this.cbphanquyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbphanquyen.FormattingEnabled = true;
            this.cbphanquyen.Items.AddRange(new object[] {
            "Bác sĩ",
            "Y tá",
            "Kế toán"});
            this.cbphanquyen.Location = new System.Drawing.Point(121, 111);
            this.cbphanquyen.Name = "cbphanquyen";
            this.cbphanquyen.Size = new System.Drawing.Size(169, 21);
            this.cbphanquyen.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Trạng thái";
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Khoá",
            "Đang sử dụng"});
            this.cbtrangthai.Location = new System.Drawing.Point(417, 111);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(201, 21);
            this.cbtrangthai.TabIndex = 33;
            // 
            // fPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 549);
            this.Controls.Add(this.panel1);
            this.Name = "fPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPhanQuyen";
            this.Load += new System.EventHandler(this.fPhanQuyen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdstaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvdstaikhoan;
        private System.Windows.Forms.CheckBox chkhienthimk;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttenhienthi;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.ComboBox cbphanquyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.Label label7;
    }
}