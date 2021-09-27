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
    class BUS_NhanVien
    {
        DAO_NhanVien dNhanVien;

        public BUS_NhanVien()
        {
            dNhanVien = new DAO_NhanVien();
        }

        public bool ktlogin(string a, string b)
        {
            if (dNhanVien.login(a, b) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void HienThiDSNV(DataGridView dgv)
        {
            dgv.DataSource = dNhanVien.LayDSNhanVien();
        }

        public bool ThemNV(Employee e)
        {
            try
            {
                dNhanVien.ThemNhanVien(e);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool SuaThongTinNV(Employee e)
        {
            //Kiểm tra thong tin Nhan vien có được phép sửa
            if (dNhanVien.KiemTraNhanVien(e))
            {
                try
                {
                    dNhanVien.SuaThongTinNhanVien(e);
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

        public bool XoaNV(Employee e)
        {
            //Kiểm tra thong tin Nhan vien có được phép xoa
            if (dNhanVien.KiemTraNhanVien(e))
            {
                try
                {
                    dNhanVien.XoaNhanVien(e);
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
