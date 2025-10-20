using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace _1150080069_TranDuongYenNhi_PTPMHDT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=DESKTOP-DA5JMVJ\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection sqlCon = null;

        // Method to open connection
        private void MoKetNoi()
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

        // Method to close connection
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        // Method to display the list of publishers
        private void HienThiDanhSach()
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiNXB";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            lsvDanhSach.Items.Clear();
            while (reader.Read())
            {
                string maNXB = reader.GetString(0);
                string tenNXB = reader.GetString(1);
                string diachi = reader.GetString(2);
                ListViewItem lvi = new ListViewItem(maNXB);
                lvi.SubItems.Add(tenNXB);
                lvi.SubItems.Add(diachi);
                lsvDanhSach.Items.Add(lvi);
            }
            reader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
            txtMaNXB.Focus();
        }

        private void btnThemDL_Click_1(object sender, EventArgs e)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "ThemDuLieu";

            SqlParameter parMaXB = new SqlParameter("@maNXB", SqlDbType.Char);
            SqlParameter parTenXB = new SqlParameter("@tenNXB", SqlDbType.VarChar);
            SqlParameter parDiaChi = new SqlParameter("@diachi", SqlDbType.VarChar);

            parMaXB.Value = txtMaNXB.Text.Trim();
            parTenXB.Value = txtTenNXB.Text.Trim();
            parDiaChi.Value = txtDiaChi.Text.Trim();

            sqlCmd.Parameters.Add(parMaXB);
            sqlCmd.Parameters.Add(parTenXB);
            sqlCmd.Parameters.Add(parDiaChi);

            sqlCmd.Connection = sqlCon;
            int kq = sqlCmd.ExecuteNonQuery();

            if (kq > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công!");
                HienThiDanhSach();
                txtMaNXB.Text = txtTenNXB.Text = txtDiaChi.Text = "";
            }
        }
    }
}
