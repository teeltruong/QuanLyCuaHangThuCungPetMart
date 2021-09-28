using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetMart.DAO;
using System.Windows.Forms;

namespace PetMart.BUS
{
    class BUS_ChiTietDonHang
    {

        DAO_ChiTietDonHang da;

        public BUS_ChiTietDonHang()
        {
            da = new DAO_ChiTietDonHang();
        }

        // LẤY DANH SÁCH CHI TIẾT ĐƠN HÀNG THEO MÃ ĐƠN HÀNG
        public void LayDSCTDH(DataGridView data, int ma)
        {
            try
            {
                data.DataSource = da.LayDSCTDH(ma);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Cảnh báo", MessageBoxButtons.OK);
            }
        }


        // XOÁ CHI TIẾT ĐƠN HÀNG THEO MÃ ĐƠN HÀNG VÀ MÃ SẢN PHÂM
        public void XoaCTDH(int maDH, int maSP)
        {
            if (da.XoaCTDH(maDH, maSP))
                MessageBox.Show("Xoá chi tiết đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Xoá chi tiết đơn hàng không thành công", "Thông báo", MessageBoxButtons.OK);

        }

        // SỬA CHI TIẾT ĐƠN HÀNG
        public void SuaCTDH(OrderDetail o)
        {
            if (da.SuaCTDH(o))
                MessageBox.Show("Sửa chi tiết đơn hàng thành công", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Sửa chi tiết đơn hàng không thành công", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
