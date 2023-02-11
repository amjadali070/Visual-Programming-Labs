using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5_2;

namespace Lab5_2
{
    public partial class frmMatrix2 : Form
    {
       
        internal int[,] array2 = new int[2, 3];
        
        public frmMatrix2()
        {
            InitializeComponent();
        }

       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            array2[0, 0] = Convert.ToInt32(this.oneOne.Text);
            array2[0, 1] = Convert.ToInt32(this.oneTwo.Text);
            array2[0, 2] = Convert.ToInt32(this.oneThree.Text);
            array2[1, 0] = Convert.ToInt32(this.twoOne.Text);
            array2[1, 1] = Convert.ToInt32(this.twoTwo.Text);
            array2[1, 2] = Convert.ToInt32(this.twoThree.Text);
            Program.frm3.callSum();
            this.Hide();
            Program.frm3.ShowDialog();
           
        }
        
    }
}
