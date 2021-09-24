using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMart.DAO
{
    class DAO_KhachHang
    {
        PetShopManagementEntities db;

        public DAO_KhachHang()
        {
            db = new PetShopManagementEntities();
        }

        public dynamic LayDSKhachHang()
        {
            var ds = db.Customers.Select(s => new
            {
                s.CustomerID,
                s.FullName,
                s.DateOfBirth,
                s.Sex,
                s.Phone,
                s.Address
            }).ToList();

            return ds;
        }

        public void ThemKhachHang(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
        }

        public bool KiemTraKhachHang(Customer c)
        {
            Customer cus = db.Customers.Find(c.CustomerID);
            if (c != null)
                return true;
            else
                return false;
        }

        public void SuaThongTinKhachHang(Customer c)
        {
            Customer cus = db.Customers.Find(c.CustomerID);
            cus.FullName = c.FullName;
            cus.DateOfBirth = c.DateOfBirth;
            cus.Sex = c.Sex;
            cus.Phone = c.Phone;
            cus.Address = c.Address;
            db.SaveChanges();
        }

        public void XoaKhachHang(Customer c)
        {
            Customer cus = db.Customers.Find(c.CustomerID);
            db.Customers.Remove(cus);
            db.SaveChanges();
        }
    }
}
