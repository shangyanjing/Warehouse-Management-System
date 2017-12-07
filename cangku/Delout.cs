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
    public partial class Delout : Form
    {
        public Delout()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ku.connection);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from Chuku where 出库单号='" + FindName.Text + "'";
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

        private void DELB_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string strsql = "delete from Chuku where (序号='" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value + "') and (出库单号='" + FindName.Text + "')";
                SqlCommand comm = new SqlCommand(strsql, conn);
                comm.ExecuteNonQuery();

                string sql = "select * from Chuku where 出库单号='" + FindName.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Chuku");
                dataGridView1.DataSource = ds.Tables["Chuku"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delout_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
