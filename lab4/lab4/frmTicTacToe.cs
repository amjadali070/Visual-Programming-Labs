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
    public partial class frmTicTacToe : Form
    {
        TicTacToe TT = new TicTacToe();

        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private void Click_Button(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (TT.getToogleValue())
            {
                button.Text = TT.getUserOne();
                TT.setToggleValue(false);
            }

            else
            {
                button.Text = TT.getUserTwo();
                TT.setToggleValue(true);
            }
               

            button.Enabled = false;
            CheckWinner();

        }
        public void CheckWinner()
        {
             void check()
            {
                if (TT.getToogleValue())
                {
                    this.lblInfo.Text = "Winner is : X";
                }
                else
                {
                    this.lblInfo.Text = "Winner is : O";
                }
                Won();
            }
            if(this.btnOne.Text==this.btnTwo.Text && btnTwo.Text == this.btnThree.Text && this.btnOne.Enabled == false)
                check();
            else if(this.btnFour.Text == this.btnFive.Text && btnSix.Text == this.btnFive.Text && this.btnFour.Enabled==false)
                check();
            else if (this.btnSeven.Text == this.btnEight.Text && btnNine.Text == this.btnEight.Text && this.btnSeven.Enabled == false)
                check();
            else if (this.btnOne.Text == this.btnFive.Text && btnNine.Text == this.btnFive.Text && this.btnOne.Enabled == false)
                check();
            else if (this.btnOne.Text == this.btnFour.Text && btnSeven.Text == this.btnFour.Text && this.btnOne.Enabled == false)
                check();
            else if (this.btnTwo.Text == this.btnFive.Text && btnEight.Text == this.btnFive.Text && this.btnTwo.Enabled == false)
                check();
            else if (this.btnThree.Text == this.btnSix.Text && btnNine.Text == this.btnSix.Text && this.btnThree.Enabled == false)
                check();

        }
        public void Won()
        {
            btnOne.Enabled = btnTwo.Enabled = btnThree.Enabled = btnFour.Enabled = btnFive.Enabled = btnSix.Enabled = btnSeven.Enabled = btnEight.Enabled = btnNine.Enabled = false;


        }
        private void PlayAgain()
        {
            btnOne.Text = btnTwo.Text = btnThree.Text = btnFour.Text = btnFive.Text = btnSix.Text = btnSeven.Text = btnEight.Text = btnNine.Text = "";
            btnOne.Enabled = btnTwo.Enabled = btnThree.Enabled = btnFour.Enabled = btnFive.Enabled = btnSix.Enabled = btnSeven.Enabled = btnEight.Enabled = btnNine.Enabled = true;
            TT.setToggleValue(true);
            lblInfo.Text = "Winner is : Still Playing";
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            PlayAgain();
        }
    }
}
