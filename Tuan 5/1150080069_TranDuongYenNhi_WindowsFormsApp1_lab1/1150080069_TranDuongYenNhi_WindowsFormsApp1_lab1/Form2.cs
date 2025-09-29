using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1150080069_TranDuongYenNhi_WindowsFormsApp1_lab1
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            btnTim.Click += btnTim_Click;
            btnThoat.Click += (s, e) => this.Close();
        }
        private static int USCLN(int a, int b)
        {
            a = Math.Abs(a);//lấy giá trị tuyệt đối
            b = Math.Abs(b);
            //neu a=0 thì kq là b, nếu b=0 thì kq là a
            if (a == 0) return b;
            if (b == 0) return a;
            //vòng lặp
            while (b != 0)
            {
                int r = a % b; //tính số dư
                a = b;
                b = r;
            } //lặp lại cho tới khi b=0
            return a;
        }

        //bội chung nhỏ nhất
        private static long BSCNN(int a, int b)
        {
            long aa = Math.Abs((long)a);
            long bb = Math.Abs((long)b);
            if (aa == 0 || bb == 0) return 0;
            int gcd = USCLN((int)aa, (int)bb); 
            return (aa / gcd) * bb;
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus(); return;
            }
            if (!int.TryParse(txtB.Text.Trim(), out int b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho B.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus(); return;
            }
            if (!rdbUSCLN.Checked && !rdbBSCNN.Checked)
            {
                MessageBox.Show("Vui lòng chọn phép tính USCLN hoặc BSCNN.", "Thiếu tùy chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rdbUSCLN.Checked)
            {
                int kq = USCLN(a, b);
                txtKetQua.Text = kq.ToString();
            }
            else if (rdbBSCNN.Checked)
            {
                long kq = BSCNN(a, b);
                txtKetQua.Text = kq.ToString();
            }
        }


        private void rdbUSCLN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbBSCNN_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
