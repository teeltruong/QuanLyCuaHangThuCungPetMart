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

namespace PetMart
{
    public partial class FormDangKyAdmin : Form
    {
        BUS_NhanVien bNhanVien;

        public FormDangKyAdmin()
        {
            InitializeComponent();
            bNhanVien = new BUS_NhanVien();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            Employee nv = new Employee();
            nv.FirstName = txtFirstName.Text;
            nv.LastName = txtLastName.Text;
            nv.DateOfBirth = dtpNgaySinh.Value;
            nv.Sex = cbGioiTinh.SelectedItem.ToString();
            nv.Address = txtAddress.Text;
            nv.Phone = txtPhone.Text;

            nv.UserName = txtUsername.Text;
            nv.Password = txtPassword.Text;

            //Gọi sự kiện Thêm của BUS
            if (bNhanVien.ThemNV(nv))
            {
                MessageBox.Show("Tạo tài khoản thành công");
                
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thất bại");
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
        }
    }
}
