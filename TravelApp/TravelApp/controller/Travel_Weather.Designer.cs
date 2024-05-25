using System.Drawing;
using System.Windows.Forms;

namespace Weather_space
{
    partial class Travel_Weather
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Travel_Weather));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboBoxProvince = new System.Windows.Forms.ToolStripComboBox();
            this.comboBoxCity = new System.Windows.Forms.ToolStripComboBox();
            this.comboBoxDistrict = new System.Windows.Forms.ToolStripComboBox();
            this.buttonSearch = new System.Windows.Forms.ToolStripButton();
            this.buttonCustom = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonAbout = new System.Windows.Forms.ToolStripButton();
            this.weatherDay1 = new Weather_space.WeatherDay();
            this.weatherDay2 = new Weather_space.WeatherDay();
            this.weatherDay3 = new Weather_space.WeatherDay();
            this.weatherDay4 = new Weather_space.WeatherDay();
            this.weatherDay5 = new Weather_space.WeatherDay();
            this.weatherDay6 = new Weather_space.WeatherDay();
            this.weatherDay7 = new Weather_space.WeatherDay();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { comboBoxProvince, comboBoxCity, comboBoxDistrict, buttonSearch, buttonCustom, buttonAbout });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1629, 41);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // comboBoxProvince
            // 
            comboBoxProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProvince.Name = "comboBoxProvince";
            comboBoxProvince.Size = new Size(121, 41);
            comboBoxProvince.SelectedIndexChanged += ComboBoxProvince_SelectedIndexChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(121, 41);
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            // 
            // comboBoxDistrict
            // 
            comboBoxDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDistrict.Name = "comboBoxDistrict";
            comboBoxDistrict.Size = new Size(121, 41);
            // 
            // buttonSearch
            // 
            buttonSearch.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonSearch.Image = (Image)resources.GetObject("buttonSearch.Image");
            buttonSearch.ImageTransparentColor = Color.Magenta;
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(66, 35);
            buttonSearch.Text = "查询";
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonCustom
            // 
            buttonCustom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonCustom.Image = (Image)resources.GetObject("buttonCustom.Image");
            buttonCustom.ImageTransparentColor = Color.Magenta;
            buttonCustom.Name = "buttonCustom";
            buttonCustom.Size = new Size(84, 35);
            buttonCustom.Text = "保存";
            // 
            // buttonAbout
            // 
            buttonAbout.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buttonAbout.Image = (Image)resources.GetObject("buttonAbout.Image");
            buttonAbout.ImageTransparentColor = Color.Magenta;
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(66, 35);
            buttonAbout.Text = "关于";
            buttonAbout.ToolTipText = "关于我们";
            buttonAbout.Click += buttonAbout_Click;
            // 
            // weatherDay1
            // 
            weatherDay1.BorderStyle = BorderStyle.Fixed3D;
            weatherDay1.Day = null;
            weatherDay1.Info = null;
            weatherDay1.Location = new Point(4, 44);
            weatherDay1.Name = "weatherDay1";
            weatherDay1.Size = new Size(200, 457);
            weatherDay1.TabIndex = 1;
            weatherDay1.Temperature = null;
            weatherDay1.WeatherStatus = WeatherStatus.Weizhi;
            weatherDay1.Wind = null;
            // 
            // weatherDay2
            // 
            weatherDay2.BorderStyle = BorderStyle.Fixed3D;
            weatherDay2.Day = null;
            weatherDay2.Info = null;
            weatherDay2.Location = new Point(237, 45);
            weatherDay2.Name = "weatherDay2";
            weatherDay2.Size = new Size(202, 457);
            weatherDay2.TabIndex = 2;
            weatherDay2.Temperature = null;
            weatherDay2.WeatherStatus = WeatherStatus.Weizhi;
            weatherDay2.Wind = null;
            // 
            // weatherDay3
            // 
            weatherDay3.BorderStyle = BorderStyle.Fixed3D;
            weatherDay3.Day = null;
            weatherDay3.Info = null;
            weatherDay3.Location = new Point(470, 45);
            weatherDay3.Name = "weatherDay3";
            weatherDay3.Size = new Size(202, 457);
            weatherDay3.TabIndex = 3;
            weatherDay3.Temperature = null;
            weatherDay3.WeatherStatus = WeatherStatus.Weizhi;
            weatherDay3.Wind = null;
            // 
            // weatherDay4
            // 
            weatherDay4.BorderStyle = BorderStyle.Fixed3D;
            weatherDay4.Day = null;
            weatherDay4.Info = null;
            weatherDay4.Location = new Point(703, 45);
            weatherDay4.Name = "weatherDay4";
            weatherDay4.Size = new Size(202, 457);
            weatherDay4.TabIndex = 4;
            weatherDay4.Temperature = null;
            weatherDay4.WeatherStatus = WeatherStatus.Weizhi;
            weatherDay4.Wind = null;
            // 
            // weatherDay5
            // 
            weatherDay5.BorderStyle = BorderStyle.Fixed3D;
            weatherDay5.Day = null;
            weatherDay5.Info = null;
            weatherDay5.Location = new Point(936, 44);
            weatherDay5.Name = "weatherDay5";
            weatherDay5.Size = new Size(203, 457);
            weatherDay5.TabIndex = 5;
            weatherDay5.Temperature = null;
            weatherDay5.WeatherStatus = WeatherStatus.Weizhi;
            weatherDay5.Wind = null;
            // 
            // weatherDay6
            // 
            weatherDay6.BorderStyle = BorderStyle.Fixed3D;
            weatherDay6.Day = null;
            weatherDay6.Info = null;
            weatherDay6.Location = new Point(1169, 44);
            weatherDay6.Name = "weatherDay6";
            weatherDay6.Size = new Size(203, 457);
            weatherDay6.TabIndex = 6;
            weatherDay6.Temperature = null;
            weatherDay6.WeatherStatus = WeatherStatus.Weizhi;
            weatherDay6.Wind = null;
            // 
            // weatherDay7
            // 
            weatherDay7.BorderStyle = BorderStyle.Fixed3D;
            weatherDay7.Day = null;
            weatherDay7.Info = null;
            weatherDay7.Location = new Point(1402, 45);
            weatherDay7.Name = "weatherDay7";
            weatherDay7.Size = new Size(202, 457);
            weatherDay7.TabIndex = 7;
            weatherDay7.Temperature = null;
            weatherDay7.WeatherStatus = WeatherStatus.Weizhi;
            weatherDay7.Wind = null;
            // 
            // Travel_Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.weatherDay7);
            this.Controls.Add(this.weatherDay6);
            this.Controls.Add(this.weatherDay5);
            this.Controls.Add(this.weatherDay4);
            this.Controls.Add(this.weatherDay3);
            this.Controls.Add(this.weatherDay2);
            this.Controls.Add(this.weatherDay1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Travel_Weather";
            this.Size = new System.Drawing.Size(1381, 728);
            this.Load += new System.EventHandler(this.Travel_Weather_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox comboBoxProvince;
        private System.Windows.Forms.ToolStripComboBox comboBoxCity;
        private System.Windows.Forms.ToolStripComboBox comboBoxDistrict;
        private System.Windows.Forms.ToolStripButton buttonSearch;
        private System.Windows.Forms.ToolStripDropDownButton buttonCustom;
        private System.Windows.Forms.ToolStripButton buttonAbout;
        private WeatherDay weatherDay1;
        private WeatherDay weatherDay2;
        private WeatherDay weatherDay3;
        private WeatherDay weatherDay4;
        private WeatherDay weatherDay5;
        private WeatherDay weatherDay6;
        private WeatherDay weatherDay7;
    }
}
