using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL.IDAL
{
    public interface ICourseDAL
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
        /// 根据班级ID取得对象
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        DataSet getByClassId(string classId);

        /// <summary>
        /// 分页取得数据
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        //DataSet getPaged(string from ,string to);

    }
}
