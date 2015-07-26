using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    /// <summary>
    /// 考勤
    /// </summary>
    public class Attendance
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Id { get; set; }  

        /// <summary>
        /// 考勤状态
        /// </summary>
        public string Status { get; set; } 

        /// <summary>
        /// 考勤备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 考勤登记人类型
        /// </summary>
        public string Recorder { get; set; } 
        /// <summary>
        /// 考勤登记人编号
        /// </summary>
        public string RecorderID { get; set; } 

        /// <summary>
        /// 学生编号
        /// </summary>
        public string StudID { get; set; }

        /// <summary>
        /// 课程表编号
        /// </summary>
        public string CourTableID { get; set; }
    }
}
