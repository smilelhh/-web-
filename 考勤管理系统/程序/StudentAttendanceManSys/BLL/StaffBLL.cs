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
    public class StaffBLL
    {
        private IStaffDAL dal = null;

        public StaffBLL()
        {
            dal = DALFactory.createStaffDAL();
        }

        /// <summary>
        /// 保存工作人员信息
        /// </summary>
        /// <param name="staff"></param>
        public void save(Staff staff)
        {
            dal.save(staff);
        }

        /// <summary>
        /// 更新工作人员信息
        /// </summary>
        /// <param name="staff"></param>
        public void update(Staff staff)
        {
            dal.update(staff);
        }

        /// <summary>
        /// 删除工作人员信息
        /// </summary>
        /// <param name="staff"></param>
        public void delete(Staff staff)
        {
            dal.delete(staff);
        }

        /// <summary>
        /// 得到所有的工作人员信息
        /// </summary>
        /// <returns></returns>
        public DataSet getAll()
        {
            return dal.getAll();
        }

        /// <summary>
        /// 根据ID得到工作人员信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Staff get(string id)
        {
            return (Staff)dal.get(id);
        }

        /// <summary>
        /// 根据用户ID得到工作人员信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Staff getByUserId(string userId)
        {
            return (Staff)dal.getByUserId(userId);
        }
    }
}
