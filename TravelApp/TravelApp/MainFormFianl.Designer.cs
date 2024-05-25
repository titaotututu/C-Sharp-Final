namespace TravelApp
{
    partial class MainFormFianl
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
            this.button_Journal = new System.Windows.Forms.Button();
            this.button_Other = new System.Windows.Forms.Button();
            this.button_Lighting = new System.Windows.Forms.Button();
            this.button_Weather = new System.Windows.Forms.Button();
            this.button_Navigation = new System.Windows.Forms.Button();
            this.button_Travel = new System.Windows.Forms.Button();
            this.button_UserInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.button_Journal);
            this.panel1.Controls.Add(this.button_Other);
            this.panel1.Controls.Add(this.button_Lighting);
            this.panel1.Controls.Add(this.button_Weather);
            this.panel1.Controls.Add(this.button_Navigation);
            this.panel1.Controls.Add(this.button_Travel);
            this.panel1.Controls.Add(this.button_UserInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 726);
            this.panel1.TabIndex = 0;
            // 
            // button_Journal
            // 
            this.button_Journal.Location = new System.Drawing.Point(28, 511);
            this.button_Journal.Name = "button_Journal";
            this.button_Journal.Size = new System.Drawing.Size(122, 50);
            this.button_Journal.TabIndex = 7;
            this.button_Journal.Text = "旅行日志";
            this.button_Journal.UseVisualStyleBackColor = true;
            // 
            // button_Other
            // 
            this.button_Other.Location = new System.Drawing.Point(28, 600);
            this.button_Other.Name = "button_Other";
            this.button_Other.Size = new System.Drawing.Size(122, 50);
            this.button_Other.TabIndex = 6;
            this.button_Other.Text = "其他";
            this.button_Other.UseVisualStyleBackColor = true;
            // 
            // button_Lighting
            // 
            this.button_Lighting.Location = new System.Drawing.Point(28, 424);
            this.button_Lighting.Name = "button_Lighting";
            this.button_Lighting.Size = new System.Drawing.Size(122, 50);
            this.button_Lighting.TabIndex = 5;
            this.button_Lighting.Text = "点亮地图";
            this.button_Lighting.UseVisualStyleBackColor = true;
            // 
            // button_Weather
            // 
            this.button_Weather.Location = new System.Drawing.Point(28, 337);
            this.button_Weather.Name = "button_Weather";
            this.button_Weather.Size = new System.Drawing.Size(122, 50);
            this.button_Weather.TabIndex = 4;
            this.button_Weather.Text = "天气";
            this.button_Weather.UseVisualStyleBackColor = true;
            this.button_Weather.Click += new System.EventHandler(this.button_Weather_Click);
            // 
            // button_Navigation
            // 
            this.button_Navigation.Location = new System.Drawing.Point(28, 251);
            this.button_Navigation.Name = "button_Navigation";
            this.button_Navigation.Size = new System.Drawing.Size(122, 50);
            this.button_Navigation.TabIndex = 3;
            this.button_Navigation.Text = "导航";
            this.button_Navigation.UseVisualStyleBackColor = true;
            // 
            // button_Travel
            // 
            this.button_Travel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Travel.Location = new System.Drawing.Point(28, 169);
            this.button_Travel.Name = "button_Travel";
            this.button_Travel.Size = new System.Drawing.Size(122, 50);
            this.button_Travel.TabIndex = 2;
            this.button_Travel.Text = "行程";
            this.button_Travel.UseVisualStyleBackColor = true;
            this.button_Travel.Click += new System.EventHandler(this.button_Travel_Click);
            // 
            // button_UserInfo
            // 
            this.button_UserInfo.Location = new System.Drawing.Point(28, 85);
            this.button_UserInfo.Name = "button_UserInfo";
            this.button_UserInfo.Size = new System.Drawing.Size(122, 50);
            this.button_UserInfo.TabIndex = 1;
            this.button_UserInfo.Text = "个人信息";
            this.button_UserInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "行迹精灵";
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(193, 39);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1377, 688);
            this.panelControl.TabIndex = 1;
            // 
            // MainFormFianl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 725);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel1);
            this.Name = "MainFormFianl";
            this.Text = "MainFormFianl";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_UserInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button button_Navigation;
        private System.Windows.Forms.Button button_Travel;
        private System.Windows.Forms.Button button_Journal;
        private System.Windows.Forms.Button button_Other;
        private System.Windows.Forms.Button button_Lighting;
        private System.Windows.Forms.Button button_Weather;
    }
}