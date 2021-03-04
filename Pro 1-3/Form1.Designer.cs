using System;

namespace Pro_1_3
{
    partial class MainForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblOuput = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblOutput2 = new System.Windows.Forms.Label();
            this.lblOutput3 = new System.Windows.Forms.Label();
            this.trkAge = new System.Windows.Forms.TrackBar();
            this.lblAge2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(118, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter your name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(70, 131);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(76, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Enter your age";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(29, 173);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(239, 13);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Enter your hieght in metres to the nearest decimal";
            // 
            // lblOuput
            // 
            this.lblOuput.AutoSize = true;
            this.lblOuput.Location = new System.Drawing.Point(87, 251);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(0, 13);
            this.lblOuput.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(197, 21);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 37);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit your info";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(288, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(288, 173);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 7;
            // 
            // lblOutput2
            // 
            this.lblOutput2.AutoSize = true;
            this.lblOutput2.Location = new System.Drawing.Point(168, 251);
            this.lblOutput2.Name = "lblOutput2";
            this.lblOutput2.Size = new System.Drawing.Size(0, 13);
            this.lblOutput2.TabIndex = 8;
            // 
            // lblOutput3
            // 
            this.lblOutput3.AutoSize = true;
            this.lblOutput3.Location = new System.Drawing.Point(118, 287);
            this.lblOutput3.Name = "lblOutput3";
            this.lblOutput3.Size = new System.Drawing.Size(0, 13);
            this.lblOutput3.TabIndex = 9;
            // 
            // trkAge
            // 
            this.trkAge.Location = new System.Drawing.Point(181, 112);
            this.trkAge.Maximum = 100;
            this.trkAge.Name = "trkAge";
            this.trkAge.Size = new System.Drawing.Size(315, 45);
            this.trkAge.TabIndex = 10;
            this.trkAge.Scroll += new System.EventHandler(this.trkAge_Scroll_1);
            // 
            // lblAge2
            // 
            this.lblAge2.AutoSize = true;
            this.lblAge2.Location = new System.Drawing.Point(539, 112);
            this.lblAge2.Name = "lblAge2";
            this.lblAge2.Size = new System.Drawing.Size(13, 13);
            this.lblAge2.TabIndex = 11;
            this.lblAge2.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 319);
            this.Controls.Add(this.lblAge2);
            this.Controls.Add(this.trkAge);
            this.Controls.Add(this.lblOutput3);
            this.Controls.Add(this.lblOutput2);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOuput);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "MainForm";
            this.Text = "Getting your info";
            ((System.ComponentModel.ISupportInitialize)(this.trkAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblOuput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblOutput2;
        private System.Windows.Forms.Label lblOutput3;
        private System.Windows.Forms.TrackBar trkAge;
        private System.Windows.Forms.Label lblAge2;
    }
}

