namespace TravelApp
{
    partial class Walk_Routing
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
            this.webBrowser_walk = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser_walk);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 426);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser_walk
            // 
            this.webBrowser_walk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_walk.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_walk.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_walk.Name = "webBrowser_walk";
            this.webBrowser_walk.ScrollBarsEnabled = false;
            this.webBrowser_walk.Size = new System.Drawing.Size(798, 426);
            this.webBrowser_walk.TabIndex = 0;
            // 
            // Walk_Routing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Walk_Routing";
            this.Text = "步行路径规划";
            this.Load += new System.EventHandler(this.Walk_Routing_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser_walk;
    }
}