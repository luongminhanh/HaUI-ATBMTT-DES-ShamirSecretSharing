using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaHoaDES.DoiTuong;
using AOC.ThuVien;
using System.IO;
using Microsoft.Office.Interop.Word;

using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MaHoaDES.BieuMau
{
    public partial class frmMaHoaDES : Form
    {
        public frmMaHoaDES()
        {
            InitializeComponent();
        }       
        private void EnableHoacDisableNut(bool b)
        {
            btnChonFile.Enabled = btnGiaiMaFile.Enabled = btnGiaiMaVanBan.Enabled = btnMaHoaFile.Enabled = btnMaHoaVanBan.Enabled = b;
        }
        int MaHoaHayGiaiMa = 1;
        bool FileHayChuoi = false;
        DES64Bit MaHoaDES64;
        Khoa Khoa;
        Thread thread;
        private void Chay()
        {
            ThreadStart start= new ThreadStart(MaHoa);
            thread = new Thread(start);
            thread.Start();
        }
       
        private void MaHoa()
        {
            //try
            //{
                string fileDichPath = openFileDialog1.FileName.Replace(".", "_2.");
                MaHoaDES64 = new DES64Bit();
                if (!ckbCheDoDebug.Checked)
                {
                    EnableHoacDisableNut(false);
                    progressBar1.Value = 10;
                    timer1.Enabled = true;
                }
            
                TenTienTrinh = "";
                 
                GiaiDoan = 0;
                Dem = 0;
               
                if (FileHayChuoi)
                {
                    Khoa = new Khoa(txtKhoaFile.Text);
                    if (MaHoaHayGiaiMa == 1)
                    {
                        GiaiDoan = 0;
                        ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(openFileDialog1.FileName);
                        GiaiDoan = 1;
                        ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, 1);
                        GiaiDoan = 2;
                        DocFileTxt.WriteBinaryToFile(fileDichPath, KQ);                        
                        GiaiDoan = 3;
                        MessageBox.Show("Mã hóa file thành công");
                }
                    else
                    {
                        GiaiDoan = 0;
                        ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(openFileDialog1.FileName);
                        GiaiDoan = 1;
                        ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, -1);
                        if (KQ == null)
                        {
                            MessageBox.Show("Lỗi giải mã. kiểm tra khóa ");
                            return;
                        }
                        GiaiDoan = 2;
                        DocFileTxt.WriteBinaryToFile(fileDichPath, KQ);

                        GiaiDoan = 3;
                        MessageBox.Show("Giải mã file thành công");
                    }
                }
                else
                {
                    Khoa = new Khoa(txtKhoaVanBan.Text);
                    if (MaHoaHayGiaiMa == 1)
                    {

                        MaHoaDES64 = new DES64Bit();
                        GiaiDoan = 0;
                        GiaiDoan = 1;
                        string kq=MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon.Text, 1);
                        txtVanBanDich.Text = kq;
                        GiaiDoan = 2;
                        GiaiDoan = 3;
                        MessageBox.Show("Mã hóa chuỗi thành công");
                    }
                    else
                    {
                        MaHoaDES64 = new DES64Bit();
                        GiaiDoan = 0;
                        GiaiDoan = 1;
                        string kq = MaHoaDES64.ThucHienDESText(Khoa, txtVanBanNguon.Text, -1);
                        txtVanBanDich.Text = kq;
                        if (kq == "")
                        {
                            return;
                        }
                        GiaiDoan = 2;
                        GiaiDoan = 3;
                        MessageBox.Show("Giải mã chuỗi thành công");
                    }
                }
               /* if (!ckbCheDoDebug.Checked)
                {
                    EnableHoacDisableNut(true);
                    timer1.Enabled = false;
                }*/
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.ToString()); 
            //}
            
        }

        private void txtMaHoaVanBan_Click(object sender, EventArgs e)
        {
            FileHayChuoi = false;
            MaHoaHayGiaiMa = 1;
            EnableHoacDisableNut(false);
            MaHoa();
            EnableHoacDisableNut(true);
        }

        private void txtGiaiMaVanBan_Click(object sender, EventArgs e)
        {

            FileHayChuoi = false;
            MaHoaHayGiaiMa = -1;
            EnableHoacDisableNut(false);
            MaHoa();
            EnableHoacDisableNut(true);
        }

        private void btnMaHoaFile_Click(object sender, EventArgs e)
        {
            
            FileHayChuoi = true;
            MaHoaHayGiaiMa = 1;
            EnableHoacDisableNut(false);
            using (StreamWriter writer = new StreamWriter(openFileDialog1.FileName.Replace(".", "_2."), true))
            {
                // Ghi dữ liệu vào cuối file
                writer.Write("");
                //writer.Flush();
                //writer.Close();
            }
            //txtFileDich.Text = File.ReadAllText(openFileDialog1.FileName.Replace(".", "_2."));
            Chay();
            //txtFileDich.Text = File.ReadAllText(openFileDialog1.FileName.Replace(".", "_2."));

            //string dataToWrite = "Hello, world!"; // Dữ liệu bạn muốn ghi vào file

            // Tạo một đối tượng StreamWriter để ghi dữ liệu vào cuối file

            //string fileDichPath = openFileDialog1.FileName.Replace(".", "_2.");

            ChuoiNhiPhan chuoiDich = DocFileTxt.FileReadToBinary(openFileDialog1.FileName.Replace(".", "_2."));
            Khoa = new Khoa(txtKhoaFile.Text);
                  ChuoiNhiPhan KQDich = MaHoaDES64.ThucHienDES(Khoa, chuoiDich, 1);
               DocFileTxt.WriteBinaryToFile(openFileDialog1.FileName.Replace(".", "_2."), KQDich);

            //string filePathTemp = openFileDialog1.FileName.Replace(".", "_2.");
            byte[] MangByte = new byte[KQDich.MangNhiPhan.Length / 8];
            for (int i = 0; i < KQDich.MangNhiPhan.Length / 8; i++)
            {
                MangByte[i] = (byte)ChuoiNhiPhan.ChuyenMangSangByte(KQDich.MangNhiPhan, i * 8, i * 8 + 8);
            }
            File.WriteAllBytes(openFileDialog1.FileName.Replace(".", "_2."), MangByte);
            txtFileDich.Text = File.ReadAllText(openFileDialog1.FileName.Replace(".", "_2."));


            if (ckbCheDoDebug.Checked)EnableHoacDisableNut(true);
        }

        private void btnGiaiMaFile_Click(object sender, EventArgs e)
        {
            FileHayChuoi = true;
            MaHoaHayGiaiMa = -1;
            EnableHoacDisableNut(false);
            Chay();
            ChuoiNhiPhan chuoiDichGiaiMa = DocFileTxt.FileReadToBinary(openFileDialog1.FileName);
            GiaiDoan = 1;
            ChuoiNhiPhan KQGiaiMa = MaHoaDES64.ThucHienDES(Khoa, chuoiDichGiaiMa, -1);
            if (KQGiaiMa == null)
            {
                MessageBox.Show("Lỗi giải mã. kiểm tra khóa ");
                return;
            }
            GiaiDoan = 2;
            DocFileTxt.WriteBinaryToFile(openFileDialog1.FileName.Replace("_2.", "_2_2."), KQGiaiMa);
            byte[] MangByteGiaiMa = new byte[KQGiaiMa.MangNhiPhan.Length / 8];
            for (int i = 0; i < KQGiaiMa.MangNhiPhan.Length / 8; i++)
            {
                MangByteGiaiMa[i] = (byte)ChuoiNhiPhan.ChuyenMangSangByte(KQGiaiMa.MangNhiPhan, i * 8, i * 8 + 8);
            }
            File.WriteAllBytes(openFileDialog1.FileName.Replace(".", "_2."), MangByteGiaiMa);
            txtFileDich.Text = File.ReadAllText(openFileDialog1.FileName.Replace("_2.", "_2_2."));
            if (ckbCheDoDebug.Checked) EnableHoacDisableNut(true);
        }
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            txtFileNguon.Clear();
            txtFileDich.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".doc" ||
                    Path.GetExtension(openFileDialog1.FileName) == ".docx")
                {
                    MessageBox.Show("Đã mở file word");
                    dynamic word = Activator.CreateInstance(Type.GetTypeFromProgID("Word.Application"));
                    word.Visible = false;
                    //Document doc = word.Documents.Open(openFileDialog1.FileName);
                    //string text = doc.Content.Text;
                    //doc.Close();
                    //word.Quit();
                    //txtFileNguon.Text = text;
                    
                    /*Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
                    object fileName = openFileDialog1.FileName;
                    object readOnly = true;
                    object isVisible = false;
                    object missing = System.Reflection.Missing.Value;
                    doc = word.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible, ref missing, ref missing, ref missing, ref missing);

                    // Lấy nội dung và định dạng của tệp Word
                    string content = "";
                    foreach (Microsoft.Office.Interop.Word.Range range in doc.StoryRanges)
                    {
                        content += range.Text;
                    }
                    string fontName = doc.Content.Font.Name;
                    int fontSize = Convert.ToInt32(doc.Content.Font.Size);
                    bool isBold = doc.Content.Font.Bold==-1;
                    bool isItalic = doc.Content.Font.Italic==-1;
                    bool isUnderline = doc.Content.Font.Underline == Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineSingle;
                    Microsoft.Office.Interop.Word.WdColor fontColor = doc.Content.Font.Color;
                    Microsoft.Office.Interop.Word.WdColor backgroundColor = doc.Content.Shading.BackgroundPatternColor;

                    // Hiển thị nội dung và định dạng trong RichTextBox
                    txtFileNguon.Text = content;
                    txtFileNguon.Font = new System.Drawing.Font(fontName, fontSize, isBold ? FontStyle.Bold : FontStyle.Regular, 
                        GraphicsUnit.Point); txtFileNguon.ForeColor = ColorTranslator.FromOle((int)fontColor);
                    txtFileNguon.BackColor = ColorTranslator.FromOle((int)backgroundColor);
                    txtFileNguon.SelectionStart = 0;
                    txtFileNguon.SelectionLength = 0;

                    // Đóng tệp Word và giải phóng đối tượng
                    doc.Close(ref missing, ref missing, ref missing);
                    word.Quit(ref missing, ref missing, ref missing);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(doc);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(word);
                    */

                }
                else
                {
                    //txtFileNguon.Text = openFileDialog1.FileName;
                    string filePath = openFileDialog1.FileName;

                    // Đọc nội dung của file
                    string text = File.ReadAllText(filePath);

                    // Hiển thị nội dung vào TextBox
                    txtFileNguon.Text = text;
                    //txtFileDich.Text = openFileDialog1.FileName.Replace(".", "_2.");
                    /* string fileDichPath = openFileDialog1.FileName.Replace(".", "_2.");
                     txtFileDich.Text = File.ReadAllText(fileDichPath);*/
                }
            }
        }
        public static string TenTienTrinh="";
        public static int GiaiDoan = -1;
        private static int Dem = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            if (GiaiDoan != -1)
                Dem++;
            if (GiaiDoan == 0)
            {
       
                if (Dem > 200)
                    Dem = 200;
            }
            else if (GiaiDoan == 1)
            {
                if (Dem < 200)
                    Dem = 200;
                if (Dem > 600)
                    Dem = 600;
               
            }
            else if (GiaiDoan == 2)
            {
                if (Dem < 600)
                    Dem = 600;
                if (Dem >= 900)
                    Dem = 900;
                 
            }
            else if (GiaiDoan == 3)
            {
                Dem = 1000;
                
            }
            progressBar1.Value = Dem;
        }

        private void frmMaHoaDES_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread!=null && thread.ThreadState == ThreadState.Running)
                thread.Abort();
            //e.Cancel = DangChay;
        }

        private void txtKhoaFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !(ChuoiHexa.BoHexa.Contains(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txtFileDich_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVanBanNguon.Text = txtVanBanDich.Text;
            txtVanBanDich.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
