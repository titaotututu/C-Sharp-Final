namespace TravelApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.UserInfoPage = new System.Windows.Forms.TabPage();
            this.TravelInfoPage = new System.Windows.Forms.TabPage();
            this.NavigatePage = new System.Windows.Forms.TabPage();
            this.WeatherPage = new System.Windows.Forms.TabPage();
            this.LightingPage = new System.Windows.Forms.TabPage();
            this.JournalPage = new System.Windows.Forms.TabPage();
            this.OtherPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.WeatherPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.UserInfoPage);
            this.materialTabControl1.Controls.Add(this.TravelInfoPage);
            this.materialTabControl1.Controls.Add(this.NavigatePage);
            this.materialTabControl1.Controls.Add(this.WeatherPage);
            this.materialTabControl1.Controls.Add(this.LightingPage);
            this.materialTabControl1.Controls.Add(this.JournalPage);
            this.materialTabControl1.Controls.Add(this.OtherPage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1075, 840);
            this.materialTabControl1.TabIndex = 0;
            // 
            // UserInfoPage
            // 
            this.UserInfoPage.AutoScroll = true;
            this.UserInfoPage.BackColor = System.Drawing.Color.White;
            this.UserInfoPage.ImageKey = "个人信息";
            this.UserInfoPage.Location = new System.Drawing.Point(8, 39);
            this.UserInfoPage.Name = "UserInfoPage";
            this.UserInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserInfoPage.Size = new System.Drawing.Size(1059, 793);
            this.UserInfoPage.TabIndex = 0;
            this.UserInfoPage.Text = "个人信息";
            // 
            // TravelInfoPage
            // 
            this.TravelInfoPage.BackColor = System.Drawing.Color.White;
            this.TravelInfoPage.ImageKey = "旅程";
            this.TravelInfoPage.Location = new System.Drawing.Point(8, 39);
            this.TravelInfoPage.Name = "TravelInfoPage";
            this.TravelInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.TravelInfoPage.Size = new System.Drawing.Size(1059, 793);
            this.TravelInfoPage.TabIndex = 1;
            this.TravelInfoPage.Text = "行程";
            // 
            // NavigatePage
            // 
            this.NavigatePage.BackColor = System.Drawing.Color.White;
            this.NavigatePage.ImageKey = "导航";
            this.NavigatePage.Location = new System.Drawing.Point(8, 39);
            this.NavigatePage.Name = "NavigatePage";
            this.NavigatePage.Padding = new System.Windows.Forms.Padding(3);
            this.NavigatePage.Size = new System.Drawing.Size(1059, 793);
            this.NavigatePage.TabIndex = 2;
            this.NavigatePage.Text = "导航";
            // 
            // WeatherPage
            // 
            this.WeatherPage.BackColor = System.Drawing.Color.White;
            this.WeatherPage.Controls.Add(this.materialButton1);
            this.WeatherPage.ImageKey = "天气";
            this.WeatherPage.Location = new System.Drawing.Point(8, 39);
            this.WeatherPage.Name = "WeatherPage";
            this.WeatherPage.Padding = new System.Windows.Forms.Padding(3);
            this.WeatherPage.Size = new System.Drawing.Size(1059, 793);
            this.WeatherPage.TabIndex = 3;
            this.WeatherPage.Text = "天气";
            // 
            // LightingPage
            // 
            this.LightingPage.BackColor = System.Drawing.Color.White;
            this.LightingPage.ImageKey = "点亮地图";
            this.LightingPage.Location = new System.Drawing.Point(8, 39);
            this.LightingPage.Name = "LightingPage";
            this.LightingPage.Padding = new System.Windows.Forms.Padding(3);
            this.LightingPage.Size = new System.Drawing.Size(1059, 793);
            this.LightingPage.TabIndex = 4;
            this.LightingPage.Text = "点亮地图";
            // 
            // JournalPage
            // 
            this.JournalPage.BackColor = System.Drawing.Color.White;
            this.JournalPage.ImageKey = "日志";
            this.JournalPage.Location = new System.Drawing.Point(8, 39);
            this.JournalPage.Name = "JournalPage";
            this.JournalPage.Padding = new System.Windows.Forms.Padding(3);
            this.JournalPage.Size = new System.Drawing.Size(1059, 793);
            this.JournalPage.TabIndex = 5;
            this.JournalPage.Text = "旅行日志";
            // 
            // OtherPage
            // 
            this.OtherPage.BackColor = System.Drawing.Color.White;
            this.OtherPage.ImageKey = "其他";
            this.OtherPage.Location = new System.Drawing.Point(8, 39);
            this.OtherPage.Name = "OtherPage";
            this.OtherPage.Padding = new System.Windows.Forms.Padding(3);
            this.OtherPage.Size = new System.Drawing.Size(1059, 793);
            this.OtherPage.TabIndex = 6;
            this.OtherPage.Text = "其他";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "个人信息");
            this.imageList1.Images.SetKeyName(1, "旅程");
            this.imageList1.Images.SetKeyName(2, "导航");
            this.imageList1.Images.SetKeyName(3, "点亮地图");
            this.imageList1.Images.SetKeyName(4, "日志");
            this.imageList1.Images.SetKeyName(5, "其他");
            this.imageList1.Images.SetKeyName(6, "天气");
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(388, 214);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(85, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "查看天气";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 913);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.DrawerWidth = 150;
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.HelpButton = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.materialTabControl1.ResumeLayout(false);
            this.WeatherPage.ResumeLayout(false);
            this.WeatherPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage UserInfoPage;
        private System.Windows.Forms.TabPage TravelInfoPage;
        private System.Windows.Forms.TabPage NavigatePage;
        private System.Windows.Forms.TabPage WeatherPage;
        private System.Windows.Forms.TabPage LightingPage;
        private System.Windows.Forms.TabPage JournalPage;
        private System.Windows.Forms.TabPage OtherPage;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}