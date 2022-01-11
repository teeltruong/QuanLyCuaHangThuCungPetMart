using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetMart.DAO;

namespace PetMart.BUS
{
    class BUS_DatHang
    {
        DAO_DatHang da;

        public BUS_DatHang()
        {
            da = new DAO_DatHang();

        }

        //public ProductMode HienThiDSSP(int ma)
        //{
        //    return da.HienThiThongTinSP(ma);
        //}
    }
}
