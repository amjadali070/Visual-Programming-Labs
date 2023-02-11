using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    static class Program
    {
       

        internal static frmMatrix1 frm1;
        internal static frmMatrix2 frm2;
        internal static frmMatrix3 frm3;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm1 = new frmMatrix1();
            frm2 = new frmMatrix2();
            frm3 = new frmMatrix3(frm1,frm2);
            Application.Run(frm1);
            
            
            
        }
    }
}
