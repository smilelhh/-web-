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
    public class StudentDAL : IStudentDAL
    {
        public void save(object obj)
        {
            Student stu = (Student)obj;

            string insertSql = "INSERT INTO t_student(stuId,name,gender,birth,phone,address,classID,userID) VALUES(@stuId,@name,@gender,@birth,@phone,@address,@classID,@userID)";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@stuId", stu.StuId),
                                                          new SqlParameter("@name", stu.Name), 
                                                          new SqlParameter("@gender", stu.Gender),  
                                                          new SqlParameter("@birth", stu.Birth),  
                                                          new SqlParameter("@phone", stu.Phone),  
                                                          new SqlParameter("@address", stu.Address),  
                                                          new SqlParameter("@classID", stu.ClassID),  
                                                          new SqlParameter("@userID", stu.UserID)};

            SQLServerDBUtil.execute(insertSql, sqlParas);
        }

        public void update(object obj)
        {
            Student stu = (Student)obj;

            string updateSql = "UPDATE t_student SET stuId=@stuId,name=@name,gender=@gender,birth=@birth,phone=@phone,address=@address,classID=@classID,userID=@userID WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@stuId", stu.StuId),
                                                          new SqlParameter("@name", stu.Name), 
                                                          new SqlParameter("@gender", stu.Gender),  
                                                          new SqlParameter("@birth", stu.Birth),  
                                                          new SqlParameter("@phone", stu.Phone),  
                                                          new SqlParameter("@address", stu.Address),  
                                                          new SqlParameter("@classID", stu.ClassID),  
                                                          new SqlParameter("@userID", stu.UserID),
                                                          new SqlParameter("@ID", stu.Id)};

            SQLServerDBUtil.execute(updateSql, sqlParas);
        }

        public void delete(object obj)
        {
            Student stu = (Student)obj;

            string deleteSql = "DELETE FROM t_student WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", stu.Id) };

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public DataSet getAll()
        {
            string selectSql = "SELECT * FROM t_student";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public object get(string id)
        {
            Student stu = null;

            string selectSql = "SELECT * FROM t_student WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", id) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                stu = new Student();
                stu.Id = ds.Tables[0].Rows[0][0].ToString();
                stu.StuId = ds.Tables[0].Rows[0][1].ToString();
                stu.Name = ds.Tables[0].Rows[0][2].ToString();
                stu.Gender = ds.Tables[0].Rows[0][3].ToString();
                stu.Birth = ds.Tables[0].Rows[0][4].ToString();
                stu.Phone = ds.Tables[0].Rows[0][5].ToString();
                stu.Address = ds.Tables[0].Rows[0][6].ToString();
                stu.ClassID = ds.Tables[0].Rows[0][7].ToString();
                stu.UserID = ds.Tables[0].Rows[0][8].ToString();
            }

            return stu;
        }


        public object getByUserId(string userId)
        {
            Student stu = null;

            string selectSql = "SELECT * FROM t_student WHERE userID=@userID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@userID", userId) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                stu = new Student();
                stu.Id = ds.Tables[0].Rows[0][0].ToString();
                stu.StuId = ds.Tables[0].Rows[0][1].ToString();
                stu.Name = ds.Tables[0].Rows[0][2].ToString();
                stu.Gender = ds.Tables[0].Rows[0][3].ToString();
                stu.Birth = ds.Tables[0].Rows[0][4].ToString();
                stu.Phone = ds.Tables[0].Rows[0][5].ToString();
                stu.Address = ds.Tables[0].Rows[0][6].ToString();
                stu.ClassID = ds.Tables[0].Rows[0][7].ToString();
                stu.UserID = ds.Tables[0].Rows[0][8].ToString();
            }

            return stu;
        }

        public object getByStuId(string stuId)
        {
            Student stu = null;

            string selectSql = "SELECT * FROM t_student WHERE stuId=@stuId";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@stuId", stuId) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                stu = new Student();
                stu.Id = ds.Tables[0].Rows[0][0].ToString();
                stu.StuId = ds.Tables[0].Rows[0][1].ToString();
                stu.Name = ds.Tables[0].Rows[0][2].ToString();
                stu.Gender = ds.Tables[0].Rows[0][3].ToString();
                stu.Birth = ds.Tables[0].Rows[0][4].ToString();
                stu.Phone = ds.Tables[0].Rows[0][5].ToString();
                stu.Address = ds.Tables[0].Rows[0][6].ToString();
                stu.ClassID = ds.Tables[0].Rows[0][7].ToString();
                stu.UserID = ds.Tables[0].Rows[0][8].ToString();
            }

            return stu;
        }

        public DataSet getByClassId(string classId)
        {
            string selectSql = "SELECT * FROM t_student where classID=@classID";
            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@classID", classId) };

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }
    }
}
