namespace cangku
{
    partial class Findin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CX = new System.Windows.Forms.Button();
            this.FindName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Findway = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(673, 365);
            this.dataGridView1.TabIndex = 10;
            // 
            // CX
            // 
            this.CX.Location = new System.Drawing.Point(499, 12);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(75, 23);
            this.CX.TabIndex = 11;
            this.CX.Text = "查询";
            this.CX.UseVisualStyleBackColor = true;
            this.CX.Click += new System.EventHandler(this.CX_Click);
            // 
            // FindName
            // 
            this.FindName.FormattingEnabled = true;
            this.FindName.Location = new System.Drawing.Point(303, 14);
            this.FindName.Name = "FindName";
            this.FindName.Size = new System.Drawing.Size(121, 20);
            this.FindName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "查询条件：";
            // 
            // Findway
            // 
            this.Findway.FormattingEnabled = true;
            this.Findway.Items.AddRange(new object[] {
            "入库日期",
            "业务类型",
            "供货单位",
            "部门"});
            this.Findway.Location = new System.Drawing.Point(82, 14);
            this.Findway.Name = "Findway";
            this.Findway.Size = new System.Drawing.Size(121, 20);
            this.Findway.TabIndex = 7;
            this.Findway.SelectedIndexChanged += new System.EventHandler(this.Findway_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "查询方式：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Findin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.FindName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Findway);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Findin";
            this.Text = "入库查询";
            this.Load += new System.EventHandler(this.Findin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CX;
        private System.Windows.Forms.ComboBox FindName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Findway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}