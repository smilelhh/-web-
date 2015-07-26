using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
using DAL.IDAL;
using DAL.DALFactory;

namespace BLL
{
    public class TeacherBLL
    {
        private ITeacherDAL dal = null;

        public TeacherBLL()
        {
            dal = DALFactory.createTeacherDAL();
        }

        /// <summary>
        /// 保存教师信息
        /// </summary>
        /// <param name="teacher"></param>
        public void save(Teacher teacher)
        {
            dal.save(teacher);
        }

        /// <summary>
        /// 更新教师信息
        /// </summary>
        /// <param name="teacher"></param>
        public void update(Teacher teacher)
        {
            dal.update(teacher);
        }

        /// <summary>
        /// 删除教师信息
        /// </summary>
        /// <param name="teacher"></param>
        public void delete(Teacher teacher)
        {
            dal.delete(teacher);
        }

        /// <summary>
        /// 得到所有的教师信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return dal.getAll();
        }

        /// <summary>
        /// 得到所有的班主任信息
        /// </summary>
        /// <returns></returns>
        public DataSet getClassTeachers()
        {
            return dal.getClassTeachers();
        }

        /// <summary>
        /// 得到所有的授课教师信息
        /// </summary>
        /// <returns></returns>
        public DataSet getTeachers()
        {
            return dal.getTeachers();
        }

        /// <summary>
        /// 根据ID得到教师信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Teacher get(string id)
        {
            return (Teacher)dal.get(id);
        }

        /// <summary>
        /// 根据教师号得到教师信息
        /// </summary>
        /// <param name="teacherId"></param>
        /// <returns></returns>
        public Teacher getByTeacherId(string teacherId)
        {
            return (Teacher)dal.getByTeacherId(teacherId);
        }


        /// <summary>
        /// 根据用户ID得到教师信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Teacher getByUserId(string userId)
        {
            return (Teacher)dal.getByUserId(userId);
        }
    }
}
