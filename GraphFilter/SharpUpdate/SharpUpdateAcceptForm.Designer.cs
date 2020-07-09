﻿namespace SharpUpdate
{
    partial class SharpUpdateAcceptForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewVersion = new System.Windows.Forms.Label();
            this.btnDetails = new MetroFramework.Controls.MetroButton();
            this.btnNo = new MetroFramework.Controls.MetroButton();
            this.btnYes = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SharpUpdate.Properties.Resources.update;
            this.pictureBox.Location = new System.Drawing.Point(12, 8);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(80, 80);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(106, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "An update is available!\r\nWould you like to update?  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNewVersion
            // 
            this.lblNewVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNewVersion.Location = new System.Drawing.Point(143, 69);
            this.lblNewVersion.Name = "lblNewVersion";
            this.lblNewVersion.Size = new System.Drawing.Size(154, 19);
            this.lblNewVersion.TabIndex = 2;
            this.lblNewVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(259, 108);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseSelectable = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(178, 108);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "No";
            this.btnNo.UseSelectable = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(97, 108);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "Yes";
            this.btnYes.UseSelectable = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // SharpUpdateAcceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 150);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblNewVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SharpUpdateAcceptForm";
            this.Padding = new System.Windows.Forms.Padding(21, 72, 21, 23);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SharpUpdateAcceptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewVersion;
        private MetroFramework.Controls.MetroButton btnDetails;
        private MetroFramework.Controls.MetroButton btnNo;
        private MetroFramework.Controls.MetroButton btnYes;
    }
}