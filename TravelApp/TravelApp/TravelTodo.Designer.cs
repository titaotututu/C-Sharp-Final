namespace TravelApp
{
    partial class TravelTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelTodo));
            this.labelTravelTitle = new System.Windows.Forms.Label();
            this.buttonAddTodo = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTodo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelTravelTitle
            // 
            this.labelTravelTitle.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTravelTitle.Location = new System.Drawing.Point(125, 25);
            this.labelTravelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTravelTitle.Name = "labelTravelTitle";
            this.labelTravelTitle.Size = new System.Drawing.Size(467, 41);
            this.labelTravelTitle.TabIndex = 0;
            this.labelTravelTitle.Text = "旅行名称";
            // 
            // buttonAddTodo
            // 
            this.buttonAddTodo.Location = new System.Drawing.Point(827, 23);
            this.buttonAddTodo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTodo.Name = "buttonAddTodo";
            this.buttonAddTodo.Size = new System.Drawing.Size(118, 41);
            this.buttonAddTodo.TabIndex = 2;
            this.buttonAddTodo.Text = "新增待办";
            this.buttonAddTodo.UseVisualStyleBackColor = true;
            this.buttonAddTodo.Click += new System.EventHandler(this.buttonAddTodo_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(679, 23);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(118, 41);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "显示待办";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "旅程：";
            // 
            // panelTodo
            // 
            this.panelTodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTodo.Location = new System.Drawing.Point(6, 78);
            this.panelTodo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTodo.Name = "panelTodo";
            this.panelTodo.Size = new System.Drawing.Size(954, 544);
            this.panelTodo.TabIndex = 4;
            // 
            // TravelTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(969, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTodo);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAddTodo);
            this.Controls.Add(this.labelTravelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TravelTodo";
            this.Text = "旅程-待办";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTravelTitle;
        private System.Windows.Forms.Button buttonAddTodo;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTodo;
    }
}