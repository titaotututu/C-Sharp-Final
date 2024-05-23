namespace TravelApp
{
    partial class MainInterface
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
            this.button_selfinfo = new System.Windows.Forms.Button();
            this.button_schedule = new System.Windows.Forms.Button();
            this.button_guide = new System.Windows.Forms.Button();
            this.button_weather = new System.Windows.Forms.Button();
            this.button_diary = new System.Windows.Forms.Button();
            this.button_light = new System.Windows.Forms.Button();
            this.button_else = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_selfinfo
            // 
            this.button_selfinfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_selfinfo.Location = new System.Drawing.Point(0, 14);
            this.button_selfinfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_selfinfo.Name = "button_selfinfo";
            this.button_selfinfo.Size = new System.Drawing.Size(256, 133);
            this.button_selfinfo.TabIndex = 0;
            this.button_selfinfo.Text = "个人信息";
            this.button_selfinfo.UseVisualStyleBackColor = false;
            // 
            // button_schedule
            // 
            this.button_schedule.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_schedule.Location = new System.Drawing.Point(0, 154);
            this.button_schedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_schedule.Name = "button_schedule";
            this.button_schedule.Size = new System.Drawing.Size(256, 90);
            this.button_schedule.TabIndex = 0;
            this.button_schedule.Text = "行程";
            this.button_schedule.UseVisualStyleBackColor = false;
            // 
            // button_guide
            // 
            this.button_guide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_guide.Location = new System.Drawing.Point(0, 251);
            this.button_guide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_guide.Name = "button_guide";
            this.button_guide.Size = new System.Drawing.Size(256, 90);
            this.button_guide.TabIndex = 0;
            this.button_guide.Text = "导航";
            this.button_guide.UseVisualStyleBackColor = false;
            this.button_guide.Click += new System.EventHandler(this.button_guide_Click);
            // 
            // button_weather
            // 
            this.button_weather.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_weather.Location = new System.Drawing.Point(0, 348);
            this.button_weather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_weather.Name = "button_weather";
            this.button_weather.Size = new System.Drawing.Size(256, 90);
            this.button_weather.TabIndex = 0;
            this.button_weather.Text = "天气";
            this.button_weather.UseVisualStyleBackColor = false;
            // 
            // button_diary
            // 
            this.button_diary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_diary.Location = new System.Drawing.Point(0, 444);
            this.button_diary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_diary.Name = "button_diary";
            this.button_diary.Size = new System.Drawing.Size(256, 90);
            this.button_diary.TabIndex = 0;
            this.button_diary.Text = "日志";
            this.button_diary.UseVisualStyleBackColor = false;
            // 
            // button_light
            // 
            this.button_light.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_light.Location = new System.Drawing.Point(0, 541);
            this.button_light.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_light.Name = "button_light";
            this.button_light.Size = new System.Drawing.Size(256, 90);
            this.button_light.TabIndex = 0;
            this.button_light.Text = "城市点亮";
            this.button_light.UseVisualStyleBackColor = false;
            this.button_light.Click += new System.EventHandler(this.button_light_Click);
            // 
            // button_else
            // 
            this.button_else.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_else.Location = new System.Drawing.Point(0, 639);
            this.button_else.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_else.Name = "button_else";
            this.button_else.Size = new System.Drawing.Size(256, 111);
            this.button_else.TabIndex = 0;
            this.button_else.Text = "其他";
            this.button_else.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(481, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用行迹精灵APP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(482, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "祝您拥有一趟完美的旅程";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1188, 751);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_else);
            this.Controls.Add(this.button_light);
            this.Controls.Add(this.button_diary);
            this.Controls.Add(this.button_weather);
            this.Controls.Add(this.button_guide);
            this.Controls.Add(this.button_schedule);
            this.Controls.Add(this.button_selfinfo);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainInterface";
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_selfinfo;
        private System.Windows.Forms.Button button_schedule;
        private System.Windows.Forms.Button button_guide;
        private System.Windows.Forms.Button button_weather;
        private System.Windows.Forms.Button button_diary;
        private System.Windows.Forms.Button button_light;
        private System.Windows.Forms.Button button_else;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}