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
           
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            FormDangKyAdmin f = new FormDangKyAdmin();
            f.ShowDialog();
        }
    }
}
