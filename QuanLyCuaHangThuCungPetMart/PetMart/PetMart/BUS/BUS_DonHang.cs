using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetMart.DAO;
using System.Windows.Forms;
using System.Data;
using System.Transactions;
using System.Data.Entity.Infrastructure;

namespace PetMart.BUS
{
    class BUS_DonHang
    {
        DAO_DonHang dDonHang;
        DAO_ChiTietDonHang daCTDH;
 
        public BUS_DonHang()
        {
            dDonHang = new DAO_DonHang();
        }

        public void HienThiDSDonHang(DataGridView dataGridView)
        {
            dataGridView.DataSource = dDonHang.LayDSDH();
        }

        public dynamic ReportHienThiDSDonHang()
        {
           return dDonHang.ReportDSDH();
        }

        public void HienThiDSCTDonHang(DataGridView dg, int maDH)
        {
            dg.DataSource = dDonHang.DSCTDH(maDH);
        }

        public void HienThiDSKH(ComboBox cb)
        {
            cb.DataSource = dDonHang.LayDSKH();
            cb.DisplayMember = "FullName";
            cb.ValueMember = "CustomerID";

        }

        public void HienThiDSNV(ComboBox cb)
        {
            cb.DataSource = dDonHang.LayDSNV();
            cb.DisplayMember = "LastName";
            cb.ValueMember = "EmployeeID";
        }


        public bool ThemDH(Order dh)
        {
            try
            {
                dDonHang.ThemDH(dh);
            }
            catch(Exception)
            {
                throw;
            }
            return true;
        }

        public bool ThemCTDH(OrderDetail dh)
        {
            daCTDH = new DAO_ChiTietDonHang();
            return daCTDH.ThemCTDH(dh);
        }

        public bool ThemCTDH(int maDH, DataTable dtDonHang)
        {
            bool ketQua = false;
            using (var tran = new TransactionScope())
            {
                try
                {
                    foreach (DataRow item in dtDonHang.Rows)
                    {
                        OrderDetail d = new OrderDetail();
                        d.OrderID = maDH;
                        d.ProductID = int.Parse(item[0].ToString());
                        d.UnitPrice = int.Parse(item[1].ToString());
                        d.Quantity = short.Parse(item[2].ToString());
                      
                        if(dDonHang.KiemTraSPDH(d))
                        {
                            dDonHang.ThemCTDH(d);
                        }
                        else
                        {
                            throw new Exception("Sản phẩm đã tồn tại" + d.ProductID);
                        }
                    }
                    ketQua = true;
                    tran.Complete();
                }
                catch (Exception ex)
                {
                    ketQua = false;//Chưa xử lý quay lui lại giao tác
                    MessageBox.Show(ex.Message);
                } 
            }
            return ketQua;
        }

        public bool  SuaDH(Order o)
        {
            //don hang co duoc phep sua
            if(dDonHang.KiemTraDH(o))
            {
                try
                {
                    dDonHang.SuaDH(o);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool XoaDH(Order o)
        {
            if (dDonHang.KiemTraDH(o))
            {
                try
                {
                    dDonHang.XoaDH(o);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else return false;
        }

    }
}
