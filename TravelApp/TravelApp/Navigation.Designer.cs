namespace TravelApp
{
    partial class Navigation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser_navi = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser_navi);
            this.panel1.Location = new System.Drawing.Point(5, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 681);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser_navi
            // 
            this.webBrowser_navi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_navi.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_navi.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_navi.Name = "webBrowser_navi";
            this.webBrowser_navi.ScrollBarsEnabled = false;
            this.webBrowser_navi.Size = new System.Drawing.Size(1222, 681);
            this.webBrowser_navi.TabIndex = 0;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 692);
            this.Controls.Add(this.panel1);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser_navi;
    }
}