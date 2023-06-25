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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BoxTextCrypt = new System.Windows.Forms.GroupBox();
            this.txtVanBanDich = new System.Windows.Forms.RichTextBox();
            this.txtVanBanNguon = new System.Windows.Forms.RichTextBox();
            this.txtKhoaVanBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMaHoaVanBan = new System.Windows.Forms.Button();
            this.btnGiaiMaVanBan = new System.Windows.Forms.Button();
            this.BoxFileCrypt = new System.Windows.Forms.GroupBox();
            this.txtFileDich = new System.Windows.Forms.RichTextBox();
            this.txtFileNguon = new System.Windows.Forms.RichTextBox();
            this.txtKhoaFile = new System.Windows.Forms.TextBox();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.ckbCheDoDebug = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.lblEncryptedFilename = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMaHoaFile = new System.Windows.Forms.Button();
            this.btnGiaiMaFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.BoxTextCrypt.SuspendLayout();
            this.BoxFileCrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(44, 404);
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
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // BoxTextCrypt
            // 
            this.BoxTextCrypt.Controls.Add(this.txtVanBanDich);
            this.BoxTextCrypt.Controls.Add(this.txtVanBanNguon);
            this.BoxTextCrypt.Controls.Add(this.txtKhoaVanBan);
            this.BoxTextCrypt.Controls.Add(this.label4);
            this.BoxTextCrypt.Controls.Add(this.label5);
            this.BoxTextCrypt.Controls.Add(this.label2);
            this.BoxTextCrypt.Controls.Add(this.btnMaHoaVanBan);
            this.BoxTextCrypt.Controls.Add(this.btnGiaiMaVanBan);
            this.BoxTextCrypt.Location = new System.Drawing.Point(651, 20);
            this.BoxTextCrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxTextCrypt.Name = "BoxTextCrypt";
            this.BoxTextCrypt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxTextCrypt.Size = new System.Drawing.Size(574, 558);
            this.BoxTextCrypt.TabIndex = 26;
            this.BoxTextCrypt.TabStop = false;
            this.BoxTextCrypt.Text = "Mã hoá và Giải mã văn bản(Text)";
            // 
            // txtVanBanDich
            // 
            this.txtVanBanDich.Location = new System.Drawing.Point(71, 296);
            this.txtVanBanDich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVanBanDich.Name = "txtVanBanDich";
            this.txtVanBanDich.Size = new System.Drawing.Size(452, 149);
            this.txtVanBanDich.TabIndex = 26;
            this.txtVanBanDich.Text = "";
            // 
            // txtVanBanNguon
            // 
            this.txtVanBanNguon.Location = new System.Drawing.Point(71, 30);
            this.txtVanBanNguon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVanBanNguon.Name = "txtVanBanNguon";
            this.txtVanBanNguon.Size = new System.Drawing.Size(452, 132);
            this.txtVanBanNguon.TabIndex = 26;
            this.txtVanBanNguon.Text = "";
            // 
            // txtKhoaVanBan
            // 
            this.txtKhoaVanBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaVanBan.Location = new System.Drawing.Point(79, 208);
            this.txtKhoaVanBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhoaVanBan.MaxLength = 16;
            this.txtKhoaVanBan.Name = "txtKhoaVanBan";
            this.txtKhoaVanBan.Size = new System.Drawing.Size(444, 29);
            this.txtKhoaVanBan.TabIndex = 17;
            this.txtKhoaVanBan.Text = "0123456789ABCDE1";
            this.txtKhoaVanBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kết quả mã hoá/giải mã";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Khoá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Text : ";
            // 
            // btnMaHoaVanBan
            // 
            this.btnMaHoaVanBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMaHoaVanBan.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoaVanBan.Location = new System.Drawing.Point(94, 479);
            this.btnMaHoaVanBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaHoaVanBan.Name = "btnMaHoaVanBan";
            this.btnMaHoaVanBan.Size = new System.Drawing.Size(169, 41);
            this.btnMaHoaVanBan.TabIndex = 10;
            this.btnMaHoaVanBan.Text = "Mã hoá";
            this.btnMaHoaVanBan.UseVisualStyleBackColor = false;
            this.btnMaHoaVanBan.Click += new System.EventHandler(this.txtMaHoaVanBan_Click);
            // 
            // btnGiaiMaVanBan
            // 
            this.btnGiaiMaVanBan.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGiaiMaVanBan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnGiaiMaVanBan.Location = new System.Drawing.Point(316, 478);
            this.btnGiaiMaVanBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiaiMaVanBan.Name = "btnGiaiMaVanBan";
            this.btnGiaiMaVanBan.Size = new System.Drawing.Size(170, 41);
            this.btnGiaiMaVanBan.TabIndex = 13;
            this.btnGiaiMaVanBan.Text = "Giải mã";
            this.btnGiaiMaVanBan.UseVisualStyleBackColor = false;
            this.btnGiaiMaVanBan.Click += new System.EventHandler(this.txtGiaiMaVanBan_Click);
            // 
            // BoxFileCrypt
            // 
            this.BoxFileCrypt.Controls.Add(this.txtFileDich);
            this.BoxFileCrypt.Controls.Add(this.txtFileNguon);
            this.BoxFileCrypt.Controls.Add(this.txtKhoaFile);
            this.BoxFileCrypt.Controls.Add(this.btnChuyen);
            this.BoxFileCrypt.Controls.Add(this.ckbCheDoDebug);
            this.BoxFileCrypt.Controls.Add(this.groupBox1);
            this.BoxFileCrypt.Controls.Add(this.label9);
            this.BoxFileCrypt.Controls.Add(this.label1);
            this.BoxFileCrypt.Controls.Add(this.label8);
            this.BoxFileCrypt.Controls.Add(this.btnChonFile);
            this.BoxFileCrypt.Controls.Add(this.lblEncryptedFilename);
            this.BoxFileCrypt.Controls.Add(this.label3);
            this.BoxFileCrypt.Controls.Add(this.btnMaHoaFile);
            this.BoxFileCrypt.Controls.Add(this.btnGiaiMaFile);
            this.BoxFileCrypt.Location = new System.Drawing.Point(21, 20);
            this.BoxFileCrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxFileCrypt.Name = "BoxFileCrypt";
            this.BoxFileCrypt.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxFileCrypt.Size = new System.Drawing.Size(622, 558);
            this.BoxFileCrypt.TabIndex = 24;
            this.BoxFileCrypt.TabStop = false;
            this.BoxFileCrypt.Text = "Mã hoá và giải mã 1 file";
            // 
            // txtFileDich
            // 
            this.txtFileDich.Location = new System.Drawing.Point(162, 298);
            this.txtFileDich.Name = "txtFileDich";
            this.txtFileDich.Size = new System.Drawing.Size(416, 98);
            this.txtFileDich.TabIndex = 30;
            this.txtFileDich.Text = "";
            // 
            // txtFileNguon
            // 
            this.txtFileNguon.Font = new System.Drawing.Font("Cambria", 14F);
            this.txtFileNguon.Location = new System.Drawing.Point(64, 22);
            this.txtFileNguon.Name = "txtFileNguon";
            this.txtFileNguon.Size = new System.Drawing.Size(452, 215);
            this.txtFileNguon.TabIndex = 29;
            this.txtFileNguon.Text = "";
            this.txtFileNguon.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtKhoaFile
            // 
            this.txtKhoaFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKhoaFile.Location = new System.Drawing.Point(110, 261);
            this.txtKhoaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhoaFile.MaxLength = 16;
            this.txtKhoaFile.Name = "txtKhoaFile";
            this.txtKhoaFile.Size = new System.Drawing.Size(403, 29);
            this.txtKhoaFile.TabIndex = 23;
            this.txtKhoaFile.Text = "0123456789ABCDE1";
            this.txtKhoaFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhoaFile_KeyPress);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(405, 460);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(94, 44);
            this.btnChuyen.TabIndex = 28;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbCheDoDebug
            // 
            this.ckbCheDoDebug.AutoSize = true;
            this.ckbCheDoDebug.Location = new System.Drawing.Point(8, 360);
            this.ckbCheDoDebug.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbCheDoDebug.Name = "ckbCheDoDebug";
            this.ckbCheDoDebug.Size = new System.Drawing.Size(137, 25);
            this.ckbCheDoDebug.TabIndex = 27;
            this.ckbCheDoDebug.Text = "Chế độ debug";
            this.ckbCheDoDebug.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "File sau khi mã hóa/giải mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "File gốc";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 264);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Khoá";
            // 
            // btnChonFile
            // 
            this.btnChonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChonFile.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnChonFile.Location = new System.Drawing.Point(523, 48);
            this.btnChonFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(91, 40);
            this.btnChonFile.TabIndex = 16;
            this.btnChonFile.Text = "Chọn file";
            this.btnChonFile.UseVisualStyleBackColor = false;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // lblEncryptedFilename
            // 
            this.lblEncryptedFilename.AutoSize = true;
            this.lblEncryptedFilename.Location = new System.Drawing.Point(13, 78);
            this.lblEncryptedFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncryptedFilename.Name = "lblEncryptedFilename";
            this.lblEncryptedFilename.Size = new System.Drawing.Size(0, 21);
            this.lblEncryptedFilename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 8;
            // 
            // btnMaHoaFile
            // 
            this.btnMaHoaFile.Location = new System.Drawing.Point(44, 463);
            this.btnMaHoaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaHoaFile.Name = "btnMaHoaFile";
            this.btnMaHoaFile.Size = new System.Drawing.Size(149, 41);
            this.btnMaHoaFile.TabIndex = 12;
            this.btnMaHoaFile.Text = "Mã hoá file";
            this.btnMaHoaFile.UseVisualStyleBackColor = true;
            this.btnMaHoaFile.Click += new System.EventHandler(this.btnMaHoaFile_Click);
            // 
            // btnGiaiMaFile
            // 
            this.btnGiaiMaFile.Location = new System.Drawing.Point(229, 463);
            this.btnGiaiMaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiaiMaFile.Name = "btnGiaiMaFile";
            this.btnGiaiMaFile.Size = new System.Drawing.Size(149, 41);
            this.btnGiaiMaFile.TabIndex = 11;
            this.btnGiaiMaFile.Text = "Giải mã file";
            this.btnGiaiMaFile.UseVisualStyleBackColor = true;
            this.btnGiaiMaFile.Click += new System.EventHandler(this.btnGiaiMaFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMaHoaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 611);
            this.Controls.Add(this.BoxTextCrypt);
            this.Controls.Add(this.BoxFileCrypt);
            this.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMaHoaDES";
            this.Text = "frmMaHoaDES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMaHoaDES_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.BoxTextCrypt.ResumeLayout(false);
            this.BoxTextCrypt.PerformLayout();
            this.BoxFileCrypt.ResumeLayout(false);
            this.BoxFileCrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox BoxTextCrypt;
        private System.Windows.Forms.TextBox txtKhoaVanBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMaHoaVanBan;
        private System.Windows.Forms.Button btnGiaiMaVanBan;
        private System.Windows.Forms.GroupBox BoxFileCrypt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKhoaFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label lblEncryptedFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMaHoaFile;
        private System.Windows.Forms.Button btnGiaiMaFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtVanBanDich;
        private System.Windows.Forms.RichTextBox txtVanBanNguon;
        private System.Windows.Forms.CheckBox ckbCheDoDebug;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.RichTextBox txtFileNguon;
        private System.Windows.Forms.RichTextBox txtFileDich;
    }
}