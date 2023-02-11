
namespace SlideShowApp
{
    partial class frmSlideShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbDrives = new System.Windows.Forms.ComboBox();
            this.lbDir = new System.Windows.Forms.ListBox();
            this.pbDirPics = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.brnPrev = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbDirPics)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDrives
            // 
            this.cbDrives.FormattingEnabled = true;
            this.cbDrives.Location = new System.Drawing.Point(39, 36);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(187, 21);
            this.cbDrives.TabIndex = 0;
            this.cbDrives.SelectedIndexChanged += new System.EventHandler(this.cbDrives_SelectedIndexChanged);
            // 
            // lbDir
            // 
            this.lbDir.FormattingEnabled = true;
            this.lbDir.Location = new System.Drawing.Point(40, 63);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(186, 251);
            this.lbDir.TabIndex = 1;
            this.lbDir.SelectedIndexChanged += new System.EventHandler(this.lbDir_SelectedIndexChanged);
            // 
            // pbDirPics
            // 
            this.pbDirPics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDirPics.Location = new System.Drawing.Point(232, 36);
            this.pbDirPics.Name = "pbDirPics";
            this.pbDirPics.Size = new System.Drawing.Size(408, 282);
            this.pbDirPics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDirPics.TabIndex = 2;
            this.pbDirPics.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(646, 36);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 42);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // brnPrev
            // 
            this.brnPrev.Location = new System.Drawing.Point(646, 84);
            this.brnPrev.Name = "brnPrev";
            this.brnPrev.Size = new System.Drawing.Size(94, 42);
            this.brnPrev.TabIndex = 4;
            this.brnPrev.Text = "Previous";
            this.brnPrev.UseVisualStyleBackColor = true;
            this.brnPrev.Click += new System.EventHandler(this.brnPrev_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(646, 132);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(94, 42);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(646, 180);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(94, 42);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(646, 228);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(94, 42);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(646, 276);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(94, 42);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.brnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbDirPics);
            this.Controls.Add(this.lbDir);
            this.Controls.Add(this.cbDrives);
            this.Name = "frmSlideShow";
            this.Text = "Slide Show";
            this.Load += new System.EventHandler(this.frmSlideShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDirPics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDrives;
        private System.Windows.Forms.ListBox lbDir;
        private System.Windows.Forms.PictureBox pbDirPics;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button brnPrev;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Timer timer1;
    }
}

