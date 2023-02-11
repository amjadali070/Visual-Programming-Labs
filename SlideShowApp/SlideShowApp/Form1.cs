using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShowApp
{
    public partial class frmSlideShow : Form
    {
        FileInfo[] files;
        int Size = 0;
        int loc = 0;
        string[] images;
        public frmSlideShow()
        {
            InitializeComponent();
        }

        private void frmSlideShow_Load(object sender, EventArgs e)
        {
            try
            {
                DriveInfo[] drives = DriveInfo.GetDrives();

                foreach (DriveInfo dir in drives)
                {
                    cbDrives.Items.Add(dir.Name);
                }
                cbDrives.Text = drives[0].Name;
            }
            catch(Exception ee)
            {

            }
            
            
        }

        private void cbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbDir.Items.Clear();
                DirectoryInfo directory = new DirectoryInfo(cbDrives.Text);
                DirectoryInfo[] directories = directory.GetDirectories();
                lbDir.Items.AddRange(directories);
            }
            catch(Exception ee)
            {

            }
        }

        private void lbDir_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Size = 0;
                DirectoryInfo directory = new DirectoryInfo(cbDrives.Text+lbDir.Text);
                files = directory.GetFiles();
                foreach(FileInfo f in files)
                {
                    
                    
                    if(f.Extension ==".png"|| f.Extension == ".jpeg" || f.Extension == ".jpg")
                    {
                        Size += 1;
                    }
                }
                images = new string[Size];
                Size = 0;
                foreach (FileInfo f in files)
                {

                    if (f.Extension == ".png" || f.Extension == ".jpeg" || f.Extension == ".jpg")
                    {
                        images[Size++] = f.FullName;
                    }
                }
                
                pbDirPics.ImageLocation = images[0];


            }
            catch (Exception ee)
            {

            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                loc = (loc + 1) % Size;
                pbDirPics.ImageLocation = images[loc];
            }
            catch(Exception ee) { }

        }

        private void brnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                loc--;
                if (loc == -1)
                    loc = Size - 1;
                pbDirPics.ImageLocation = images[loc];
            }
            catch (Exception ee) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                loc = (loc + 1) % Size;
                pbDirPics.ImageLocation = images[loc];
            }
            catch (Exception ee) { }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pbDirPics.ImageLocation = images[0];
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pbDirPics.ImageLocation = images[Size-1];
        }
    }
}
