using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetMart.BUS;
using PetMart.Report;

namespace PetMart
{
    public partial class FormQuanLySanPham : Form
    {
        BUS_SanPham bSanPham;
        public FormQuanLySanPham()
        {
            InitializeComponent();
            bSanPham = new BUS_SanPham();
        }

        public void HienThiDanhSachSanPham()
        {
            dGSP.DataSource = null;
            bSanPham.LayDanhSachSP(dGSP);
            dGSP.Columns[0].Width = (int)(dGSP.Width * 0.1);
            dGSP.Columns[1].Width = (int)(dGSP.Width * 0.25);
            dGSP.Columns[2].Width = (int)(dGSP.Width * 0.2);
            dGSP.Columns[3].Width = (int)(dGSP.Width * 0.2);
            dGSP.Columns[4].Width = (int)(dGSP.Width * 0.25);
        }

        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSanPham();
            bSanPham.LayDanhSachLoaiSP(cbLoaiSP);
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = txtTenSP.Text;
            p.Size = txtSize.Text;
            p.Price = int.Parse(txtDonGia.Text);
            p.CategoryID = int.Parse(cbLoaiSP.SelectedValue.ToString());

            //Gọi sự kiện Thêm của BUS
            if (bSanPham.ThemSanPham(p))
            {
                MessageBox.Show("Tạo sản phẩm thành công");
                bSanPham.LayDanhSachSP(dGSP);
            }
            else
            {
                MessageBox.Show("Tạo sản phẩm thất bại");
            }
        }

        private void dGSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGSP.Rows.Count)
            {
                txtMaSP.Enabled = false;
                txtMaSP.Text = dGSP.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtTenSP.Text = dGSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = dGSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSize.Text = dGSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbLoaiSP.Text = dGSP.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            //Kiem tra san pham co ton tai hay khong
            product.ProductID = int.Parse(txtMaSP.Text);

            //Sua thong tin san pham
            product.ProductName = txtTenSP.Text;
            product.Size = txtSize.Text;
            product.Price = int.Parse(txtDonGia.Text);
            product.CategoryID = int.Parse(cbLoaiSP.SelectedValue.ToString());
           
            //Gọi sự kiện SỬA của BUS
            if (bSanPham.SuaThongTinSP(product))
            {
                MessageBox.Show("Sửa thông tin sản phẩm thành công");
                bSanPham.LayDanhSachSP(dGSP);
            }
            else
            {
                MessageBox.Show("Sửa thông tin sản phẩm thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            //Kiem tra san pham co ton tai hay khong
            product.ProductID = int.Parse(txtMaSP.Text);

            //Gọi sự kiện XOÁ của BUS
            if (bSanPham.XoaSP(product))
            {
                MessageBox.Show("Xóa thông tin sản phẩm thành công");
                bSanPham.LayDanhSachSP(dGSP);
            }
            else
            {
                MessageBox.Show("Xóa thông tin sản phẩm thất bại");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reportSP_Click(object sender, EventArgs e)
        {
            cRSanPham r = new cRSanPham();
            FormReport f = new FormReport();
            r.SetDataSource(bSanPham.LayDSSP().ToList());
            f.crystalReportViewer1.ReportSource = r;
            f.Show();
        }
    }
}
