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
    public partial class Delin : Form
    {
        public Delin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ku.connection);
        private void ESC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DELB_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string strsql = "delete from Ruku where (序号='" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value + "') and (入库单号='" + FindName.Text + "')";
                SqlCommand comm = new SqlCommand(strsql, conn);
                comm.ExecuteNonQuery();

                string sql = "select * from Ruku where 入库单号='" + FindName.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Ruku");
                dataGridView1.DataSource = ds.Tables["Ruku"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delin_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "select * from Ruku where 入库单号='" + FindName.Text + "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
