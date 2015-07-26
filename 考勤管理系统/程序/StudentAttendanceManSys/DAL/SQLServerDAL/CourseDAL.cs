using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.IDAL;
using System.Data;
using Model;
using System.Data.SqlClient;
using Utility;
using Utility.Global;

namespace DAL.SQLServerDAL
{
    class CourseDAL : ICourseDAL
    {
        public void save(object obj)
        {
            Course course = (Course)obj;

            string insertSql = "INSERT INTO t_course(name,credit,schoolHour) VALUES(@name,@credit,@schoolHour)";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@name", course.Name),
                                                          new SqlParameter("@credit", course.Credit),                                                        
                                                          new SqlParameter("@schoolHour", course.SchoolHour)};

            SQLServerDBUtil.execute(insertSql, sqlParas);
        }

        public void update(object obj)
        {
            Course course = (Course)obj;

            string updateSql = "UPDATE t_course SET name=@name,credit=@credit,schoolHour=@schoolHour WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@name", course.Name),
                                                          new SqlParameter("@credit", course.Credit),                                                        
                                                          new SqlParameter("@schoolHour", course.SchoolHour),
                                                          new SqlParameter("@ID", course.Id)};

            SQLServerDBUtil.execute(updateSql, sqlParas);
        }

        public void delete(object obj)
        {
            Course course = (Course)obj;

            string deleteSql = "DELETE FROM t_course WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", course.Id)};

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public DataSet getAll()
        {
            string selectSql = "SELECT * FROM t_course";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public object get(string id)
        {
            Course course = null;

            string selectSql = "SELECT * FROM t_course WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", id) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                course = new Course();
                course.Id = ds.Tables[0].Rows[0][0].ToString();
                course.Name = ds.Tables[0].Rows[0][1].ToString();
                course.Credit = ds.Tables[0].Rows[0][2].ToString();
                course.SchoolHour = ds.Tables[0].Rows[0][3].ToString();
            }

            return course;
        }

        public DataSet getByClassId(string classId)
        {
            string selectSql = "SELECT  * FROM t_course WHERE ID in (SELECT distinct courId FROM t_courseTable WHERE classID=@classID AND semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@classID", classId),
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        //public DataSet getPaged(string from, string to)
        //{
        //    string selectSql = "EXEC P_GetPagedTable @from,@to,@tableName";

        //    SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@from", from),
        //                                                   new SqlParameter("@to", to),
        //                                                   new SqlParameter("@tableName", "t_course")};

        //    return SQLServerDBUtil.query(selectSql, sqlParas);
        //}

    }
}
