namespace TravelApp.controller
{
    partial class Personalinfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_pwd = new System.Windows.Forms.TextBox();
            this.new_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.new_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // new_pwd
            // 
            this.new_pwd.Location = new System.Drawing.Point(317, 297);
            this.new_pwd.Name = "new_pwd";
            this.new_pwd.Size = new System.Drawing.Size(195, 25);
            this.new_pwd.TabIndex = 4;
            // 
            // new_name
            // 
            this.new_name.Location = new System.Drawing.Point(317, 188);
            this.new_name.Name = "new_name";
            this.new_name.Size = new System.Drawing.Size(195, 25);
            this.new_name.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // new_id
            // 
            this.new_id.Location = new System.Drawing.Point(317, 66);
            this.new_id.Name = "new_id";
            this.new_id.Size = new System.Drawing.Size(195, 25);
            this.new_id.TabIndex = 7;
            // 
            // Personalinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.new_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.new_name);
            this.Controls.Add(this.new_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Personalinfo";
            this.Size = new System.Drawing.Size(889, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_pwd;
        private System.Windows.Forms.TextBox new_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox new_id;
    }
}
