
namespace Lab5_2
{
    partial class frmMatrix2
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.twoOne = new System.Windows.Forms.TextBox();
            this.twoTwo = new System.Windows.Forms.TextBox();
            this.oneTwo = new System.Windows.Forms.TextBox();
            this.oneThree = new System.Windows.Forms.TextBox();
            this.twoThree = new System.Windows.Forms.TextBox();
            this.oneOne = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubmit.Location = new System.Drawing.Point(329, 274);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 33);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // twoOne
            // 
            this.twoOne.Location = new System.Drawing.Point(263, 167);
            this.twoOne.Multiline = true;
            this.twoOne.Name = "twoOne";
            this.twoOne.Size = new System.Drawing.Size(69, 46);
            this.twoOne.TabIndex = 15;
            // 
            // twoTwo
            // 
            this.twoTwo.Location = new System.Drawing.Point(368, 167);
            this.twoTwo.Multiline = true;
            this.twoTwo.Name = "twoTwo";
            this.twoTwo.Size = new System.Drawing.Size(69, 46);
            this.twoTwo.TabIndex = 14;
            // 
            // oneTwo
            // 
            this.oneTwo.Location = new System.Drawing.Point(368, 82);
            this.oneTwo.Multiline = true;
            this.oneTwo.Name = "oneTwo";
            this.oneTwo.Size = new System.Drawing.Size(69, 46);
            this.oneTwo.TabIndex = 13;
            // 
            // oneThree
            // 
            this.oneThree.Location = new System.Drawing.Point(469, 82);
            this.oneThree.Multiline = true;
            this.oneThree.Name = "oneThree";
            this.oneThree.Size = new System.Drawing.Size(69, 46);
            this.oneThree.TabIndex = 12;
            // 
            // twoThree
            // 
            this.twoThree.Location = new System.Drawing.Point(469, 167);
            this.twoThree.Multiline = true;
            this.twoThree.Name = "twoThree";
            this.twoThree.Size = new System.Drawing.Size(69, 46);
            this.twoThree.TabIndex = 11;
            // 
            // oneOne
            // 
            this.oneOne.Location = new System.Drawing.Point(263, 82);
            this.oneOne.Multiline = true;
            this.oneOne.Name = "oneOne";
            this.oneOne.Size = new System.Drawing.Size(69, 46);
            this.oneOne.TabIndex = 10;
            // 
            // frmMatrix2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.twoOne);
            this.Controls.Add(this.twoTwo);
            this.Controls.Add(this.oneTwo);
            this.Controls.Add(this.oneThree);
            this.Controls.Add(this.twoThree);
            this.Controls.Add(this.oneOne);
            this.Name = "frmMatrix2";
            this.Text = "frmMatrix2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox twoOne;
        private System.Windows.Forms.TextBox twoTwo;
        private System.Windows.Forms.TextBox oneTwo;
        private System.Windows.Forms.TextBox oneThree;
        private System.Windows.Forms.TextBox twoThree;
        private System.Windows.Forms.TextBox oneOne;
    }
}