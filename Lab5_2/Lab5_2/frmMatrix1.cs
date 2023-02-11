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
    public partial class frmMatrix1 : Form
    {
        internal  int[,] array1 = new int[2, 3];
       
        

        public frmMatrix1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            array1[0, 0] = Convert.ToInt32(this.oneOne.Text);
            array1[0, 1] = Convert.ToInt32(this.oneTwo.Text);
            array1[0, 2] = Convert.ToInt32(this.oneThree.Text);
            array1[1, 0] = Convert.ToInt32(this.twoOne.Text);
            array1[1, 1] = Convert.ToInt32(this.twoTwo.Text);
            array1[1, 2] = Convert.ToInt32(this.twoThree.Text);
            this.Hide();
            Program.frm2.ShowDialog();


        }

    }
}
