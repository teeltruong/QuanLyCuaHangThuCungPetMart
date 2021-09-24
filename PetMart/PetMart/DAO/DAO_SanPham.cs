using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMart.DAO
{
    class DAO_SanPham
    {
        PetShopManagementEntities db;
        public DAO_SanPham()
        {
            db = new PetShopManagementEntities();
        }

        public dynamic LayDSSanPham()
        {
            var ds = db.Products.Select(s => new
            {
                s.ProductID,
                s.ProductName,
                s.Price,
                s.Size,
                s.Category.CategoryName
            }).ToList();

            return ds;
        }

        public dynamic LayDSLoaiSP()
        {
            var ds = db.Categories.Select(s => new
            {
                s.CategoryID,
                s.CategoryName
            }).ToList();

            return ds;
        }

        public void ThemSanPham(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
        }

        public bool KiemTraSanPham(Product product)
        {
            Product p = db.Products.Find(product.ProductID);
            if (product != null)
                return true;
            else
                return false;
        }

        public void SuaThongTinSP(Product product)
        {
            Product p = db.Products.Find(product.ProductID);
            p.ProductName = product.ProductName;
            p.Size = product.Size;
            p.Price = product.Price;
            p.CategoryID = product.CategoryID;
            db.SaveChanges();
        }

        public void XoaSP(Product p)
        {
            Product product = db.Products.Find(p.ProductID);
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}
