﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetMart
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DangNhap());
            //Application.Run(new FormMainMenu());
            //Application.Run(new FormIndex());
            Application.Run(new FormDangNhapAdmin());
            //Application.Run(new FormDangKyAdmin());

        }
    }
}
