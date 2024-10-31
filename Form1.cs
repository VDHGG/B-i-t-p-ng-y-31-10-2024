using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace BaiKTSo2_31_10_2024
{
    public partial class Form1 : Form
    {
        public class SanPham
        {
            public string TenSP { get; set; }
            public decimal GiaSP { get; set; }
            public int SoLuongSP { get; set; }

            public SanPham(string tensp, decimal giasp, int soluongsp)
            {
                TenSP = tensp;
                GiaSP = giasp;
                SoLuongSP = soluongsp;
            }
        }

        public class GioHang
        {
            private Dictionary<SanPham, int> TrongGioHang = new Dictionary<SanPham, int>();
            public void ThemVaoGioHang(SanPham product, int quantity)
            {
                if (TrongGioHang.ContainsKey(product))
                    TrongGioHang[product] += quantity;
                else
                    TrongGioHang[product] = quantity;
            }

            public void XoaKhoiGioHang(SanPham product)
            {
                if (TrongGioHang.ContainsKey(product))
                    TrongGioHang.Remove(product);
            }

            public decimal CalculateTotal()
            {
                return TrongGioHang.Sum(item => item.Key.GiaSP * item.Value);
            }

            public void ClearCart()
            {
                TrongGioHang.Clear();
            }

            public Dictionary<SanPham, int> GetCartItems()
            {
                return TrongGioHang;
            }
        }

        private List<SanPham> products = new List<SanPham>();
        private GioHang cart = new GioHang();

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            DisplayProducts();
        }

        private void LoadProducts()
        {
            products.Add(new SanPham("AO BA LO", 100000, 10));
            products.Add(new SanPham("QUAN DUI", 200000, 15));
            products.Add(new SanPham("VAY", 150000, 20));
            products.Add(new SanPham("AO DAI", 250000, 30));
        }

        private void DisplayProducts()
        {
            ListSPBox.Items.Clear();
            foreach (var product in products)
            {
                ListSPBox.Items.Add($"{product.TenSP} - {product.GiaSP:C} - So Luong Con Lai: {product.SoLuongSP}");
            }
        }

        private void DisplayCartItems()
        {
            GioHangBox.Items.Clear();
            foreach (var item in cart.GetCartItems())
            {
                GioHangBox.Items.Add($"{item.Key.TenSP} - {item.Value} x {item.Key.GiaSP:C}");
            }
        }

        private void UpdateTotal()
        {
            TextTotal.Text = $"{cart.CalculateTotal():C}";
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListSPBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < products.Count)
            {
                SanPham selectedProduct = products[selectedIndex];

                if (selectedProduct.SoLuongSP > 0)
                {
                    cart.ThemVaoGioHang(selectedProduct, 1);
                    selectedProduct.SoLuongSP--;
                    DisplayProducts();
                    DisplayCartItems();
                    UpdateTotal();
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã hết hàng.", "Thông báo");
                }
            }
        }

        private void ThanhToanButton_Click(object sender, EventArgs e)
        {
            if (cart.CalculateTotal() == 0)
            {
                MessageBox.Show("XIN HÃY CHỌN SẢN PHẨM CẦN THANH TOÁN", "Thông Báo");
            }
            else
            {
                MessageBox.Show("THANH TOÁN THÀNH CÔNG", "Thông Báo");
                cart.ClearCart();
                DisplayCartItems();
                UpdateTotal();
            }
        }


        private void XoaButton_Click(object sender, EventArgs e)
        {
            if (GioHangBox.SelectedIndex >= 0)
            {
                int index = GioHangBox.SelectedIndex;

                string selectedText = GioHangBox.Items[index].ToString();
                string productName = selectedText.Split('-')[0].Trim(); 

               
                var selectedCartItem = cart.GetCartItems()
                    .FirstOrDefault(item => item.Key.TenSP == productName);

                if (selectedCartItem.Key != null)
                {
                    
                    selectedCartItem.Key.SoLuongSP += selectedCartItem.Value;

                    cart.XoaKhoiGioHang(selectedCartItem.Key);

            
                    DisplayProducts();
                    DisplayCartItems();
                    UpdateTotal();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tìm thấy trong giỏ hàng.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo");
            }
        }
    }
}
