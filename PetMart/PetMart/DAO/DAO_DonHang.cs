using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMart.DAO
{
    
    class DAO_DonHang
    {
        PetShopManagementEntities db;

        public DAO_DonHang()
        {
            db = new PetShopManagementEntities();
        }

        public dynamic LayDSDH()
        {
            try
            {
                var ds = db.Orders.Select(s => new
                {
                    s.OrderID,
                    s.CreatedDate,
                    s.Customer.Address,
                    s.Employee.LastName
                }).ToList();
                return ds;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public dynamic LayDSKH()
        {
            try
            {
                var ds = db.Customers.Select(kh => new
                {
                    kh.CustomerID,
                    kh.Address
                }).ToList();
                return ds;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public dynamic LayDSNV()
        {
            try
            {
                var ds = db.Employees.Select(nv => new
                {
                    nv.EmployeeID,
                    nv.LastName,
                    nv.FirstName
                }).ToList();
                return ds;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }


        public void ThemDH(Order dh)
        {
            //bool trangThai = false;
            try
            {
                db.Orders.Add(dh);
                db.SaveChanges();
                //trangThai = true;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Warning", MessageBoxButtons.OK);
            }
            //return trangThai;
        }


        public bool KiemTraDH(Order d)
        {
            Order o = db.Orders.Find(d.OrderID);
            if (d != null)
            {
                return true;
            }
            else
                return false;
        }

       

        public void SuaDH(Order d)
        {
            Order o = db.Orders.Find(d.OrderID);
            o.CreatedDate = d.CreatedDate;
            o.CustomerID = d.CustomerID;
            o.EmployeeID = d.EmployeeID;
            db.SaveChanges();
        }

        public void XoaDH(Order d)
        {
            Order o = db.Orders.Find(d.OrderID);
            db.Orders.Remove(o);
            db.SaveChanges();
        }

        public bool KiemTraSPDH(OrderDetail d)
        {
            int? sl;
            sl = db.sp_KiemTraSPDH(d.OrderID, d.ProductID).FirstOrDefault();
            if (sl != 0)
                return false;
            else
                return true;
        }


        public void ThemCTDH(OrderDetail d)
        {
            int? sl;
            sl = db.sp_KiemTraSPDH(d.OrderID, d.ProductID).FirstOrDefault();
            db.OrderDetails.Add(d);
            db.SaveChanges();
        }


        public dynamic DSCTDH(int maDH)
        {
            var ds = db.OrderDetails.Where(s => s.OrderID == maDH)
                .Select(s => new
                {
                    s.OrderID,
                    s.Product.ProductName,
                    s.UnitPrice,
                    s.Quantity,
                

                }).ToList();
            return ds;
        }
    }
}
