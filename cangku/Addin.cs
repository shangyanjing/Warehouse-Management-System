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
    public partial class Addin : Form
    {
        public Addin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(ku.connection);
        int i = 0;
        public int y;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (i = 1; i < dataGridView1.Rows.Count; )
                {

                    SqlConnection conn = new SqlConnection(ku.connection);
                    conn.Open();
                    string strsql = "insert into Ruku(序号,入库单号,入库日期,仓库,业务类型,供货单位,部门,业务员,业务号,审批时间,备注,存货编码,存货名称,规格型号,单位,数量,单价,金额) "
                                    + "values('" + i + "','" + Convert.ToInt32(RKDH.Text) + "','" + RKRQ.Text + "','" + CK.Text + "','" + YWLX.Text + "','" + GHDW.Text + "','" +
                                    BM.Text + "','" + YWY.Text + "','" + YWH.Text + "','" + SPRQ.Text.ToString() + "','" + BJ.Text + "','" + dataGridView1.Rows[i - 1].Cells[0].Value.ToString()
                                    + "','" + dataGridView1.Rows[i - 1].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[4].Value.ToString()
                                    + "','" + dataGridView1.Rows[i - 1].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[6].Value.ToString() + "','" + Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[5].Value.ToString()) * Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[6].Value.ToString()) + "')";

                    SqlCommand comm = new SqlCommand(strsql, conn);
                    comm.ExecuteNonQuery();
                    string str = "select * from Kucun where 材料编码='" + dataGridView1.Rows[i - 1].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(str, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        conn.Close();
                        string strsql2 = "update  Kucun set 数量  = 数量+'" + Convert.ToInt32(dataGridView1.Rows[y].Cells[5].Value.ToString()) + "' where 材料编码='" + dataGridView1.Rows[y].Cells[0].Value.ToString().Trim() + "'";
                        conn.Open();
                        SqlCommand comm2 = new SqlCommand(strsql2, conn);
                        comm2.ExecuteNonQuery();
                    }
                    else
                    {
                        string char1 = dataGridView1.Rows[i - 1].Cells[1].Value.ToString();
                        zfzh zf = new zfzh();
                        string char2 = zf.StrConvertToPinyin(char1);
                        conn.Close();
                        string strsql1 = "insert into Kucun(材料编码,材料名称,规格型号,单位,数量,单价,金额,存货代码) "
                                        + "values('" + dataGridView1.Rows[i - 1].Cells[0].Value.ToString()
                                    + "','" + dataGridView1.Rows[i - 1].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[3].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[4].Value.ToString()
                                    + "','" + dataGridView1.Rows[i - 1].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[i - 1].Cells[6].Value.ToString() + "','" + Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[5].Value.ToString()) * Convert.ToInt32(dataGridView1.Rows[i - 1].Cells[6].Value.ToString()) +
                                    "','" + char2 + "')";
                        conn.Open();
                        SqlCommand comm1 = new SqlCommand(strsql1, conn);
                        comm1.ExecuteNonQuery();
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

        private void Addin_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            RKRQ.Text = now.ToString("yyyy年MM月dd日HH:mm:ss");
            try
            {
               

                //combox供货单位下拉获取
                string str = "select distinct 供货单位 from Ruku ";
                SqlDataAdapter ad = new SqlDataAdapter(str, conn);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                DataTable table = ds.Tables[0];
                this.GHDW.Items.Clear();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    this.GHDW.Items.Add(table.Rows[i][0].ToString().Trim());
                }
                //combox仓库下拉获取
                string strCK = "select distinct 仓库 from Ruku ";
                SqlDataAdapter adCK = new SqlDataAdapter(strCK, conn);
                DataSet dsCK = new DataSet();
                adCK.Fill(dsCK);
                DataTable tableCK = dsCK.Tables[0];
                this.CK.Items.Clear();
                for (int i = 0; i < tableCK.Rows.Count; i++)
                {
                    this.CK.Items.Add(tableCK.Rows[i][0].ToString().Trim());
                }

                //combox部门下拉获取
                string strBM = "select distinct 部门 from Ruku ";
                SqlDataAdapter adBM = new SqlDataAdapter(strBM, conn);
                DataSet dsBM = new DataSet();
                adBM.Fill(dsBM);
                DataTable tableBM = dsBM.Tables[0];
                this.BM.Items.Clear();
                for (int i = 0; i < tableBM.Rows.Count; i++)
                {
                    this.BM.Items.Add(tableBM.Rows[i][0].ToString().Trim());
                }

                //combox业务类型下拉获取
                string strYWLX = "select distinct 业务类型 from Ruku ";
                SqlDataAdapter adYWLX = new SqlDataAdapter(strYWLX, conn);
                DataSet dsYWLX = new DataSet();
                adYWLX.Fill(dsYWLX);
                DataTable tableYWLX = dsYWLX.Tables[0];
                this.YWLX.Items.Clear();
                for (int i = 0; i < tableYWLX.Rows.Count; i++)
                {
                    this.YWLX.Items.Add(tableYWLX.Rows[i][0].ToString().Trim());
                }

                //combox业务员下拉获取
                string strYWY = "select distinct 业务员 from Ruku ";
                SqlDataAdapter adYWY = new SqlDataAdapter(strYWY, conn);
                DataSet dsYWY = new DataSet();
                adYWY.Fill(dsYWY);
                DataTable tableYWY = dsYWY.Tables[0];
                this.YWY.Items.Clear();
                for (int i = 0; i < tableYWY.Rows.Count; i++)
                {
                    this.YWY.Items.Add(tableYWY.Rows[i][0].ToString().Trim());
                }

                //select max(id) from ceshi 
                //入库单号获取
                string strRU = "select max(入库单号) from Ruku ";
                SqlDataAdapter adRU = new SqlDataAdapter(strRU, conn);
                DataSet dsRU = new DataSet();
                adRU.Fill(dsRU);
                DataTable tableRU = dsRU.Tables[0];
                for (int i = 0; i < tableRU.Rows.Count; i++)
                {
                    int a = Convert.ToInt32(tableRU.Rows[i][0].ToString().Trim()) + 1;
                    RKDH.Text = a.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex;
            y = e.RowIndex;
            if (x == 2)
            {
                Searchin S = new Searchin();
                S.Instance(this);
                S.Show();
            }
            else if(x==8)
            {
                if (dataGridView1.Rows[y].Cells[5].Value.ToString() != " ")
                {
                    dataGridView1.Rows[y].Cells[7].Value = (Convert.ToDouble(dataGridView1.Rows[y].Cells[5].Value.ToString()) * Convert.ToDouble(dataGridView1.Rows[y].Cells[6].Value.ToString()));
                }
            }
        }

        //private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    MessageBox.Show(e.Row.Displayed.ToString());
            
        //    //int i = Convert.ToInt16(e.Row.ToString());
        //    //if(i!=0){
        //    //    dataGridView1.Rows[i-1].Cells[7].Value = (Convert.ToDouble(dataGridView1.Rows[i- 1].Cells[5].Value.ToString()) * Convert.ToDouble(dataGridView1.Rows[i - 1].Cells[6].Value.ToString()));
        //    //}
            
        //}



        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int i = Convert.ToInt16( e.RowIndex.ToString());
            if (i != 1)
            {
                dataGridView1.Rows[i-2].Cells[7].Value = (Convert.ToDouble(dataGridView1.Rows[i - 2].Cells[5].Value.ToString()) * Convert.ToDouble(dataGridView1.Rows[i - 2].Cells[6].Value.ToString()));
            }
            

        }


    }
}
