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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chuoi ket noi
        string strCon = @"Data Source=DESKTOP-DA5JMVJ\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True;TrustServerCertificate=True";

        // Doi tuong ket noi
        SqlConnection sqlCon = null;

        // Mo ket noi
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

        // Dong ket noi
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        // Hien thi danh sach nha xuat ban
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

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            string maNXB = lvi.SubItems[0].Text;
            HienThiThongTinNXBTheoMa(maNXB);
        }

        private void HienThiThongTinNXBTheoMa(string maNXB)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "HienThiChiTietNXB";
            sqlCmd.Connection = sqlCon;
            SqlParameter parMaNXB = new SqlParameter("@maNXB", SqlDbType.Char);
            parMaNXB.Value = maNXB;
            sqlCmd.Parameters.Add(parMaNXB);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            txtMaNXB.Text = txtTenNXB.Text = txtDiaChi.Text = "";
            if (reader.Read())
            {
                string _maNXB = reader.GetString(0);
                string tenNXB = reader.GetString(1);
                string diaChi = reader.GetString(2);
                txtMaNXB.Text = _maNXB;
                txtTenNXB.Text = tenNXB;
                txtDiaChi.Text = diaChi;
            }
            reader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
