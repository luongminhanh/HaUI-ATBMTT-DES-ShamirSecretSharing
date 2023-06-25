namespace TestWinform
{
    partial class Form2
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
            btnThoat = new Button();
            txtWord = new RichTextBox();
            btnOpen = new Button();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(691, 554);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 49);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(87, 36);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(943, 484);
            txtWord.TabIndex = 6;
            txtWord.Text = "";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(316, 554);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(122, 50);
            btnOpen.TabIndex = 7;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 647);
            Controls.Add(btnOpen);
            Controls.Add(txtWord);
            Controls.Add(btnThoat);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnThoat;
        private RichTextBox txtWord;
        private Button btnOpen;
    }
}