﻿namespace libraryManagement
{
    partial class Frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmlogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginlbl = new System.Windows.Forms.Label();
            this.StdPic = new System.Windows.Forms.PictureBox();
            this.AdmPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.loginlbl);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 100);
            this.panel1.TabIndex = 9;
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlbl.ForeColor = System.Drawing.SystemColors.Window;
            this.loginlbl.Location = new System.Drawing.Point(202, 0);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(559, 105);
            this.loginlbl.TabIndex = 7;
            this.loginlbl.Text = "KELCO LIBRARY";
            // 
            // StdPic
            // 
            this.StdPic.Image = ((System.Drawing.Image)(resources.GetObject("StdPic.Image")));
            this.StdPic.Location = new System.Drawing.Point(498, 192);
            this.StdPic.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StdPic.Name = "StdPic";
            this.StdPic.Size = new System.Drawing.Size(165, 191);
            this.StdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StdPic.TabIndex = 12;
            this.StdPic.TabStop = false;
            this.StdPic.Click += new System.EventHandler(this.StdPic_Click);
            // 
            // AdmPic
            // 
            this.AdmPic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdmPic.Image = ((System.Drawing.Image)(resources.GetObject("AdmPic.Image")));
            this.AdmPic.Location = new System.Drawing.Point(306, 192);
            this.AdmPic.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AdmPic.Name = "AdmPic";
            this.AdmPic.Size = new System.Drawing.Size(162, 191);
            this.AdmPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdmPic.TabIndex = 13;
            this.AdmPic.TabStop = false;
            this.AdmPic.Click += new System.EventHandler(this.AdmPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(346, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(516, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "STUDENT";
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(947, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StdPic);
            this.Controls.Add(this.AdmPic);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frmlogin";
            this.Text = "login";
            this.Click += new System.EventHandler(this.login_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdmPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox StdPic;
        private System.Windows.Forms.PictureBox AdmPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}