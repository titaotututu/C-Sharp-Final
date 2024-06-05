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
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxProvince,
            this.comboBoxCity,
            this.comboBoxDistrict,
            this.buttonSearch,
            this.buttonCustom,
            this.buttonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(92, 33);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(92, 33);
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(92, 33);
            // 
            // buttonSearch
            // 
            this.buttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 28);
            this.buttonSearch.Text = "查询";
            // 
            // buttonCustom
            // 
            this.buttonCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonCustom.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustom.Image")));
            this.buttonCustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(64, 28);
            this.buttonCustom.Text = "保存";
            // 
            // buttonAbout
            // 
            this.buttonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(50, 28);
            this.buttonAbout.Text = "关于";
            this.buttonAbout.ToolTipText = "关于我们";
            // 
            // weatherDay1
            // 
            this.weatherDay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay1.Day = null;
            this.weatherDay1.Info = null;
            this.weatherDay1.Location = new System.Drawing.Point(3, 33);
            this.weatherDay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay1.Name = "weatherDay1";
            this.weatherDay1.Size = new System.Drawing.Size(151, 344);
            this.weatherDay1.TabIndex = 1;
            this.weatherDay1.Temperature = null;
            this.weatherDay1.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay1.Wind = null;
            // 
            // weatherDay2
            // 
            this.weatherDay2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay2.Day = null;
            this.weatherDay2.Info = null;
            this.weatherDay2.Location = new System.Drawing.Point(153, 34);
            this.weatherDay2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay2.Name = "weatherDay2";
            this.weatherDay2.Size = new System.Drawing.Size(152, 344);
            this.weatherDay2.TabIndex = 2;
            this.weatherDay2.Temperature = null;
            this.weatherDay2.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay2.Wind = null;
            // 
            // weatherDay3
            // 
            this.weatherDay3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay3.Day = null;
            this.weatherDay3.Info = null;
            this.weatherDay3.Location = new System.Drawing.Point(303, 34);
            this.weatherDay3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay3.Name = "weatherDay3";
            this.weatherDay3.Size = new System.Drawing.Size(152, 344);
            this.weatherDay3.TabIndex = 3;
            this.weatherDay3.Temperature = null;
            this.weatherDay3.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay3.Wind = null;
            // 
            // weatherDay4
            // 
            this.weatherDay4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay4.Day = null;
            this.weatherDay4.Info = null;
            this.weatherDay4.Location = new System.Drawing.Point(453, 34);
            this.weatherDay4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay4.Name = "weatherDay4";
            this.weatherDay4.Size = new System.Drawing.Size(152, 344);
            this.weatherDay4.TabIndex = 4;
            this.weatherDay4.Temperature = null;
            this.weatherDay4.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay4.Wind = null;
            // 
            // weatherDay5
            // 
            this.weatherDay5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay5.Day = null;
            this.weatherDay5.Info = null;
            this.weatherDay5.Location = new System.Drawing.Point(603, 33);
            this.weatherDay5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay5.Name = "weatherDay5";
            this.weatherDay5.Size = new System.Drawing.Size(153, 344);
            this.weatherDay5.TabIndex = 5;
            this.weatherDay5.Temperature = null;
            this.weatherDay5.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay5.Wind = null;
            // 
            // weatherDay6
            // 
            this.weatherDay6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay6.Day = null;
            this.weatherDay6.Info = null;
            this.weatherDay6.Location = new System.Drawing.Point(753, 33);
            this.weatherDay6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay6.Name = "weatherDay6";
            this.weatherDay6.Size = new System.Drawing.Size(153, 344);
            this.weatherDay6.TabIndex = 6;
            this.weatherDay6.Temperature = null;
            this.weatherDay6.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay6.Wind = null;
            // 
            // weatherDay7
            // 
            this.weatherDay7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay7.Day = null;
            this.weatherDay7.Info = null;
            this.weatherDay7.Location = new System.Drawing.Point(903, 34);
            this.weatherDay7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay7.Name = "weatherDay7";
            this.weatherDay7.Size = new System.Drawing.Size(145, 344);
            this.weatherDay7.TabIndex = 7;
            this.weatherDay7.Temperature = null;
            this.weatherDay7.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay7.Wind = null;
            // 
            // Travel_Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.weatherDay7);
            this.Controls.Add(this.weatherDay6);
            this.Controls.Add(this.weatherDay5);
            this.Controls.Add(this.weatherDay4);
            this.Controls.Add(this.weatherDay3);
            this.Controls.Add(this.weatherDay2);
            this.Controls.Add(this.weatherDay1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Travel_Weather";
            this.Size = new System.Drawing.Size(948, 546);
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
