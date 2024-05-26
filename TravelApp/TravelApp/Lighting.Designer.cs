namespace TravelApp
{
    partial class Lighting
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
            this.webBrowser_light = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_light = new System.Windows.Forms.Button();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser_light);
            this.panel1.Location = new System.Drawing.Point(27, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 464);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser_light
            // 
            this.webBrowser_light.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser_light.Location = new System.Drawing.Point(0, 0);
            this.webBrowser_light.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_light.Name = "webBrowser_light";
            this.webBrowser_light.ScrollBarsEnabled = false;
            this.webBrowser_light.Size = new System.Drawing.Size(676, 464);
            this.webBrowser_light.TabIndex = 0;
            this.webBrowser_light.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_light_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(745, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "城市点亮图";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入将要点亮的城市：";
            // 
            // button_light
            // 
            this.button_light.Location = new System.Drawing.Point(741, 380);
            this.button_light.Name = "button_light";
            this.button_light.Size = new System.Drawing.Size(139, 33);
            this.button_light.TabIndex = 3;
            this.button_light.Text = "点亮";
            this.button_light.UseVisualStyleBackColor = true;
            this.button_light.Click += new System.EventHandler(this.button_light_Click);
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(722, 316);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(185, 28);
            this.textBox_city.TabIndex = 4;
            // 
            // Lighting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 544);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.button_light);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lighting";
            this.Text = "地图点亮功能";
            this.Load += new System.EventHandler(this.Lighting_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser_light;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_light;
        private System.Windows.Forms.TextBox textBox_city;
    }
}