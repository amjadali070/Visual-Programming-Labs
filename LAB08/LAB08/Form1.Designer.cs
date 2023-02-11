
namespace LAB08
{
    partial class frmBuildPizza
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
            this.groupSize = new System.Windows.Forms.GroupBox();
            this.groupToppings = new System.Windows.Forms.GroupBox();
            this.groupCrust = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.cbExtraChees = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbOnions = new System.Windows.Forms.CheckBox();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupSize.SuspendLayout();
            this.groupToppings.SuspendLayout();
            this.groupCrust.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSize
            // 
            this.groupSize.Controls.Add(this.rbLarge);
            this.groupSize.Controls.Add(this.rbMedium);
            this.groupSize.Controls.Add(this.rbSmall);
            this.groupSize.Location = new System.Drawing.Point(102, 91);
            this.groupSize.Name = "groupSize";
            this.groupSize.Size = new System.Drawing.Size(297, 127);
            this.groupSize.TabIndex = 0;
            this.groupSize.TabStop = false;
            this.groupSize.Text = "Size";
            // 
            // groupToppings
            // 
            this.groupToppings.Controls.Add(this.cbOnions);
            this.groupToppings.Controls.Add(this.cbTomatoes);
            this.groupToppings.Controls.Add(this.cbMushrooms);
            this.groupToppings.Controls.Add(this.cbExtraChees);
            this.groupToppings.Location = new System.Drawing.Point(405, 91);
            this.groupToppings.Name = "groupToppings";
            this.groupToppings.Size = new System.Drawing.Size(297, 127);
            this.groupToppings.TabIndex = 1;
            this.groupToppings.TabStop = false;
            this.groupToppings.Text = "Toppings";
            // 
            // groupCrust
            // 
            this.groupCrust.Controls.Add(this.rbThickCrust);
            this.groupCrust.Controls.Add(this.rbThinCrust);
            this.groupCrust.Location = new System.Drawing.Point(102, 224);
            this.groupCrust.Name = "groupCrust";
            this.groupCrust.Size = new System.Drawing.Size(297, 50);
            this.groupCrust.TabIndex = 1;
            this.groupCrust.TabStop = false;
            this.groupCrust.Text = "Crust Type";
            // 
            // rbSmall
            // 
            this.rbSmall.Location = new System.Drawing.Point(6, 19);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(85, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.Location = new System.Drawing.Point(6, 55);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(85, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.Location = new System.Drawing.Point(6, 93);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(85, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.Location = new System.Drawing.Point(190, 20);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(85, 17);
            this.rbThickCrust.TabIndex = 4;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.Location = new System.Drawing.Point(60, 20);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(85, 17);
            this.rbThinCrust.TabIndex = 3;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // cbExtraChees
            // 
            this.cbExtraChees.AutoSize = true;
            this.cbExtraChees.Location = new System.Drawing.Point(6, 19);
            this.cbExtraChees.Name = "cbExtraChees";
            this.cbExtraChees.Size = new System.Drawing.Size(83, 17);
            this.cbExtraChees.TabIndex = 0;
            this.cbExtraChees.Text = "Extra Chees";
            this.cbExtraChees.UseVisualStyleBackColor = true;
            this.cbExtraChees.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Location = new System.Drawing.Point(6, 42);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(80, 17);
            this.cbMushrooms.TabIndex = 1;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Location = new System.Drawing.Point(6, 88);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(73, 17);
            this.cbTomatoes.TabIndex = 2;
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // cbOnions
            // 
            this.cbOnions.AutoSize = true;
            this.cbOnions.Location = new System.Drawing.Point(6, 65);
            this.cbOnions.Name = "cbOnions";
            this.cbOnions.Size = new System.Drawing.Size(59, 17);
            this.cbOnions.TabIndex = 3;
            this.cbOnions.Text = "Onions";
            this.cbOnions.UseVisualStyleBackColor = true;
            this.cbOnions.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.Location = new System.Drawing.Point(411, 244);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(85, 17);
            this.rbEatin.TabIndex = 4;
            this.rbEatin.TabStop = true;
            this.rbEatin.Text = "Eat In";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.Location = new System.Drawing.Point(531, 244);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(85, 17);
            this.rbTakeOut.TabIndex = 3;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(181, 303);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(218, 44);
            this.btnBuild.TabIndex = 5;
            this.btnBuild.Text = "Build Pizza";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(405, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(218, 44);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBuildPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.rbEatin);
            this.Controls.Add(this.rbTakeOut);
            this.Controls.Add(this.groupCrust);
            this.Controls.Add(this.groupToppings);
            this.Controls.Add(this.groupSize);
            this.Name = "frmBuildPizza";
            this.Text = "Select Your Order";
            this.groupSize.ResumeLayout(false);
            this.groupToppings.ResumeLayout(false);
            this.groupToppings.PerformLayout();
            this.groupCrust.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox groupToppings;
        private System.Windows.Forms.CheckBox cbExtraChees;
        private System.Windows.Forms.GroupBox groupCrust;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.CheckBox cbOnions;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnExit;
    }
}

