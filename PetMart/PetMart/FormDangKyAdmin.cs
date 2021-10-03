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

            
            if (cbGioiTinh.SelectedIndex == -1 || txtFirstName.Text.Length == 0 || txtLastName.Text.Length == 0 || txtPhone.Text.Length == 0
                     && txtPhone.Text.Length >= 10 || txtAddress.Text.Length == 0 || txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Không được trống!");
            }
            else
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
                    this.Hide();
                    Form f = new FormDangNhapAdmin();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại");
                }
            }

            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormDangNhapAdmin();
            f.Show();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtFirstName.ForeColor = Color.Black;
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            txtLastName.Clear();
            txtLastName.ForeColor = Color.Black;
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
            txtPhone.ForeColor = Color.Black;
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtAddress.ForeColor = Color.Black;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUsername.ForeColor = Color.Black;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.ForeColor = Color.Black;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || txtPhone.Text.Length > 9)
                e.Handled = true;
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FormDangKyAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
