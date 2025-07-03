
namespace GuessThatWord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SplashBackground = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplashBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashBackground
            // 
            this.SplashBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SplashBackground.BackgroundImage")));
            this.SplashBackground.Location = new System.Drawing.Point(0, 0);
            this.SplashBackground.Margin = new System.Windows.Forms.Padding(4);
            this.SplashBackground.Name = "SplashBackground";
            this.SplashBackground.Size = new System.Drawing.Size(933, 615);
            this.SplashBackground.TabIndex = 0;
            this.SplashBackground.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Image = ((System.Drawing.Image)(resources.GetObject("lblLoading.Image")));
            this.lblLoading.Location = new System.Drawing.Point(305, 436);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(339, 106);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 615);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.SplashBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SplashBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SplashBackground;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer timer1;
    }
}

