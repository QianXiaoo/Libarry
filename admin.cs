using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libarry
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintainbook ad = new maintainbook();
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }

        private void 添加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 图书数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchbook rder = new searchbook();
            this.Hide();
            rder.ShowDialog();
            this.Show();
        }

        private void 读者数据维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maintainreader ad = new maintainreader();
            this.Hide();
            ad.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void 借阅数据录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addborrow ab = new addborrow();
            this.Hide();
            ab.ShowDialog();
            this.Show();
        }

        private void 还书数据录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addreturn ar = new addreturn();
            this.Hide();
            ar.ShowDialog();
            this.Show();
        }
    }
}
