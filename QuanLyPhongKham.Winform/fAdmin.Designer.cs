namespace QuanLyPhongKham.Winform
{
    partial class fAdmin
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Phiếu nhập thuốc");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Phiếu nhập vật tư");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Quản lý phiếu nhập", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Thuốc");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Vật tư y tế");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quản lý kho", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelchinh = new System.Windows.Forms.Panel();
            this.panelkhothuoc = new System.Windows.Forms.Panel();
            this.panelkhovattuyte = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.TableKhovattuyte = new System.Windows.Forms.DataGridView();
            this.comboBoxTimtheokhovattu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btTimkiemkhovattu = new System.Windows.Forms.Button();
            this.txtTimkiemkhovattu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoluongton = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenDVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenVTYT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaVTYT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTimtheokhothuoc = new System.Windows.Forms.ComboBox();
            this.btTimkiemkhothuoc = new System.Windows.Forms.Button();
            this.txttimkiemkhothuoc = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.Tableketquatimkiemthuoc = new System.Windows.Forms.DataGridView();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtSLT = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.txtLoaithuoc = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenthuoc = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtMaT = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.treeViewQuanly = new System.Windows.Forms.TreeView();
            this.btCapnhatthuoc = new System.Windows.Forms.Button();
            this.btThemthuoc = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelchinh.SuspendLayout();
            this.panelkhothuoc.SuspendLayout();
            this.panelkhovattuyte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableKhovattuyte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tableketquatimkiemthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1362, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Checked = true;
            this.menuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // panelchinh
            // 
            this.panelchinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelchinh.Controls.Add(this.panelkhothuoc);
            this.panelchinh.Location = new System.Drawing.Point(241, 39);
            this.panelchinh.Name = "panelchinh";
            this.panelchinh.Size = new System.Drawing.Size(1099, 602);
            this.panelchinh.TabIndex = 5;
            // 
            // panelkhothuoc
            // 
            this.panelkhothuoc.Controls.Add(this.panelkhovattuyte);
            this.panelkhothuoc.Controls.Add(this.comboBoxTimtheokhothuoc);
            this.panelkhothuoc.Controls.Add(this.btTimkiemkhothuoc);
            this.panelkhothuoc.Controls.Add(this.txttimkiemkhothuoc);
            this.panelkhothuoc.Controls.Add(this.label36);
            this.panelkhothuoc.Controls.Add(this.label38);
            this.panelkhothuoc.Controls.Add(this.Tableketquatimkiemthuoc);
            this.panelkhothuoc.Controls.Add(this.txtGhichu);
            this.panelkhothuoc.Controls.Add(this.label30);
            this.panelkhothuoc.Controls.Add(this.txtSLT);
            this.panelkhothuoc.Controls.Add(this.label51);
            this.panelkhothuoc.Controls.Add(this.label50);
            this.panelkhothuoc.Controls.Add(this.txtLoaithuoc);
            this.panelkhothuoc.Controls.Add(this.label37);
            this.panelkhothuoc.Controls.Add(this.label45);
            this.panelkhothuoc.Controls.Add(this.label46);
            this.panelkhothuoc.Controls.Add(this.txtDVT);
            this.panelkhothuoc.Controls.Add(this.txtTenthuoc);
            this.panelkhothuoc.Controls.Add(this.label47);
            this.panelkhothuoc.Controls.Add(this.txtMaT);
            this.panelkhothuoc.Controls.Add(this.label48);
            this.panelkhothuoc.Controls.Add(this.label49);
            this.panelkhothuoc.Controls.Add(this.btThemthuoc);
            this.panelkhothuoc.Controls.Add(this.btCapnhatthuoc);
            this.panelkhothuoc.Location = new System.Drawing.Point(18, 3);
            this.panelkhothuoc.Name = "panelkhothuoc";
            this.panelkhothuoc.Size = new System.Drawing.Size(1080, 591);
            this.panelkhothuoc.TabIndex = 30;
            // 
            // panelkhovattuyte
            // 
            this.panelkhovattuyte.Controls.Add(this.label10);
            this.panelkhovattuyte.Controls.Add(this.btCapnhat);
            this.panelkhovattuyte.Controls.Add(this.TableKhovattuyte);
            this.panelkhovattuyte.Controls.Add(this.btThem);
            this.panelkhovattuyte.Controls.Add(this.comboBoxTimtheokhovattu);
            this.panelkhovattuyte.Controls.Add(this.label9);
            this.panelkhovattuyte.Controls.Add(this.btTimkiemkhovattu);
            this.panelkhovattuyte.Controls.Add(this.txtTimkiemkhovattu);
            this.panelkhovattuyte.Controls.Add(this.label8);
            this.panelkhovattuyte.Controls.Add(this.label7);
            this.panelkhovattuyte.Controls.Add(this.txtSoluongton);
            this.panelkhovattuyte.Controls.Add(this.label6);
            this.panelkhovattuyte.Controls.Add(this.txtTenDVT);
            this.panelkhovattuyte.Controls.Add(this.label5);
            this.panelkhovattuyte.Controls.Add(this.txtTenVTYT);
            this.panelkhovattuyte.Controls.Add(this.label4);
            this.panelkhovattuyte.Controls.Add(this.txtMaVTYT);
            this.panelkhovattuyte.Controls.Add(this.label3);
            this.panelkhovattuyte.Controls.Add(this.label2);
            this.panelkhovattuyte.Controls.Add(this.label1);
            this.panelkhovattuyte.Location = new System.Drawing.Point(0, 1);
            this.panelkhovattuyte.Name = "panelkhovattuyte";
            this.panelkhovattuyte.Size = new System.Drawing.Size(1080, 587);
            this.panelkhovattuyte.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "DANH SÁCH KHO VẬT TƯ Y TẾ";
            // 
            // TableKhovattuyte
            // 
            this.TableKhovattuyte.AllowUserToAddRows = false;
            this.TableKhovattuyte.AllowUserToDeleteRows = false;
            this.TableKhovattuyte.AllowUserToResizeColumns = false;
            this.TableKhovattuyte.AllowUserToResizeRows = false;
            this.TableKhovattuyte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableKhovattuyte.Location = new System.Drawing.Point(142, 250);
            this.TableKhovattuyte.MultiSelect = false;
            this.TableKhovattuyte.Name = "TableKhovattuyte";
            this.TableKhovattuyte.ReadOnly = true;
            this.TableKhovattuyte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableKhovattuyte.Size = new System.Drawing.Size(571, 304);
            this.TableKhovattuyte.TabIndex = 16;
            this.TableKhovattuyte.SelectionChanged += new System.EventHandler(this.TableKhovattuyte_SelectionChanged);
            // 
            // comboBoxTimtheokhovattu
            // 
            this.comboBoxTimtheokhovattu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimtheokhovattu.FormattingEnabled = true;
            this.comboBoxTimtheokhovattu.Items.AddRange(new object[] {
            "Mã vật tư y tế",
            "Tên vât tư y tế"});
            this.comboBoxTimtheokhovattu.Location = new System.Drawing.Point(570, 154);
            this.comboBoxTimtheokhovattu.Name = "comboBoxTimtheokhovattu";
            this.comboBoxTimtheokhovattu.Size = new System.Drawing.Size(183, 21);
            this.comboBoxTimtheokhovattu.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(504, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tìm theo";
            // 
            // btTimkiemkhovattu
            // 
            this.btTimkiemkhovattu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimkiemkhovattu.Location = new System.Drawing.Point(377, 152);
            this.btTimkiemkhovattu.Name = "btTimkiemkhovattu";
            this.btTimkiemkhovattu.Size = new System.Drawing.Size(75, 23);
            this.btTimkiemkhovattu.TabIndex = 13;
            this.btTimkiemkhovattu.Text = "Tìm kiếm";
            this.btTimkiemkhovattu.UseVisualStyleBackColor = true;
            this.btTimkiemkhovattu.Click += new System.EventHandler(this.btTimkiemkhovattu_Click);
            // 
            // txtTimkiemkhovattu
            // 
            this.txtTimkiemkhovattu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemkhovattu.Location = new System.Drawing.Point(124, 152);
            this.txtTimkiemkhovattu.Name = "txtTimkiemkhovattu";
            this.txtTimkiemkhovattu.Size = new System.Drawing.Size(231, 22);
            this.txtTimkiemkhovattu.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tìm kiếm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "TÌM KIẾM KHO VẬT TƯ";
            // 
            // txtSoluongton
            // 
            this.txtSoluongton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluongton.Location = new System.Drawing.Point(446, 75);
            this.txtSoluongton.Name = "txtSoluongton";
            this.txtSoluongton.Size = new System.Drawing.Size(169, 22);
            this.txtSoluongton.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng tồn";
            // 
            // txtTenDVT
            // 
            this.txtTenDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDVT.Location = new System.Drawing.Point(446, 41);
            this.txtTenDVT.Name = "txtTenDVT";
            this.txtTenDVT.Size = new System.Drawing.Size(169, 22);
            this.txtTenDVT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtTenVTYT
            // 
            this.txtTenVTYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVTYT.Location = new System.Drawing.Point(124, 79);
            this.txtTenVTYT.Name = "txtTenVTYT";
            this.txtTenVTYT.Size = new System.Drawing.Size(165, 22);
            this.txtTenVTYT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên vật tư y tế";
            // 
            // txtMaVTYT
            // 
            this.txtMaVTYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVTYT.Location = new System.Drawing.Point(124, 43);
            this.txtMaVTYT.Name = "txtMaVTYT";
            this.txtMaVTYT.Size = new System.Drawing.Size(165, 22);
            this.txtMaVTYT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã vật tư y tế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "KHO VẬT TƯ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // comboBoxTimtheokhothuoc
            // 
            this.comboBoxTimtheokhothuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTimtheokhothuoc.FormattingEnabled = true;
            this.comboBoxTimtheokhothuoc.Items.AddRange(new object[] {
            "Mã Thuốc",
            "Tên thuốc",
            "Loại thuốc"});
            this.comboBoxTimtheokhothuoc.Location = new System.Drawing.Point(548, 179);
            this.comboBoxTimtheokhothuoc.Name = "comboBoxTimtheokhothuoc";
            this.comboBoxTimtheokhothuoc.Size = new System.Drawing.Size(144, 24);
            this.comboBoxTimtheokhothuoc.TabIndex = 39;
            // 
            // btTimkiemkhothuoc
            // 
            this.btTimkiemkhothuoc.Location = new System.Drawing.Point(353, 178);
            this.btTimkiemkhothuoc.Name = "btTimkiemkhothuoc";
            this.btTimkiemkhothuoc.Size = new System.Drawing.Size(75, 23);
            this.btTimkiemkhothuoc.TabIndex = 38;
            this.btTimkiemkhothuoc.Text = "Tìm kiếm";
            this.btTimkiemkhothuoc.UseVisualStyleBackColor = true;
            //this.btTimkiemkhothuoc.Click += new System.EventHandler(this.btTimkiemkhothuoc_Click);
            // 
            // txttimkiemkhothuoc
            // 
            this.txttimkiemkhothuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiemkhothuoc.Location = new System.Drawing.Point(114, 179);
            this.txttimkiemkhothuoc.Name = "txttimkiemkhothuoc";
            this.txttimkiemkhothuoc.Size = new System.Drawing.Size(231, 22);
            this.txttimkiemkhothuoc.TabIndex = 37;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label36.Location = new System.Drawing.Point(45, 182);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(63, 16);
            this.label36.TabIndex = 36;
            this.label36.Text = "Tìm kiếm";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(466, 183);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 16);
            this.label38.TabIndex = 35;
            this.label38.Text = "Tìm theo";
            // 
            // Tableketquatimkiemthuoc
            // 
            this.Tableketquatimkiemthuoc.AllowUserToAddRows = false;
            this.Tableketquatimkiemthuoc.AllowUserToDeleteRows = false;
            this.Tableketquatimkiemthuoc.AllowUserToResizeColumns = false;
            this.Tableketquatimkiemthuoc.AllowUserToResizeRows = false;
            this.Tableketquatimkiemthuoc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tableketquatimkiemthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tableketquatimkiemthuoc.Location = new System.Drawing.Point(23, 251);
            this.Tableketquatimkiemthuoc.Name = "Tableketquatimkiemthuoc";
            this.Tableketquatimkiemthuoc.ReadOnly = true;
            this.Tableketquatimkiemthuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tableketquatimkiemthuoc.Size = new System.Drawing.Size(1019, 319);
            this.Tableketquatimkiemthuoc.TabIndex = 34;
            this.Tableketquatimkiemthuoc.SelectionChanged += new System.EventHandler(this.Tableketquatimkiemthuoc_SelectionChanged);
            // 
            // txtGhichu
            // 
            this.txtGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(692, 78);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(242, 64);
            this.txtGhichu.TabIndex = 23;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(45, 223);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(234, 16);
            this.label30.TabIndex = 33;
            this.label30.Text = "BẢNG DANH SÁCH KHO THUỐC";
            // 
            // txtSLT
            // 
            this.txtSLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLT.Location = new System.Drawing.Point(692, 37);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Size = new System.Drawing.Size(242, 22);
            this.txtSLT.TabIndex = 22;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(593, 82);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(52, 16);
            this.label51.TabIndex = 21;
            this.label51.Text = "Ghi chú";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(593, 40);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(82, 16);
            this.label50.TabIndex = 20;
            this.label50.Text = "Số lượng tồn";
            // 
            // txtLoaithuoc
            // 
            this.txtLoaithuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaithuoc.Location = new System.Drawing.Point(400, 78);
            this.txtLoaithuoc.Name = "txtLoaithuoc";
            this.txtLoaithuoc.Size = new System.Drawing.Size(164, 22);
            this.txtLoaithuoc.TabIndex = 10;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label37.Location = new System.Drawing.Point(32, 138);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(186, 18);
            this.label37.TabIndex = 28;
            this.label37.Text = "TÌM KIẾM KHO THUỐC";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(315, 81);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(69, 16);
            this.label45.TabIndex = 9;
            this.label45.Text = "Loại thuốc";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(315, 40);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(68, 16);
            this.label46.TabIndex = 8;
            this.label46.Text = "Đơn vị tính";
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(400, 37);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(164, 22);
            this.txtDVT.TabIndex = 7;
            // 
            // txtTenthuoc
            // 
            this.txtTenthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenthuoc.Location = new System.Drawing.Point(100, 78);
            this.txtTenthuoc.Name = "txtTenthuoc";
            this.txtTenthuoc.Size = new System.Drawing.Size(172, 22);
            this.txtTenthuoc.TabIndex = 4;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(27, 78);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(67, 16);
            this.label47.TabIndex = 3;
            this.label47.Text = "Tên thuốc";
            // 
            // txtMaT
            // 
            this.txtMaT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaT.Location = new System.Drawing.Point(100, 37);
            this.txtMaT.Name = "txtMaT";
            this.txtMaT.Size = new System.Drawing.Size(172, 22);
            this.txtMaT.TabIndex = 2;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(32, 40);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(62, 16);
            this.label48.TabIndex = 1;
            this.label48.Text = "Mã thuốc";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(44, 7);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(112, 20);
            this.label49.TabIndex = 0;
            this.label49.Text = "KHO THUỐC";
            // 
            // btCapnhat
            // 
            this.btCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapnhat.Location = new System.Drawing.Point(935, 110);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(107, 45);
            this.btCapnhat.TabIndex = 40;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(935, 41);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(107, 47);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm mới";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // treeViewQuanly
            // 
            this.treeViewQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewQuanly.Location = new System.Drawing.Point(12, 38);
            this.treeViewQuanly.Name = "treeViewQuanly";
            treeNode1.Name = "NodePhieunhapthuoc";
            treeNode1.Text = "Phiếu nhập thuốc";
            treeNode2.Name = "NodePhieunhapvattu";
            treeNode2.Text = "Phiếu nhập vật tư";
            treeNode3.Name = "NodePhieunhap";
            treeNode3.Text = "Quản lý phiếu nhập";
            treeNode4.Name = "NodeThuoc";
            treeNode4.Text = "Thuốc";
            treeNode5.Name = "NodeVattuyte";
            treeNode5.Text = "Vật tư y tế";
            treeNode6.Name = "NodeQuanlykho";
            treeNode6.Text = "Quản lý kho";
            this.treeViewQuanly.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeViewQuanly.Size = new System.Drawing.Size(223, 643);
            this.treeViewQuanly.TabIndex = 0;
            this.treeViewQuanly.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewQuanly_AfterSelect);
            // 
            // btCapnhatthuoc
            // 
            this.btCapnhatthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapnhatthuoc.Location = new System.Drawing.Point(955, 99);
            this.btCapnhatthuoc.Name = "btCapnhatthuoc";
            this.btCapnhatthuoc.Size = new System.Drawing.Size(107, 45);
            this.btCapnhatthuoc.TabIndex = 43;
            this.btCapnhatthuoc.Text = "Cập nhật";
            this.btCapnhatthuoc.UseVisualStyleBackColor = true;
            // 
            // btThemthuoc
            // 
            this.btThemthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemthuoc.Location = new System.Drawing.Point(955, 30);
            this.btThemthuoc.Name = "btThemthuoc";
            this.btThemthuoc.Size = new System.Drawing.Size(107, 47);
            this.btThemthuoc.TabIndex = 42;
            this.btThemthuoc.Text = "Thêm mới";
            this.btThemthuoc.UseVisualStyleBackColor = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panelchinh);
            this.Controls.Add(this.treeViewQuanly);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelchinh.ResumeLayout(false);
            this.panelkhothuoc.ResumeLayout(false);
            this.panelkhothuoc.PerformLayout();
            this.panelkhovattuyte.ResumeLayout(false);
            this.panelkhovattuyte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableKhovattuyte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tableketquatimkiemthuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panelchinh;
        private System.Windows.Forms.TreeView treeViewQuanly;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Panel panelkhothuoc;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.TextBox txtSLT;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.DataGridView Tableketquatimkiemthuoc;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtLoaithuoc;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenthuoc;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtMaT;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox comboBoxTimtheokhothuoc;
        private System.Windows.Forms.Button btTimkiemkhothuoc;
        private System.Windows.Forms.TextBox txttimkiemkhothuoc;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.Panel panelkhovattuyte;
        private System.Windows.Forms.TextBox txtMaVTYT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenVTYT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoluongton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView TableKhovattuyte;
        private System.Windows.Forms.ComboBox comboBoxTimtheokhovattu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btTimkiemkhovattu;
        private System.Windows.Forms.TextBox txtTimkiemkhovattu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThemthuoc;
        private System.Windows.Forms.Button btCapnhatthuoc;
    }
}