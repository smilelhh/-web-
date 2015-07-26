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
    public class CourseTableDAL : ICourseTableDAL
    {
        public void save(object obj)
        {
            CourseTable courTable = (CourseTable)obj;

            string insertSql = "INSERT INTO t_courseTable(semester,week,weekDay,place,courseTime,teachID,classID,courId) VALUES(@semester,@week,@weekDay,@place,@courseTime,@teachID,@classID,@courId)";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@semester", courTable.Semester),
                                                          new SqlParameter("@week", courTable.Week),                                                        
                                                          new SqlParameter("@weekDay", courTable.WeekDay),
                                                          new SqlParameter("@place", courTable.Place),
                                                          new SqlParameter("@courseTime", courTable.CourseTime),
                                                          new SqlParameter("@teachID", courTable.TeachID),
                                                          new SqlParameter("@classID", courTable.ClassID),
                                                          new SqlParameter("@courId", courTable.CourId)};

            SQLServerDBUtil.execute(insertSql, sqlParas);
        }

        public void update(object obj)
        {
            CourseTable courTable = (CourseTable)obj;

            string updateSql = "UPDATE t_courseTable SET semester=@semester,week=@week,weekDay=@weekDay,place=@place,courseTime=@courseTime,teachID=@teachID,classID=@classID,courId=@courId WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@semester", courTable.Semester),
                                                          new SqlParameter("@week", courTable.Week),                                                        
                                                          new SqlParameter("@weekDay", courTable.WeekDay),
                                                          new SqlParameter("@place", courTable.Place),
                                                          new SqlParameter("@courseTime", courTable.CourseTime),
                                                          new SqlParameter("@teachID", courTable.TeachID),
                                                          new SqlParameter("@classID", courTable.ClassID),
                                                          new SqlParameter("@courId", courTable.CourId),
                                                          new SqlParameter("@ID", courTable.Id)};

            SQLServerDBUtil.execute(updateSql, sqlParas);
        }

        public void delete(object obj)
        {
            CourseTable courTable = (CourseTable)obj;

            string deleteSql = "DELETE FROM t_courseTable WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", courTable.Id) };

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public DataSet getAll()
        {
            string selectSql = "SELECT * FROM t_courseTable";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public object get(string id)
        {
            CourseTable courTable = null;

            string selectSql = "SELECT * FROM t_courseTable WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", id) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                courTable = new CourseTable();
                courTable.Id = ds.Tables[0].Rows[0][0].ToString();
                courTable.Semester = ds.Tables[0].Rows[0][1].ToString();
                courTable.Week = ds.Tables[0].Rows[0][2].ToString();
                courTable.WeekDay = ds.Tables[0].Rows[0][3].ToString();
                courTable.Place = ds.Tables[0].Rows[0][4].ToString();
                courTable.CourseTime = ds.Tables[0].Rows[0][5].ToString();
                courTable.TeachID = ds.Tables[0].Rows[0][6].ToString();
                courTable.ClassID = ds.Tables[0].Rows[0][7].ToString();
                courTable.CourId = ds.Tables[0].Rows[0][8].ToString();
            }


            return courTable;
        }

        public DataSet getByTeacherId(string teachId)
        {
            string selectSql = "SELECT * FROM t_courseTable WHERE teachID=@teachID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@teachID", teachId) };

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }


        public DataSet getByParas(string semester, string week, string weekDay, string classID)
        {
            string selectSql = "SELECT * FROM t_courseTable WHERE semester=@semester and week=@week and weekDay=@weekDay and classID=@classID ORDER BY courseTime";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", semester),
                                                           new SqlParameter("@week", week),
                                                           new SqlParameter("@weekDay", weekDay),
                                                           new SqlParameter("@classID", classID)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByParas(string semester, string week, string teacherID)
        {
            string selectSql = "SELECT * FROM t_courseTable WHERE semester=@semester and week=@week and teachID=@teachID ORDER BY courseTime";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", semester),
                                                           new SqlParameter("@week", week),         
                                                           new SqlParameter("@teachID", teacherID)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByParas(string semester, string teacherID)
        {
            string selectSql = "SELECT * FROM t_courseTable WHERE semester=@semester and teachID=@teachID ORDER BY courseTime";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", semester),
                                                           new SqlParameter("@teachID", teacherID)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByTCC(string semester, string teacherID, string classID, string courID)
        {
            string selectSql = "SELECT * FROM t_courseTable WHERE semester=@semester and teachID=@teachID and classID=@classID and courId=@courID ORDER BY week";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", semester),
                                                           new SqlParameter("@teachID", teacherID),
                                                           new SqlParameter("@classID",classID),
                                                           new SqlParameter("@courID",courID)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        
    }
}
