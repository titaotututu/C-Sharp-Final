namespace TravelApp.controller
{
    partial class MyTravel
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
            this.buttonNewTravel = new System.Windows.Forms.Button();
            this.buttonOldTravel = new System.Windows.Forms.Button();
            this.panelTravel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonNewTravel
            // 
            this.buttonNewTravel.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonNewTravel.FlatAppearance.BorderSize = 0;
            this.buttonNewTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewTravel.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNewTravel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNewTravel.Location = new System.Drawing.Point(53, 418);
            this.buttonNewTravel.Name = "buttonNewTravel";
            this.buttonNewTravel.Size = new System.Drawing.Size(275, 96);
            this.buttonNewTravel.TabIndex = 1;
            this.buttonNewTravel.Text = "开启一个新行程";
            this.buttonNewTravel.UseVisualStyleBackColor = false;
            this.buttonNewTravel.Click += new System.EventHandler(this.buttonNewTravel_Click);
            // 
            // buttonOldTravel
            // 
            this.buttonOldTravel.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonOldTravel.FlatAppearance.BorderSize = 0;
            this.buttonOldTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOldTravel.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOldTravel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOldTravel.Location = new System.Drawing.Point(53, 197);
            this.buttonOldTravel.Name = "buttonOldTravel";
            this.buttonOldTravel.Size = new System.Drawing.Size(275, 96);
            this.buttonOldTravel.TabIndex = 0;
            this.buttonOldTravel.Text = "查看我的历史行程";
            this.buttonOldTravel.UseVisualStyleBackColor = false;
            this.buttonOldTravel.Click += new System.EventHandler(this.buttonOldTravel_Click);
            // 
            // panelTravel
            // 
            this.panelTravel.BackColor = System.Drawing.Color.Transparent;
            this.panelTravel.Location = new System.Drawing.Point(405, 25);
            this.panelTravel.Name = "panelTravel";
            this.panelTravel.Size = new System.Drawing.Size(835, 679);
            this.panelTravel.TabIndex = 2;
            // 
            // MyTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TravelApp.Properties.Resources.在路上旅行;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelTravel);
            this.Controls.Add(this.buttonOldTravel);
            this.Controls.Add(this.buttonNewTravel);
            this.DoubleBuffered = true;
            this.Name = "MyTravel";
            this.Size = new System.Drawing.Size(1267, 727);
            this.Load += new System.EventHandler(this.MyTravel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewTravel;
        private System.Windows.Forms.Button buttonOldTravel;
        private System.Windows.Forms.FlowLayoutPanel panelTravel;
    }
}
