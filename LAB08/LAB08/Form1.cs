using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB08
{
    public partial class frmBuildPizza : Form
    {
        String Size;
        String Crust;
        String Toppings;
        String orderType;
        


        public frmBuildPizza()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
           
            String order = "Size is: " + Size + "\n" +
                           "Toppings: "+Toppings+"\n" +
                           "Crust is: " + Crust + "\n" +
                             orderType + "\n";
            MessageBox.Show(order);


        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            Size = rb.Text;
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            Crust = rb.Text;
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            orderType = rb.Text;
        }

        private void cbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                Toppings = Toppings + " " + cb.Text;
            }
            if(!cb.Checked)
            {
                Toppings = Toppings.Replace(" "+cb.Text, "");
               

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
