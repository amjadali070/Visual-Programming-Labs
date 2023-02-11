namespace LAB7
{
    partial class Form1
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
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStudents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(77, 33);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(177, 20);
            this.txtStudent.TabIndex = 0;
            this.txtStudent.Text = "Enter Student Name";
            this.txtStudent.Enter += new System.EventHandler(this.txtStudent_Enter);
            this.txtStudent.Leave += new System.EventHandler(this.txtStudent_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 33);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStudents.Location = new System.Drawing.Point(74, 56);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(261, 222);
            this.lblStudents.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 323);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStudents;
    }
}

