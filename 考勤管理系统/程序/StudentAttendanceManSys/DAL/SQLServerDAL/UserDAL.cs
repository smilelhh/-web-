using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.IDAL;
using System.Data;
using Model;
using System.Data.SqlClient;
using Utility;

namespace DAL.SQLServerDAL
{
    public class UserDAL : IUserDAL
    {

        public void save(object obj)
        {
            User user = (User)obj;

            string insertSql = "INSERT INTO t_user(username,password,type) VALUES(@username,@password,@type)";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@username", user.UserName),
                                                          new SqlParameter("@password", user.Password),                                                        
                                                          new SqlParameter("@type", user.Type)};

            SQLServerDBUtil.execute(insertSql, sqlParas);
        }

        public void update(object obj)
        {
            User user = (User)obj;

            string updateSql = "UPDATE t_user SET username=@username,password=@password,type=@type WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@username", user.UserName),
                                                          new SqlParameter("@password", user.Password), 
                                                          new SqlParameter("@type", user.Type),     
                                                          new SqlParameter("@ID", user.Id)};

            SQLServerDBUtil.execute(updateSql, sqlParas);
        }

        public void delete(object obj)
        {
            User user = (User)obj;

            string deleteSql = "DELETE FROM t_user WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{new SqlParameter("@ID", user.Id)};

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public DataSet getAll()
        {
            string selectSql = "SELECT * FROM t_user";

            return SQLServerDBUtil.query(selectSql,null);
        }

        public object get(string id)
        {
            User user = null;

            string selectSql = "SELECT * FROM t_user WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", id) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                user = new User();
                user.Id = ds.Tables[0].Rows[0][0].ToString();
                user.UserName = ds.Tables[0].Rows[0][1].ToString();
                user.Password = ds.Tables[0].Rows[0][2].ToString();
                user.Type = ds.Tables[0].Rows[0][3].ToString();
            }
            

            return user;
        }

        public object getByUsername(string username)
        {
            User user = null;

            string selectSql = "SELECT * FROM t_user WHERE username=@username";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@username", username) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                user = new User();
                user.Id = ds.Tables[0].Rows[0][0].ToString();
                user.UserName = ds.Tables[0].Rows[0][1].ToString();
                user.Password = ds.Tables[0].Rows[0][2].ToString();
                user.Type = ds.Tables[0].Rows[0][3].ToString();
            }

            return user;
        }
    }
}
