using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cangku
{
    public partial class Useradd : Form
    {
        public Useradd()
        {
            InitializeComponent();
        }

        private void QuXiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TianJia_Click(object sender, EventArgs e)
        {
            if (this.UserName.Text == "" || this.Password.Text == "" || this.cxsr.Text == "" || this.CbType.Text == "")
            {
                MessageBox.Show("注册的项目不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else 
            {
                if (Password.Text.Trim() == cxsr.Text.Trim())
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(ku.connection);
                        conn.Open();
                        string strsql = "insert into Users(UsersName,UsersPassword,UsersType) " + "values('" + UserName.Text + "','" + cxsr.Text + "','" + CbType.Text + "')";
                        SqlCommand comm = new SqlCommand(strsql, conn);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("录入成功，请继续操作");
                        conn.Close();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("您两次输入的密码不一致，请重新输入");
                }
            }
        }
    }
}
