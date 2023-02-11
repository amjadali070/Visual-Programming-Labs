using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashedScreen
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            
            InitializeComponent();
            this.progressBar1.Minimum = this.progressBar1.Value = 0;
            this.progressBar1.Maximum = 10000;
            splash();
            
            
            
        }
        private void splash()
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value == 10000)
            {
                timer1.Stop();
                
                this.Dispose();
                return;
            }
                
            this.progressBar1.Value+=100;
            

        }
        
    }
}
