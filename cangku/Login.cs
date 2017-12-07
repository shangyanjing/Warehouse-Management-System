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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.TbName.Text == "" || this.TbPwd.Text == "" || this.CbType.Text == "")
            {
                MessageBox.Show("用户名,密码或用户类型不能为空！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.TbName.Focus();
                TbPwd.Clear();
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ku.connection);
                    string str = "select * from Users where UsersName='" + this.TbName.Text.Trim() + "'";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        if (TbPwd.Text.Trim() == read["UsersPassword"].ToString().Trim())
                        {
                            if (CbType.Text.Trim() == read["UsersType"].ToString().Trim())
                            {
                                MessageBox.Show("登录成功");
                                Global.UsersType = CbType.Text.Trim();
                                Main ma = new Main();
                                this.Hide();
                                ma.Show();
                            }
                            else
                            {
                                MessageBox.Show("您的用户类型不正确请重新选择");
                            }
                        }
                        else
                        {
                            MessageBox.Show("密码错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TbPwd.Clear();
                            TbPwd.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("不存在该用户");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection conn = new SqlConnection(ku.connection);
        private void Login_Load(object sender, EventArgs e)
        {
            
            try
            {
                conn.Open();
                string str = "select distinct UsersName from Users ";
                SqlDataAdapter ad = new SqlDataAdapter(str, conn);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                DataTable table = ds.Tables[0];
                this.TbName.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    this.TbName.Items.Add(table.Rows[i][0].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
