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
    public partial class addborrow : Form
    {
        public addborrow()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void show()
        {
            Connect dao = new Connect();
            string sql = "select * from Tborrow";
            IDataReader rd;
            rd = dao.read(sql);
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            rd.Close();
            dao.DaoClose();
        }
        private void 借阅数据录入_Load(object sender, EventArgs e)
        {
            show();
            Connect dao = new Connect();
            String sql = "SELECT * FROM Treader";
            IDataReader dc = dao.read(sql);
            while(dc.Read())
            {
                comboBox1.Items.Add(dc[0].ToString());
            }
            sql = "SELECT * FROM Tbook";
            dc = dao.read(sql);
            while (dc.Read())
            {
                comboBox2.Items.Add(dc[0].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "" && textBox2.Text != "")
            {
                Connect dao = new Connect();
                String sql = String.Format("SELECT * FROM Tborrow WHERE 应还日期 < GETDATE()");
                IDataReader dc = dao.read(sql);
                bool flag = false;
                while(dc.Read())
                {
                    if (comboBox1.Text == dc[0].ToString())
                    {
                        MessageBox.Show("该读者存在逾期未还的图书，无法继续借书");
                        flag = true;
                        break;
                    }
                }
                if(!flag)
                {
                    sql = String.Format("SELECT * FROM Tbook WHERE 图书编号 = '{0}'", comboBox2.Text);
                    dc = dao.read(sql);

                    dc.Read();
                    if (dc[4].ToString() == "0")
                    {
                        MessageBox.Show("该图书的库存量为0");
                    }
                    else
                    {
                        sql = String.Format("INSERT INTO Tborrow VALUES ('{0}','{1}','{2}','{3}')",
                        comboBox1.Text, comboBox2.Text, textBox1.Text, textBox2.Text);
                        int n = dao.Execute(sql);
                        if (n > 0)
                        {
                            MessageBox.Show("借阅信息添加成功");
                            sql = String.Format("UPDATE Tbook set 库存量 = 库存量 - 1 WHERE 图书编号 = '{0}'", comboBox2.Text);
                            dao.Execute(sql);
                        }
                        else MessageBox.Show("借阅信息添加失败");
                        show();
                    }
                }
                dc.Close();
                dao.DaoClose();
            }
            else
            {
                MessageBox.Show("输入有空");
            }
        }
    }
}
