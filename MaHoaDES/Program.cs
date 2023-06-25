﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaHoaDES.BieuMau;

namespace MaHoaDES
{
    static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMaHoaDES());
        }
    }
}
