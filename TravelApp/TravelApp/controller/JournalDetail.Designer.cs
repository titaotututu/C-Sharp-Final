﻿namespace TravelApp.controller
{
    partial class JournalDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalDetail));
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flpTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbWeather = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmotion = new System.Windows.Forms.TextBox();
            this.flpImage = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flpTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(20, 10);
            this.pbBack.Margin = new System.Windows.Forms.Padding(20, 10, 3, 3);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(59, 59);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 17;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.flowLayoutPanel1.Controls.Add(this.pbBack);
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(720, 74);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(482, 20);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(400, 20, 3, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 40);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("幼圆", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(603, 20);
            this.btnSave.Margin = new System.Windows.Forms.Padding(30, 20, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 40);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flpTitle
            // 
            this.flpTitle.Controls.Add(this.pictureBox1);
            this.flpTitle.Controls.Add(this.tbTitle);
            this.flpTitle.Controls.Add(this.pbAdd);
            this.flpTitle.Location = new System.Drawing.Point(0, 75);
            this.flpTitle.Name = "flpTitle";
            this.flpTitle.Size = new System.Drawing.Size(720, 88);
            this.flpTitle.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(40, 20, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Font = new System.Drawing.Font("幼圆", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTitle.Location = new System.Drawing.Point(122, 35);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(20, 35, 3, 3);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(490, 36);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Text = "快乐旅游";
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.SystemColors.Control;
            this.pbAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbAdd.Image")));
            this.pbAdd.Location = new System.Drawing.Point(635, 20);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(59, 57);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdd.TabIndex = 22;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.lblTime);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.tbWeather);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.tbEmotion);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 169);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(720, 37);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(30, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "日期：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTime.Location = new System.Drawing.Point(112, 6);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(106, 21);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "2000.2.2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(251, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "天气：";
            // 
            // tbWeather
            // 
            this.tbWeather.BackColor = System.Drawing.SystemColors.Control;
            this.tbWeather.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWeather.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWeather.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbWeather.Location = new System.Drawing.Point(333, 5);
            this.tbWeather.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.tbWeather.Name = "tbWeather";
            this.tbWeather.Size = new System.Drawing.Size(76, 24);
            this.tbWeather.TabIndex = 21;
            this.tbWeather.Text = "晴";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(442, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "心情：";
            // 
            // tbEmotion
            // 
            this.tbEmotion.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmotion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmotion.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEmotion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbEmotion.Location = new System.Drawing.Point(524, 5);
            this.tbEmotion.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.tbEmotion.Name = "tbEmotion";
            this.tbEmotion.Size = new System.Drawing.Size(76, 24);
            this.tbEmotion.TabIndex = 22;
            this.tbEmotion.Text = "开心";
            // 
            // flpImage
            // 
            this.flpImage.Location = new System.Drawing.Point(3, 212);
            this.flpImage.Name = "flpImage";
            this.flpImage.Size = new System.Drawing.Size(714, 154);
            this.flpImage.TabIndex = 21;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbDescription.Location = new System.Drawing.Point(3, 372);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbDescription.Size = new System.Drawing.Size(714, 386);
            this.rtbDescription.TabIndex = 22;
            this.rtbDescription.Text = "";
            // 
            // JournalDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flpTitle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flpImage);
            this.Name = "JournalDetail";
            this.Size = new System.Drawing.Size(720, 761);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flpTitle.ResumeLayout(false);
            this.flpTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flpTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbWeather;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmotion;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.FlowLayoutPanel flpImage;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}