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
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void Demo_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (this.btnDemo.Left > Width)
                this.btnDemo.Left = 0;
            this.btnDemo.Left = this.btnDemo.Left + 10;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(this.btnDemo.Left < 0)
                this.btnDemo.Left = Width;
            this.btnDemo.Left = this.btnDemo.Left - 10;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            if (this.btnDemo.Top < 0)
                this.btnDemo.Top = Height;

            this.btnDemo.Top = this.btnDemo.Top - 10;
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            if (this.btnDemo.Top > Height)
                this.btnDemo.Top = 0;
            this.btnDemo.Top = this.btnDemo.Top + 10;
        }
    }
}
