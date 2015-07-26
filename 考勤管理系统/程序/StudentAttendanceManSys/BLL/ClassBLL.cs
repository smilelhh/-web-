using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.IDAL;
using DAL.DALFactory;
using Model;
using System.Data;

namespace BLL
{
    public class ClassBLL
    {
        private IClassDAL dal = null;

        public ClassBLL()
        {
            dal = DALFactory.createClassDAL();
        }

        /// <summary>
        /// 保存班级信息
        /// </summary>
        /// <param name="clazz"></param>
        public void save(Class clazz)
        {
            dal.save(clazz);
        }

        /// <summary>
        /// 更新班级信息
        /// </summary>
        /// <param name="clazz"></param>
        public void update(Class clazz)
        {
            dal.update(clazz);
        }

        /// <summary>
        /// 删除班级信息
        /// </summary>
        /// <param name="clazz"></param>
        public void delete(Class clazz)
        {
            dal.delete(clazz);
        }

        /// <summary>
        /// 得到所有班级的信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return dal.getAll();
        }

        /// <summary>
        /// 根据ID得到班级信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Class get(string id)
        {
            return (Class)dal.get(id);
        }

        /// <summary>
        /// 根据教师ID得到班级信息
        /// </summary>
        /// <param name="teachId"></param>
        /// <returns></returns>
        public DataSet getByTeacherId(string teachId)
        {
            return dal.getByTeacherId(teachId);
        }

        /// <summary>
        /// 分页取得数据
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        //public DataSet getPaged(string from, string to)
        //{
        //    return dal.getPaged(from, to);
        //}

        
    }
}
