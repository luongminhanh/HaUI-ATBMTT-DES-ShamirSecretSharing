using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Controls;
using MaHoaDES.DoiTuong;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using AOC.ThuVien;
using System.IO;
using System.Threading;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography;
using Font = DocumentFormat.OpenXml.Wordprocessing.Font;
using SecretSharingDotNet.Cryptography;
using SecretSharingDotNet.Math;
using System.Numerics;
using Microsoft.Office.Interop.Word;
using Xceed.Document.NET;





namespace MaHoaDES.BieuMau
{
    public partial class frmMaHoaDES : Form
    {
        public frmMaHoaDES()
        {
            InitializeComponent();
         //   dataGridView1.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridView2_RowsAdded);
        }
        private void EnableHoacDisableNut(bool b)
        {
            //btnChonFile.Enabled  = btnGiaiMaVanBan.Enabled =  btnMaHoaVanBan.Enabled = b;
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

        private string filepath;
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            txtVanBanNguon.Clear();
            txtVanBanDich.Clear();
            txtBanMa2.Clear();
            txtBanRo2.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".doc" ||
                    Path.GetExtension(openFileDialog1.FileName) == ".docx")
                {
                    flag1 = "fileDoc";
                    string path = openFileDialog1.FileName;
                    filepath = path;
                    MessageBox.Show("Đã mở file word" + filepath);
                    //
                   /* FileHayChuoi = true;
                    using (var doc = WordprocessingDocument.Open(@"C:\path\to\document.docx", false))
                    {
                        var converter = new WmlToRtfConverter();
                        var rtf = converter.Convert(doc.MainDocumentPart.Document);
                        txtVanBanNguon.Rtf = rtf;
                    }
                   */
                }

