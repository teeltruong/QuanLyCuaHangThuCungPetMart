using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetMart.BUS;
using System.Windows.Forms;

namespace PetMart
{
    public partial class FormChiTietDonHang : Form
    {
       
        public int ma;
        BUS_ChiTietDonHang bus;
        BUS_SanPham busSP;
        BUS_DonHang busDH;
        public FormChiTietDonHang()
        {
            InitializeComponent();
            bus = new BUS_ChiTietDonHang();
            busDH = new BUS_DonHang();
            busSP = new BUS_SanPham();
        }

        private void CapNhatView()
        {

            bus.LayDSCTDH(gVCTDH, ma);
            gVCTDH.Columns[0].Width = (int)(0.25 * gVCTDH.Width);
            gVCTDH.Columns[1].Width = (int)(0.22 * gVCTDH.Width);
            gVCTDH.Columns[2].Width = (int)(0.22 * gVCTDH.Width);
            gVCTDH.Columns[3].Width = (int)(0.2 * gVCTDH.Width);
          
            

        }

        private void reLoad()
        {
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtMaSP.Text = "";
            busSP.LayDSSP(cbTenSP);

        }

  

        private void FormChiTietDonHang_Load(object sender, EventArgs e)
        {

            CapNhatView();
            txtMaDH.Text = ma.ToString();
            txtMaDH.Enabled = false;
            busSP.LayDSSP(cbTenSP);

        }

       
        private void gVCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVCTDH.Rows.Count)
            {
                txtMaDH.Text = gVCTDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                txtMaSP.Text = gVCTDH.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                txtDonGia.Text = gVCTDH.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtSoLuong.Text = gVCTDH.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                //busSP.Lay1SP(cbTenSP, int.Parse(txtMaSP.Text));

            }
        }
        private void FChiTietDH_Activated(object sender, EventArgs e)
        {
            bus.LayDSCTDH(gVCTDH, ma);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            FormDatHang fDatHang = new FormDatHang();
            fDatHang.maDH = ma;
            fDatHang.Show();
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            int maDH = int.Parse(txtMaDH.Text);
            int maSP = int.Parse(gVCTDH.CurrentRow.Cells["ProductID"].Value.ToString());
            bus.XoaCTDH(maDH, maSP);
            gVCTDH.Columns.Clear();
            bus.LayDSCTDH(gVCTDH, ma);
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

      
    }
}
