
namespace PetMart
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLNV = new FontAwesome.Sharp.IconButton();
            this.btnQLKH = new FontAwesome.Sharp.IconButton();
            this.btnQLDH = new FontAwesome.Sharp.IconButton();
            this.btnQLSP = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lbTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTiltle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(121)))), ((int)(((byte)(231)))));
            this.panelMenu.Controls.Add(this.btnQLNV);
            this.panelMenu.Controls.Add(this.btnQLKH);
            this.panelMenu.Controls.Add(this.btnQLDH);
            this.panelMenu.Controls.Add(this.btnQLSP);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(386, 1043);
            this.panelMenu.TabIndex = 0;
            // 
            // btnQLNV
            // 
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLNV.ForeColor = System.Drawing.Color.White;
            this.btnQLNV.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnQLNV.IconColor = System.Drawing.Color.White;
            this.btnQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNV.IconSize = 37;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 470);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnQLNV.Size = new System.Drawing.Size(386, 100);
            this.btnQLNV.TabIndex = 4;
            this.btnQLNV.Text = "  QUẢN LÝ NHÂN VIÊN";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKH.FlatAppearance.BorderSize = 0;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLKH.ForeColor = System.Drawing.Color.White;
            this.btnQLKH.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnQLKH.IconColor = System.Drawing.Color.White;
            this.btnQLKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLKH.IconSize = 37;
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Location = new System.Drawing.Point(0, 370);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnQLKH.Size = new System.Drawing.Size(386, 100);
            this.btnQLKH.TabIndex = 3;
            this.btnQLKH.Text = "  QUẢN LÝ KHÁCH HÀNG";
            this.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLDH
            // 
            this.btnQLDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDH.FlatAppearance.BorderSize = 0;
            this.btnQLDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDH.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLDH.ForeColor = System.Drawing.Color.White;
            this.btnQLDH.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnQLDH.IconColor = System.Drawing.Color.White;
            this.btnQLDH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDH.IconSize = 37;
            this.btnQLDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDH.Location = new System.Drawing.Point(0, 270);
            this.btnQLDH.Name = "btnQLDH";
            this.btnQLDH.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnQLDH.Size = new System.Drawing.Size(386, 100);
            this.btnQLDH.TabIndex = 2;
            this.btnQLDH.Text = "  QUẢN LÝ ĐƠN HÀNG";
            this.btnQLDH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDH.UseVisualStyleBackColor = true;
            this.btnQLDH.Click += new System.EventHandler(this.btnQLDH_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSP.FlatAppearance.BorderSize = 0;
            this.btnQLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSP.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLSP.ForeColor = System.Drawing.Color.White;
            this.btnQLSP.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnQLSP.IconColor = System.Drawing.Color.White;
            this.btnQLSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLSP.IconSize = 37;
            this.btnQLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSP.Location = new System.Drawing.Point(0, 170);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnQLSP.Size = new System.Drawing.Size(386, 100);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "  QUẢN LÝ SẢN PHẨM";
            this.btnQLSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(386, 170);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sigmar One", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.label1.Location = new System.Drawing.Point(52, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "PETMART";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(118, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(173)))));
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.lbTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(386, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1310, 88);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(173)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lbTitleChildForm.Location = new System.Drawing.Point(67, 30);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(119, 24);
            this.lbTitleChildForm.TabIndex = 0;
            this.lbTitleChildForm.Text = "TRANG CHỦ";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.labelTiltle);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(386, 88);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1310, 955);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Loko", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(484, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 64);
            this.label2.TabIndex = 3;
            this.label2.Text = "HỆ THỐNG";
            // 
            // labelTiltle
            // 
            this.labelTiltle.AutoSize = true;
            this.labelTiltle.Font = new System.Drawing.Font("UTM Loko", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiltle.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.labelTiltle.Location = new System.Drawing.Point(129, 121);
            this.labelTiltle.Name = "labelTiltle";
            this.labelTiltle.Size = new System.Drawing.Size(826, 80);
            this.labelTiltle.TabIndex = 2;
            this.labelTiltle.Text = "CỬA HÀNG THÚ CƯNG PETMART";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(22, 182);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1232, 936);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1696, 1043);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1714, 1090);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1714, 1028);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnQLSP;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnQLNV;
        private FontAwesome.Sharp.IconButton btnQLKH;
        private FontAwesome.Sharp.IconButton btnQLDH;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelTiltle;
        private System.Windows.Forms.Label label2;
    }
}

