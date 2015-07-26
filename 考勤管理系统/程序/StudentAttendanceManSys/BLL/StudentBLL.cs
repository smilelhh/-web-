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
    public class StudentBLL
    {
        private IStudentDAL dal = null;

        public StudentBLL()
        {
            dal = DALFactory.createStudentDAL();
        }

        /// <summary>
        /// 保存学生信息
        /// </summary>
        /// <param name="student"></param>
        public void save(Student student)
        {
            dal.save(student);
        }

        /// <summary>
        /// 更新学生信息
        /// </summary>
        /// <param name="student"></param>
        public void update(Student student)
        {
            dal.update(student);
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="student"></param>
        public void delete(Student student)
        {
            dal.delete(student);
        }

        /// <summary>
        /// 得到所有的学生信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return dal.getAll();
        }

        /// <summary>
        /// 根据ID得到学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student get(string id)
        {
            return (Student)dal.get(id);
        }

        /// <summary>
        /// 根据用户ID得到学生信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Student getByUserId(string userId)
        {
            return (Student)dal.getByUserId(userId);
        }

        /// <summary>
        /// 根据学号得到学生信息
        /// </summary>
        /// <param name="stuId"></param>
        /// <returns></returns>
        public Student getByStuId(string stuId)
        {
            return (Student)dal.getByStuId(stuId);
        }

        /// <summary>
        /// 根据班级ID取得学生信息
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        public DataSet getByClassId(string classId)
        {
            return dal.getByClassId(classId);
        }
    }
}
