using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.IDAL;
using DAL.DALFactory;
using Model;

namespace BLL
{
    public class CourseBLL
    {
        private ICourseDAL dal = null;

        public CourseBLL()
        {
            dal = DALFactory.createCourseDAL();
        }

        /// <summary>
        /// 保存课程信息
        /// </summary>
        /// <param name="course"></param>
        public void save(Course course)
        {
            dal.save(course);
        }

        /// <summary>
        /// 更新课程信息
        /// </summary>
        /// <param name="course"></param>
        public void update(Course course)
        {
            dal.update(course);
        }

        /// <summary>
        /// 删除课程信息
        /// </summary>
        /// <param name="course"></param>
        public void delete(Course course)
        {
            dal.delete(course);
        }

        /// <summary>
        /// 得到所有的课程信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return dal.getAll();
        }

        /// <summary>
        /// 根据ID得到课程信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Course get(string id)
        {
            return (Course)dal.get(id);
        }

        /// <summary>
        /// 根据班级ID得到课程信息
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public DataSet getByClassId(string classId)
        {
            return dal.getByClassId(classId);
        }

        /// <summary>
        /// 分页取得数据
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        //public DataSet getPaged(string from,string to)
        //{
        //    return dal.getPaged(from,to);
        //}
    }
}
