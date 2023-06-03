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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("输入有空项，请重新输入");
            }
        }
        //验证登录
        public void Login()
        {
            //用户验证
            if(radioButtonReader.Checked == true)
            {
                Connect dao = new Connect();
               
                string sql = String.Format("select * from Treader where 读者编号='{0}' and 密码 = {1}", textBox1.Text, textBox2.Text);
                IDataReader dc = dao.read(sql);
                if(dc.Read())
                {
                    USER.UID = dc["读者编号"].ToString();
                    USER.NAME = dc["读者姓名"].ToString();
                    MessageBox.Show("读者登录成功");
                    //进入读者界面
                    reader rder = new reader();
                    this.Hide();
                    rder.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("读者登录失败");                  
                }
                dao.DaoClose();
            }
            //管理员
            if(radioButtonAdmin.Checked == true)
            {
                Connect dao = new Connect();
             
                string sql = String.Format("select * from Tadmin where id='{0}' and psw = {1}", textBox1.Text, textBox2.Text);
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("管理员登录成功");
                    //进入管理员界面
                    admin ad = new admin();
                    this.Hide();
                    ad.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("管理员登录失败");
                    
                }
                dao.DaoClose();
            }
            
        }
    }
}
