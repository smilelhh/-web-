using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 课程表
    /// </summary>
    public class CourseTable
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 学期
        /// </summary>
        public string Semester { get; set; }

        /// <summary>
        /// 周次
        /// </summary>
        public string Week { get; set; }

        /// <summary>
        /// 星期
        /// </summary>
        public string WeekDay { get; set; }

        /// <summary>
        /// 上课地点
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// 上课时间
        /// </summary>
        public string CourseTime { get; set; }

        /// <summary>
        /// 教师编号
        /// </summary>
        public string TeachID { get; set; }

        /// <summary>
        /// 班级编号
        /// </summary>
        public string ClassID { get; set; }

        /// <summary>
        /// 课程ID
        /// </summary>
        public string CourId { get; set; }
    }
}
