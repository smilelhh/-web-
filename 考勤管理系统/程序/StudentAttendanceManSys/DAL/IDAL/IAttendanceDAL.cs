using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL.IDAL
{
    public interface IAttendanceDAL
    {
        /// <summary>
        /// 保存对象
        /// </summary>
        /// <param name="obj"></param>
        void save(object obj);

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="obj"></param>
        void update(object obj);

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="obj"></param>
        void delete(object obj);

        /// <summary>
        /// 通过课程表ID删除对象
        /// </summary>
        /// <param name="ctId"></param>
        void deleteByCourseTableId(string ctId);

        /// <summary>
        /// 取得所有对象
        /// </summary>
        DataSet getAll();

        /// <summary>
        /// 根据ID取得对象
        /// </summary>
        /// <param name="id"></param>
        object get(string id);

        /// <summary>
        /// 根据课程表ID取得教师登记的对象集
        /// </summary>
        /// <param name="courTableId"></param>
        /// <returns></returns>
        DataSet getByCourTableIdAboutTeacher(string courTableId);

        /// <summary>
        /// 根据课程表ID取得班长登记的对象集
        /// </summary>
        /// <param name="courTableId"></param>
        /// <returns></returns>
        DataSet getByCourTableIdAboutMonitor(string courTableId);

        /// <summary>
        /// 根据班级ID取得教师登记的对象集
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        DataSet getByClassIdAboutTeacher(string classId);

        /// <summary>
        /// 根据班级ID取得班长登记的对象集
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        DataSet getByClassIdAboutMonitor(string classId);

        /// <summary>
        /// 根据学生ID取得教师登记的对象集
        /// </summary>
        /// <param name="studId"></param>
        /// <returns></returns>
        DataSet getByStudIdAboutTeacher(string studId);

        /// <summary>
        /// 根据学生ID取得班长登记的对象集
        /// </summary>
        /// <param name="studId"></param>
        /// <returns></returns>
        DataSet getByStudIdAboutMonitor(string studId);

        /// <summary>
        /// 根据学生ID,周次取得教师登记的对象集
        /// </summary>
        /// <param name="studId"></param>
        /// <returns></returns>
        DataSet getByParasAboutTeacher(string studId, string week);

        /// <summary>
        /// 根据学生ID,周次取得班长登记的对象集
        /// </summary>
        /// <param name="studId"></param>
        /// <returns></returns>
        DataSet getByParasAboutMonitor(string studId,string week);

        /// <summary>
        /// 取得每周的教师登记考勤的对象集
        /// </summary>
        /// <returns></returns>
        DataSet getAboutTeacher();

        /// <summary>
        /// 取得指定周的教师登记考勤的对象集
        /// </summary>
        /// <param name="week"></param>
        /// <returns></returns>
        DataSet getAboutTeacher(string week);

        /// <summary>
        /// 取得每周的班长登记考勤的对象集
        /// </summary>
        /// <returns></returns>
        DataSet getAboutMonitor();

        /// <summary>
        /// 取得指定周的班长登记考勤的对象集
        /// </summary>
        /// <param name="week"></param>
        /// <returns></returns>
        DataSet getAboutMonitor(string week);

        /// <summary>
        /// 取得指定教师登记考勤的对象集
        /// </summary>
        /// <param name="recordId"></param>
        /// <returns></returns>
        DataSet getByRecordId(string recordId);
    }
}
