﻿
namespace Lab5_2
{
    partial class frmMatrix3
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
            this.endApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endApp
            // 
            this.endApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.endApp.Location = new System.Drawing.Point(136, 85);
            this.endApp.Name = "endApp";
            this.endApp.Size = new System.Drawing.Size(268, 39);
            this.endApp.TabIndex = 0;
            this.endApp.Text = "END APPLICATION";
            this.endApp.UseVisualStyleBackColor = true;
            this.endApp.Click += new System.EventHandler(this.endApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // frmMatrix3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endApp);
            this.Name = "frmMatrix3";
            this.Text = "frmMatrix3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button endApp;
        private System.Windows.Forms.Label label1;
    }
}