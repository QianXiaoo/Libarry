using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Libarry
{
    public partial class addreturn : Form
    {
        public addreturn()
        {
            InitializeComponent();
        }

        private void addreturn_Load(object sender, EventArgs e)
        {
            Connect dao = new Connect();
            string sql = String.Format("SELECT * FROM Treturn");
            IDataReader rd;
            rd = dao.read(sql);
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            sql = "SELECT * FROM Treader";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                comboBox1.Items.Add(dc[0].ToString());
            }
            
            dc.Close();
            rd.Close();
            dao.DaoClose();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void show()
        {
            Connect dao = new Connect();
            string sql = "select * from Treturn";
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
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && textBox1.Text != "" )
            {
                Connect dao = new Connect();
                string sql = String.Format("SELECT 应还日期 FROM Tborrow WHERE 读者编号 = '{0}' AND 图书编号 = '{1}' AND 借书日期 = '{2}'",
                    comboBox1.Text, comboBox2.Text, comboBox3.Text);
                IDataReader dc = dao.read(sql);
                dc.Read();
                String returntime = dc[0].ToString();
                Convert.ToDateTime(returntime);
                //罚款金额计算
                sql = String.Format("SELECT ISNULL(GREATEST(价格 * LEAST(0.01 * DATEDIFF(day, 应还日期, GETDATE()),1),0),0) AS 超期罚款金额 FROM Tborrow bo JOIN Tbook b ON bo.图书编号 = b.图书编号 WHERE 读者编号 = '{0}' AND b.图书编号 = '{1}' AND 借书日期 = '{2}'", 
                    comboBox1.Text, comboBox2.Text, comboBox3.Text);
                dc = dao.read(sql);
                dc.Read();
                float fakuan = float.Parse(dc[0].ToString());

                sql = String.Format("INSERT INTO Treturn VALUES ('{0}','{1}','{2}', '{3}', '{4}', {5})",
                comboBox1.Text, comboBox2.Text, comboBox3.Text, returntime, textBox1.Text, fakuan);
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    // 借书信息删除
                    sql = String.Format("DELETE FROM Tborrow WHERE 读者编号 = '{0}' AND 图书编号 = '{1}' AND 借书日期 = '{2}'",
                    comboBox1.Text, comboBox2.Text, comboBox3.Text);
                    dao.Execute(sql);
                    // 库存量加一
                    sql = String.Format("UPDATE Tbook set 库存量 = 库存量 + 1 WHERE 图书编号 = '{0}'", comboBox2.Text);
                    dao.Execute(sql);
                    MessageBox.Show("还书信息添加成功");
                }
                else MessageBox.Show("还书信息添加失败");
                dc.Close();
                dao.DaoClose();
                show();
            }
            else
            {
                MessageBox.Show("输入有空");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            Connect dao = new Connect();
            String sql = String.Format("SELECT 借书日期 FROM Tborrow WHERE 读者编号 = '{0}' AND 图书编号 = '{1}'", comboBox1.SelectedItem, comboBox2.SelectedItem);
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                comboBox3.Items.Add(dc[0].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Connect dao = new Connect();
            String sql = String.Format("SELECT DISTINCT 图书编号 FROM Tborrow WHERE 读者编号 = '{0}'", comboBox1.SelectedItem);
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                comboBox2.Items.Add(dc[0].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
