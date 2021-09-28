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
    public partial class FormQuanLyNhanVien : Form
    {
        BUS_NhanVien bNhanVien;
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            bNhanVien = new BUS_NhanVien();
        }

        public void HienThiDanhSachNhanVien()
        {
            dGNhanVien.DataSource = null;
            bNhanVien.HienThiDSNV(dGNhanVien);
            dGNhanVien.Columns[0].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[1].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[2].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[3].Width = (int)(dGNhanVien.Width * 0.1);
            dGNhanVien.Columns[4].Width = (int)(dGNhanVien.Width * 0.18);
            dGNhanVien.Columns[5].Width = (int)(dGNhanVien.Width * 0.18);
            dGNhanVien.Columns[6].Width = (int)(dGNhanVien.Width * 0.24);
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Employee nv = new Employee();
            nv.FirstName = txtHo.Text;
            nv.LastName = txtTen.Text;
            nv.Sex = cbGioiTinh.SelectedItem.ToString();
            nv.DateOfBirth = dtpNgaySinh.Value;
            nv.Phone = txtDienThoai.Text;
            nv.Address = txtDiaChi.Text;

            //Gọi sự kiện Thêm của BUS
            if (bNhanVien.ThemNV(nv))
            {
                MessageBox.Show("Thêm NV thành công");
                bNhanVien.HienThiDSNV(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Thêm NV thất bại");
            }
                
        }

        private void dGNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGNhanVien.Rows.Count)
            {
                txtMaNV.Enabled = false;
                txtMaNV.Text = dGNhanVien.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtHo.Text = dGNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTen.Text = dGNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbGioiTinh.Text = dGNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpNgaySinh.Text = dGNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDienThoai.Text = dGNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dGNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Employee nv = new Employee();
            //Kiem tra ID nhan vien co ton tai hay khong
            nv.EmployeeID = int.Parse(txtMaNV.Text);

            //Sua thong tin nhan vien
            nv.FirstName = txtHo.Text;
            nv.LastName = txtTen.Text;
            nv.Sex = cbGioiTinh.SelectedItem.ToString();
            nv.DateOfBirth = dtpNgaySinh.Value;
            nv.Phone = txtDienThoai.Text;
            nv.Address = txtDiaChi.Text;

            //Gọi sự kiện SỬA của BUS
            if (bNhanVien.SuaThongTinNV(nv))
            {
                MessageBox.Show("Sửa thông tin nhân viên thành công");
                bNhanVien.HienThiDSNV(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Employee nv = new Employee();
            //Kiem tra ID nhan vien co ton tai hay khong
            nv.EmployeeID = int.Parse(txtMaNV.Text);

            //Gọi sự kiện Xóa của BUS
            if (bNhanVien.XoaNV(nv))
            {
                MessageBox.Show("Xóa thông tin nhân viên thành công");
                bNhanVien.HienThiDSNV(dGNhanVien);
            }
            else
            {
                MessageBox.Show("Xóa thông tin nhân viên thất bại");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dGNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cRNhanVien r = new cRNhanVien();
            FormReport f = new FormReport();
            r.SetDataSource(bNhanVien.LayDSNV().ToList());
            f.crystalReportViewer1.ReportSource = r;
            f.Show();
        }
    }
}
