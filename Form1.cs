using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtSo1.Text);
            double so2 = Convert.ToDouble(txtSo2.Text);

            double kq = so1 + so2;
            txtKQ.Text = kq.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtSo1.Text);
            double so2 = Convert.ToDouble(txtSo2.Text);

            double kq = so1 - so2;
            txtKQ.Text = kq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtSo1.Text);
            double so2 = Convert.ToDouble(txtSo2.Text);

            double kq = so1 * so2;
            txtKQ.Text = kq.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double so1 = Convert.ToDouble(txtSo1.Text);
            double so2 = Convert.ToDouble(txtSo2.Text);



            if (so2 == 0)
            {
                // báo lỗi không thể chia cho 0
                txtKQ.Text = " không thể chia cho 0";
            }
            else
            { // ngược lại chia và hiện kết quả                   
                double kq = so1 / so2;                   
                txtKQ.Text = kq.ToString();
            }
        }
    }
}
