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
    public partial class Findin : Form
    {
        public Findin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(ku.connection);
        private void Findway_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Findway.Text == "部门")
                {
                    string str = "select distinct 部门 from Ruku ";
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
                else if (Findway.Text == "入库日期")
                {
                    string str = "select distinct 入库日期 from Ruku ";
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
                else if (Findway.Text == "供货单位")
                {
                    string str = "select distinct 供货单位 from Ruku ";
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
                else if (Findway.Text == "业务类型")
                {
                    string str = "select distinct 业务类型 from Ruku ";
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
                string sql = "select * from Ruku where " + " " + Findway.Text + "='" + FindName.Text + "'";
                SqlDataAdapter comm = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                comm.Fill(ds, "Ruku");
                dataGridView1.DataSource = ds.Tables["Ruku"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Findin_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from Ruku";
                SqlDataAdapter comm = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                comm.Fill(ds, "Ruku");
                dataGridView1.DataSource = ds.Tables["Ruku"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
    }
}
