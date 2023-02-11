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

namespace Lab5
{
    public partial class PictureViewer : Form
    {
        String[] allPics = Directory.GetFiles(@"F:\Infinix Note 7\DCIM\Facebook");
        
        int cur = 0;
        bool check = true;
       
        

        public PictureViewer()
        {
            InitializeComponent();
        }

       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PictureViewer_Load(object sender, EventArgs e)
        {
            this.picSlideShow.ImageLocation = allPics[cur];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            cur--;
            if (cur <= 0)
                cur = allPics.Length - 1;
            this.picSlideShow.ImageLocation = allPics[cur];
            fileLocation.Text = allPics[cur];
            check = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cur = (cur + 1) % allPics.Length;

            this.picSlideShow.ImageLocation = allPics[cur];
            fileLocation.Text = allPics[cur];
            check = true;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                cur = (cur + 1) % allPics.Length;

                this.picSlideShow.ImageLocation = allPics[cur];
                fileLocation.Text = allPics[cur];

            }
            else
            {
                cur--;
                if (cur <= 0)
                    cur = allPics.Length - 1;
                this.picSlideShow.ImageLocation = allPics[cur];
                fileLocation.Text = allPics[cur];

            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
         
            timer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer.Stop();

        }
    }
}
