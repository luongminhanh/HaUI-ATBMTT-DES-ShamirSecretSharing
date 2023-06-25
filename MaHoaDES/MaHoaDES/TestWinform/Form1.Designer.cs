namespace TestWinform
{
    partial class Form_Test
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTenSV = new TextBox();
            dateOfBirth = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTenMon1 = new TextBox();
            txtDiemMon1 = new TextBox();
            txtHeSoMon1 = new TextBox();
            txtHeSoMon2 = new TextBox();
            txtDiemMon2 = new TextBox();
            txtTenMon2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtHeSoMon3 = new TextBox();
            txtDiemMon3 = new TextBox();
            txtTenMon3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtTongDiem = new TextBox();
            btnKiemTra = new Button();
            btnLamMoi = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 28);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhập thông tin sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 129);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập ngày tháng năm sinh";
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(213, 82);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(312, 27);
            txtTenSV.TabIndex = 3;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Format = DateTimePickerFormat.Short;
            dateOfBirth.Location = new Point(213, 129);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(122, 27);
            dateOfBirth.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 188);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Môn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 191);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 6;
            label4.Text = "Điểm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(562, 195);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 7;
            label5.Text = "Hệ số";
            // 
            // txtTenMon1
            // 
            txtTenMon1.Location = new Point(73, 188);
            txtTenMon1.Name = "txtTenMon1";
            txtTenMon1.Size = new Size(191, 27);
            txtTenMon1.TabIndex = 8;
            // 
            // txtDiemMon1
            // 
            txtDiemMon1.Location = new Point(389, 191);
            txtDiemMon1.Name = "txtDiemMon1";
            txtDiemMon1.Size = new Size(97, 27);
            txtDiemMon1.TabIndex = 9;
            // 
            // txtHeSoMon1
            // 
            txtHeSoMon1.Location = new Point(631, 191);
            txtHeSoMon1.Name = "txtHeSoMon1";
            txtHeSoMon1.Size = new Size(69, 27);
            txtHeSoMon1.TabIndex = 10;
            // 
            // txtHeSoMon2
            // 
            txtHeSoMon2.Location = new Point(631, 250);
            txtHeSoMon2.Name = "txtHeSoMon2";
            txtHeSoMon2.Size = new Size(69, 27);
            txtHeSoMon2.TabIndex = 16;
            // 
            // txtDiemMon2
            // 
            txtDiemMon2.Location = new Point(389, 250);
            txtDiemMon2.Name = "txtDiemMon2";
            txtDiemMon2.Size = new Size(97, 27);
            txtDiemMon2.TabIndex = 15;
            // 
            // txtTenMon2
            // 
            txtTenMon2.Location = new Point(73, 247);
            txtTenMon2.Name = "txtTenMon2";
            txtTenMon2.Size = new Size(191, 27);
            txtTenMon2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(562, 254);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 13;
            label6.Text = "Hệ số";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 250);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 12;
            label7.Text = "Điểm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 247);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 11;
            label8.Text = "Môn";
            // 
            // txtHeSoMon3
            // 
            txtHeSoMon3.Location = new Point(631, 310);
            txtHeSoMon3.Name = "txtHeSoMon3";
            txtHeSoMon3.Size = new Size(69, 27);
            txtHeSoMon3.TabIndex = 22;
            // 
            // txtDiemMon3
            // 
            txtDiemMon3.Location = new Point(389, 310);
            txtDiemMon3.Name = "txtDiemMon3";
            txtDiemMon3.Size = new Size(97, 27);
            txtDiemMon3.TabIndex = 21;
            // 
            // txtTenMon3
            // 
            txtTenMon3.Location = new Point(73, 307);
            txtTenMon3.Name = "txtTenMon3";
            txtTenMon3.Size = new Size(191, 27);
            txtTenMon3.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(562, 314);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 19;
            label9.Text = "Hệ số";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(338, 310);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 18;
            label10.Text = "Điểm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 307);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 17;
            label11.Text = "Môn";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 354);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 23;
            label12.Text = "Tổng điểm";
            // 
            // txtTongDiem
            // 
            txtTongDiem.Enabled = false;
            txtTongDiem.Location = new Point(99, 351);
            txtTongDiem.Name = "txtTongDiem";
            txtTongDiem.Size = new Size(125, 27);
            txtTongDiem.TabIndex = 24;
            // 
            // btnKiemTra
            // 
            btnKiemTra.Location = new Point(99, 396);
            btnKiemTra.Name = "btnKiemTra";
            btnKiemTra.Size = new Size(125, 41);
            btnKiemTra.TabIndex = 25;
            btnKiemTra.Text = "Kiểm tra";
            btnKiemTra.UseVisualStyleBackColor = true;
            btnKiemTra.Click += btnKiemTra_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(323, 396);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(117, 41);
            btnLamMoi.TabIndex = 26;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(543, 396);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 41);
            btnThoat.TabIndex = 27;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form_Test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnLamMoi);
            Controls.Add(btnKiemTra);
            Controls.Add(txtTongDiem);
            Controls.Add(label12);
            Controls.Add(txtHeSoMon3);
            Controls.Add(txtDiemMon3);
            Controls.Add(txtTenMon3);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(txtHeSoMon2);
            Controls.Add(txtDiemMon2);
            Controls.Add(txtTenMon2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtHeSoMon1);
            Controls.Add(txtDiemMon1);
            Controls.Add(txtTenMon1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateOfBirth);
            Controls.Add(txtTenSV);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form_Test";
            Text = "Form1";
            Load += Form_Test_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtTenSV;
        private DateTimePicker dateOfBirth;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTenMon1;
        private TextBox txtDiemMon1;
        private TextBox txtHeSoMon1;
        private TextBox txtHeSoMon2;
        private TextBox txtDiemMon2;
        private TextBox txtTenMon2;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtHeSoMon3;
        private TextBox txtDiemMon3;
        private TextBox txtTenMon3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtTongDiem;
        private Button btnKiemTra;
        private Button btnLamMoi;
        private Button btnThoat;
    }
}