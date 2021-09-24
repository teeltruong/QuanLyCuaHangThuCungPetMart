using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetMart.DAO;
using System.Data.Entity.Infrastructure;


namespace PetMart.BUS
{
    class BUS_KhachHang
    {
        DAO_KhachHang dKhachHang;
        public BUS_KhachHang()
        {
            dKhachHang = new DAO_KhachHang();
        }

        public void HienThiDSKhachHang(DataGridView dgv)
        {
            dgv.DataSource = dKhachHang.LayDSKhachHang();
        }

        public bool ThemKhachHang(Customer c)
        {
            try
            {
                dKhachHang.ThemKhachHang(c);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaThongTinKH(Customer c)
        {
            //Kiểm tra thong tin Khach hang có được phép sửa
            if (dKhachHang.KiemTraKhachHang(c))
            {
                try
                {
                    dKhachHang.SuaThongTinKhachHang(c);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }

        public bool XoaKhachHang(Customer c)
        {
            //Kiểm tra thong tin Khach Hang có được phép xoa
            if (dKhachHang.KiemTraKhachHang(c))
            {
                try
                {
                    dKhachHang.XoaKhachHang(c);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
                return false;
        }


    }
}
