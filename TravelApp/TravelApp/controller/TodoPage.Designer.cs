﻿using System;

namespace TravelApp.controller
{
    partial class TodoPage
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
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(34, 8);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(115, 23);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "时间";
            this.labelTime.Text=todo.Time.ToShortDateString();

            // 
            // labelPlace
            // 
            this.labelPlace.Location = new System.Drawing.Point(195, 8);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(97, 24);
            this.labelPlace.TabIndex = 2;
            this.labelPlace.Text = "地点";
            this.labelPlace.Text = todo.Place;
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(34, 56);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(158, 29);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "描述";
            this.labelDescription.Text=todo.Description;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(2, 8);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Checked=todo.IsCompleted;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(295, 41);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(59, 24);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TodoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPlace);
            this.Controls.Add(this.labelTime);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TodoPage";
            this.Size = new System.Drawing.Size(376, 101);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonDelete;
    }
}
