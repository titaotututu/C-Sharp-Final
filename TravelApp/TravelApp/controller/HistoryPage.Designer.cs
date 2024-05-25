namespace TravelApp.controller
{
    partial class HistoryPage
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Ivory;
            this.labelTitle.Location = new System.Drawing.Point(37, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(173, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "标题";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            this.labelTitle.Text = travel.TravelTitle;
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(252, 104);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(146, 38);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "时间";
            this.labelTime.Text=travel.TravelTime.ToLongDateString();
            // 
            // labelPlace
            // 
            this.labelPlace.Location = new System.Drawing.Point(37, 104);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(146, 38);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "城市";
            this.labelPlace.Text = travel.TravelCity;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(445, 122);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(149, 48);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "删除行程";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // HistoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTitle);
            this.Name = "HistoryPage";
            this.Size = new System.Drawing.Size(620, 188);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonDelete;
    }
}
