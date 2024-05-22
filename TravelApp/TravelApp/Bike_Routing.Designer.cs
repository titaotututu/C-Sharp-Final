namespace TravelApp
{
    partial class Biking_Routing
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
            this.webBrowser_bike = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser_bike);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 595);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser_bike
            // 
            this.webBrowser_bike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_bike.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_bike.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_bike.Name = "webBrowser_bike";
            this.webBrowser_bike.ScrollBarsEnabled = false;
            this.webBrowser_bike.Size = new System.Drawing.Size(1127, 595);
            this.webBrowser_bike.TabIndex = 0;
            // 
            // Biking_Routing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 610);
            this.Controls.Add(this.panel1);
            this.Name = "Biking_Routing";
            this.Text = "骑行路径规划";
            this.Load += new System.EventHandler(this.Biking_Routing_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser_bike;
    }
}