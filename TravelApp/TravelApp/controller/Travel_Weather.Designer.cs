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
            this.flpHead = new System.Windows.Forms.FlowLayoutPanel();
            this.labelIcon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.comboBoxProvince = new System.Windows.Forms.ToolStripComboBox();
            this.comboBoxCity = new System.Windows.Forms.ToolStripComboBox();
            this.comboBoxDistrict = new System.Windows.Forms.ToolStripComboBox();
            this.buttonSearch = new System.Windows.Forms.ToolStripButton();
            this.buttonCustom = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelControl = new System.Windows.Forms.Panel();
            this.weatherDay7 = new Weather_space.WeatherDay();
            this.weatherDay6 = new Weather_space.WeatherDay();
            this.weatherDay5 = new Weather_space.WeatherDay();
            this.weatherDay4 = new Weather_space.WeatherDay();
            this.weatherDay3 = new Weather_space.WeatherDay();
            this.weatherDay2 = new Weather_space.WeatherDay();
            this.weatherDay1 = new Weather_space.WeatherDay();
            this.flpHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpHead
            // 
            this.flpHead.BackColor = System.Drawing.Color.White;
            this.flpHead.Controls.Add(this.pictureBoxIcon);
            this.flpHead.Controls.Add(this.labelIcon);
            this.flpHead.Location = new System.Drawing.Point(0, 0);
            this.flpHead.Name = "flpHead";
            this.flpHead.Size = new System.Drawing.Size(948, 76);
            this.flpHead.TabIndex = 9;
            // 
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIcon.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelIcon.Location = new System.Drawing.Point(101, 25);
            this.labelIcon.Margin = new System.Windows.Forms.Padding(10, 25, 3, 0);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(75, 30);
            this.labelIcon.TabIndex = 1;
            this.labelIcon.Text = "天气";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(-17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1000, 2);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::TravelApp.Properties.Resources.天气预报;
            this.pictureBoxIcon.Location = new System.Drawing.Point(30, 10);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(58, 56);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelApp.Properties.Resources.甜美云;
            this.pictureBox1.Location = new System.Drawing.Point(0, 410);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "新项选择";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.miniToolStrip.Location = new System.Drawing.Point(460, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(464, 27);
            this.miniToolStrip.TabIndex = 0;
            // 
            // comboBoxProvince
            // 
            this.comboBoxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvince.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxProvince.Name = "comboBoxProvince";
            this.comboBoxProvince.Size = new System.Drawing.Size(92, 36);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(92, 36);
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(92, 36);
            // 
            // buttonSearch
            // 
            this.buttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSearch.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(48, 31);
            this.buttonSearch.Text = "查询";
            // 
            // buttonCustom
            // 
            this.buttonCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonCustom.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCustom.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustom.Image")));
            this.buttonCustom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCustom.Name = "buttonCustom";
            this.buttonCustom.Size = new System.Drawing.Size(62, 31);
            this.buttonCustom.Text = "保存";
            // 
            // buttonAbout
            // 
            this.buttonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonAbout.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(48, 31);
            this.buttonAbout.Text = "关于";
            this.buttonAbout.ToolTipText = "关于我们";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBoxProvince,
            this.comboBoxCity,
            this.comboBoxDistrict,
            this.buttonSearch,
            this.buttonCustom,
            this.buttonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 76);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(204)))), ((int)(((byte)(172)))));
            this.panelControl.Location = new System.Drawing.Point(0, 76);
            this.panelControl.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(948, 470);
            this.panelControl.TabIndex = 14;
            // 
            // weatherDay7
            // 
            this.weatherDay7.BackColor = System.Drawing.Color.Honeydew;
            this.weatherDay7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay7.Day = null;
            this.weatherDay7.Info = null;
            this.weatherDay7.Location = new System.Drawing.Point(808, 114);
            this.weatherDay7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay7.Name = "weatherDay7";
            this.weatherDay7.Size = new System.Drawing.Size(138, 296);
            this.weatherDay7.TabIndex = 7;
            this.weatherDay7.Temperature = null;
            this.weatherDay7.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay7.Wind = null;
            // 
            // weatherDay6
            // 
            this.weatherDay6.BackColor = System.Drawing.Color.Honeydew;
            this.weatherDay6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay6.Day = null;
            this.weatherDay6.Info = null;
            this.weatherDay6.Location = new System.Drawing.Point(660, 114);
            this.weatherDay6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay6.Name = "weatherDay6";
            this.weatherDay6.Size = new System.Drawing.Size(149, 296);
            this.weatherDay6.TabIndex = 6;
            this.weatherDay6.Temperature = null;
            this.weatherDay6.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay6.Wind = null;
            // 
            // weatherDay5
            // 
            this.weatherDay5.BackColor = System.Drawing.Color.Honeydew;
            this.weatherDay5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay5.Day = null;
            this.weatherDay5.Info = null;
            this.weatherDay5.Location = new System.Drawing.Point(530, 114);
            this.weatherDay5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay5.Name = "weatherDay5";
            this.weatherDay5.Size = new System.Drawing.Size(126, 296);
            this.weatherDay5.TabIndex = 5;
            this.weatherDay5.Temperature = null;
            this.weatherDay5.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay5.Wind = null;
            // 
            // weatherDay4
            // 
            this.weatherDay4.BackColor = System.Drawing.Color.Honeydew;
            this.weatherDay4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay4.Day = null;
            this.weatherDay4.Info = null;
            this.weatherDay4.Location = new System.Drawing.Point(400, 114);
            this.weatherDay4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay4.Name = "weatherDay4";
            this.weatherDay4.Size = new System.Drawing.Size(126, 296);
            this.weatherDay4.TabIndex = 4;
            this.weatherDay4.Temperature = null;
            this.weatherDay4.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay4.Wind = null;
            // 
            // weatherDay3
            // 
            this.weatherDay3.BackColor = System.Drawing.Color.Honeydew;
            this.weatherDay3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay3.Day = null;
            this.weatherDay3.Info = null;
            this.weatherDay3.Location = new System.Drawing.Point(270, 114);
            this.weatherDay3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay3.Name = "weatherDay3";
            this.weatherDay3.Size = new System.Drawing.Size(126, 296);
            this.weatherDay3.TabIndex = 3;
            this.weatherDay3.Temperature = null;
            this.weatherDay3.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay3.Wind = null;
            // 
            // weatherDay2
            // 
            this.weatherDay2.BackColor = System.Drawing.Color.Honeydew;
            this.weatherDay2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay2.Day = null;
            this.weatherDay2.Info = null;
            this.weatherDay2.Location = new System.Drawing.Point(140, 114);
            this.weatherDay2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay2.Name = "weatherDay2";
            this.weatherDay2.Size = new System.Drawing.Size(126, 296);
            this.weatherDay2.TabIndex = 2;
            this.weatherDay2.Temperature = null;
            this.weatherDay2.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay2.Wind = null;
            // 
            // weatherDay1
            // 
            this.weatherDay1.BackColor = System.Drawing.Color.Honeydew;
            this.weatherDay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weatherDay1.Day = null;
            this.weatherDay1.Info = null;
            this.weatherDay1.Location = new System.Drawing.Point(2, 114);
            this.weatherDay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weatherDay1.Name = "weatherDay1";
            this.weatherDay1.Size = new System.Drawing.Size(135, 296);
            this.weatherDay1.TabIndex = 1;
            this.weatherDay1.Temperature = null;
            this.weatherDay1.WeatherStatus = Weather_space.WeatherStatus.Weizhi;
            this.weatherDay1.Wind = null;
            // 
            // Travel_Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(204)))), ((int)(((byte)(172)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flpHead);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.weatherDay7);
            this.Controls.Add(this.weatherDay6);
            this.Controls.Add(this.weatherDay5);
            this.Controls.Add(this.weatherDay4);
            this.Controls.Add(this.weatherDay3);
            this.Controls.Add(this.weatherDay2);
            this.Controls.Add(this.weatherDay1);
            this.Controls.Add(this.panelControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Travel_Weather";
            this.Size = new System.Drawing.Size(948, 546);
            this.Load += new System.EventHandler(this.Travel_Weather_Load);
            this.flpHead.ResumeLayout(false);
            this.flpHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WeatherDay weatherDay1;
        private WeatherDay weatherDay2;
        private WeatherDay weatherDay3;
        private WeatherDay weatherDay4;
        private WeatherDay weatherDay5;
        private WeatherDay weatherDay6;
        private WeatherDay weatherDay7;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flpHead;
        private Label labelIcon;
        private PictureBox pictureBoxIcon;
        private Label label5;
        private ToolStrip miniToolStrip;
        private ToolStripComboBox comboBoxProvince;
        private ToolStripComboBox comboBoxCity;
        private ToolStripComboBox comboBoxDistrict;
        private ToolStripButton buttonSearch;
        private ToolStripDropDownButton buttonCustom;
        private ToolStripButton buttonAbout;
        private ToolStrip toolStrip1;
        private Panel panelControl;
    }
}
