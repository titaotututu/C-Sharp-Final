using System.Drawing;
using System.Windows.Forms;

namespace Weather_space
{
    partial class WeatherDay
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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelWind = new Label();
            labelTemp = new Label();
            labelInfo = new Label();
            labelDay = new Label();
            pictureBoxWeather = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelWind, 0, 3);
            tableLayoutPanel1.Controls.Add(labelTemp, 0, 2);
            tableLayoutPanel1.Controls.Add(labelInfo, 0, 1);
            tableLayoutPanel1.Controls.Add(labelDay, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.860466F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.139534F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.Size = new Size(220, 297);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelWind
            // 
            labelWind.Location = new Point(3, 214);
            labelWind.Name = "labelWind";
            labelWind.Size = new Size(214, 77);
            labelWind.TabIndex = 3;
            // 
            // labelTemp
            // 
            labelTemp.Location = new Point(3, 137);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(214, 77);
            labelTemp.TabIndex = 2;
            // 
            // labelInfo
            // 
            labelInfo.Location = new Point(3, 57);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(214, 80);
            labelInfo.TabIndex = 1;
            // 
            // labelDay
            // 
            labelDay.BackColor = SystemColors.ControlDark;
            labelDay.Location = new Point(3, 0);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(214, 41);
            labelDay.TabIndex = 0;
            // 
            // pictureBoxWeather
            // 
            pictureBoxWeather.Location = new Point(0, 294);
            pictureBoxWeather.Name = "pictureBoxWeather";
            pictureBoxWeather.Size = new Size(223, 216);
            pictureBoxWeather.TabIndex = 1;
            pictureBoxWeather.TabStop = false;
            // 
            // WeatherDay
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(pictureBoxWeather);
            Controls.Add(tableLayoutPanel1);
            Name = "WeatherDay";
            Size = new Size(219, 507);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeather).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelDay;
        private Label labelInfo;
        private Label labelWind;
        private Label labelTemp;
        private PictureBox pictureBoxWeather;
    }
}
