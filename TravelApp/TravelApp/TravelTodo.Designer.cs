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
            this.labelTravelTitle = new System.Windows.Forms.Label();
            this.panelTodo = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddTodo = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTravelTitle
            // 
            this.labelTravelTitle.Font = new System.Drawing.Font("宋体", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTravelTitle.Location = new System.Drawing.Point(30, 35);
            this.labelTravelTitle.Name = "labelTravelTitle";
            this.labelTravelTitle.Size = new System.Drawing.Size(295, 55);
            this.labelTravelTitle.TabIndex = 0;
            this.labelTravelTitle.Text = "旅行名称";
            this.labelTravelTitle.Text=TravelTitle;
            // 
            // panelTodo
            // 
            this.panelTodo.Location = new System.Drawing.Point(28, 144);
            this.panelTodo.Name = "panelTodo";
            this.panelTodo.Size = new System.Drawing.Size(1126, 541);
            this.panelTodo.TabIndex = 1;
            // 
            // buttonAddTodo
            // 
            this.buttonAddTodo.Location = new System.Drawing.Point(997, 31);
            this.buttonAddTodo.Name = "buttonAddTodo";
            this.buttonAddTodo.Size = new System.Drawing.Size(157, 55);
            this.buttonAddTodo.TabIndex = 2;
            this.buttonAddTodo.Text = "新增待办";
            this.buttonAddTodo.UseVisualStyleBackColor = true;
            this.buttonAddTodo.Click += new System.EventHandler(this.buttonAddTodo_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(796, 31);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(157, 55);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "显示待办";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // TravelTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1180, 697);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonAddTodo);
            this.Controls.Add(this.panelTodo);
            this.Controls.Add(this.labelTravelTitle);
            this.Name = "TravelTodo";
            this.Text = "TravelTodo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTravelTitle;
        private System.Windows.Forms.FlowLayoutPanel panelTodo;
        private System.Windows.Forms.Button buttonAddTodo;
        private System.Windows.Forms.Button buttonShow;
    }
}