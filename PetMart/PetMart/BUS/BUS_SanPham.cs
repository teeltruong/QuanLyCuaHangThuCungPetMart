using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetMart.DAO;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace PetMart.BUS
{
    class BUS_SanPham
    {
        DAO_SanPham dSanPham;

        public BUS_SanPham()
        {
            dSanPham = new DAO_SanPham();
        }

        public void LayDanhSachSP(DataGridView dgv)
        {
            dgv.DataSource = dSanPham.LayDSSanPham();
        }

        public void LayDanhSachLoaiSP(ComboBox cb)
        {
            cb.DataSource = dSanPham.LayDSLoaiSP();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CategoryID";
        }

        public bool ThemSanPham(Product p)
        {
            try
            {
                dSanPham.ThemSanPham(p);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool SuaThongTinSP(Product p)
        {
            //Kiểm tra sản phẩm có được phép sửa
            if (dSanPham.KiemTraSanPham(p))
            {
                try
                {
                    dSanPham.SuaThongTinSP(p);
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

        public bool XoaSP(Product p)
        {
            //Kiểm tra sản phẩm có được phép xoá
            if (dSanPham.KiemTraSanPham(p))
            {
                try
                {
                    dSanPham.XoaSP(p);
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
