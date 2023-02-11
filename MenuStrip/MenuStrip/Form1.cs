﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
       
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog(); 
            o.ShowDialog(this); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.ContextMenuStrip = contextMenuStrip1;
        }
    }
}
