using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.IDAL;
using Model;
using System.Data.SqlClient;
using Utility;
using System.Data;

namespace DAL.SQLServerDAL
{
    public class ClassDAL : IClassDAL
    {
        public void save(object obj)
        {
            Class clazz = (Class)obj;

            string insertSql = "INSERT INTO t_class(depart,grade,name,studCount,monitorID,teacherID) VALUES(@depart,@grade,@name,@studCount,@monitorID,@teacherID)";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@depart", clazz.Depart),
                                                          new SqlParameter("@grade", clazz.Grade),
                                                          new SqlParameter("@name", clazz.Name), 
                                                          new SqlParameter("@studCount", clazz.StudCount),    
                                                          string.IsNullOrEmpty(clazz.MonitorID)? new SqlParameter("@monitorID",DBNull.Value) : new SqlParameter("@monitorID",clazz.MonitorID),
                                                          new SqlParameter("@teacherID", clazz.TeacherID)};

            SQLServerDBUtil.execute(insertSql, sqlParas);
        }

        public void update(object obj)
        {
            Class clazz = (Class)obj;

            string updateSql = "UPDATE t_class SET depart=@depart,grade=@grade,name=@name,studCount=@studCount,monitorID=@monitorID,teacherID=@teacherID WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@depart", clazz.Depart),
                                                          new SqlParameter("@grade", clazz.Grade),
                                                          new SqlParameter("@name", clazz.Name), 
                                                          new SqlParameter("@studCount", clazz.StudCount),
                                                          string.IsNullOrEmpty(clazz.MonitorID)? new SqlParameter("@monitorID",DBNull.Value) : new SqlParameter("@monitorID",clazz.MonitorID),
                                                          new SqlParameter("@teacherID", clazz.TeacherID),
                                                          new SqlParameter("@ID", clazz.Id)};

            SQLServerDBUtil.execute(updateSql, sqlParas);
        }

        public void delete(object obj)
        {
            Class clazz = (Class)obj;

            string deleteSql = "DELETE t_class WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", clazz.Id) };

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public System.Data.DataSet getAll()
        {
            string selectSql = "SELECT * FROM t_class";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public object get(string id)
        {
            Class clazz = null;

            string selectSql = "SELECT * FROM t_class WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", id) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                clazz = new Class();
                clazz.Id = ds.Tables[0].Rows[0][0].ToString();
                clazz.Depart = ds.Tables[0].Rows[0][1].ToString();
                clazz.Grade = ds.Tables[0].Rows[0][2].ToString();
                clazz.Name = ds.Tables[0].Rows[0][3].ToString();
                clazz.StudCount = ds.Tables[0].Rows[0][4].ToString();
                clazz.MonitorID = ds.Tables[0].Rows[0][5].ToString();
                clazz.TeacherID = ds.Tables[0].Rows[0][6].ToString();
            }


            return clazz;
        }

        public DataSet getByTeacherId(string teachId)
        {
            string selectSql = "SELECT * FROM t_class WHERE teacherID=@teacherID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@teacherID", teachId) };

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        //public DataSet getPaged(string from, string to)
        //{
        //    string selectSql = "EXEC P_GetPagedTable @from,@to,@tableName";

        //    SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@from", from),
        //                                                   new SqlParameter("@to", to),
        //                                                   new SqlParameter("@tableName", "t_class")};

        //    return SQLServerDBUtil.query(selectSql, sqlParas);
        //}

        
    }
}
