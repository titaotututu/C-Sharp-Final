namespace TravelApp.controller
{
    partial class JournalList
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
            this.labelIcon = new System.Windows.Forms.Label();
            this.flpHead = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpJournalList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.flpHead.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIcon.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelIcon.Location = new System.Drawing.Point(101, 35);
            this.labelIcon.Margin = new System.Windows.Forms.Padding(10, 35, 3, 0);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(137, 30);
            this.labelIcon.TabIndex = 1;
            this.labelIcon.Text = "旅行日志";
            // 
            // flpHead
            // 
            this.flpHead.BackColor = System.Drawing.Color.White;
            this.flpHead.Controls.Add(this.pictureBoxIcon);
            this.flpHead.Controls.Add(this.labelIcon);
            this.flpHead.Location = new System.Drawing.Point(3, 3);
            this.flpHead.Name = "flpHead";
            this.flpHead.Size = new System.Drawing.Size(819, 88);
            this.flpHead.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(0, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1000, 2);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // flpJournalList
            // 
            this.flpJournalList.AutoScroll = true;
            this.flpJournalList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpJournalList.Location = new System.Drawing.Point(3, 107);
            this.flpJournalList.Name = "flpJournalList";
            this.flpJournalList.Size = new System.Drawing.Size(943, 434);
            this.flpJournalList.TabIndex = 13;
            this.flpJournalList.WrapContents = false;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Controls.Add(this.flpJournalList);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(953, 550);
            this.panelControl.TabIndex = 15;
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Image = global::TravelApp.Properties.Resources.add;
            this.pbAdd.Location = new System.Drawing.Point(865, 23);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(30, 20, 3, 3);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(58, 60);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 14;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::TravelApp.Properties.Resources.旅行日志;
            this.pictureBoxIcon.Location = new System.Drawing.Point(30, 20);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(30, 20, 3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(58, 57);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // JournalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.flpHead);
            this.Controls.Add(this.panelControl);
            this.Name = "JournalList";
            this.Size = new System.Drawing.Size(953, 550);
            this.flpHead.ResumeLayout(false);
            this.flpHead.PerformLayout();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.FlowLayoutPanel flpHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpJournalList;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Panel panelControl;
    }
}
