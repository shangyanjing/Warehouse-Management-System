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
    public partial class Addout : Form
    {
        public Addout()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(ku.connection);
        private void Addout_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            CKRQ.Text = now.ToString("yyyy年MM月dd日HH:mm:ss");
            try
            {
                //入库单号获取
                string strRU = "select max(出库单号) from Chuku ";
                SqlDataAdapter adRU = new SqlDataAdapter(strRU, conn);
                DataSet dsRU = new DataSet();
                adRU.Fill(dsRU);
                DataTable tableRU = dsRU.Tables[0];
                for (int i = 0; i < tableRU.Rows.Count; i++)
                {
                    int a = Convert.ToInt32(tableRU.Rows[i][0].ToString().Trim()) + 1;
                    CKDH.Text = a.ToString();
                }
                //combox业务类型下拉获取
                string str = "select distinct 业务类型 from Chuku ";
                SqlDataAdapter ad = new SqlDataAdapter(str, conn);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                DataTable table = ds.Tables[0];
                this.YWLX.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    this.YWLX.Items.Add(table.Rows[i][0].ToString().Trim());
                }
                //combox仓库下拉获取
                string strCK = "select distinct 仓库 from Chuku ";
                SqlDataAdapter adCK = new SqlDataAdapter(strCK, conn);
                DataSet dsCK = new DataSet();
                adCK.Fill(dsCK);
                DataTable tableCK = dsCK.Tables[0];
                this.CK.Items.Clear();
                for (int i = 0; i < tableCK.Rows.Count; i++)
                {
                    this.CK.Items.Add(tableCK.Rows[i][0].ToString().Trim());
                }
                //COMBOX工程名称下拉获取
                string str11 = "select distinct 工程名称 from Chuku ";
                SqlDataAdapter ad11 = new SqlDataAdapter(str11, conn);
                DataSet ds11 = new DataSet();
                ad11.Fill(ds11);
                DataTable table11 = ds11.Tables[0];
                for (int i = 0; i < table11.Rows.Count; i++)
                {
                    this.GCMC.Items.Add(table11.Rows[i][0].ToString().Trim());
                }
                //combox部门下拉获取
                string str1 = "select distinct 部门 from Chuku ";
                SqlDataAdapter ad1 = new SqlDataAdapter(str1, conn);
                DataSet ds1 = new DataSet();
                ad1.Fill(ds1);
                DataTable table1 = ds1.Tables[0];
                this.BM.Items.Clear();
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    this.BM.Items.Add(table1.Rows[i][0].ToString().Trim());
                }

                //combox出库类别下拉获取
                string str2 = "select distinct 出库类别 from Chuku ";
                SqlDataAdapter ad2 = new SqlDataAdapter(str2, conn);
                DataSet ds2 = new DataSet();
                ad2.Fill(ds2);
                DataTable table2 = ds2.Tables[0];
                this.CKLB.Items.Clear();
                for (int i = 0; i < table2.Rows.Count; i++)
                {
                    this.CKLB.Items.Add(table2.Rows[i][0].ToString().Trim());
                }

            
                //combox业务员下拉获取
                string strYWY = "select distinct 业务员 from Chuku ";
                SqlDataAdapter adYWY = new SqlDataAdapter(strYWY, conn);
                DataSet dsYWY = new DataSet();
                adYWY.Fill(dsYWY);
                DataTable tableYWY = dsYWY.Tables[0];
                this.YWY.Items.Clear();
                for (int i = 0; i < tableYWY.Rows.Count; i++)
                {
                    this.YWY.Items.Add(tableYWY.Rows[i][0].ToString().Trim());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                for (i = 1; i < dataGridView1.Rows.Count; )
                {
                    SqlConnection conn = new SqlConnection(ku.connection);
                    conn.Open();
                    string strsql = "insert into Chuku(序号,出库单号,出库日期,仓库,业务类型,出库类别,部门,业务号,业务员,工程名称,审批日期,备注,材料编码,材料名称,规格型号,单位,数量,单价,金额) "
                                    + "values('" + i + "','" + Convert.ToInt32( CKDH.Text ) + "','" + CKRQ.Text + "','" + CK.Text + "','" + YWLX.Text + "','" + CKLB.Text + "','" +
                                    BM.Text + "','" + YWH.Text + "','" + YWY.Text + "','" + GCMC.Text + "','" + SPRQ.Text.ToString() + "','" + BJ.Text + "','" + dataGridView1.Rows[i - 1].Cells[0].Value.ToString()
                                    + "','" + dataGridView1.Rows[i - 1].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[4].Value.ToString()
                                    + "','" + dataGridView1.Rows[i - 1].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[6].Value.ToString() + "','" + Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[5].Value.ToString())*Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[6].Value.ToString()) + "')";
                    SqlCommand comm = new SqlCommand(strsql, conn);
                    comm.ExecuteNonQuery();
                    string str = "select * from Kucun where 材料编码='" + dataGridView1.Rows[i - 1].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        conn.Close();
                        string strsql2 = "update  Kucun set 数量  = 数量-'" + Convert.ToInt32(dataGridView1.Rows[y].Cells[5].Value.ToString()) + "' where 材料编码='" + dataGridView1.Rows[y].Cells[0].Value.ToString() + "'";
                        conn.Open();
                        SqlCommand comm2 = new SqlCommand(strsql2, conn);
                        comm2.ExecuteNonQuery();
                    }
                    conn.Close();
                    i = i + 1;
                }
                MessageBox.Show("录入成功，请继续操作");
                this.Close();

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
        public int y=0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex;
            y = e.RowIndex;
            if (x == 2)
            {
                Searchout S = new Searchout();
                S.Instance(this);
                S.Show();    
            }
            else if (x == 8)
            {
                if (dataGridView1.Rows[y].Cells[5].Value.ToString() != " ")
                {
                    dataGridView1.Rows[y].Cells[7].Value = (Convert.ToDouble(dataGridView1.Rows[y].Cells[5].Value.ToString()) * Convert.ToDouble(dataGridView1.Rows[y].Cells[6].Value.ToString()));
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = Convert.ToInt16(e.RowIndex.ToString());
            if (i != 1)
            {
                dataGridView1.Rows[i - 2].Cells[7].Value = (Convert.ToDouble(dataGridView1.Rows[i - 2].Cells[5].Value.ToString()) * Convert.ToDouble(dataGridView1.Rows[i - 2].Cells[6].Value.ToString()));
            }
        }
    }
}
