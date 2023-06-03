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
    public partial class maintainbook : Form
    {
        public maintainbook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="" && textBox5.Text!="" && textBox6.Text!="" && textBox7.Text!="")
            {
                Connect dao = new Connect();
                string sql = String.Format("INSERT INTO Tbook VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                int n = dao.Execute(sql);
                if (n > 0) MessageBox.Show("图书信息添加成功");
                else MessageBox.Show("图书信息添加失败");
                dao.DaoClose();
                show();
            }
            else
            {
                MessageBox.Show("输入有空");
            }
        }

        private void maintainbook_Load(object sender, EventArgs e)
        {
            show();
        }
        public void show()
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                Connect dao = new Connect();
                string sql = String.Format("UPDATE Tbook set 图书编号 = '{0}', 图书类别 = '{1}', 图书名称 = '{2}', 作者 = '{3}', 库存量 = {4}, 价格 = {5} , 出版社 = '{6}' WHERE 图书编号 = '{7}'",
                    textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox1.Text);
                int n = dao.Execute(sql);
                if (n > 0) MessageBox.Show("图书信息修改成功");
                else MessageBox.Show("图书信息添加失败");
                dao.DaoClose();
                show();
            }
            else
            {
                MessageBox.Show("输入有空");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                //用异常捕获语句防止没有选中
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // 选取图书编号
                DialogResult dr = MessageBox.Show("你确定要删除该图书信息吗？","消息框",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    string sql = String.Format("Delete from Tbook where 图书编号 = '{0}'", id);
                    Connect dao = new Connect();
                    if(dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        show();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的图书信息", "消息框", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
