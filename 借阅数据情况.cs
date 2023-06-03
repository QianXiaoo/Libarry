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
    public partial class borrowbook : Form
    {
        public borrowbook()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void borrowbook_Load(object sender, EventArgs e)
        {
            label2.Text = USER.NAME;
            Connect dao = new Connect();
            string sql = String.Format("SELECT * FROM Tborrow WHERE 读者编号 = '{0}'", USER.UID);
            IDataReader rd;
            rd = dao.read(sql);
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataGridView1.DataSource = dt;
            rd.Close();
            dao.DaoClose();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
