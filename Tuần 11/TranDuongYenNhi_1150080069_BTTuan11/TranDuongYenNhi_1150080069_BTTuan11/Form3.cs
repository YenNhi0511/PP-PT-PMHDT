using System;
using System.Collections;
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
    public partial class Form3: Form
    {
        string strCon = @"Data Source=DESKTOP-DA5JMVJ\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form3()
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
        //Ham xoa du lieu cua cac control
        private void XoaDuLieuForm()
        {
        txtMaNXB.Text = txtTenNXB.Text = txtDiaChi.Text = "";
        }

        //Ham hien thi du lieu tren datagridview
        private void HienThiDuLieu()
        {
        MoKetoi();

            string query = "select * from NhaXuatBan";

            adapter = new SqlDataAdapter(query, sqlCon); SqlCommandBuilder builder = new SqlCommandBuilder(adapter); ds = new DataSet();
            adapter.Fill(ds, "tblNhaXuatBan"); dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            HienThiDuLieu(); XoaDuLieuForm();
        }

        int vt = -1;

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt]; txtMaNXB.Text = row["NXB"].ToString().Trim(); txtTenNXB.Text = row["TenNXB"].ToString().Trim(); txtDiaChi.Text = row["DiaChi"].ToString().Trim();
        }

        private void btnChinhSuaThongTin_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để chỉnh sửa!"); return;
            }

            DataRow row = ds.Tables["tblNhaXuatBan"].Rows[vt]; row.BeginEdit();
            row["NXB"] = txtMaNXB.Text.Trim(); row["TenNXB"] = txtTenNXB.Text.Trim(); row["DiaChi"] = txtDiaChi.Text.Trim(); row.EndEdit();

            int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]); if (kq > 0)
            {
                MessageBox.Show("Chỉnh sửa dữ liệu thành công!"); HienThiDuLieu();
                XoaDuLieuForm();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa dữ liệu không thành công!");
            }
        }

        
    }
}




