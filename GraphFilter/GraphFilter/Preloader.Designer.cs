namespace GraphFilter
{
    partial class Preloader
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
            this.runningProgress = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // runningProgress
            // 
            this.runningProgress.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.runningProgress.AnimationSpeed = 500;
            this.runningProgress.BackColor = System.Drawing.Color.Transparent;
            this.runningProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.runningProgress.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.runningProgress.InnerMargin = 2;
            this.runningProgress.InnerWidth = -1;
            this.runningProgress.Location = new System.Drawing.Point(242, 57);
            this.runningProgress.MarqueeAnimationSpeed = 2000;
            this.runningProgress.Name = "runningProgress";
            this.runningProgress.OuterColor = System.Drawing.Color.Gray;
            this.runningProgress.OuterMargin = -25;
            this.runningProgress.OuterWidth = 26;
            this.runningProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.runningProgress.ProgressWidth = 25;
            this.runningProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningProgress.Size = new System.Drawing.Size(320, 320);
            this.runningProgress.StartAngle = 270;
            this.runningProgress.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.runningProgress.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.runningProgress.SubscriptText = "";
            this.runningProgress.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.runningProgress.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.runningProgress.SuperscriptText = "";
            this.runningProgress.TabIndex = 0;
            this.runningProgress.Text = "Running";
            this.runningProgress.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // Preloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.runningProgress);
            this.Name = "Preloader";
            this.Text = "Preloader";
            this.Load += new System.EventHandler(this.Preloader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar runningProgress;
    }
}