                else
                {
                    MessageBox.Show("Mở file txt");
                    flag1 = "fileTxt";
                    //txtFileNguon.Text = openFileDialog1.FileName;
                    string filePath = openFileDialog1.FileName;

                    // Đọc nội dung của file
                    string text = File.ReadAllText(filePath);

                    // Hiển thị nội dung vào TextBox
                    txtVanBanNguon.Text = text;
                }
            }
        }
        private void UpdateTxtVanBanDich(string text)
        {
            if (txtBanRo2.InvokeRequired)
            {
                txtBanRo2.Invoke(new Action<string>(UpdateTxtVanBanDich), text);
            }
            else
            {
                txtBanRo2.Text = text;
            }
        }

        private void MaHoa()
        {
            MaHoaDES64 = new DES64Bit();

            TenTienTrinh = "";

            GiaiDoan = 0;
            Dem = 0;
            if (FileHayChuoi)
            {
                Khoa = new Khoa(txtKhoaFile.Text);
                if (MaHoaHayGiaiMa == 1)
                {
                    GiaiDoan = 0;
                    ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(filepath);
                    GiaiDoan = 1;
                    ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, 1);
                    GiaiDoan = 2;
                    DocFileTxt.WriteBinaryToFile(filepath.Replace(".", "_2."), KQ);
                    UpdateTxtVanBanDich(filepath);
                    GiaiDoan = 3;
                    MessageBox.Show("Mã hóa file thành công");
                }
                else
                {
                    GiaiDoan = 0;
                    ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(filepath);
                    GiaiDoan = 1;
                    ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, -1);
                    if (KQ == null)
                    {
                        MessageBox.Show("Lỗi giải mã. kiểm tra khóa ");
                        return;
                    }
                    GiaiDoan = 2;
                    DocFileTxt.WriteBinaryToFile(filepath.Replace(".", "_2."), KQ);

                    GiaiDoan = 3;
                    MessageBox.Show("Giải mã file thành công");

                    if (flag1 == "fileDoc")
                    {
                        MessageBox.Show("Đã mở file word" + filepath);
                        //
                        
                        FileHayChuoi = true;
                        object readOnly = false;
                        object visible = true;
                        object save = false;
                        object missing = Type.Missing;
                        string filepath1 = filepath.Replace(".", "_2.");
                        object fileName = filepath1;
                        object newTemplate = false;
                        object docType = 0;
                        Microsoft.Office.Interop.Word._Document document;
                        Microsoft.Office.Interop.Word._Application application = new Microsoft.Office.Interop.Word.Application() { Visible = false };
                        document = application.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                            ref missing, ref visible, ref missing, ref missing, ref missing, ref missing);
                        document.ActiveWindow.Selection.WholeStory();
                        document.ActiveWindow.Selection.Copy();
                        IDataObject dataObject = Clipboard.GetDataObject();
                        if (dataObject != null)
                        {
                            txtBanRo2.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Null");
                        }
                        //txtBanRo2.Rtf = dataObject.GetData(DataFormats.Rtf).ToString();
                        application.Quit(ref missing, ref missing, ref missing);
                    }
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
                        string kq = MaHoaDES64.ThucHienDESText(Khoa, txtBanMa2.Text, -1);
                        txtBanRo2.Text = kq;
                        if (kq == "")
                        {
                            return;
                        }
                        GiaiDoan = 2;
                        GiaiDoan = 3;
                        MessageBox.Show("Giải mã chuỗi thành công");
                    }
                }
                if (!ckbCheDoDebug.Checked)
                {
                    EnableHoacDisableNut(true);
                    timer1.Enabled = false;
                }            
        }

        string flag = "";
        private void txtMaHoaVanBan_Click(object sender, EventArgs e)
        {
            if ((flag == "nhap" && flag1=="") || flag1 == "fileTxt")
            {
                FileHayChuoi = false;
                MaHoaHayGiaiMa = 1;
                MaHoa();
            }
            else if (flag1=="fileDoc")
            {
                FileHayChuoi = true;
                MaHoaHayGiaiMa = 1;
                Chay();
            }    
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
            }
       
            Chay();

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
            //txtFileDich.Text = File.ReadAllText(openFileDialog1.FileName.Replace("_2.", "_2_2."));
            if (ckbCheDoDebug.Checked) EnableHoacDisableNut(true);
        }

        private void txtVanBanNguon_TextChanged(object sender, EventArgs e)
        {
            flag = "nhap";
        }

        string flag1 = "";
       
        public static string TenTienTrinh="";
        public static int GiaiDoan = -1;
        private static int Dem = 0;

        private void frmMaHoaDES_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread!=null && thread.ThreadState == ThreadState.Running)
                thread.Abort();
        }

        private void txtKhoaFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !(ChuoiHexa.BoHexa.Contains(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtVanBanNguon.Text = txtVanBanDich.Text;
            txtVanBanDich.Text = "";
        }      

        private void btnChuyenGM_Click(object sender, EventArgs e)
        {
            txtBanMa2.Text = txtVanBanDich.Text;
        }

      

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại SaveFileDialog để chọn đường dẫn và tên file lưu trữ
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = ("Text files (*.txt)|*.txt");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Mở file để ghi nội dung
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    // Lưu nội dung của RichTextBox dưới định dạng văn bản thuần túy
                    sw.Write(txtVanBanDich.Text);
                }
            }
            MessageBox.Show("Lưu file thành công");
        }
        private void btnChonFileGM_Click(object sender, EventArgs e)
        {
            txtVanBanNguon.Clear();
            txtVanBanDich.Clear();
            txtBanMa2.Clear();
            txtBanRo2.Clear();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".doc" ||
                    Path.GetExtension(openFileDialog1.FileName) == ".docx")
                {
                    flag1 = "fileDoc";
                    string path = openFileDialog1.FileName;
                    filepath = path;
                    MessageBox.Show("Đã mở file word" + filepath);
                    FileHayChuoi = true;
                    MessageBox.Show("Đã chọn file để giải mã");
                }
                else
                {
                    flag1 = "fileTxt";
                    //txtFileNguon.Text = openFileDialog1.FileName;
                    string filePath = openFileDialog1.FileName;

                    // Đọc nội dung của file
                    string text = File.ReadAllText(filePath);

                    // Hiển thị nội dung vào TextBox
                    txtBanMa2.Text = text;
                }
            }
        }

        private void btnSaveFileGM_Click(object sender, EventArgs e)
        {
            if (flag1 == "fileTxt")
            {
                // Đang mở file plain text
                MessageBox.Show("Lưu file txt");
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = ("Text files (*.txt)|*.txt");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Mở file để ghi nội dung
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        // Lưu nội dung của RichTextBox dưới định dạng văn bản thuần túy
                        sw.Write(txtBanRo2.Text);
                    }
                }
                MessageBox.Show("Lưu file thành công");
            }
        }

        private void btnGiaiMaVanBan_Click(object sender, EventArgs e)
        {
            
            if ((flag=="nhap" && flag1=="") || (flag=="fileTxt"))
            FileHayChuoi = false;
            MaHoaHayGiaiMa = -1;
            EnableHoacDisableNut(false);
            MaHoa();
            EnableHoacDisableNut(true);
            
        }

        private bool BeforeClickButtonHanlder()
        {
            if (string.IsNullOrWhiteSpace(txtSecretKey.Text)
                || string.IsNullOrWhiteSpace(txtMaxKey.Text)
                || string.IsNullOrWhiteSpace(txtMinKey.Text)
                || string.IsNullOrWhiteSpace(txtMaxKey.Text)
                || string.IsNullOrWhiteSpace(txtP.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void txtSNT_TextChanged(object sender, EventArgs e)
        {

        }

        private int modInverse(int a, int m)
        {
            int y = 0, x = 1, m0 = m;
            while (a > 1)
            {
                int q = a / m;
                int t = m;
                m = a % m;
                a = t;
                t = y;
                y = x - q * y;
                x = t;
            }
            if (x < 0) x += m0;
            return x;
        }

        static Boolean isPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return false;
            }
            // check so nguyen to khi n >= 2
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnShareKey_Click_1(object sender, EventArgs e)
        {
            dgvKey.Rows.Clear();
            dgvKeyShare.Rows.Clear();
            // Khóa bí mật
            var secretKey = BigInteger.Parse(txtSecretKey.Text);
         
            // Số người giữ khóa
            var maxKey = int.Parse(txtMaxKey.Text);

            // Số người tối thiểu để khôi phục khóa
            var minKey = int.Parse(txtMinKey.Text);

            // Mảng các giá trị random a
            BigInteger[] a = new BigInteger[minKey];
            for (int i = 0; i < minKey-1; i++)
            {
                a[i] = i+1;
            }

            // Mảng các chỉ số đầu của khóa chia sẻ 
            BigInteger[] x = new BigInteger[maxKey + 1];
            for (int i = 0; i < maxKey; i++)
            {
                x[i] = i+1;
            }

            // Mảng các chỉ số thứ 2 của khóa chia sẻ
            BigInteger[] y = new BigInteger[maxKey+1];

            BigInteger h;

            for (int i = 0; i < maxKey; i++)
            {
                BigInteger l = 0;
                for (int j = 0; j < minKey - 1; j++)
                {
                    h = BigInteger.Pow(x[i], j+1);
                    l += (a[j] * h);
                }
                BigInteger yShare = secretKey + l;

                // Thêm phần tử tính được vào cặp khóa
                y[i] = yShare;

            }
            dgvKey.Rows.Clear(); // Xóa các hàng cũ trước khi gán giá trị mới

            // Gán giá trị cho dgvKey
            for (int i = 0; i < maxKey; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvKey);
                row.Cells[0].Value = x[i];
                row.Cells[1].Value = y[i];
                dgvKey.Rows.Add(row);
            }
            //Gán giá trị cho dataKeyShare
            for (int i = 0; i < maxKey; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvKeyShare);
                row.Cells[1].Value = x[i];
                row.Cells[2].Value = y[i];
                dgvKeyShare.Rows.Add(row);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSecretKey.Clear();
            txtMaxKey.Clear();
            txtMinKey.Clear();
            txtP.Clear();
            txtRecoveryKey.Text = "";
            dgvKey.Rows.Clear();
            dgvKeyShare.Rows.Clear();
        }
       
        private void btnRecoveryKey_Click(object sender, EventArgs e)
        {
            //Lấy ra các cặp để khôi phục khóa
            // Số nguyên tố p
            var p = BigInteger.Parse(txtP.Text);

            // Số người tối thiểu để khôi phục khóa
            var minKey = int.Parse(txtMinKey.Text);

            //Giá trị x[i] đã trao 
            List<int> x = new List<int>();
            List<float> y = new List<float>();
            // Duyệt qua tất cả các dòng của dgvKeyShare
            int k = 0;
            foreach (DataGridViewRow row in dgvKeyShare.Rows)
            {
                // Lấy giá trị của ô checkbox tại cột đầu tiên
                DataGridViewCheckBoxCell chk1 = (DataGridViewCheckBoxCell)row.Cells[0];

                // Nếu giá trị của ô checkbox là true, lấy giá trị của ô tương ứng tại cột thứ 2 và lưu vào mảng
                if (chk1?.Value != null && (bool)chk1.Value == true)
                {
                    string value = dgvKeyShare.Rows[k].Cells[2].Value.ToString();
                    y.Add(float.Parse(value));
                    string value2 = dgvKeyShare.Rows[k].Cells[1].Value.ToString();
                    x.Add(int.Parse(value2));
                }
                k++;
            }

            if (x.Count() < minKey)
            {
                MessageBox.Show("Chưa đủ thành viên để khôi phục khóa");
            }
            else
            {
                double k1 = 0;
                for (int l = 0; l < minKey; l++)
                {
                    float m = 1;
                    for (int j = 0; j < minKey; j++)
                    {
                        if (j != l)
                        {
                            float b = x[j] - x[l];
                            float n = x[j] / b;
                            m *= n;
                        }
                    }
                    k1 += y[l] * m;
                }
                k1 = Math.Round(k1);
                txtRecoveryKey.Text = "Khóa khôi phục được là " + k1.ToString();
            }

        }
    }
}
