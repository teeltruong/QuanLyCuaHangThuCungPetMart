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
    public partial class FormDatHang : Form
    {
        BUS_SanPham busSP;
        BUS_DatHang busDatHang;
        BUS_DonHang busDH;
        public int maDH;
        bool flag = false;
        DataTable dtSanPham;
        public FormDatHang()
        {
            InitializeComponent();
            busSP = new BUS_SanPham();
            busDatHang = new BUS_DatHang();
            busDH = new BUS_DonHang();
        }

        private void CapNhapGridView()
        {
            dtSanPham = new DataTable();

            dtSanPham.Columns.Add("ProductID");
            dtSanPham.Columns.Add("UnitPrice");
            dtSanPham.Columns.Add("Quantity");
            dtSanPham.Columns.Add("Size");

            //Them datatable vao datagridview
            dGSP.DataSource = dtSanPham;

            dGSP.Columns[0].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[1].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[2].Width = (int)(0.2 * dGSP.Width);
            dGSP.Columns[3].Width = (int)(0.32 * dGSP.Width);
        }


     

        //private void HienThiThongTinSP(string ma)
        //{
        //    ProductMode p = busDatHang.HienThiDSSP(int.Parse(ma));
        //    txtLoaiSP.Text = p.CategoryName;
        //    txtDonGia.Text = p.Price.ToString();
        //    txtNCC.Text = p.CompanyName;
        //}


        // Chon 1 SP -> hien thi thong tin len textbox
        private void cbSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p;
            int maSP;
            //Dua vao thong tin san pham -> Lay ma san pham
         
            if (flag == true)
            {
                maSP = Int32.Parse(cbSP.SelectedValue.ToString());
                p = busSP.LayThongTinSP(maSP);
                //Hien thi ra cac textbox
                txtLoaiSP.Text = p.Category.CategoryName.ToString();
                KichCo.Text = p.Size.ToString();
                txtDonGia.Text = p.Price.ToString();
                KichCo.Text = p.Size.ToString();
                
            }
               
        }
        private void dGSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGSP.Rows.Count)
            {
                txtDonGia.Text = dGSP.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                txtSize.Text = dGSP.Rows[e.RowIndex].Cells["Size"].Value.ToString();
                if (dGSP.Rows[e.RowIndex].Cells["ProductID"].Value.ToString() != "")
                {
                    busSP.Lay1SP(cbSP, int.Parse(dGSP.Rows[e.RowIndex]
                        .Cells["ProductID"].Value.ToString()));
                    numSoLuong.Value = int.Parse(dGSP.Rows[e.RowIndex]
                        .Cells["Quantity"].Value.ToString());
                }
                else
                {
                    busSP.LayDSSP(cbSP);
                }
            }
        }


        private void btThem_Click_1(object sender, EventArgs e)
        {
            bool kiemtra = true;
            foreach (DataRow item in dtSanPham.Rows)
            {
                if (item[0].ToString() == cbSP.SelectedValue.ToString())
                {
                    kiemtra = false;
                    item[2] = int.Parse(item[2].ToString()) + numSoLuong.Value;
                    break;
                }
            }

            if (kiemtra)
            {

                DataRow dataRow = dtSanPham.NewRow();
                dataRow[0] = Int32.Parse(cbSP.SelectedValue.ToString());
                dataRow[1] = Int32.Parse(txtDonGia.Text.Replace(".", ""));
                dataRow[2] = Convert.ToInt32(numSoLuong.Value.ToString());
                dataRow[3] = txtSize.Text;

                dtSanPham.Rows.Add(dataRow);
            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            dtSanPham.Rows.RemoveAt(dGSP.CurrentRow.Index);

        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            bool kt = true;

            if (numSoLuong.Value.Equals(""))
            {
                kt = false;
                MessageBox.Show("Vui lòng không bỏ trống đơn giá/ số lượng sản phẩm",
                   "Thông báo", MessageBoxButtons.OK);
            }
            if (kt)
            {
                int t = dGSP.CurrentRow.Index;
                DataRow d = dtSanPham.Rows[t];
                d[2] = numSoLuong.Value;
                d.AcceptChanges();
            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btTaoDonHang_Click_1(object sender, EventArgs e)
        {
            OrderDetail o = new OrderDetail();
            o.OrderID = maDH;
            o.ProductID = int.Parse(cbSP.SelectedValue.ToString());
            o.Quantity = short.Parse(numSoLuong.Value.ToString());
            o.UnitPrice = Int32.Parse(txtDonGia.Text.Replace(".", ""));
            
            if (busDH.ThemCTDH(maDH, dtSanPham))
            {
                MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK);
                Close();
            }
            else
                MessageBox.Show("Đặt hàng không thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void FormDatHang_Load(object sender, EventArgs e)
        {
            txtLoaiSP.Enabled = false;
            txtSize.Enabled = false;
            txtDonGia.Enabled = false;
            txtMaDH.Enabled = false;
            //Hien thi DS SP ra combobox
            busSP.LayDSSP(cbSP);
            cbSP.SelectedIndex = 1;
            flag = true;
            //Hien thi ma DH
            txtMaDH.Text = maDH.ToString();
            CapNhapGridView();
        }
    }
}
