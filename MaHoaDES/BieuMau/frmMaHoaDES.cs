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
                    FileHayChuoi = true;
                  
                            using (WordprocessingDocument wordDocument = WordprocessingDocument.Open(path, false))
                            {
                        Body body = wordDocument.MainDocumentPart.Document.Body;
                        string text = body.InnerText;

                        // Lấy tất cả các đối tượng Run trong phần Body của tài liệu Word
                        var runs = body.Descendants<Run>();

                        // Hiển thị nội dung văn bản giống như trong file Word, bao gồm định dạng văn bản
                        foreach (var run in runs)
                        {
                            string runText = run.InnerText;
                            var runProperties = run.RunProperties;

                            // Tạo một đối tượng Font để lưu trữ các thuộc tính font chữ
                            Font font = new Font();

                            // Nếu đối tượng Run có thuộc tính Bold, đặt thuộc tính Bold của Font thành true
                            if (runProperties.Bold != null)
                            {
                                // Đối tượng Run được định dạng in đậm
                                txtVanBanNguon.SelectionFont = new System.Drawing.Font(txtVanBanNguon.Font, FontStyle.Bold);
                            }
                            else
                            {
                                // Đối tượng Run không được định dạng in đậm
                                txtVanBanNguon.SelectionFont = new System.Drawing.Font(txtVanBanNguon.Font, FontStyle.Regular);
                            }


                            // Nếu đối tượng Run có thuộc tính Italic, đặt thuộc tính Italic của Font thành true
                            if (runProperties.Italic != null)
                            {
                                txtVanBanNguon.SelectionFont = new System.Drawing.Font(txtVanBanNguon.Font, FontStyle.Italic);
                            }
                            else
                            {
                                txtVanBanNguon.SelectionFont = new System.Drawing.Font(txtVanBanNguon.Font, FontStyle.Regular);
                            } 
                            

                            // Nếu đối tượng Run có thuộc tính Underline, đặt thuộc tính Underline của Font thành true
                            if (runProperties.Underline != null && runProperties.Underline.Val != null)
                            {
                                txtVanBanNguon.SelectionFont = new System.Drawing.Font(txtVanBanNguon.Font, FontStyle.Underline);
                            }

                            // Nếu đối tượng Run có thuộc tính Color, đặt thuộc tính Color của Font thành màu chữ được định nghĩa trong tài liệu Word
                            if (runProperties.Color != null)
                            {
                                string colorValue = runProperties.Color.Val.Value;
                                System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("#" + colorValue);
                                txtVanBanNguon.SelectionColor = color;
                            }

                            // Highlight
                            if (runProperties.Shading != null && runProperties.Shading.Fill != null)
                            {
                                string shadingValue = runProperties.Shading.Fill.Value;
                                System.Drawing.Color shadingColor = System.Drawing.ColorTranslator.FromHtml("#" + shadingValue);
                                txtVanBanNguon.SelectionBackColor = shadingColor;
                            }

                            // Kích thước font chữ
                            if (runProperties.FontSize != null)
                            {
                                string fontSizeValue = runProperties.FontSize.Val.Value;
                                double fontSizeInPoints = double.Parse(fontSizeValue) / 2;
                                txtVanBanNguon.SelectionFont = new System.Drawing.Font(txtVanBanNguon.Font.FontFamily, (float)fontSizeInPoints);
                            }
                            // Thêm văn bản và định dạng của nó vào điều khiển RichTextBox
                           
                            txtVanBanNguon.AppendText(runText);
                        }
                    }
                        
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
                    l += a[j] * h;
                    //MessageBox.Show("l = " + l.ToString());
                }
                BigInteger yShare = secretKey + l;
                //MessageBox.Show("yShare = " + yShare.ToString());

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
                float k1 = 0;
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
                txtRecoveryKey.Text = "Khóa khôi phục được là " + k1.ToString();
            }

        }



        /*
        private void frmMaHoaDES_Load(object sender, EventArgs e)
        {
            // Set AutoSizeMode of each column to None
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            // Set AutoSizeMode of all columns to Fill
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns[0].DefaultCellStyle.Format = "F0";
            dataGridView1.Columns[0].ValueType = typeof(double);
            //dataGridView1.Columns[1].DefaultCellStyle.Format = "F0";
            dataGridView1.Columns[1].ValueType = typeof(double);

            double s = double.Parse(txtKhoaBiMat.Text);
            double p = double.Parse(txtSNT.Text);
            //double a1 = double.Parse(txtA1.Text);
            //double a2 = double.Parse(txtA2.Text);
            double x1 = double.Parse(dataGridView1.Rows[0].Cells[0].Value.ToString());
            double x2 = double.Parse(dataGridView1.Rows[1].Cells[0].Value.ToString());
            double x3 = double.Parse(dataGridView1.Rows[2].Cells[0].Value.ToString());
            double x4 = double.Parse(dataGridView1.Rows[3].Cells[0].Value.ToString());
            double x5 = double.Parse(dataGridView1.Rows[4].Cells[0].Value.ToString());

            Random rand = new Random();
            int a1 = rand.Next(1, (int)p);
            int a2 = rand.Next(1, (int)p);
            double s1, s2, s3, s4, s5; //Các mảnh chia cho mỗi thành viên

            // Mảnh 1                  
            s1 = (s + a1 * x1 + a2 * Math.Pow(x1, 2));

            // Mảnh 2                  
            s2 = (s + a1 * x2 + a2 * Math.Pow(x2, 2));

            // Mảnh 3                  
            s3 = (s + a1 * x3 + a2 * Math.Pow(x3, 2));

            // Mảnh 4                 
            s4 = (s + a1 * x4 + a2 * Math.Pow(x4, 2));

            // Mảnh 5                 
            s5 = (s + a1 * x5 + a2 * Math.Pow(x5, 2));

            dataGridView1.Rows[0].Cells[1].Value = s1;
            dataGridView1.Rows[1].Cells[1].Value = s2;
            dataGridView1.Rows[2].Cells[1].Value = s3;
            dataGridView1.Rows[3].Cells[1].Value = s4;
            dataGridView1.Rows[4].Cells[1].Value = s5;


            dataGridView2.Rows[0].Cells[2].Value = s1;
            dataGridView2.Rows[1].Cells[2].Value = s2;
            dataGridView2.Rows[2].Cells[2].Value = s3;
            dataGridView2.Rows[3].Cells[2].Value = s4;
            dataGridView2.Rows[4].Cells[2].Value = s5;

            dataGridView2.Rows[0].Cells[1].Value = x1;
            dataGridView2.Rows[1].Cells[1].Value = x2;
            dataGridView2.Rows[2].Cells[1].Value = x3;
            dataGridView2.Rows[3].Cells[1].Value = x4;
            dataGridView2.Rows[4].Cells[1].Value = x5;

        }

        private void frmMaHoaDES_Load_1(object sender, EventArgs e)
        {
            update();
        }
        public void update()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Lựa chọn";
            chk.Name = "CheckBox";
            dataGridView2.Columns.Insert(0, chk);
        }
        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].GetType() == typeof(DataGridViewCheckBoxCell))
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells[0];
                    checkBoxCell.Value = true;
                }
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();
            List<double> manhKhoa = new List<double>();
            List<double> giaTri = new List<double>();
            List<double> lagrange = new List<double>();

            // Duyệt qua tất cả các dòng của DataGridView
            int k = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                // Lấy giá trị của ô checkbox tại cột đầu tiên
                DataGridViewCheckBoxCell chk1 = (DataGridViewCheckBoxCell)row.Cells[0];

                // Nếu giá trị của ô checkbox là true, lấy giá trị của ô tương ứng tại cột thứ 2 và lưu vào mảng
                if (chk1?.Value != null && (bool)chk1.Value == true)
                {
                    string value = dataGridView2.Rows[k].Cells[2].Value.ToString();
                    manhKhoa.Add(double.Parse(value));
                    //values.Add(value);
                    string value2 = dataGridView2.Rows[k].Cells[1].Value.ToString();
                    giaTri.Add(double.Parse(value2));
                }
                k++;
            }

            lagrange.Add((giaTri[1] / (giaTri[1] - giaTri[0])) * (giaTri[2] / (giaTri[2] - giaTri[0])));
            lagrange.Add((giaTri[0] / (giaTri[0] - giaTri[1])) * (giaTri[2] / (giaTri[2] - giaTri[1])));
            lagrange.Add((giaTri[0] / (giaTri[0] - giaTri[2])) * (giaTri[1] / (giaTri[1] - giaTri[2])));


            double KhoaGoc = manhKhoa[0] * lagrange[0] + manhKhoa[1] * lagrange[1] + manhKhoa[2] * lagrange[2];

            richTextBox1.Text = "Khóa khôi phục được là: " + KhoaGoc.ToString();
        }
        */
    }
}
