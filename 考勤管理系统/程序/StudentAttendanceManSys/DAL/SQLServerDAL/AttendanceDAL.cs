using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.IDAL;
using Model;
using Utility;
using System.Data.SqlClient;
using System.Data;
using Utility.Global;

namespace DAL.SQLServerDAL
{
    public class AttendanceDAL : IAttendanceDAL
    {

        public void save(object obj)
        {
            Attendance att = (Attendance)obj;

            string insertSql = "INSERT INTO t_attendance(status,remark,recorder,recorderID,studID,courTableID) VALUES(@status,@remark,@recorder,@recorderID,@studID,@courTableID)";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@status", att.Status),
                                                          new SqlParameter("@remark", att.Remark),
                                                          new SqlParameter("@recorder", att.Recorder),
                                                          new SqlParameter("@recorderID", att.RecorderID),
                                                          new SqlParameter("@studID", att.StudID),
                                                          new SqlParameter("@courTableID", att.CourTableID)};

            SQLServerDBUtil.execute(insertSql, sqlParas);
        }

        public void update(object obj)
        {
            Attendance att = (Attendance)obj;

            string updateSql = "UPDATE t_attendance SET status=@status,remark=@remark,recorder=@recorder,recorderID=@recorderID,studID=@studID,courTableID=@courTableID WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[]{ new SqlParameter("@status", att.Status),
                                                          new SqlParameter("@remark", att.Remark),
                                                          new SqlParameter("@recorder", att.Recorder),
                                                          new SqlParameter("@recorderID", att.RecorderID),
                                                          new SqlParameter("@studID", att.StudID),
                                                          new SqlParameter("@courTableID", att.CourTableID),
                                                          new SqlParameter("@ID", att.Id)};

            SQLServerDBUtil.execute(updateSql, sqlParas);
        }

        public void delete(object obj)
        {
            Attendance att = (Attendance)obj;

            string deleteSql = "DELETE FROM t_attendance WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", att.Id) };

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public void deleteByCourseTableId(string ctId)
        {

            string deleteSql = "DELETE FROM t_attendance WHERE courTableID=@courTableID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@courTableID", ctId) };

            SQLServerDBUtil.execute(deleteSql, sqlParas);
        }

        public DataSet getAll()
        {
            string selectSql = "SELECT * FROM t_attendance";

            return SQLServerDBUtil.query(selectSql, null);
        }

        public object get(string id)
        {
            Attendance att = null;

            string selectSql = "SELECT * FROM t_attendance WHERE ID=@ID";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@ID", id) };

            DataSet ds = SQLServerDBUtil.query(selectSql, sqlParas);

            if (ds.Tables[0].Rows.Count != 0)
            {
                att = new Attendance();

                att.Id = ds.Tables[0].Rows[0][0].ToString();
                att.Status = ds.Tables[0].Rows[0][1].ToString();
                att.Remark = ds.Tables[0].Rows[0][2].ToString();
                att.Recorder = ds.Tables[0].Rows[0][3].ToString();
                att.RecorderID = ds.Tables[0].Rows[0][4].ToString();
                att.StudID = ds.Tables[0].Rows[0][5].ToString();
                att.CourTableID = ds.Tables[0].Rows[0][6].ToString();
            }

            return att;
        }

        public DataSet getByCourTableIdAboutTeacher(string courTableId)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='教师' AND courTableID=@courTableID AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@courTableID", courTableId),
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByCourTableIdAboutMonitor(string courTableId)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='班长' AND courTableID=@courTableID AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@courTableID", courTableId),
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByClassIdAboutTeacher(string classId)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='教师' AND studID in (SELECT ID FROM t_student WHERE classID=@classID) AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@classId", classId),
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByClassIdAboutMonitor(string classId)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='班长' AND studID in (SELECT ID FROM t_student WHERE classID=@classID) AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@classId", classId),
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByStudIdAboutTeacher(string studId)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='教师' AND studID=@studID AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@studID", studId), 
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER) };

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByStudIdAboutMonitor(string studId)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='班长' AND studID=@studID AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@studID", studId), 
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER) };

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByParasAboutTeacher(string studId, string week)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='教师' AND studID=@studID AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester AND week=@week)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@studID", studId), 
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER),
                                                           new SqlParameter("@week", week)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByParasAboutMonitor(string studId, string week)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='班长' AND studID=@studID AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester AND week=@week)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@studID", studId), 
                                                           new SqlParameter("@semester", GlobalVars.SEMESTER),
                                                           new SqlParameter("@week", week)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getAboutTeacher()
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='教师' AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", GlobalVars.SEMESTER) };

            return SQLServerDBUtil.query(selectSql, sqlParas);

        }


        public DataSet getAboutTeacher(string week)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='教师' AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester AND week=@week)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", GlobalVars.SEMESTER),
                                                           new SqlParameter("@week", week)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getAboutMonitor()
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='班长' AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", GlobalVars.SEMESTER) };

            return SQLServerDBUtil.query(selectSql, sqlParas);

        }


        public DataSet getAboutMonitor(string week)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorder='班长' AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester AND week=@week)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", GlobalVars.SEMESTER),
                                                           new SqlParameter("@week", week)};

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

        public DataSet getByRecordId(string recordId)
        {
            string selectSql = "SELECT * FROM t_attendance WHERE recorderID=@recordID AND courTableID in (SELECT ID FROM t_courseTable WHERE semester=@semester)";

            SqlParameter[] sqlParas = new SqlParameter[] { new SqlParameter("@semester", GlobalVars.SEMESTER),
                                                           new SqlParameter("@recordID",recordId) };

            return SQLServerDBUtil.query(selectSql, sqlParas);
        }

    }
}
