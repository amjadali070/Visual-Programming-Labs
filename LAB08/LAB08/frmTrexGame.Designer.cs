
namespace LAB08
{
    partial class frmTrexGame
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
            this.lblScore = new System.Windows.Forms.Label();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbTrex = new System.Windows.Forms.PictureBox();
            this.pbObstacle1 = new System.Windows.Forms.PictureBox();
            this.pbObstacle2 = new System.Windows.Forms.PictureBox();
            this.tmGame = new System.Windows.Forms.Timer(this.components);
            this.tmJmp = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(50, 52);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // pbGround
            // 
            this.pbGround.Location = new System.Drawing.Point(3, 270);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(905, 291);
            this.pbGround.TabIndex = 1;
            this.pbGround.TabStop = false;
            // 
            // pbTrex
            // 
            this.pbTrex.Location = new System.Drawing.Point(161, 494);
            this.pbTrex.Name = "pbTrex";
            this.pbTrex.Size = new System.Drawing.Size(86, 57);
            this.pbTrex.TabIndex = 2;
            this.pbTrex.TabStop = false;
            // 
            // pbObstacle1
            // 
            this.pbObstacle1.Location = new System.Drawing.Point(408, 494);
            this.pbObstacle1.Name = "pbObstacle1";
            this.pbObstacle1.Size = new System.Drawing.Size(74, 67);
            this.pbObstacle1.TabIndex = 3;
            this.pbObstacle1.TabStop = false;
            // 
            // pbObstacle2
            // 
            this.pbObstacle2.Location = new System.Drawing.Point(685, 504);
            this.pbObstacle2.Name = "pbObstacle2";
            this.pbObstacle2.Size = new System.Drawing.Size(85, 57);
            this.pbObstacle2.TabIndex = 4;
            this.pbObstacle2.TabStop = false;
            // 
            // tmGame
            // 
            this.tmGame.Tick += new System.EventHandler(this.tmGame_Tick);
            // 
            // tmJmp
            // 
            this.tmJmp.Interval = 300;
            this.tmJmp.Tick += new System.EventHandler(this.tmJmp_Tick);
            // 
            // frmTrexGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 573);
            this.Controls.Add(this.pbObstacle2);
            this.Controls.Add(this.pbObstacle1);
            this.Controls.Add(this.pbTrex);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.lblScore);
            this.Name = "frmTrexGame";
            this.Text = "frmTrexGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTrexGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmTrexGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObstacle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbTrex;
        private System.Windows.Forms.PictureBox pbObstacle1;
        private System.Windows.Forms.PictureBox pbObstacle2;
        private System.Windows.Forms.Timer tmGame;
        private System.Windows.Forms.Timer tmJmp;
    }
}