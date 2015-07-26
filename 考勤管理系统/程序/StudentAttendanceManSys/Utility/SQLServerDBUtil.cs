using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Utility
{
    public class SQLServerDBUtil
    {
        /// <summary>
        /// 数据库连接对象
        /// </summary>
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString.ToString());

        /// <summary>
        /// 根据sql语句查询数据库
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParas"></param>
        /// <returns></returns>
        public static DataSet query(string sql, SqlParameter[] sqlParas)
        {
            //数据适配器对象
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            try
            {
                if (sqlParas != null)
                    da.SelectCommand.Parameters.AddRange(sqlParas);

                conn.Open();
                da.Fill(ds);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        /// <summary>
        /// 根据sql语句执行操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sqlParas"></param>
        /// <returns></returns>
        public static int execute(string sql, SqlParameter[] sqlParas)
        {

            try
            {
                //数据库操作对象
                SqlCommand cmd = new SqlCommand(sql, conn);

                if (sqlParas != null)
                    cmd.Parameters.AddRange(sqlParas);

                conn.Open();
                return cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }


        }

    }
}
