using System.Data.SqlClient;

namespace Libarry
{
    class Connect
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=DESKTOP-BE7DDTQ;Initial Catalog=LibraryDB;Integrated Security=True";//数据库连接
            sc = new SqlConnection(str);//创建数据库连接对象
            sc.Open();//打开数据库
            return sc;
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)//更新操作
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)//读取操作
        {
            return command(sql).ExecuteReader();
        }
        public void DaoClose()
        {
            sc.Close();//关闭数据库连接
        }
    }
}
