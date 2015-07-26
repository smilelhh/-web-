using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 课程
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 课程名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 学分
        /// </summary>
        public string Credit { get; set; }

        /// <summary>
        /// 课时
        /// </summary>
        public string SchoolHour { get; set; }
    }
}
