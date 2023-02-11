using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class calculator : Form
    {
        int result;
        String op;

        public calculator()
        {
            InitializeComponent();
        }

        private void all_Btn_clicks(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button.Text=="clear")
                this.txtCaclulator.Text ="0";
            else if(button.Text == "/")
            {
                result = Convert.ToInt32(this.txtCaclulator.Text);
                op = "/";
                this.txtCaclulator.Text = "0";
            }
            else if (button.Text == "x")
            {
                result = Convert.ToInt32(this.txtCaclulator.Text);
                op = "x";
                this.txtCaclulator.Text = "0";


            }
            else if (button.Text == "+")
            {
                result = Convert.ToInt32(this.txtCaclulator.Text);
                op = "+";
                this.txtCaclulator.Text = "0";

            }
            else if (button.Text == "-")
            {
                result = Convert.ToInt32(this.txtCaclulator.Text);
                op = "-";
                this.txtCaclulator.Text = "0";

            }
            else if (button.Text == "=")
            {
               

                if (op == "/")
                {
                    result /= Convert.ToInt32(this.txtCaclulator.Text);
                }
                else if (op == "x")
                {
                    result *= Convert.ToInt32(this.txtCaclulator.Text);
                }
                else if (op == "+")
                {
                    result += Convert.ToInt32(this.txtCaclulator.Text);
                }
                else if (op == "-")
                {
                    result -= Convert.ToInt32(this.txtCaclulator.Text);
                }
                this.txtCaclulator.Text = Convert.ToString(result); 


            }
            else
                this.txtCaclulator.Text += button.Text;
        }
    }
}
