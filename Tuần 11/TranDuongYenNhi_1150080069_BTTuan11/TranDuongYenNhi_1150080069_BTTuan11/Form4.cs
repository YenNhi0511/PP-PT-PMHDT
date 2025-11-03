using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranDuongYenNhi_1150080069_BTTuan11
{
    public partial class Form4 : Form
    {
        string strCon = @"Data Source=DESKTOP-DA5JMVJ\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form4()
        {
            InitializeComponent();
        }

        // Doi tuong ket noi
        SqlConnection sqlCon = null; SqlDataAdapter adapter = null; DataSet ds = null;

        // Ham mo ket noi
        private void MoKetoi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

        //Ham dong ket noi
        private void DongKetoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        private void HienThiDuLieu()
        {
            MoKetoi();

            string query = "select * from NhaXuatBan";

            adapter = new SqlDataAdapter(query, sqlCon); SqlCommandBuilder builder = new SqlCommandBuilder(adapter); ds = new DataSet();
            adapter.Fill(ds, "tblNhaXuatBan"); dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        int vt = -1;

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
        }

        private void btnXoaDuLieu_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!"); return;
            }

            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                XoaDuLieu(); HienThiDuLieu();
            }
        }

        // Ham xoa du lieu
        private void XoaDuLieu()
        {
            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt];
            row.Delete();
            int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]);
            if (kq > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công!");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công!");
            }
        }
    }
}
