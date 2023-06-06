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
    public partial class searchbook : Form
    {
        public searchbook()
        {
            InitializeComponent();
        }

        private void reader2_Load(object sender, EventArgs e)
        {
            Connect dao = new Connect();
            string sql = "select * from Tbook";
            IDataReader rd;
            rd = dao.read(sql);
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            rd.Close();
            dao.DaoClose();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //根据图书编号查询
        private void button1_Click(object sender, EventArgs e)
        {
            Connect dao = new Connect();
            string sql = String.Format("select * from Tbook where 图书编号 = '{0}'" , textBox1.Text);
            IDataReader rd;
            rd = dao.read(sql);
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            rd.Close();
            dao.DaoClose();
        }

        //根据书名(模糊查询的方法实现)查询
        private void button2_Click(object sender, EventArgs e)
        {
            Connect dao = new Connect();
            string sql = String.Format("select * from Tbook where 图书名称 like '%{0}%'", textBox2.Text); 
            IDataReader rd;
            rd = dao.read(sql);
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            rd.Close();
            dao.DaoClose();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
