using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cangku
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Useradd useradd = new Useradd();
            useradd.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Global.UsersType == "入库员")
            {
                出库ToolStripMenuItem.Enabled = false;
            }
            else if (Global.UsersType == "出库员")
            {
                入库ToolStripMenuItem.Enabled = false;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("是否确定退出本程序","确认", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }          
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addin addin = new Addin();
            addin.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delin delin = new Delin();
            delin.Show();
        }

        private void 添加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Addout addout = new Addout();
            addout.Show();
        }

        private void 修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delout delout = new Delout();
            delout.Show();
        }

        private void 入库查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Findin findin = new Findin();
            findin.Show();
        }

        private void 出库查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Findout findout = new Findout();
            findout.Show();
        }
    }
}
