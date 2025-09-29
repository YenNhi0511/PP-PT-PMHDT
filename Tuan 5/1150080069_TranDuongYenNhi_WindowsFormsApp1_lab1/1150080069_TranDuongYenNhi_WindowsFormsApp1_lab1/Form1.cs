using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080069_TranDuongYenNhi_WindowsFormsApp1_lab1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double kq = a + b;
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông báo lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double kq = a - b;
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông báo lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                double kq = a * b;
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông báo lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text.Trim());
                double b = Convert.ToDouble(txtB.Text.Trim());
                if (b == 0)
                {
                    MessageBox.Show("Mẫu số khoog dược bằng 0.Nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtB.Text = "";
                    txtB.Focus();
                }
                double kq = a / b;
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thông báo lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtKetQua.Text = string.Empty;
            txtA.Focus();
        }
    }
}
