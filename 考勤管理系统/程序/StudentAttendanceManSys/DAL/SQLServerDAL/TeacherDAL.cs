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
    public class TeacherDAL : ITeacherDAL
    {
        public void save(object obj)
        {
            Teacher teacher = (Teacher)obj;

            string insertSql = "INSERT INTO t_teacher(teacherId,name,gender,birth,title,phone,email,userID) VALUES(@teacherId,@name,@gender,@birth,@title,@phone,@email,@userID)";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@teacherId", teacher.TeacherId),
                                                          new SqlParameter("@name", teacher.Name),
                                                          new SqlParameter("@gender", teacher.Gender), 
                                                          new SqlParameter("@birth", teacher.Birth),  
                                                          new SqlParameter("@title", teacher.Title),  
                                                          new SqlParameter("@phone", teacher.Phone),  
                                                          new SqlParameter("@email", teacher.Email),  
                                                          new SqlParameter("@userID", teacher.UserID)};

            SQLServerDBUtil.execute(insertSql, sqlParas);
        }

        public void update(object obj)
        {
            Teacher teacher = (Teacher)obj;

            string updateSql = "UPDATE t_teacher SET teacherId=@teacherId, name=@name,gender=@gender,birth=@birth,title=@title,phone=@phone,email=@email,userID=@userID WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@teacherId", teacher.TeacherId),
                                                          new SqlParameter("@name", teacher.Name),
                                                          new SqlParameter("@gender", teacher.Gender), 
                                                          new SqlParameter("@birth", teacher.Birth),  
                                                          new SqlParameter("@title", teacher.Title),  
                                                          new SqlParameter("@phone", teacher.Phone),  
                                                          new SqlParameter("@email", teacher.Email), 
                                                          new SqlParameter("@userID", teacher.UserID),
                                                          new SqlParameter("@ID", teacher.Id)};

            SQLServerDBUtil.execute(updateSql, sqlParas);
        }

        public void delete(object obj)
        {
            Teacher teacher = (Teacher)obj;

            string deleteSql = "DELETE FROM t_teacher WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", teacher.Id) };

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public DataSet getAll()
        {
            string selectSql = "SELECT * FROM t_teacher";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public DataSet getClassTeachers()
        {
            string selectSql = "SELECT * FROM t_teacher WHERE title='辅导员'";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public DataSet getTeachers()
        {
            string selectSql = "SELECT * FROM t_teacher WHERE title!='辅导员'";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public object get(string id)
        {
            Teacher teacher = null;

            string selectSql = "SELECT * FROM t_teacher WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", id) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                teacher = new Teacher();
                teacher.Id = ds.Tables[0].Rows[0][0].ToString();
                teacher.TeacherId = ds.Tables[0].Rows[0][1].ToString();
                teacher.Name = ds.Tables[0].Rows[0][2].ToString();
                teacher.Gender = ds.Tables[0].Rows[0][3].ToString();
                teacher.Birth = ds.Tables[0].Rows[0][4].ToString();
                teacher.Title = ds.Tables[0].Rows[0][5].ToString();
                teacher.Phone = ds.Tables[0].Rows[0][6].ToString();
                teacher.Email = ds.Tables[0].Rows[0][7].ToString();
                teacher.UserID = ds.Tables[0].Rows[0][8].ToString();
            }


            return teacher;
        }

        public object getByTeacherId(string teacherId)
        {
            Teacher teacher = null;

            string selectSql = "SELECT * FROM t_teacher WHERE teacherId=@teacherId";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@teacherId", teacherId) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                teacher = new Teacher();
                teacher.Id = ds.Tables[0].Rows[0][0].ToString();
                teacher.TeacherId = ds.Tables[0].Rows[0][1].ToString();
                teacher.Name = ds.Tables[0].Rows[0][2].ToString();
                teacher.Gender = ds.Tables[0].Rows[0][3].ToString();
                teacher.Birth = ds.Tables[0].Rows[0][4].ToString();
                teacher.Title = ds.Tables[0].Rows[0][5].ToString();
                teacher.Phone = ds.Tables[0].Rows[0][6].ToString();
                teacher.Email = ds.Tables[0].Rows[0][7].ToString();
                teacher.UserID = ds.Tables[0].Rows[0][8].ToString();
            }


            return teacher;
        }

        public object getByUserId(string userId)
        {
            Teacher teacher = null;

            string selectSql = "SELECT * FROM t_teacher WHERE userID=@userID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@userID", userId) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                teacher = new Teacher();
                teacher.Id = ds.Tables[0].Rows[0][0].ToString();
                teacher.TeacherId = ds.Tables[0].Rows[0][1].ToString();
                teacher.Name = ds.Tables[0].Rows[0][2].ToString();
                teacher.Gender = ds.Tables[0].Rows[0][3].ToString();
                teacher.Birth = ds.Tables[0].Rows[0][4].ToString();
                teacher.Title = ds.Tables[0].Rows[0][5].ToString();
                teacher.Phone = ds.Tables[0].Rows[0][6].ToString();
                teacher.Email = ds.Tables[0].Rows[0][7].ToString();
                teacher.UserID = ds.Tables[0].Rows[0][8].ToString();
            }


            return teacher;
        }

    }
}
