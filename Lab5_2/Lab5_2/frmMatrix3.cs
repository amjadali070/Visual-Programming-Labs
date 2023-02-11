using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class frmMatrix3 : Form
    {
        internal  int[,] array3 = new int[2, 3];
        internal frmMatrix2 frm2 ;
        internal frmMatrix1 frm1;
        public frmMatrix3(frmMatrix1 frm1 , frmMatrix2 frm2)
        {
            this.frm1 = frm1;
            this.frm2 = frm2;
            

            
            InitializeComponent();
            

        }
        public frmMatrix3()
        {
            InitializeComponent();
        }
       
        internal void sum()
        {
            array3[0, 0] = frm1.array1[0, 0] + frm2.array2[0, 0];
            array3[0, 1] = frm1.array1[0, 1] + frm2.array2[0, 1];
            array3[0, 2] = frm1.array1[0, 2] + frm2.array2[0, 2];
            array3[1, 0] = frm1.array1[1, 0] + frm2.array2[1, 0];
            array3[1, 1] = frm1.array1[1, 1] + frm2.array2[1, 1];
            array3[1, 2] = frm1.array1[1, 2] + frm2.array2[1, 2];
        }
        internal void showMatrix()
        {
            String msg = Convert.ToString(array3[0, 0]) + "           " + Convert.ToString(array3[0, 1]) + "           " + Convert.ToString(array3[0, 2]) + "\n" +
                         Convert.ToString(array3[1, 0]) + "           " + Convert.ToString(array3[1, 1]) + "           " + Convert.ToString(array3[1, 2]) + "\n\n";
            this.label1.Text = msg;
        }
        internal void callSum()
        {
            sum();
            showMatrix();
        }

        private void endApp_Click(object sender, EventArgs e)
        {

            
            frm1.Dispose();
            frm2.Dispose();
            this.Dispose();
        }
    }
}
