namespace TestWinform
{
    public partial class Form_Test : Form
    {
        public Form_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenSV.Text = "";
            txtTenMon1.Text = "";
            txtTenMon2.Text = "";
            txtTenMon3.Text = "";
            txtDiemMon1.Text = "";
            txtDiemMon2.Text = "";
            txtDiemMon3.Text = "";
            txtHeSoMon1.Text = "";
            txtHeSoMon2.Text = "";
            txtHeSoMon3.Text = "";
            txtTenSV.Focus();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (txtTenSV.Text == "")
            {
                MessageBox.Show("Chưa nhập tên!");
                txtTenSV.Focus();
                return;
            }
            float DiemTB = (Convert.ToInt32(txtDiemMon1.Text) * Convert.ToInt32(txtHeSoMon1.Text) +
                 Convert.ToInt32(txtDiemMon2.Text) * Convert.ToInt32(txtHeSoMon2.Text) +
                 Convert.ToInt32(txtDiemMon3.Text) * Convert.ToInt32(txtHeSoMon3.Text)) / (
                 Convert.ToInt32(txtHeSoMon1.Text) + Convert.ToInt32(txtHeSoMon2.Text) +
                 Convert.ToInt32(txtHeSoMon3.Text));
            if (DiemTB >= 5) MessageBox.Show("Sinh viên " + txtTenSV.Text + " đỗ" + " với điểm " + DiemTB);
            else MessageBox.Show("Trượt");
        }

        private void Form_Test_Load(object sender, EventArgs e)
        {

        }
    }
}