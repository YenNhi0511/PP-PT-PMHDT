using System.Data.SqlClient;
using System;
--Tạo đối tượng Connection
SqlConnection con = new SqlConnection();
 --Truyền vào chuỗi kết nối tới cơ sở dữ liệu
 --Sử dụng Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
 con.ConnectionString = @"Data Source=DESKTOP-DA5JMVJ\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
 con.Open(); // mở kết nối