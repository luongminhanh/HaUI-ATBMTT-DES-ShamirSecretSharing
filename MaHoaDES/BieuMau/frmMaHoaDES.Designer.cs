namespace MaHoaDES.BieuMau
{
    partial class frmMaHoaDES
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
            this.ckbCheDoDebug = new System.Windows.Forms.CheckBox();
            this.txtKhoaVanBan = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRecoveryKey = new System.Windows.Forms.RichTextBox();
            this.btnRecoveryKey = new System.Windows.Forms.Button();
            this.dgvKeyShare = new System.Windows.Forms.DataGridView();
            this.luaChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xi_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pi_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvKey = new System.Windows.Forms.DataGridView();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShareKey = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtMinKey = new System.Windows.Forms.TextBox();
            this.txtMaxKey = new System.Windows.Forms.TextBox();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BoxFileCrypt = new System.Windows.Forms.GroupBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnChuyenGM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVanBanDich = new System.Windows.Forms.RichTextBox();
            this.txtVanBanNguon = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnMaHoaVanBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.lblEncryptedFilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxTextCrypt = new System.Windows.Forms.GroupBox();
            this.btnSaveFileGM = new System.Windows.Forms.Button();
            this.btnChonFileGM = new System.Windows.Forms.Button();
            this.txtBanRo2 = new System.Windows.Forms.RichTextBox();
            this.txtBanMa2 = new System.Windows.Forms.RichTextBox();
            this.txtKhoaFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiaiMaVanBan = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyShare)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKey)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.BoxFileCrypt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BoxTextCrypt.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbCheDoDebug
            // 
            this.ckbCheDoDebug.AutoSize = true;
            this.ckbCheDoDebug.BackColor = System.Drawing.Color.White;
            this.ckbCheDoDebug.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCheDoDebug.ForeColor = System.Drawing.Color.White;
            this.ckbCheDoDebug.Location = new System.Drawing.Point(685, 758);
            this.ckbCheDoDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbCheDoDebug.Name = "ckbCheDoDebug";
            this.ckbCheDoDebug.Size = new System.Drawing.Size(136, 24);
            this.ckbCheDoDebug.TabIndex = 27;
            this.ckbCheDoDebug.Text = "Chế độ debug";
            this.ckbCheDoDebug.UseVisualStyleBackColor = false;
            // 
            // txtKhoaVanBan
            // 
            this.txtKhoaVanBan.BackColor = System.Drawing.Color.White;
            this.txtKhoaVanBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKhoaVanBan.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtKhoaVanBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaVanBan.Location = new System.Drawing.Point(651, 324);
            this.txtKhoaVanBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhoaVanBan.MaxLength = 16;
            this.txtKhoaVanBan.Name = "txtKhoaVanBan";
            this.txtKhoaVanBan.Size = new System.Drawing.Size(10, 22);
            this.txtKhoaVanBan.TabIndex = 17;
            this.txtKhoaVanBan.Text = "0123456789ABCDE1";
            this.txtKhoaVanBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1346, 716);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chia sẻ khóa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRecoveryKey);
            this.groupBox3.Controls.Add(this.btnRecoveryKey);
            this.groupBox3.Controls.Add(this.dgvKeyShare);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(682, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 673);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khôi phục khóa";
            // 
            // txtRecoveryKey
            // 
            this.txtRecoveryKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecoveryKey.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecoveryKey.ForeColor = System.Drawing.Color.Red;
            this.txtRecoveryKey.Location = new System.Drawing.Point(123, 488);
            this.txtRecoveryKey.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtRecoveryKey.Name = "txtRecoveryKey";
            this.txtRecoveryKey.Size = new System.Drawing.Size(426, 57);
            this.txtRecoveryKey.TabIndex = 13;
            this.txtRecoveryKey.Text = "";
            // 
            // btnRecoveryKey
            // 
            this.btnRecoveryKey.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnRecoveryKey.ForeColor = System.Drawing.Color.White;
            this.btnRecoveryKey.Location = new System.Drawing.Point(246, 339);
            this.btnRecoveryKey.Name = "btnRecoveryKey";
            this.btnRecoveryKey.Size = new System.Drawing.Size(184, 63);
            this.btnRecoveryKey.TabIndex = 12;
            this.btnRecoveryKey.Text = "Khôi phục khóa";
            this.btnRecoveryKey.UseVisualStyleBackColor = false;
            this.btnRecoveryKey.Click += new System.EventHandler(this.btnRecoveryKey_Click);
            // 
            // dgvKeyShare
            // 
            this.dgvKeyShare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeyShare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeyShare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.luaChon,
            this.xi_,
            this.pi_});
            this.dgvKeyShare.Location = new System.Drawing.Point(49, 51);
            this.dgvKeyShare.Name = "dgvKeyShare";
            this.dgvKeyShare.RowHeadersWidth = 51;
            this.dgvKeyShare.RowTemplate.Height = 24;
            this.dgvKeyShare.Size = new System.Drawing.Size(541, 236);
            this.dgvKeyShare.TabIndex = 11;
            // 
            // luaChon
            // 
            this.luaChon.HeaderText = "Lựa Chọn";
            this.luaChon.MinimumWidth = 6;
            this.luaChon.Name = "luaChon";
            this.luaChon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.luaChon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // xi_
            // 
            this.xi_.DataPropertyName = "X";
            this.xi_.HeaderText = "xi";
            this.xi_.MinimumWidth = 6;
            this.xi_.Name = "xi_";
            // 
            // pi_
            // 
            this.pi_.DataPropertyName = "Y";
            this.pi_.HeaderText = "pi";
            this.pi_.MinimumWidth = 6;
            this.pi_.Name = "pi_";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvKey);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnShareKey);
            this.groupBox2.Controls.Add(this.txtP);
            this.groupBox2.Controls.Add(this.txtMinKey);
            this.groupBox2.Controls.Add(this.txtMaxKey);
            this.groupBox2.Controls.Add(this.txtSecretKey);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 673);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chia khóa";
            // 
            // dgvKey
            // 
            this.dgvKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xi,
            this.pi});
            this.dgvKey.Location = new System.Drawing.Point(33, 398);
            this.dgvKey.Name = "dgvKey";
            this.dgvKey.RowHeadersWidth = 51;
            this.dgvKey.RowTemplate.Height = 24;
            this.dgvKey.Size = new System.Drawing.Size(541, 236);
            this.dgvKey.TabIndex = 10;
            // 
            // xi
            // 
            this.xi.DataPropertyName = "X";
            this.xi.HeaderText = "xi";
            this.xi.MinimumWidth = 6;
            this.xi.Name = "xi";
            // 
            // pi
            // 
            this.pi.DataPropertyName = "Y";
            this.pi.HeaderText = "pi";
            this.pi.MinimumWidth = 6;
            this.pi.Name = "pi";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(332, 280);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 56);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Nhập lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShareKey
            // 
            this.btnShareKey.BackColor = System.Drawing.Color.Red;
            this.btnShareKey.ForeColor = System.Drawing.Color.White;
            this.btnShareKey.Location = new System.Drawing.Point(83, 280);
            this.btnShareKey.Name = "btnShareKey";
            this.btnShareKey.Size = new System.Drawing.Size(149, 56);
            this.btnShareKey.TabIndex = 8;
            this.btnShareKey.Text = "Chia sẻ khóa";
            this.btnShareKey.UseVisualStyleBackColor = false;
            this.btnShareKey.Click += new System.EventHandler(this.btnShareKey_Click_1);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(416, 190);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(158, 31);
            this.txtP.TabIndex = 7;
            this.txtP.TextChanged += new System.EventHandler(this.txtSNT_TextChanged);
            // 
            // txtMinKey
            // 
            this.txtMinKey.Location = new System.Drawing.Point(416, 144);
            this.txtMinKey.Name = "txtMinKey";
            this.txtMinKey.Size = new System.Drawing.Size(158, 31);
            this.txtMinKey.TabIndex = 6;
            // 
            // txtMaxKey
            // 
            this.txtMaxKey.Location = new System.Drawing.Point(416, 97);
            this.txtMaxKey.Name = "txtMaxKey";
            this.txtMaxKey.Size = new System.Drawing.Size(158, 31);
            this.txtMaxKey.TabIndex = 5;
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(416, 51);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(158, 31);
            this.txtSecretKey.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Giá trị p";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số thành viên tối thiểu để mở khóa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số thành viên giữ khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khóa bí mật";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BoxFileCrypt);
            this.tabPage1.Controls.Add(this.BoxTextCrypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1346, 716);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BoxFileCrypt
            // 
            this.BoxFileCrypt.Controls.Add(this.btnSaveFile);
            this.BoxFileCrypt.Controls.Add(this.btnChuyenGM);
            this.BoxFileCrypt.Controls.Add(this.label6);
            this.BoxFileCrypt.Controls.Add(this.txtVanBanDich);
            this.BoxFileCrypt.Controls.Add(this.txtVanBanNguon);
            this.BoxFileCrypt.Controls.Add(this.groupBox1);
            this.BoxFileCrypt.Controls.Add(this.btnMaHoaVanBan);
            this.BoxFileCrypt.Controls.Add(this.label1);
            this.BoxFileCrypt.Controls.Add(this.btnChonFile);
            this.BoxFileCrypt.Controls.Add(this.lblEncryptedFilename);
            this.BoxFileCrypt.Controls.Add(this.label3);
            this.BoxFileCrypt.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFileCrypt.Location = new System.Drawing.Point(23, 8);
            this.BoxFileCrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxFileCrypt.Name = "BoxFileCrypt";
            this.BoxFileCrypt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxFileCrypt.Size = new System.Drawing.Size(622, 701);
            this.BoxFileCrypt.TabIndex = 24;
            this.BoxFileCrypt.TabStop = false;
            this.BoxFileCrypt.Text = "MÃ HÓA";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveFile.Font = new System.Drawing.Font("Cambria", 13F);
            this.btnSaveFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveFile.Location = new System.Drawing.Point(138, 636);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(147, 54);
            this.btnSaveFile.TabIndex = 33;
            this.btnSaveFile.Text = "Lưu";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnChuyenGM
            // 
            this.btnChuyenGM.BackColor = System.Drawing.Color.Red;
            this.btnChuyenGM.Font = new System.Drawing.Font("Cambria", 13F);
            this.btnChuyenGM.ForeColor = System.Drawing.Color.White;
            this.btnChuyenGM.Location = new System.Drawing.Point(328, 635);
            this.btnChuyenGM.Name = "btnChuyenGM";
            this.btnChuyenGM.Size = new System.Drawing.Size(143, 54);
            this.btnChuyenGM.TabIndex = 32;
            this.btnChuyenGM.Text = "Chuyển";
            this.btnChuyenGM.UseVisualStyleBackColor = false;
            this.btnChuyenGM.Click += new System.EventHandler(this.btnChuyenGM_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 498);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 27);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bản mã";
            // 
            // txtVanBanDich
            // 
            this.txtVanBanDich.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanBanDich.Location = new System.Drawing.Point(105, 402);
            this.txtVanBanDich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVanBanDich.Name = "txtVanBanDich";
            this.txtVanBanDich.Size = new System.Drawing.Size(405, 205);
            this.txtVanBanDich.TabIndex = 26;
            this.txtVanBanDich.Text = "";
            // 
            // txtVanBanNguon
            // 
            this.txtVanBanNguon.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVanBanNguon.Location = new System.Drawing.Point(105, 50);
            this.txtVanBanNguon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVanBanNguon.Name = "txtVanBanNguon";
            this.txtVanBanNguon.Size = new System.Drawing.Size(405, 216);
            this.txtVanBanNguon.TabIndex = 26;
            this.txtVanBanNguon.Text = "";
            this.txtVanBanNguon.TextChanged += new System.EventHandler(this.txtVanBanNguon_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(8, 698);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(530, 27);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiến trình";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 46);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(524, 33);
            this.progressBar1.TabIndex = 0;
            // 
            // btnMaHoaVanBan
            // 
            this.btnMaHoaVanBan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMaHoaVanBan.Font = new System.Drawing.Font("Cambria", 14F);
            this.btnMaHoaVanBan.ForeColor = System.Drawing.Color.White;
            this.btnMaHoaVanBan.Location = new System.Drawing.Point(206, 304);
            this.btnMaHoaVanBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaHoaVanBan.Name = "btnMaHoaVanBan";
            this.btnMaHoaVanBan.Size = new System.Drawing.Size(169, 64);
            this.btnMaHoaVanBan.TabIndex = 10;
            this.btnMaHoaVanBan.Text = "Mã hoá";
            this.btnMaHoaVanBan.UseVisualStyleBackColor = false;
            this.btnMaHoaVanBan.Click += new System.EventHandler(this.txtMaHoaVanBan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bản rõ";
            // 
            // btnChonFile
            // 
            this.btnChonFile.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnChonFile.Font = new System.Drawing.Font("Cambria", 13F);
            this.btnChonFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChonFile.Location = new System.Drawing.Point(526, 129);
            this.btnChonFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(91, 53);
            this.btnChonFile.TabIndex = 16;
            this.btnChonFile.Text = "File";
            this.btnChonFile.UseVisualStyleBackColor = false;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // lblEncryptedFilename
            // 
            this.lblEncryptedFilename.AutoSize = true;
            this.lblEncryptedFilename.Location = new System.Drawing.Point(13, 78);
            this.lblEncryptedFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncryptedFilename.Name = "lblEncryptedFilename";
            this.lblEncryptedFilename.Size = new System.Drawing.Size(0, 30);
            this.lblEncryptedFilename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.TabIndex = 8;
            // 
            // BoxTextCrypt
            // 
            this.BoxTextCrypt.Controls.Add(this.btnSaveFileGM);
            this.BoxTextCrypt.Controls.Add(this.btnChonFileGM);
            this.BoxTextCrypt.Controls.Add(this.txtBanRo2);
            this.BoxTextCrypt.Controls.Add(this.txtBanMa2);
            this.BoxTextCrypt.Controls.Add(this.txtKhoaFile);
            this.BoxTextCrypt.Controls.Add(this.label5);
            this.BoxTextCrypt.Controls.Add(this.label2);
            this.BoxTextCrypt.Controls.Add(this.btnGiaiMaVanBan);
            this.BoxTextCrypt.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTextCrypt.ForeColor = System.Drawing.Color.Black;
            this.BoxTextCrypt.Location = new System.Drawing.Point(669, 8);
            this.BoxTextCrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxTextCrypt.Name = "BoxTextCrypt";
            this.BoxTextCrypt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxTextCrypt.Size = new System.Drawing.Size(649, 704);
            this.BoxTextCrypt.TabIndex = 26;
            this.BoxTextCrypt.TabStop = false;
            this.BoxTextCrypt.Text = "GIẢI MÃ";
            // 
            // btnSaveFileGM
            // 
            this.btnSaveFileGM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveFileGM.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFileGM.ForeColor = System.Drawing.Color.White;
            this.btnSaveFileGM.Location = new System.Drawing.Point(272, 636);
            this.btnSaveFileGM.Name = "btnSaveFileGM";
            this.btnSaveFileGM.Size = new System.Drawing.Size(143, 50);
            this.btnSaveFileGM.TabIndex = 29;
            this.btnSaveFileGM.Text = "Lưu";
            this.btnSaveFileGM.UseVisualStyleBackColor = false;
            this.btnSaveFileGM.Click += new System.EventHandler(this.btnSaveFileGM_Click);
            // 
            // btnChonFileGM
            // 
            this.btnChonFileGM.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnChonFileGM.Font = new System.Drawing.Font("Cambria", 13F);
            this.btnChonFileGM.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChonFileGM.Location = new System.Drawing.Point(545, 126);
            this.btnChonFileGM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonFileGM.Name = "btnChonFileGM";
            this.btnChonFileGM.Size = new System.Drawing.Size(91, 53);
            this.btnChonFileGM.TabIndex = 28;
            this.btnChonFileGM.Text = "File";
            this.btnChonFileGM.UseVisualStyleBackColor = false;
            this.btnChonFileGM.Click += new System.EventHandler(this.btnChonFileGM_Click);
            // 
            // txtBanRo2
            // 
            this.txtBanRo2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanRo2.Location = new System.Drawing.Point(140, 402);
            this.txtBanRo2.Name = "txtBanRo2";
            this.txtBanRo2.Size = new System.Drawing.Size(382, 205);
            this.txtBanRo2.TabIndex = 25;
            this.txtBanRo2.Text = "";
            // 
            // txtBanMa2
            // 
            this.txtBanMa2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanMa2.Location = new System.Drawing.Point(140, 50);
            this.txtBanMa2.Name = "txtBanMa2";
            this.txtBanMa2.Size = new System.Drawing.Size(382, 216);
            this.txtBanMa2.TabIndex = 24;
            this.txtBanMa2.Text = "";
            // 
            // txtKhoaFile
            // 
            this.txtKhoaFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaFile.Location = new System.Drawing.Point(-89, 45);
            this.txtKhoaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhoaFile.MaxLength = 16;
            this.txtKhoaFile.Name = "txtKhoaFile";
            this.txtKhoaFile.Size = new System.Drawing.Size(73, 37);
            this.txtKhoaFile.TabIndex = 23;
            this.txtKhoaFile.Text = "0123456789ABCDE1";
            this.txtKhoaFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 498);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bản rõ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Bản mã";
            // 
            // btnGiaiMaVanBan
            // 
            this.btnGiaiMaVanBan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGiaiMaVanBan.Font = new System.Drawing.Font("Cambria", 14F);
            this.btnGiaiMaVanBan.ForeColor = System.Drawing.Color.White;
            this.btnGiaiMaVanBan.Location = new System.Drawing.Point(245, 304);
            this.btnGiaiMaVanBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiaiMaVanBan.Name = "btnGiaiMaVanBan";
            this.btnGiaiMaVanBan.Size = new System.Drawing.Size(170, 64);
            this.btnGiaiMaVanBan.TabIndex = 13;
            this.btnGiaiMaVanBan.Text = "Giải mã";
            this.btnGiaiMaVanBan.UseVisualStyleBackColor = false;
            this.btnGiaiMaVanBan.Click += new System.EventHandler(this.btnGiaiMaVanBan_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1354, 750);
            this.tabControl1.TabIndex = 27;
            // 
            // frmMaHoaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 762);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtKhoaVanBan);
            this.Controls.Add(this.ckbCheDoDebug);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMaHoaDES";
            this.Text = "An toàn và bảo mật thông tin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaHoaDES_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyShare)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKey)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.BoxFileCrypt.ResumeLayout(false);
            this.BoxFileCrypt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.BoxTextCrypt.ResumeLayout(false);
            this.BoxTextCrypt.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKhoaVanBan;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ckbCheDoDebug;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtRecoveryKey;
        private System.Windows.Forms.Button btnRecoveryKey;
        private System.Windows.Forms.DataGridView dgvKeyShare;
        private System.Windows.Forms.DataGridViewCheckBoxColumn luaChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi_;
        private System.Windows.Forms.DataGridViewTextBoxColumn pi_;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn pi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShareKey;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtMinKey;
        private System.Windows.Forms.TextBox txtMaxKey;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox BoxFileCrypt;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnChuyenGM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtVanBanDich;
        private System.Windows.Forms.RichTextBox txtVanBanNguon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnMaHoaVanBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label lblEncryptedFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox BoxTextCrypt;
        private System.Windows.Forms.Button btnSaveFileGM;
        private System.Windows.Forms.Button btnChonFileGM;
        private System.Windows.Forms.RichTextBox txtBanRo2;
        private System.Windows.Forms.RichTextBox txtBanMa2;
        private System.Windows.Forms.TextBox txtKhoaFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiaiMaVanBan;
        private System.Windows.Forms.TabControl tabControl1;
    }
}