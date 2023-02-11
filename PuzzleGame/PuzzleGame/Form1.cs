using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class frmPuzzle : Form
    {
        List<int> val = new List<int>();
        List<int> val1 = new List<int>();
        int pic = 0;
       
        int count = 3;
        public frmPuzzle()
        {
            InitializeComponent();
        }

        private void frmPuzzle_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            pic = rand.Next(1, 18);
            val1.Add(pic);
            String str = "D:/puzzlePics/candy" + Convert.ToString(pic) + ".jpg";
            this.btnpic.Image = Image.FromFile(@str);
            this.btninfo.Text = "GUSESS PICTURE THREE TIMES FROM PUZZLE\n (Attempts allowed = 3)";
            for(int i = 0; i < 2; i++)
            {
                rand = new Random();
                int value = rand.Next(1, 18);
                val1.Add(value);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button obj = sender as Button;
            Random rand = new Random();
            int value = rand.Next(1, 18);
            while (val.Contains(value))
            {
                rand = new Random();
                value = rand.Next(1, 18);
            }
            String str = "D:/puzzlePics/candy" + Convert.ToString(pic) + ".jpg";
            if (val1.Contains(value))
            {
                obj.Image = Image.FromFile(@str);
                MessageBox.Show("YOU WON!");
                this.Dispose();
                
            }
           

            val.Add(value);
            count--;
             str = "D:/puzzlePics/candy" + Convert.ToString(value)+".jpg";
            obj.Image = Image.FromFile(@str);
            
            if (count == 0)
            {
                MessageBox.Show("YOU LOSE!");
                this.Dispose();
            }
            
            btninfo.Text = "GUSESS PICTURE THREE TIMES FROM PUZZLE\n (Attempts allowed = " + Convert.ToString(count) + ")";
            obj.Click -= btn1_Click;
        }
    }
}
