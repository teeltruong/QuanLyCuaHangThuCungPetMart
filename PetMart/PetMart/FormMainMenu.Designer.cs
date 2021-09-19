
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLNV = new FontAwesome.Sharp.IconButton();
            this.btnQLKH = new FontAwesome.Sharp.IconButton();
            this.btnQLDH = new FontAwesome.Sharp.IconButton();
            this.btnQLSP = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lbTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(261, 675);
            this.panelMenu.TabIndex = 0;
            // 
            // btnQLNV
            // 
            this.btnQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLNV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLNV.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.btnQLNV.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNV.IconSize = 37;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 395);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnQLNV.Size = new System.Drawing.Size(261, 75);
            this.btnQLNV.TabIndex = 4;
            this.btnQLNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLKH
            // 
            this.btnQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKH.FlatAppearance.BorderSize = 0;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLKH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLKH.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnQLKH.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLKH.IconSize = 37;
            this.btnQLKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKH.Location = new System.Drawing.Point(0, 320);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnQLKH.Size = new System.Drawing.Size(261, 75);
            this.btnQLKH.TabIndex = 3;
            this.btnQLKH.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLDH
            // 
            this.btnQLDH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLDH.FlatAppearance.BorderSize = 0;
            this.btnQLDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDH.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLDH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLDH.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnQLDH.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLDH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDH.IconSize = 37;
            this.btnQLDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDH.Location = new System.Drawing.Point(0, 245);
            this.btnQLDH.Name = "btnQLDH";
            this.btnQLDH.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnQLDH.Size = new System.Drawing.Size(261, 75);
            this.btnQLDH.TabIndex = 2;
            this.btnQLDH.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.btnQLDH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDH.UseVisualStyleBackColor = true;
            this.btnQLDH.Click += new System.EventHandler(this.btnQLDH_Click);
            // 
            // btnQLSP
            // 
            this.btnQLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLSP.FlatAppearance.BorderSize = 0;
            this.btnQLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLSP.Font = new System.Drawing.Font("Montserrat ExtraBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLSP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLSP.IconChar = FontAwesome.Sharp.IconChar.Cubes;
            this.btnQLSP.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnQLSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLSP.IconSize = 37;
            this.btnQLSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLSP.Location = new System.Drawing.Point(0, 170);
            this.btnQLSP.Name = "btnQLSP";
            this.btnQLSP.Padding = new System.Windows.Forms.Padding(8, 0, 5, 0);
            this.btnQLSP.Size = new System.Drawing.Size(261, 75);
            this.btnQLSP.TabIndex = 1;
            this.btnQLSP.Text = "QUẢN LÝ SẢN PHẨM";
            this.btnQLSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(261, 170);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(173)))));
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.lbTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(261, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1024, 74);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(173)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTitleChildForm.Location = new System.Drawing.Point(67, 27);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(119, 24);
            this.lbTitleChildForm.TabIndex = 0;
            this.lbTitleChildForm.Text = "TRANG CHỦ";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(261, 74);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1024, 601);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1285, 675);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
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
    }
}

