namespace cangku
{
    partial class Useradd
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
            this.QuXiao = new System.Windows.Forms.Button();
            this.TianJia = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cxsr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // QuXiao
            // 
            this.QuXiao.Location = new System.Drawing.Point(168, 207);
            this.QuXiao.Name = "QuXiao";
            this.QuXiao.Size = new System.Drawing.Size(75, 23);
            this.QuXiao.TabIndex = 11;
            this.QuXiao.Text = "取消";
            this.QuXiao.UseVisualStyleBackColor = true;
            this.QuXiao.Click += new System.EventHandler(this.QuXiao_Click);
            // 
            // TianJia
            // 
            this.TianJia.Location = new System.Drawing.Point(52, 207);
            this.TianJia.Name = "TianJia";
            this.TianJia.Size = new System.Drawing.Size(75, 23);
            this.TianJia.TabIndex = 10;
            this.TianJia.Text = "添加";
            this.TianJia.UseVisualStyleBackColor = true;
            this.TianJia.Click += new System.EventHandler(this.TianJia_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(118, 84);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(100, 21);
            this.Password.TabIndex = 9;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(118, 42);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 21);
            this.UserName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(54, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "密  码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名：";
            // 
            // cxsr
            // 
            this.cxsr.Location = new System.Drawing.Point(118, 121);
            this.cxsr.Name = "cxsr";
            this.cxsr.PasswordChar = '*';
            this.cxsr.Size = new System.Drawing.Size(100, 21);
            this.cxsr.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(37, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "重新输入：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(54, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "权  限：";
            // 
            // CbType
            // 
            this.CbType.FormattingEnabled = true;
            this.CbType.Items.AddRange(new object[] {
            "管理员",
            "入库员",
            "出库员"});
            this.CbType.Location = new System.Drawing.Point(122, 157);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(96, 20);
            this.CbType.TabIndex = 15;
            // 
            // Useradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.CbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cxsr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuXiao);
            this.Controls.Add(this.TianJia);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Useradd";
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuXiao;
        private System.Windows.Forms.Button TianJia;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cxsr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbType;
    }
}