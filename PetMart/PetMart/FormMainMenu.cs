using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace PetMart
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Contructor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 75);
            panelMenu.Controls.Add(leftBorderBtn);
            
            //Set giao dien form: cac nut X, mở lớn, ẩn
            this.Text = "PET MART";
            //this.ControlBox = false;
            this.DoubleBuffered = true;
            //Dùng chuột di chuyển form đến rìa màn hình thì tự động mở full screen 
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
         

        }

        //Structs
            //Ham color
        private struct RGBColors
        {
            public static Color colorLightBlue = Color.FromArgb(154, 179, 245);
            public static Color menuColor = Color.FromArgb(117,121,231);
            public static Color white = Color.WhiteSmoke;
        }

        //Methods
        private void ActivateButton (object senderBtn, Color color)
        {
            if(senderBtn !=null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(154, 179, 245);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if(currentBtn !=null)
            {
               
                currentBtn.BackColor = Color.FromArgb(117, 121, 231);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.white);
            OpenChildForm(new FormQuanLySanPham());

        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.white);
            OpenChildForm(new FormQuanLyDonHang());
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.white);
            OpenChildForm(new FormQuanLyKhachHang());
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.white);
            OpenChildForm(new FormQuanLyNhanVien());
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.WhiteSmoke;
            lbTitleChildForm.Text = "TRANG CHỦ";

        }



        //Hàm chuyển qua form con
        private void OpenChildForm (Form childForm)
        {
            if( currentChildForm != null)
            {
                //Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lbTitleChildForm.Text = childForm.Text;
        }


        //Drag Form
      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
    }
}
