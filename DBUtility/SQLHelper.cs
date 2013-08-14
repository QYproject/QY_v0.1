using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DBUtility
{
    public class SQLHelper
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;

        public static void PrepareCmd(SqlCommand cmd, SqlConnection conn, CommandType cmdType, string cmdTxt, System.Data.SqlClient.SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdTxt;
            cmd.CommandType = cmdType;
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        public static SqlDataReader ExecuteReader(string constr, CommandType cmdType, string cmdTxt, SqlParameter[] commandParameters)
        {
            //实例化临时的SqlCommand、SqlConnection对象。
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(constr);

            try
            {
                // 使用上面定义的PrepareCommand方法构建一个即将执行的命令对象。
                PrepareCmd(cmd, conn, cmdType, cmdTxt, commandParameters);
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                // 命令已经执行完毕，将参数集合清空以释放资源。
                cmd.Parameters.Clear();
                return rdr;
            }
            catch
            {
                // 异常：一旦出现异常则先显示关闭连接对象。然后再将异常抛出。
                conn.Close();
                throw;
            }
        }

        public static int ExecuteNonQuery(string constr, CommandType cmdType, string cmdTxt, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                PrepareCmd(cmd, conn, cmdType, cmdTxt, commandParameters);
                int val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                return val;
            }
        }

        public static object ExecuteScalar(string constr, CommandType cmdType, string cmdTxt, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();

            using (SqlConnection connection = new SqlConnection(constr))
            {
                PrepareCmd(cmd, connection, cmdType, cmdTxt, commandParameters);
                object val = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                return val;
            }
        }
    }
}
