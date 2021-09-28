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
    public partial class FormQuanLyKhachHang : Form
    {
        BUS_KhachHang bKhachHang;

        public FormQuanLyKhachHang()
        {
            InitializeComponent();
            bKhachHang = new BUS_KhachHang();
        }

        public void HienThiDSKhachHang()
        {
            dGKhachHang.DataSource = null;
            bKhachHang.HienThiDSKhachHang(dGKhachHang);
            dGKhachHang.Columns[0].Width = (int)(dGKhachHang.Width * 0.125);
            dGKhachHang.Columns[1].Width = (int)(dGKhachHang.Width * 0.2);
            dGKhachHang.Columns[2].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[3].Width = (int)(dGKhachHang.Width * 0.125);
            dGKhachHang.Columns[4].Width = (int)(dGKhachHang.Width * 0.15);
            dGKhachHang.Columns[5].Width = (int)(dGKhachHang.Width * 0.25);
        }

        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }

        private void dGNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGKhachHang.Rows.Count)
            {
                txtMaKH.Enabled = false;
                txtMaKH.Text = dGKhachHang.Rows[e.RowIndex].Cells["CustomerID"].Value.ToString();
                txtHoTen.Text = dGKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dGKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGioiTinh.Text = dGKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDienThoai.Text = dGKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDiaChi.Text = dGKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.FullName = txtHoTen.Text;
            c.DateOfBirth = dtpNgaySinh.Value;
            c.Sex = cbGioiTinh.SelectedItem.ToString();
            c.Phone = txtDienThoai.Text;
            c.Address = txtDiaChi.Text;

            //Gọi sự kiện Thêm của BUS
            if (bKhachHang.ThemKhachHang(c))
            {
                MessageBox.Show("Thêm Khách hàng thành công");
                bKhachHang.HienThiDSKhachHang(dGKhachHang);
            }
            else
            {
                MessageBox.Show("Thêm Khách hàng thất bại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            //Kiem tra ID khach hang
            c.CustomerID = int.Parse(txtMaKH.Text);

            //Sua thong tin Khach hang
            c.FullName = txtHoTen.Text;
            c.Sex = cbGioiTinh.SelectedItem.ToString();
            c.DateOfBirth = dtpNgaySinh.Value;
            c.Phone = txtDienThoai.Text;
            c.Address = txtDiaChi.Text;

            //Gọi sự kiện SỬA của BUS
            if (bKhachHang.SuaThongTinKH(c))
            {
                MessageBox.Show("Sửa thông tin khách hàng thành công");
                bKhachHang.HienThiDSKhachHang(dGKhachHang);
            }
            else
            {
                MessageBox.Show("Sửa thông tin khách hàng thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            //Kiem tra ID khach hang
            c.CustomerID = int.Parse(txtMaKH.Text);

            //Gọi sự kiện Xoa của BUS
            if (bKhachHang.XoaKhachHang(c))
            {
                MessageBox.Show("Xóa thông tin khách hàng thành công");
                bKhachHang.HienThiDSKhachHang(dGKhachHang);
            }
            else
            {
                MessageBox.Show("Xóa thông tin khách hàng thất bại");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reportKH_Click(object sender, EventArgs e)
        {
            cRKhachHang r = new cRKhachHang();
            FormReport f = new FormReport();
            r.SetDataSource(bKhachHang.LayDSKH().ToList());
            f.crystalReportViewer1.ReportSource = r;
            f.Show();
        }
    }
}
