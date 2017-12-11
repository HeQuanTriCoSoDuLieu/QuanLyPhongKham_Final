namespace QuanLyPhongKham.Winform
{
    partial class fLichSuTiepNhan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLichSuTiepNhan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNgayHeThong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTimKiemLichSu = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTimKiemLichSu = new System.Windows.Forms.Button();
            this.txtTimKiemLichSu = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuTiepNhan)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvLichSuTiepNhan);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1326, 685);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dgvLichSuTiepNhan
            // 
            this.dgvLichSuTiepNhan.AllowUserToAddRows = false;
            this.dgvLichSuTiepNhan.AllowUserToDeleteRows = false;
            this.dgvLichSuTiepNhan.AllowUserToOrderColumns = true;
            this.dgvLichSuTiepNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichSuTiepNhan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLichSuTiepNhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSuTiepNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLichSuTiepNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuTiepNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column18,
            this.Column2,
            this.Column9,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvLichSuTiepNhan.Location = new System.Drawing.Point(3, 50);
            this.dgvLichSuTiepNhan.Name = "dgvLichSuTiepNhan";
            this.dgvLichSuTiepNhan.ReadOnly = true;
            this.dgvLichSuTiepNhan.RowHeadersVisible = false;
            this.dgvLichSuTiepNhan.RowHeadersWidth = 50;
            this.dgvLichSuTiepNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSuTiepNhan.Size = new System.Drawing.Size(1317, 627);
            this.dgvLichSuTiepNhan.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Mã bệnh nhân";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Ngày khám";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 110;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 210;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Chuẩn đoán";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 350;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Hình thức khám";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Bác sĩ khám";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExcel);
            this.panel2.Controls.Add(this.lblNhanVien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblNgayHeThong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbTimKiemLichSu);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnTimKiemLichSu);
            this.panel2.Controls.Add(this.txtTimKiemLichSu);
            this.panel2.Location = new System.Drawing.Point(3, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1314, 33);
            this.panel2.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(990, 9);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(116, 16);
            this.lblNhanVien.TabIndex = 42;
            this.lblNhanVien.Text = "Đặng Huỳnh Đạt Ý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nhân viên:";
            // 
            // lblNgayHeThong
            // 
            this.lblNgayHeThong.AutoSize = true;
            this.lblNgayHeThong.Location = new System.Drawing.Point(1216, 9);
            this.lblNgayHeThong.Name = "lblNgayHeThong";
            this.lblNgayHeThong.Size = new System.Drawing.Size(95, 16);
            this.lblNgayHeThong.TabIndex = 40;
            this.lblNgayHeThong.Text = "Ngày hệ thống";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ngày hệ thống:";
            // 
            // cbbTimKiemLichSu
            // 
            this.cbbTimKiemLichSu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimKiemLichSu.FormattingEnabled = true;
            this.cbbTimKiemLichSu.Items.AddRange(new object[] {
            "Tất cả",
            "Mã bệnh nhân",
            "Họ tên",
            "Số điện thoại",
            "Số CMND",
            "Ngày khám"});
            this.cbbTimKiemLichSu.Location = new System.Drawing.Point(101, 6);
            this.cbbTimKiemLichSu.Name = "cbbTimKiemLichSu";
            this.cbbTimKiemLichSu.Size = new System.Drawing.Size(110, 24);
            this.cbbTimKiemLichSu.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Tìm kiếm theo";
            // 
            // btnTimKiemLichSu
            // 
            this.btnTimKiemLichSu.Location = new System.Drawing.Point(413, 3);
            this.btnTimKiemLichSu.Name = "btnTimKiemLichSu";
            this.btnTimKiemLichSu.Size = new System.Drawing.Size(75, 25);
            this.btnTimKiemLichSu.TabIndex = 36;
            this.btnTimKiemLichSu.Text = "Tìm kiếm";
            this.btnTimKiemLichSu.UseVisualStyleBackColor = true;
            this.btnTimKiemLichSu.Click += new System.EventHandler(this.btnTimKiemLichSu_Click);
            // 
            // txtTimKiemLichSu
            // 
            this.txtTimKiemLichSu.Location = new System.Drawing.Point(217, 6);
            this.txtTimKiemLichSu.Name = "txtTimKiemLichSu";
            this.txtTimKiemLichSu.Size = new System.Drawing.Size(190, 22);
            this.txtTimKiemLichSu.TabIndex = 35;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(494, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(115, 25);
            this.btnExcel.TabIndex = 43;
            this.btnExcel.Text = "Kết xuất Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // fLichSuTiepNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.groupBox1);
            this.Name = "fLichSuTiepNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử tiếp nhận";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fLichSuTiepNhan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuTiepNhan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbTimKiemLichSu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTimKiemLichSu;
        private System.Windows.Forms.TextBox txtTimKiemLichSu;
        private System.Windows.Forms.DataGridView dgvLichSuTiepNhan;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNgayHeThong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnExcel;
    }
}