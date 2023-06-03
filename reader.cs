using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Libarry
{
    public partial class reader : Form
    {
        public reader()
        {
            InitializeComponent();
        }

        private void reader_Load(object sender, EventArgs e)
        {

        }

        private void 图书数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchbook rder = new searchbook();
            this.Hide();
            rder.ShowDialog();
            this.Show();

        }

        private void 借阅数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrowbook bber = new borrowbook();
            this.Hide();
            bber.ShowDialog();
            this.Show();
        }

        private void 还书数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            returnbook rber = new returnbook();
            this.Hide();
            rber.ShowDialog();
            this.Show();
        }
    }
}
