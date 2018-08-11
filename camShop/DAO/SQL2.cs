using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SQL2
    {
        static string _strConn = "Data Source=.;Initial Catalog=ShopC;Integrated Security=True";

        public string strConn()
        {
            return _strConn;
        }

        public static SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(_strConn);
            conn.Open();
            return conn;
        }
        
        public static void ExecNonQuery(SqlCommand cmd)
        {
            if (cmd.Connection!=null)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                using (SqlConnection conn = Connect())
                {
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable getData(SqlCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlDataAdapter adap = new SqlDataAdapter())
                    {
                        adap.SelectCommand = cmd;
                        adap.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            else
            {
                using (SqlConnection conn = Connect())
                {
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlDataAdapter adap = new SqlDataAdapter())
                        {
                            cmd.Connection = conn;
                            adap.SelectCommand = cmd;
                            adap.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
        }

    }
}
