using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMart.DAO
{
    class DAO_DatHang
    {
        PetShopManagementEntities db;
        public DAO_DatHang()
        {
            db = new PetShopManagementEntities();
        }


        //// LẤY DANH SÁCH SẢN PHẨM BẰNG MỘT LỚP TỰ ĐỊNH NGHĨA
        //public ProductMode HienThiThongTinSP(int ma)
        //{
        //    try
        //    {
        //        ProductMode productMode = db.Products.Where(p => p.ProductID == ma)
        //                .Select(p => new ProductMode()
        //                {
        //                    ProductID = p.ProductID,
        //                    CategoryName = p.Category.CategoryName,
        //                    //CompanyName = p.Supplier.CompanyName,
        //                    Price = p.Price,
        //                    ProductName = p.ProductName
        //                }).FirstOrDefault();

        //        return productMode;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        public Product LayThongTinSP(int ma)
        {
            try
            {
                var ds = db.Products.Where(p => p.ProductID == ma).FirstOrDefault();
                return ds;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
