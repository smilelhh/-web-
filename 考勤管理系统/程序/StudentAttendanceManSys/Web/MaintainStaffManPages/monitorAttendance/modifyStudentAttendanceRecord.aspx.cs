using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace Web.MaintainStaffManPages.monitorAttendance
{
    public partial class modifyStudentAttendanceRecord : System.Web.UI.Page
    {
        private static Attendance attend = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        private void bind()
        {
            string id = Request.QueryString["id"].ToString();

            AttendanceBLL attendBLL = new AttendanceBLL();
            attend = attendBLL.get(id);

            CourseTableBLL ctBLL = new CourseTableBLL();
            CourseTable ct = ctBLL.get(attend.CourTableID);

            ClassBLL classBLL = new ClassBLL();
            TeacherBLL teacherBLL = new TeacherBLL();
            CourseBLL courseBLL = new CourseBLL();
            StudentBLL stuBLL = new StudentBLL();

            #region 绑定页面数据
            Label_class.Text = classBLL.get(ct.ClassID).Name;
            Label_course.Text = courseBLL.get(ct.CourId).Name;
            Label_teacher.Text = teacherBLL.get(ct.TeachID).Name;
            Label_student.Text = stuBLL.get(attend.StudID).Name;
            Label_oldStatus.Text = attend.Status;
            Label_week.Text = ct.Week;
            Label_weekDay.Text = ct.WeekDay;
            Label_courseTime.Text = ct.CourseTime;
            Label_place.Text = ct.Place;

            #endregion
        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {
            AttendanceBLL attendBLL = new AttendanceBLL();
            attend.Status = DropDownList_newStatus.SelectedValue;

            attendBLL.update(attend);

            Response.Write("<script>alert('修改成功！');location.href='attendanceStatistics.aspx';</script>");
        }
    }
}