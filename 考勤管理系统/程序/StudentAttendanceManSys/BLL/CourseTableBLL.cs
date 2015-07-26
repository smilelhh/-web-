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
    public class CourseTableBLL
    {
        private ICourseTableDAL dal = null;

        public CourseTableBLL()
        {
            dal = DALFactory.createCourseTableDAL();
        }

        /// <summary>
        /// 保存课程表信息
        /// </summary>
        /// <param name="courTable"></param>
        public void save(CourseTable courTable)
        {
            dal.save(courTable);
        }

        /// <summary>
        /// 更新课程表信息
        /// </summary>
        /// <param name="courTable"></param>
        public void update(CourseTable courTable)
        {
            dal.update(courTable);
        }

        /// <summary>
        /// 删除课程表信息
        /// </summary>
        /// <param name="courTable"></param>
        public void delete(CourseTable courTable)
        {
            dal.delete(courTable);
        }

        /// <summary>
        /// 得到所有的课程表信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return dal.getAll();
        }

        /// <summary>
        /// 根据ID得到课程表信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CourseTable get(string id)
        {
            return (CourseTable)dal.get(id);
        }

        /// <summary>
        /// 根据教师ID得到课程表信息
        /// </summary>
        /// <param name="teachId"></param>
        /// <returns></returns>
        public DataSet getByTeacherId(string teachId)
        {
            return dal.getByTeacherId(teachId);
        }

        /// <summary>
        /// 通过学期，周次，星期，班级ID取得课程表信息
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="week"></param>
        /// <param name="weekDay"></param>
        /// <param name="classID"></param>
        /// <returns></returns>
        public DataSet getByParas(string semester, string week, string weekDay, string classID)
        {
            return dal.getByParas(semester, week, weekDay, classID);
        }

        /// <summary>
        /// 通过学期，周次，教师ID取得课程表信息
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="week"></param>
        /// <param name="teachID"></param>
        /// <returns></returns>
        public DataSet getByParas(string semester, string week, string teachID)
        {
            return dal.getByParas(semester, week, teachID);
        }

        /// <summary>
        /// 通过学期，教师ID取得课程表信息
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="teachID"></param>
        /// <returns></returns>
        public DataSet getByParas(string semester, string teachID)
        {
            return dal.getByParas(semester, teachID);
        }

        public DataSet getByTCC(string semester, string teacherID, string classID, string courID)
        {
            return dal.getByTCC(semester, teacherID, classID, courID);
        }
    }
}
