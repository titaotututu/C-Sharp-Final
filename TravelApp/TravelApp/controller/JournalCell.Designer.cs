namespace TravelApp.controller
{
    partial class JournalCell
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBoxGoose = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(80, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(780, 2);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(78, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 30);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "标题";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(525, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "天气：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(525, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "日期：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWeather.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWeather.Location = new System.Drawing.Point(610, 20);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(80, 21);
            this.lblWeather.TabIndex = 19;
            this.lblWeather.Text = "(天气)";
            this.lblWeather.Click += new System.EventHandler(this.lblWeather_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Location = new System.Drawing.Point(610, 58);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 21);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "(日期)";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // pictureBoxGoose
            // 
            this.pictureBoxGoose.Image = global::TravelApp.Properties.Resources.鹅;
            this.pictureBoxGoose.Location = new System.Drawing.Point(10, 20);
            this.pictureBoxGoose.Margin = new System.Windows.Forms.Padding(30, 20, 3, 3);
            this.pictureBoxGoose.Name = "pictureBoxGoose";
            this.pictureBoxGoose.Size = new System.Drawing.Size(72, 59);
            this.pictureBoxGoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGoose.TabIndex = 21;
            this.pictureBoxGoose.TabStop = false;
            this.pictureBoxGoose.Click += new System.EventHandler(this.pictureBoxGoose_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::TravelApp.Properties.Resources.删除;
            this.pbDelete.Location = new System.Drawing.Point(846, 20);
            this.pbDelete.Margin = new System.Windows.Forms.Padding(30, 20, 3, 3);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(56, 59);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDelete.TabIndex = 22;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // JournalCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.pictureBoxGoose);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label3);
            this.Name = "JournalCell";
            this.Size = new System.Drawing.Size(905, 100);
            this.Click += new System.EventHandler(this.JournalCell_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblWeather;
        public System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pictureBoxGoose;
        private System.Windows.Forms.PictureBox pbDelete;
    }
}
