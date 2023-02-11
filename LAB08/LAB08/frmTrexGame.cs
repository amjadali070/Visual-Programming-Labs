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
    public partial class frmTrexGame : Form
    {
        public frmTrexGame()
        {
            
            InitializeComponent();
            pbTrex.ImageLocation = @"trexImages\running.gif";
            pbObstacle1.ImageLocation = @"trexImages\obstacle-1.gif";
            pbObstacle2.ImageLocation = @"trexImages\obstacle-2.gif";
            tmGame.Start();

        }

        private void tmGame_Tick(object sender, EventArgs e)
        {
            pbObstacle1.Left -= 30;
            pbObstacle2.Left -= 30;


        }

        private void frmTrexGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pbTrex.Top -= 80;
            }
        }

        private void frmTrexGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                pbTrex.Top += 80;
            }
        }

        private void tmJmp_Tick(object sender, EventArgs e)
        {

        }
    }
}
