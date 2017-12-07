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
    public partial class Searchin : Form
    {
        public Searchin()
        {
            InitializeComponent();
        }
        Addin ad1;
      
        public void Instance(Addin ad)
        { ad1 = ad; }
      
        private void Search_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ku.connection);
                conn.Open();
                string sql = "select * from Kucun where 存货代码 like '" + ad1.dataGridView1.Rows[ad1.y].Cells[1].Value.ToString() + "%'";
                SqlDataAdapter comm = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                comm.Fill(ds, "Kucun");
                dataGridView1.DataSource = ds.Tables["Kucun"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            x = e.RowIndex;        
        }
        int x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int y = ad1.y;
                ad1.dataGridView1.Rows[y].Cells[0].Value = this.dataGridView1.Rows[x].Cells[0].Value.ToString();
                ad1.dataGridView1.Rows[y].Cells[1].Value = this.dataGridView1.Rows[x].Cells[1].Value.ToString();
                ad1.dataGridView1.Rows[y].Cells[3].Value = this.dataGridView1.Rows[x].Cells[2].Value.ToString();
                ad1.dataGridView1.Rows[y].Cells[4].Value = this.dataGridView1.Rows[x].Cells[3].Value.ToString();
                ad1.dataGridView1.Rows[y].Cells[6].Value = this.dataGridView1.Rows[x].Cells[5].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            x = e.RowIndex; 
        }
    }
}
