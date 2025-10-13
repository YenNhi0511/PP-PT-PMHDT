using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Net.Sockets;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp_B8
{
    public partial class Form1: Form
    {
        // Chuoi ket noi
        string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\QLDA\PP-PT-PMHDT\Tuần 8\WindowsFormsApp_B8\WindowsFormsApp_B8\DB1.mdf"";Integrated Security=True";
        // Doi tuong ket noi
        SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }
        // Ham mo ket noi
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
        // Ham dong ket noi
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        private void HienThiDanhSach()
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from SinhVien";
            sqlCmd.Connection = sqlCon;
            lsvDanhSachSV.Items.Clear();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maSv = reader.GetString(0);
                string tenSV = reader.GetString(1);
                string gioiTinh = reader.GetString(2);
                string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                string queQuan = reader.GetString(4);
                string maLop = reader.GetString(5);
                ListViewItem lvi = new ListViewItem(maSv);
                lvi.SubItems.Add(tenSV);
                lvi.SubItems.Add(gioiTinh);
                lvi.SubItems.Add(ngaySinh);
                lvi.SubItems.Add(queQuan);
                lvi.SubItems.Add(maLop);
                lsvDanhSachSV.Items.Add(lvi);
            }
            reader.Close();
        }
        
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThemSinhVien_Click_1(object sender, EventArgs e)
        {
            MoKetNoi();
            try
            {
                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                string gioiTinh = cbGioiTinh.SelectedText;
                string ngaySinh = dtpNgaySinh.Value.Month + "/" + dtpNgaySinh.Value.Day + "/" + dtpNgaySinh.Value.Year;
                string queQuan = txtQueQuan.Text.Trim();
                string maLop = txtMaLop.Text.Trim();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "insert into SinhVien values ('" + maSV +
                "', '" + tenSV + "', '" + gioiTinh + "', '" + ngaySinh + "', '" + queQuan + "','" + maLop + "')";
                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    HienThiDanhSach();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm dữ liệu bị lỗi!" + ex);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbGioiTinh.SelectedIndex = 0;
            HienThiDanhSach();
            string gioiTinh = cbGioiTinh.SelectedItem?.ToString() ?? "";
        }
    }
}
