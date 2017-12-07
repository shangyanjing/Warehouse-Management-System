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
    public partial class Findout : Form
    {
        public Findout()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ku.connection);
        private void Findway_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Findway.Text == "出库单号")
                {
                    string str = "select distinct 出库单号 from Chuku ";
                    SqlDataAdapter ad = new SqlDataAdapter(str, conn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    DataTable table = ds.Tables[0];
                    this.FindName.Items.Clear();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        this.FindName.Items.Add(table.Rows[i][0].ToString().Trim());
                    }
                }
                else if (Findway.Text == "出库日期")
                {
                    string str = "select distinct 出库日期 from Chuku ";
                    SqlDataAdapter ad = new SqlDataAdapter(str, conn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    DataTable table = ds.Tables[0];
                    this.FindName.Items.Clear();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        this.FindName.Items.Add(table.Rows[i][0].ToString().Trim());
                    }
                }
                else if (Findway.Text == "部门")
                {


                    string str = "select distinct 部门 from Chuku ";
                    SqlDataAdapter ad = new SqlDataAdapter(str, conn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    DataTable table = ds.Tables[0];
                    this.FindName.Items.Clear();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        this.FindName.Items.Add(table.Rows[i][0].ToString().Trim());
                    }
                }
                else if (Findway.Text == "工程名称")
                {
                    string str = "select distinct 工程名称 from Chuku ";
                    SqlDataAdapter ad = new SqlDataAdapter(str, conn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);
                    DataTable table = ds.Tables[0];
                    this.FindName.Items.Clear();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        this.FindName.Items.Add(table.Rows[i][0].ToString().Trim());
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void CX_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from Chuku where " + " " + Findway.Text + "='" + FindName.Text + "'union all select ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','合计金额',sum(金额) from Chuku where(" + Findway.Text + "='" + FindName.Text + "')";
                SqlDataAdapter comm = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                comm.Fill(ds, "Chuku");
                dataGridView1.DataSource = ds.Tables["Chuku"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Findout_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from Chuku";
                SqlDataAdapter comm = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                comm.Fill(ds, "Chuku");
                dataGridView1.DataSource = ds.Tables["Chuku"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

    }
}
