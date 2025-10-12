using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11500080069_TranDuongYenNhi_b6_Winform
{
    // Danh sách món (có thể thêm giá nếu muốn)
    public partial class Form1 : Form
    {
        private readonly string[] _menuItems = new[]
               {
            "Cơm chiên trứng","Bánh mì ốp la","Coca","Lipton",
            "Ốc rang muối","Khoai tây chiên","7 up","Cam",
            "Mỳ xào hải sản","Cá viên chiên","Pepsi","Cafe",
            "Burger bò nướng","Đùi gà rán","Bún bò Huế"
        };

        // Lưu trữ giỏ: Tên món -> Số lượng
        private readonly Dictionary<string, int> _cart = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

        public Form1()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            SetupUI();
        }

        private void SetupUI()
        {
            // 1) ComboBox chọn bàn
            cbbChonBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbChonBan.Items.Clear();
            for (int i = 1; i <= 20; i++) cbbChonBan.Items.Add($"Bàn {i}");
            cbbChonBan.SelectedIndex = 0;

            // 2) DataGridView hiển thị order
            dataGridViewOrder.AutoGenerateColumns = false;
            dataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewOrder.Columns.Clear();
            dataGridViewOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colItem",
                HeaderText = "Món",
                DataPropertyName = "Item",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQty",
                HeaderText = "SL",
                DataPropertyName = "Qty",
                Width = 60
            });

            // 3️⃣ Tạo các nút món ăn trong GroupBox
            CreateMenuButtons();

            // 4️⃣ Gắn sự kiện cho các nút chức năng
            btnXoa.Click += BtnClear_Click;
            btnOrder.Click += BtnOrder_Click;
        }

        private void CreateMenuButtons()
        {
            int startX = 20;   // vị trí bắt đầu theo trục X
            int startY = 30;   // vị trí bắt đầu theo trục Y
            int btnWidth = 140;
            int btnHeight = 35;
            int marginX = 15;
            int marginY = 15;
            int col = 0, row = 0;

            for (int i = 0; i < _menuItems.Length; i++)
            {
                Button btn = new Button
                {
                    Text = _menuItems[i],
                    Width = btnWidth,
                    Height = btnHeight,
                    Tag = _menuItems[i],
                    Location = new Point(startX + col * (btnWidth + marginX),
                                         startY + row * (btnHeight + marginY))
                };
                btn.Click += MenuButton_Click;
                groupBox1.Controls.Add(btn);

                col++;
                if (col >= 4) // mỗi hàng 4 nút
                {
                    col = 0;
                    row++;
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            var item = (sender as Button).Tag.ToString();

            if (_cart.ContainsKey(item))
                _cart[item]++;
            else
                _cart[item] = 1;

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dataGridViewOrder.DataSource = null;
            dataGridViewOrder.DataSource = _cart.Select(x => new { Item = x.Key, Qty = x.Value }).ToList();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {
                var item = dataGridViewOrder.SelectedRows[0].Cells[0].Value.ToString();
                _cart.Remove(item);
            }
            else
            {
                _cart.Clear();
            }
            RefreshGrid();
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Chưa có món nào được chọn!");
                return;
            }

            string table = cbbChonBan.SelectedItem.ToString();
            string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Orders");
            Directory.CreateDirectory(dir);

            string file = Path.Combine(dir, $"Order_{table}_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine($"=== ĐƠN HÀNG {table} ===");
                foreach (var item in _cart)
                {
                    sw.WriteLine($"{item.Key} x {item.Value}");
                }
                sw.WriteLine("=========================");
                sw.WriteLine($"Thời gian: {DateTime.Now}");
            }

            MessageBox.Show($"Đã lưu đơn hàng:\n{file}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _cart.Clear();
            RefreshGrid();
        }

        private void btnComChienTrung_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCafe_Click(object sender, EventArgs e)
        {

        }

        private void btnDuiGa_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCoca_Click(object sender, EventArgs e)
        {

        }

        private void btn7Up_Click(object sender, EventArgs e)
        {

        }

        private void btnPepsi_Click(object sender, EventArgs e)
        {

        }
    }
}