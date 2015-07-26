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
    class StaffDAL : IStaffDAL
    {
        public void save(object obj)
        {
            Staff staff = (Staff)obj;

            string insertSql = "INSERT INTO t_staff(name,gender,birth,phone,type,userID) VALUES(@name,@gender,@birth,@phone,@type,@userID)";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@name", staff.Name),
                                                          new SqlParameter("@gender", staff.Gender),
                                                          new SqlParameter("@birth", staff.Birth),       
                                                          new SqlParameter("@phone", staff.Phone),       
                                                          new SqlParameter("@type", staff.Type),       
                                                          new SqlParameter("@userID", staff.UserId)};

            SQLServerDBUtil.execute(insertSql, sqlParas);
        }

        public void update(object obj)
        {
            Staff staff = (Staff)obj;

            string updateSql = "UPDATE t_staff SET name=@name,gender=@gender,birth=@birth,phone=@phone,type=@type,userID=@userID WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@name", staff.Name),
                                                          new SqlParameter("@gender", staff.Gender),
                                                          new SqlParameter("@birth", staff.Birth),       
                                                          new SqlParameter("@phone", staff.Phone),       
                                                          new SqlParameter("@type", staff.Type),  
                                                          new SqlParameter("@userID", staff.UserId),
                                                          new SqlParameter("@ID", staff.Id)};

            SQLServerDBUtil.execute(updateSql, sqlParas);
        }

        public void delete(object obj)
        {
            Staff staff = (Staff)obj;

            string deleteSql = "DELETE FROM t_staff WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", staff.Id) };

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public DataSet getAll()
        {
            string selectSql = "SELECT * FROM t_staff";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public object get(string id)
        {
            Staff staff = null;

            string selectSql = "SELECT * FROM t_staff WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", id) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                staff = new Staff();
                staff.Id = ds.Tables[0].Rows[0][0].ToString();
                staff.Name = ds.Tables[0].Rows[0][1].ToString();
                staff.Gender = ds.Tables[0].Rows[0][2].ToString();
                staff.Birth = ds.Tables[0].Rows[0][3].ToString();
                staff.Phone = ds.Tables[0].Rows[0][4].ToString();
                staff.Type = ds.Tables[0].Rows[0][5].ToString();
                staff.UserId = ds.Tables[0].Rows[0][6].ToString();
            }


            return staff;
        }

        public object getByUserId(string userId)
        {
            Staff staff = null;

            string selectSql = "SELECT * FROM t_staff WHERE userID=@userID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@userID", userId) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                staff = new Staff();
                staff.Id = ds.Tables[0].Rows[0][0].ToString();
                staff.Name = ds.Tables[0].Rows[0][1].ToString();
                staff.Gender = ds.Tables[0].Rows[0][2].ToString();
                staff.Birth = ds.Tables[0].Rows[0][3].ToString();
                staff.Phone = ds.Tables[0].Rows[0][4].ToString();
                staff.Type = ds.Tables[0].Rows[0][5].ToString();
                staff.UserId = ds.Tables[0].Rows[0][6].ToString();
            }


            return staff;
        }
    }
}
