namespace QuanLyPhongKham.Winform
{
    partial class fTimKiemThuoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvdsthuoc = new System.Windows.Forms.DataGridView();
            this.cbxnhomthuoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "TÌM KIẾM";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(494, 32);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(78, 25);
            this.btntimkiem.TabIndex = 42;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(141, 33);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(309, 22);
            this.txttimkiem.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Danh sách thuốc";
            // 
            // dgvdsthuoc
            // 
            this.dgvdsthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsthuoc.Location = new System.Drawing.Point(12, 118);
            this.dgvdsthuoc.Name = "dgvdsthuoc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdsthuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdsthuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdsthuoc.Size = new System.Drawing.Size(740, 348);
            this.dgvdsthuoc.TabIndex = 39;
            this.dgvdsthuoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvdsthuoc_MouseDoubleClick);
            // 
            // cbxnhomthuoc
            // 
            this.cbxnhomthuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxnhomthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxnhomthuoc.FormattingEnabled = true;
            this.cbxnhomthuoc.Items.AddRange(new object[] {
            "TẤT CẢ",
            "THUỐC CHỐNG DỊ ỨNG",
            "HẠ SỐT, CHỐNG CO THẮT, GIẢM ĐAU",
            "THUỐC ĐIỀU TRỊ BỆNH KHỚP",
            "THUỐC TÁC ĐỘNG LÊN, RUỘT GANG, DẠ DÀY",
            "THUỐC GIẢI ĐỘC",
            "THUỐC NGOÀI DA",
            "THUỐC SỬ DỤNG TRONG NHA KHOA",
            "THUỐC SỬ DỤNG TRONG NHÃN KHOA",
            "THUỐC THUỐC ĐIỀU TRỊ TAY-MŨI-HỌNG",
            "THUỐC TRỊ BỆNH NHIỄM KHUẨN, KÍ SINH TRÙNG"});
            this.cbxnhomthuoc.Location = new System.Drawing.Point(141, 65);
            this.cbxnhomthuoc.Name = "cbxnhomthuoc";
            this.cbxnhomthuoc.Size = new System.Drawing.Size(309, 24);
            this.cbxnhomthuoc.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nhóm thuốc";
            // 
            // fTimKiemThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 478);
            this.Controls.Add(this.cbxnhomthuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvdsthuoc);
            this.Name = "fTimKiemThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tim Kiem Thuoc";
            this.Load += new System.EventHandler(this.fTimKiemThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsthuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvdsthuoc;
        private System.Windows.Forms.ComboBox cbxnhomthuoc;
        private System.Windows.Forms.Label label1;
    }
}
