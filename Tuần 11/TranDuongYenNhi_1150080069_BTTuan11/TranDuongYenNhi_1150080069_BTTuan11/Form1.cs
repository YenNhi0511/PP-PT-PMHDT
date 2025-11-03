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
using static System.Windows.Forms.AxHost;

namespace TranDuongYenNhi_1150080069_BTTuan11
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=DESKTOP-DA5JMVJ\SQLEXPRESS;Initial Catalog=QuanLyBanSach;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        // Doi tuong ket noi
        SqlConnection sqlCon = null;

        //Ham mo ket noi
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

        //Ham dong ket noi
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click_1(object sender, EventArgs e)
        {
            MoKetNoi();

            string sql = "select * from NhaXuatBan";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblNhaXuatBan");
            dgvDanhSach.DataSource = ds.Tables["tblNhaXuatBan"];

            DongKetNoi();
        }
    }
}

