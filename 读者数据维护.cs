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
    public partial class maintainreader : Form
    {
        public maintainreader()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void show()
        {
            Connect dao = new Connect();
            string sql = "select * from Treader";
            IDataReader rd;
            rd = dao.read(sql);
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            rd.Close();
            dao.DaoClose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                Connect dao = new Connect();
                string sql = String.Format("INSERT INTO Treader VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                int n = dao.Execute(sql);
                if (n > 0) MessageBox.Show("读者信息添加成功");
                else MessageBox.Show("读者信息添加失败");
                dao.DaoClose();
                show();
            }
            else
            {
                MessageBox.Show("输入有空");
            }
        }

        private void maintainreader_Load(object sender, EventArgs e)
        {
            show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                Connect dao = new Connect();
                string sql = String.Format("UPDATE Treader set 读者编号 = '{0}', 读者姓名 = '{1}', 密码 = '{2}', 出生日期 = '{3}', 性别 = '{4}', 联系电话 = '{5}' WHERE 读者编号 = '{6}'",
                    textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox1.Text);
                int n = dao.Execute(sql);
                if (n > 0) MessageBox.Show("读者信息修改成功");
                else MessageBox.Show("读者信息修改失败");
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
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // 选取读者编号
                DialogResult dr = MessageBox.Show("你确定要删除该读者信息吗？", "消息框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Connect dao = new Connect();
                    string sql = String.Format("Delete from Tborrow where 读者编号 = '{0}'", id);
                    dao.Execute(sql);
                    sql = String.Format("Delete from Treturn where 读者编号 = '{0}'", id);
                    dao.Execute(sql);
                    sql = String.Format("Delete from Treader where 读者编号 = '{0}'", id);
                    if (dao.Execute(sql) > 0)
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
                MessageBox.Show("请先选中要删除的读者信息", "消息框", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
