using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace LAB08
{
    public partial class frmSignUp : Form
    {
        String UserName;
        String Password;
       
        String str ="";
        Regex reg = new Regex(@"^[a-zA-Z0-9_]");
        String[] users;
      

        public frmSignUp()
        {
            InitializeComponent();
        }
        
        bool verification()
        {
            
           
            if (UserName.Length <= 8)
            {
                str = ("Username should contain more than 8 charcters" + "\n");
                
                return false;
            }
            if (Password.Length <= 8)
            {
                str = ("Password should contain more than 8 charcters" + "\n");
                
                return false;

            }
            if (!reg.IsMatch(Password))
            {
                str = ("Password should be alphanumeric" + "\n");
                
                return false;

            }
            return true;
           
        }
        bool Validation()
        {
            string user = "";
            users = File.ReadAllLines("users.txt");


            foreach (String str1 in users)
            {
                int i = 0;
                while (true)
                {

                    if (str1[i] == ':')
                    {
                        break;
                    }
                    user += str1[i];
                    i++;

                }

                if (UserName == user)
                {
                  
                    MessageBox.Show("User Already Exist");
                    return false;
                }
                user = "";
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserName = txtUsername.Text;
            Password = txtPassword.Text;
           
           
           
            if (!verification())
            {
                MessageBox.Show(str);
                
                return;
            }
            if (!Validation())
            {
                return;
            }
            

            StreamWriter obj = File.AppendText("users.txt");
            obj.WriteLine(UserName + ":" + Password);
            obj.Close();
            MessageBox.Show("User Added");
            txtUsername.Text = txtPassword.Text = "";
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtPassword.Text = "";
        }
    }
}
