using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL.IDAL
{
    public interface ICourseTableDAL
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
        /// 取得所有对象
        /// </summary>
        DataSet getAll();

        /// <summary>
        /// 根据ID取得对象
        /// </summary>
        /// <param name="id"></param>
        object get(string id);

        /// <summary>
        /// 根据教师ID取得对象集
        /// </summary>
        /// <param name="teachId"></param>
        /// <returns></returns>
        DataSet getByTeacherId(string teachId);

        /// <summary>
        /// 通过学期，周次，星期，班级ID取得对象集
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="week"></param>
        /// <param name="weekDay"></param>
        /// <param name="classID"></param>
        /// <returns></returns>
        DataSet getByParas(string semester, string week, string weekDay, string classID);

        /// <summary>
        /// 通过学期，周次，教师ID取得对象集
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="week"></param>
        /// <param name="teacherID"></param>
        /// <returns></returns>
        DataSet getByParas(string semester, string week, string teacherID);

        /// <summary>
        /// 通过学期，教师ID取得对象集
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="teacherID"></param>
        /// <returns></returns>
        DataSet getByParas(string semester, string teacherID);

        /// <summary>
        /// 通过学期，教师ID,班级ID和课程ID取得对象集
        /// </summary>
        /// <param name="semester"></param>
        /// <param name="teacherID"></param>
        /// <param name="classID"></param>
        /// <param name="courID"></param>
        /// <returns></returns>
        DataSet getByTCC(string semester, string teacherID, string classID, string courID);
    }
}
