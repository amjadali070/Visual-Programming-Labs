using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        List<Label> lblContacts = new List<Label>();
        List<TextBox> txtContacts = new List<TextBox>();
        Label lbl;
        TextBox txt;
        int i = 2;
        bool check = true;
        Button btnRemove = new Button();
        


        int a;

        public Form1()
        {
            btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            InitializeComponent();
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            if (check)
            {
                lblContacts.Add(lblContact1);
                txtContacts.Add(txtConatct1);
                btnRemove.Text = "Remove";
                btnRemove.Top = btnAddMore.Top;
                btnRemove.Left = btnAddMore.Right + 10;
                this.Controls.Add(btnRemove);
                check = false;
            }
            lbl = new Label();
            txt = new TextBox();
            a = this.lblPassword.Top - this.lblUsername.Bottom;
            lbl.Text = "Enter Contact No#"+ Convert.ToString(i);
            i++;
            lbl.Width = lblContact1.Width;
            lbl.Left = lblContact1.Left;

            lbl.Top = btnAddMore.Bottom + a;

            txt.Width = txtConatct1.Width;
            txt.Left = txtConatct1.Left;
            txt.Top = lbl.Top;

            btnAddMore.Top = lbl.Top;
            btnClear.Top = btnSubmit.Top = btnAddMore.Bottom + a;
            btnRemove.Top = btnAddMore.Top;

            lblContacts.Add(lbl);
            txtContacts.Add(txt);



           
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            
           


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (check)
            {
                
                return;
            }
            i--;
            lbl = lblContacts[lblContacts.Count - 1];
            txt = txtContacts[txtContacts.Count - 1];
            lblContacts.RemoveAt(lblContacts.Count - 1);
            txtContacts.RemoveAt(txtContacts.Count - 1);
            btnSubmit.Top = btnClear.Top = lbl.Top;
            btnAddMore.Top = btnRemove.Top = lblContacts[lblContacts.Count - 1].Top;
            
            this.Controls.Remove(lbl);
            this.Controls.Remove(txt);
            if (i == 2)
            {
                check = true;
                this.Controls.Remove(btnRemove);
            }



        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string message = "Username : " + txtUsername.Text + "\n" +
                             "Password : " + "********" + "\n";
            int k = 0;
            while (k!=txtContacts.Count)
            {
                message +="Contact#" + Convert.ToString(k+1) +" "+ txtContacts[k].Text+"\n"  ;
                k++;
            }

                             

            string title = "Add Contact";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                message = "Contact is Added";
                MessageBox.Show(message, title);
            }
            else
            {
                // Do something  
            }
        }
    }
}
