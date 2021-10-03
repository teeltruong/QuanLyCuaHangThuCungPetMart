using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetMart.BUS;
using PetMart.Report;

namespace PetMart
{
    public partial class FormQuanLyDonHang : Form
    {
        BUS_DonHang busDonHang;
        public FormQuanLyDonHang()
        {
            InitializeComponent();
            busDonHang = new BUS_DonHang();
        }

        private void CapNhapGridView()
        {
            gVDH.DataSource = null;
            busDonHang.HienThiDSDonHang(gVDH);
            gVDH.Columns[0].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[1].Width = (int)(0.2 * gVDH.Width);
            gVDH.Columns[2].Width = (int)(0.25 * gVDH.Width);
            gVDH.Columns[3].Width = (int)(0.3 * gVDH.Width);
           
        }

        private void FormQuanLyDonHang_Load(object sender, EventArgs e)
        {
            CapNhapGridView();
            busDonHang.HienThiDSKH(cbKhachHang);
            busDonHang.HienThiDSNV(cbNhanVien);

        }

        private void gVDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gVDH.Rows.Count)
            {
                txtMaDH.Enabled = false;
                txtMaDH.Text = gVDH.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                dtpNgayDH.Text = gVDH.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbKhachHang.Text = gVDH.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbNhanVien.Text = gVDH.Rows[e.RowIndex].Cells[3].Value.ToString();



            }
           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Order dh = new Order();
            dh.CustomerID = cbKhachHang.SelectedIndex;
            dh.CreatedDate = DateTime.Parse(dtpNgayDH.Value.ToString("yyyy/MM/dd"));
            dh.EmployeeID = Int32.Parse(cbNhanVien.SelectedValue.ToString());
            if (busDonHang.ThemDH(dh))
            {
                MessageBox.Show("Tạo đơn hàng thành công");
                busDonHang.HienThiDSDonHang(gVDH);
            }
            else
            {
                MessageBox.Show("Tạo đơn hàng thất bại");
            }



        }

        private void gVDH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma;
            ma = int.Parse(gVDH.CurrentRow.Cells[0].Value.ToString());
            //Truyen cho form CTDH
            FormChiTietDonHang fChiTietDH = new FormChiTietDonHang();
            fChiTietDH.ma = ma;
            fChiTietDH.ShowDialog();
        }

    

        private void btnThemCTDH_Click_1(object sender, EventArgs e)
        {
            FormChiTietDonHang fChiTietDH = new FormChiTietDonHang();
            fChiTietDH.ma = int.Parse(gVDH.CurrentRow.Cells["OrderID"].Value.ToString());
            fChiTietDH.ShowDialog();
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            Order dh = new Order();
            //dh.OrderID = int.Parse(gVDH.CurrentRow.Cells["OrderID"].Value.ToString());
            dh.OrderID = int.Parse(txtMaDH.Text);
            dh.CustomerID = int.Parse(cbKhachHang.SelectedValue.ToString());
            dh.EmployeeID = int.Parse(cbNhanVien.SelectedValue.ToString());
            //dh.CreatedDate = DateTime.Parse(dtpNgayDH.Value.ToString("yyyy/MM/dd"));
            dh.CreatedDate = dtpNgayDH.Value;
            if (busDonHang.SuaDH(dh))
            {
                MessageBox.Show("Sửa đơn hàng thành công");
                busDonHang.HienThiDSDonHang(gVDH);
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng thất bại");
            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            Order dh = new Order();
            //dh.OrderID = int.Parse(gVDH.CurrentRow.Cells["OrderID"].Value.ToString()); ;
            dh.OrderID = int.Parse(txtMaDH.Text);
            if(busDonHang.XoaDH(dh))
            {
                MessageBox.Show("Xóa đơn hàng thành công");
                busDonHang.HienThiDSDonHang(gVDH);
            }
            else
            {
                MessageBox.Show("Xóa đơn hàng thất bại");
            }
           
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_report_Click(object sender, EventArgs e)
        {

            cRDonDatHang r = new cRDonDatHang();
            FormReport f = new FormReport();
            r.SetDataSource(busDonHang.ReportHienThiDSDonHang());
            f.crystalReportViewer1.ReportSource = r;
            f.Show();
        }

        private void dtpNgayDH_ValueChanged(object sender, EventArgs e)
        {

        }



        //private void gVDH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    foreach(DataGridView row in gVDH.Rows)
        //    {
        //        row.DefaultCellStyle.ForeColor = Color.Black;

        //    }
        //}
    } 
    
}
