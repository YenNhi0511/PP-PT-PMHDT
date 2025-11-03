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
using static System.Windows.Forms.AxHost;

namespace TranDuongYenNhi_1150080069_BTTuan11
{
    public partial class Form2: Form
    {
        string strCon = @"Data Source=DESKTOP-DA5JMVJ\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public Form2()
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
        private void
            XoaDuLieuForm()
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
        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDuLieu(); 
            XoaDuLieuForm();
        }

        private void btnThemDL_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblNhaXuatBan"].NewRow(); row["NXB"] = txtMaNXB.Text.Trim();
            row["TenNXB"] = txtTenNXB.Text.Trim(); row["DiaChi"] = txtDiaChi.Text.Trim();

            ds.Tables["tblNhaXuatBan"].Rows.Add(row);

            int kq = adapter.Update(ds.Tables["tblNhaXuatBan"]); if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công!");
            }

        }
    }
}
