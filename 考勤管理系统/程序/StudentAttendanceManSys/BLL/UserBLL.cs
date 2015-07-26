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
    public class UserBLL
    {
        private IUserDAL dal = null;

        public UserBLL()
        {
            dal = DALFactory.createUserDAL();
        }

        /// <summary>
        /// 保存系统用户信息
        /// </summary>
        /// <param name="user"></param>
        public void save(User user)
        {
            dal.save(user);
        }

        /// <summary>
        /// 更新系统用户信息
        /// </summary>
        /// <param name="user"></param>
        public void update(User user)
        {
            dal.update(user);
        }

        /// <summary>
        /// 删除系统用户信息
        /// </summary>
        /// <param name="user"></param>
        public void delete(User user)
        {
            dal.delete(user);
        }

        /// <summary>
        /// 得到所有的系统用户信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return dal.getAll();
        }

        /// <summary>
        /// 根据ID得到系统用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User get(string id)
        {
            return (User)dal.get(id);
        }

        /// <summary>
        /// 根据用户名得到系统用户信息
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User getByUsername(string username)
        {
            return (User)dal.getByUsername(username);
        }
    }
}
