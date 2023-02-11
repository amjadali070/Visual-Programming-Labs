using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class frmAdRotator : Form
    {
        String[] Urls;
        String Patteren;
        Regex regex;
        Match match;
        int i = 0;

        public frmAdRotator()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                
                    match = regex.Match(Urls[i++]);
                    if (match.Success)
                    {
                    
                        pictureBox1.ImageLocation = match.Value.Trim() ;
                    }
                    if (i == Urls.Length)
                    {
                        timer1.Stop(); 
                    }
                    

            
        }

        private void frmAdRotator_Load(object sender, EventArgs e)
        {
            Urls = File.ReadAllLines(@"D:\\puzzlePics\\paths.txt");
            //@"\s[A-Za-z0-9.\\]+\s"
            Patteren = @"\s[A-Za-z0-9.:\\]+\s";
            regex = new Regex(Patteren);
            
            
        }
    }
}


