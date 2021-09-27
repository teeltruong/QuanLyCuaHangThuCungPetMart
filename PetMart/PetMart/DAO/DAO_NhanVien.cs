using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMart.DAO
{
    class DAO_NhanVien
    {
        PetShopManagementEntities db;

        public DAO_NhanVien()
        {
            db = new PetShopManagementEntities();
        }
        public Boolean login(string u, string p)
        {
            var ds = db.Employees.Where(a => a.UserName == u).Select(b => new { b.Password}).ToList();
                if (ds.Count > 0)
                {
                    if (ds[0].Password == p)
                        return true;
                    else
                    {
                        MessageBox.Show("Sai mật khẩu!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                    return false;
                }
        }

        public dynamic LayDSNhanVien()
        {
            var ds = db.Employees.Select(s => new
            {
                s.EmployeeID,
                s.FirstName,
                s.LastName,
                s.Sex,
                s.DateOfBirth,
                s.Phone,
                s.Address
            }).ToList();

            return ds;
        }

        public void ThemNhanVien(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
        }

        //Ham kiem tra xem nhan vien do co ton tai ko?
        public bool KiemTraNhanVien(Employee e)
        {
            Employee nv = db.Employees.Find(e.EmployeeID);
            if (e != null)
                return true;
            else
                return false;
        }

        public void SuaThongTinNhanVien(Employee e)
        {
            Employee nv = db.Employees.Find(e.EmployeeID);
            nv.FirstName = e.FirstName;
            nv.LastName = e.LastName;
            nv.Sex = e.Sex;
            nv.DateOfBirth = e.DateOfBirth;
            nv.Phone = e.Phone;
            nv.Address = e.Address;
            db.SaveChanges();
        }

        public void XoaNhanVien(Employee e)
        {
            Employee nv = db.Employees.Find(e.EmployeeID);
            db.Employees.Remove(nv);
            db.SaveChanges();
        }

       
    }
}
