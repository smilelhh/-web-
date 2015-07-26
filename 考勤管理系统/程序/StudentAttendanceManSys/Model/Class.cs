using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 班级
    /// </summary>
    public class Class
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 所属专业/系
        /// </summary>
        public string Depart { get; set; }

        /// <summary>
        /// 年级
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// 班级名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 班级人数
        /// </summary>
        public string StudCount { get; set; }

        /// <summary>
        /// 班长编号
        /// </summary>
        public string MonitorID { get; set; }

        /// <summary>
        /// 班主任编号
        /// </summary>
        public string TeacherID { get; set; }
    }
}
