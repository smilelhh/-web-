using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.IDAL;
using DAL.DALFactory;
using System.Data;
using Model;

namespace BLL
{
    public class AttendanceBLL
    {
        private IAttendanceDAL dal = null;

        public AttendanceBLL()
        {
            dal = DALFactory.createAttendanceDAL();
        }

        /// <summary>
        /// 保存考勤信息
        /// </summary>
        /// <param name="att"></param>
        public void save(Attendance att)
        {
            dal.save(att);
        }

        /// <summary>
        /// 更新考勤信息
        /// </summary>
        /// <param name="att"></param>
        public void update(Attendance att)
        {
            dal.update(att);
        }

        /// <summary>
        /// 删除考勤信息
        /// </summary>
        /// <param name="att"></param>
        public void delete(Attendance att)
        {
            dal.delete(att);
        }

        /// <summary>
        /// 通过课程表ID删除考勤信息
        /// </summary>
        /// <param name="ctId"></param>
        public void deleteByCourseTableId(string ctId)
        {
            dal.deleteByCourseTableId(ctId);
        }

        /// <summary>
        /// 得到所有的考勤信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return dal.getAll();
        }

        /// <summary>
        /// 根据ID得到考勤信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Attendance get(string id)
        {
            return (Attendance)dal.get(id);
        }

        /// <summary>
        /// 根据课程表ID取得教师登记的考勤信息
        /// </summary>
        /// <param name="courTableId"></param>
        /// <returns></returns>
        public DataSet getByCourTableIdAboutTeacher(string courTableId)
        {
            return dal.getByCourTableIdAboutTeacher(courTableId);
        }

        /// <summary>
        /// 根据课程表ID取得班长登记的考勤信息
        /// </summary>
        /// <param name="courTableId"></param>
        /// <returns></returns>
        public DataSet getByCourTableIdAboutMonitor(string courTableId)
        {
            return dal.getByCourTableIdAboutMonitor(courTableId);
        }

        /// <summary>
        /// 根据班级ID取得教师登记的考勤信息
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public DataSet getByClassIdAboutTeacher(string classId)
        {
            return dal.getByClassIdAboutTeacher(classId);
        }
        /// <summary>
        /// 根据班级ID取得班长登记的考勤信息
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public DataSet getByClassIdAboutMonitor(string classId)
        {
            return dal.getByClassIdAboutMonitor(classId);
        }


        /// <summary>
        /// 根据学生D取得教师登记的考勤信息
        /// </summary>
        /// <param name="studId"></param>
        /// <returns></returns>
        public DataSet getByStudIdAboutTeacher(string studId)
        {
            return dal.getByStudIdAboutTeacher(studId);
        }

        /// <summary>
        /// 根据学生ID取得班长登记的考勤信息
        /// </summary>
        /// <param name="studId"></param>
        /// <returns></returns>
        public DataSet getByStudIdAboutMonitor(string studId)
        {
            return dal.getByStudIdAboutMonitor(studId);
        }

        /// <summary>
        /// 根据学生ID,周次取得教师登记的考勤信息
        /// </summary>
        /// <param name="studId"></param>
        /// <returns></returns>
        public DataSet getByParasAboutTeacher(string studId, string week)
        {
            return dal.getByParasAboutTeacher(studId, week);
        }

        /// <summary>
        /// 根据学生ID,周次取得班长登记的考勤信息
        /// </summary>
        /// <param name="studId"></param>
        /// <returns></returns>
        public DataSet getByParasAboutMonitor(string studId, string week)
        {
            return dal.getByParasAboutMonitor(studId, week);
        }

        /// <summary>
        /// 取得教师登记的考勤信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAboutTeacher()
        {
            return dal.getAboutTeacher();
        }

        /// <summary>
        /// 取得指定周的教师登记的考勤信息
        /// </summary>
        /// <param name="week"></param>
        /// <returns></returns>
        public DataSet getAboutTeacher(string week)
        {
            return dal.getAboutTeacher(week);
        }

        /// <summary>
        /// 取得班长登记的考勤信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAboutMonitor()
        {
            return dal.getAboutMonitor();
        }

        /// <summary>
        /// 取得指定周的班长登记的考勤信息
        /// </summary>
        /// <param name="week"></param>
        /// <returns></returns>
        public DataSet getAboutMonitor(string week)
        {
            return dal.getAboutMonitor(week);
        }

        public DataSet getByRecordId(string recordId)
        {
            return dal.getByRecordId(recordId);
        }
    }
}
