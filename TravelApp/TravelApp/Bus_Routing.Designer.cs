namespace TravelApp
{
    partial class Bus_Routing
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
            this.webBrowser_bus = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser_bus);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 693);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser_bus
            // 
            this.webBrowser_bus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_bus.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_bus.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_bus.Name = "webBrowser_bus";
            this.webBrowser_bus.ScrollBarsEnabled = false;
            this.webBrowser_bus.Size = new System.Drawing.Size(1137, 693);
            this.webBrowser_bus.TabIndex = 0;
            this.webBrowser_bus.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Bus_Routing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 718);
            this.Controls.Add(this.panel1);
            this.Name = "Bus_Routing";
            this.Text = "公交行程规划";
            this.Load += new System.EventHandler(this.Bus_Routing_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser_bus;
    }
}