using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class ShortcutApp : Form
    {
        Button btnPaint = new Button();
        Button btnPpt = new Button();
        Button btnNotepad = new Button();
        public ShortcutApp()
        {
            this.Controls.Add(btnPpt);
            this.Controls.Add(btnNotepad);
            this.Controls.Add(btnPaint);
            InitializeComponent();
        }

        private void ShortcutApp_Load(object sender, EventArgs e)
        {
            btnPaint.Text = "Paint";
            btnNotepad.Text = "Notepad";
            btnPpt.Text = "PowerPoint";

            btnPpt.SetBounds(20, 35, 150, 40);
            btnPaint.SetBounds(20, 105, 150, 40);
            btnNotepad.SetBounds(20, 180, 150, 40);

            

            btnNotepad.Click += RunApp;
            btnPaint.Click += RunApp;
            btnPpt.Click += RunApp;




        }
        private void RunApp(object Sender , EventArgs e)
        {
            Button button = Sender as Button;
            if(button == btnNotepad)
            {
                System.Diagnostics.Process.Start("notepad.exe");

            }
            else if(button == btnPpt)
            {
                System.Diagnostics.Process.Start("powerpnt.exe");

            }
            else if(button == btnPaint)
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
        }
    }
}
