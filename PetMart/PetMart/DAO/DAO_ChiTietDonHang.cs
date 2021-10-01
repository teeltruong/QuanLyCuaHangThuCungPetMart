using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace PetMart.DAO
{

    class DAO_ChiTietDonHang
    {
        PetShopManagementEntities db;
        public DAO_ChiTietDonHang()
        {
            db = new PetShopManagementEntities();
        }

        public dynamic LayDSCTDH(int maDH)
        {
            // Tìm ds chi tiết đơn hàng bằng mã đơn hàng
            try
            {
                var ds = db.OrderDetails.Where(s => s.OrderID == maDH).Select(s => new
                {
                    s.OrderID,
                    s.ProductID,
                    s.UnitPrice,
                    s.Quantity
                }).ToList();
                return ds;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        // THÊM CHI TIẾT ĐƠN HÀNG
        public bool ThemCTDH(OrderDetail order)
        {
            bool isThanhCong;
            using (var trac = new TransactionScope())
            {
                try
                {
                    int? sl;
                    sl = db.sp_KiemTraSPDonHang(order.OrderID, order.ProductID).FirstOrDefault();
                    if (sl != 0)
                        isThanhCong = false;
                    else
                    {
                        db.OrderDetails.Add(order);
                        db.SaveChanges();
                        trac.Complete();
                        isThanhCong = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    isThanhCong = false;
                }
                return isThanhCong;
            }
        }


        public bool XoaCTDH(int maDH, int maSP)
        {
            bool isThanhCong;
            try
            {
                OrderDetail ds = db.OrderDetails.First(s => s.OrderID == maDH
                && s.ProductID == maSP);
                db.OrderDetails.Remove(ds);
                db.SaveChanges();
                isThanhCong = true;
            }
            catch (Exception)
            {
                isThanhCong = false;
            }

            return isThanhCong;
        }

        public bool SuaCTDH(OrderDetail o)
        {
            bool isThanhCong;
            try
            {
                OrderDetail order = db.OrderDetails.First(s => s.OrderID == o.OrderID
                     && s.ProductID == o.ProductID);
                isThanhCong = true;
                order.UnitPrice = o.UnitPrice;

                order.Quantity = o.Quantity;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                isThanhCong = false;
            }
            return isThanhCong;
        }
    }
}
