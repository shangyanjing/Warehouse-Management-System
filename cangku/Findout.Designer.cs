namespace cangku
{
    partial class Findout
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
            this.CX = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FindName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Findway = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CX
            // 
            this.CX.Location = new System.Drawing.Point(488, 19);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(75, 23);
            this.CX.TabIndex = 15;
            this.CX.Text = "查询";
            this.CX.UseVisualStyleBackColor = true;
            this.CX.Click += new System.EventHandler(this.CX_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(673, 361);
            this.dataGridView1.TabIndex = 14;
            // 
            // FindName
            // 
            this.FindName.FormattingEnabled = true;
            this.FindName.Location = new System.Drawing.Point(315, 19);
            this.FindName.Name = "FindName";
            this.FindName.Size = new System.Drawing.Size(121, 20);
            this.FindName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "查询条件：";
            // 
            // Findway
            // 
            this.Findway.FormattingEnabled = true;
            this.Findway.Items.AddRange(new object[] {
            "出库单号",
            "出库日期",
            "部门",
            "工程名称"});
            this.Findway.Location = new System.Drawing.Point(71, 19);
            this.Findway.Name = "Findway";
            this.Findway.Size = new System.Drawing.Size(121, 20);
            this.Findway.TabIndex = 11;
            this.Findway.SelectedIndexChanged += new System.EventHandler(this.Findway_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "查询方式:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Findout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.FindName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Findway);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Findout";
            this.Text = "出库查询";
            this.Load += new System.EventHandler(this.Findout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox FindName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Findway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;

    }
}