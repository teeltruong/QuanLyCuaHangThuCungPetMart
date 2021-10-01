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
using PetMart.DAO;

namespace PetMart
{
    public partial class FormDangNhapAdmin : Form
    {
        BUS_NhanVien bNhanVien;
        public FormDangNhapAdmin()
        {
            InitializeComponent();
            bNhanVien = new BUS_NhanVien();
        }

        //Loi
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
        
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (bNhanVien.ktlogin(userName, passWord) == true)
            {
                MessageBox.Show("Đăng nhập thành công!!");
                FormMainMenu f = new FormMainMenu();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!!");
                txbUserName.Clear();
                txbPassWord.Clear();
            }
        }


        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKyAdmin f = new FormDangKyAdmin();
            f.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormDangNhapAdmin_Load(object sender, EventArgs e)
        {

            Form f = new Form();
            f.Size = new Size(840, 580);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
