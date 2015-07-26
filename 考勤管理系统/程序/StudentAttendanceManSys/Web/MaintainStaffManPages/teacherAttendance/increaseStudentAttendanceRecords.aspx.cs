using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Utility;
using Model;

namespace Web.MaintainStaffManPages.teacherAttendance
{
    public partial class increaseStudentAttendanceRecords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CourseTableBLL ctBLL = new CourseTableBLL();
                ClassBLL classBLL = new ClassBLL();
                CourseBLL courBLL = new CourseBLL();
                TeacherBLL teachBLL = new TeacherBLL();

                DropDownList_class.DataSource = classBLL.getAll();
                DropDownList_class.DataTextField = "name";
                DropDownList_class.DataValueField = "ID";
                DropDownList_class.DataBind();


                DropDownList_course.DataSource = courBLL.getByClassId(DropDownList_class.SelectedValue);
                DropDownList_course.DataTextField = "name";
                DropDownList_course.DataValueField = "ID";
                DropDownList_course.DataBind();

                string filterTeacher = "classID='" + DropDownList_class.SelectedValue + "' and courId='" + DropDownList_course.SelectedValue + "'";
                DataTable tempDt = PageUtil.getProcessedDataTable(ctBLL.getAll().Tables[0], filterTeacher, null, false);

                DataView dv = tempDt.DefaultView;
                tempDt = dv.ToTable(true, "teachID");
                foreach (DataRow dr in tempDt.Rows)
                {
                    Teacher teacher = teachBLL.get(dr["teachID"].ToString());
                    DropDownList_teacher.Items.Add(new ListItem(teacher.Name, teacher.Id));
                }

                bind();
            }
        }

        /// <summary>
        /// 页面数据绑定
        /// </summary>
        private void bind()
        {
            CourseTableBLL ctBLL = new CourseTableBLL();
            StudentBLL stuBLL = new StudentBLL();
            //绑定页面查询条件的数据

            DropDownList_student.Items.Clear();
            DropDownList_student.DataSource = stuBLL.getByClassId(DropDownList_class.SelectedValue);
            DropDownList_student.DataTextField = "name";
            DropDownList_student.DataValueField = "ID";
            DropDownList_student.DataBind();

            DropDownList_week.Items.Clear();

            string filterWeek = "classID='" + DropDownList_class.SelectedValue + "' and courId='" + DropDownList_course.SelectedValue + "'";
            filterWeek += " and teachID='" + DropDownList_teacher.SelectedValue + "'";
            DataTable tempDt = PageUtil.getProcessedDataTable(ctBLL.getAll().Tables[0], filterWeek, null, false);
            int week_from = tempDt.Rows.Count == 0 ? 0 : tempDt.Select().Min(r => Convert.ToInt32(r["week"].ToString()));
            int week_to = tempDt.Rows.Count == 0 ? 0 : tempDt.Select().Max(r => Convert.ToInt32(r["week"].ToString()));

            for (int i = week_from; i <= week_to; i++)
            {
                DropDownList_week.Items.Add(i.ToString());
            }


            string preValue = DropDownList_weekDay.SelectedValue;
            DropDownList_weekDay.Items.Clear();

            string filterWeekDay = "week='" + DropDownList_week.SelectedValue + "'";
            tempDt = PageUtil.getProcessedDataTable(tempDt, filterWeekDay, "weekDay", false);

            foreach (DataRow dr in tempDt.Rows)
            {
                DropDownList_weekDay.Items.Add(dr["weekDay"].ToString());
            }
            PageUtil.bindDropDownList(DropDownList_weekDay, preValue);


            DropDownList_courseTime.Items.Clear();

            string filterCourTime = "weekDay='" + DropDownList_weekDay.SelectedValue + "'";
            tempDt = PageUtil.getProcessedDataTable(tempDt, filterCourTime, "courseTime", false);

            foreach (DataRow dr in tempDt.Rows)
            {
                DropDownList_courseTime.Items.Add(dr["courseTime"].ToString());
            }


            string filterPlace = "courseTime='" + DropDownList_courseTime.SelectedValue + "'";
            tempDt = PageUtil.getProcessedDataTable(tempDt, filterPlace, null, false);
            Label_place.Text = tempDt.Rows.Count == 0 ? "" : tempDt.Rows[0]["place"].ToString();

            Label_courTableId.Text = tempDt.Rows.Count == 0 ? "" : tempDt.Rows[0]["ID"].ToString();

        }

        protected void DropDownList_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseTableBLL ctBLL = new CourseTableBLL();
            CourseBLL courBLL = new CourseBLL();
            TeacherBLL teachBLL = new TeacherBLL();

            DropDownList_course.Items.Clear();

            DropDownList_course.DataSource = courBLL.getByClassId(DropDownList_class.SelectedValue);
            DropDownList_course.DataTextField = "name";
            DropDownList_course.DataValueField = "ID";
            DropDownList_course.DataBind();

            DropDownList_teacher.Items.Clear();

            string filterTeacher = "classID='" + DropDownList_class.SelectedValue + "' and courId='" + DropDownList_course.SelectedValue + "'";
            DataTable tempDt = PageUtil.getProcessedDataTable(ctBLL.getAll().Tables[0], filterTeacher, null, false);
            DataView dv = tempDt.DefaultView;
            tempDt = dv.ToTable(true, "teachID");
            foreach (DataRow dr in tempDt.Rows)
            {
                Teacher teacher = teachBLL.get(dr["teachID"].ToString());
                DropDownList_teacher.Items.Add(new ListItem(teacher.Name, teacher.Id));
            }

            bind();
        }

        protected void DropDownList_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseTableBLL ctBLL = new CourseTableBLL();
            TeacherBLL teachBLL = new TeacherBLL();

            DropDownList_teacher.Items.Clear();

            string filterTeacher = "classID='" + DropDownList_class.SelectedValue + "' and courId='" + DropDownList_course.SelectedValue + "'";
            DataTable tempDt = PageUtil.getProcessedDataTable(ctBLL.getAll().Tables[0], filterTeacher, null, false);
            DataView dv = tempDt.DefaultView;
            tempDt = dv.ToTable(true, "teachID");

            foreach (DataRow dr in tempDt.Rows)
            {
                Teacher teacher = teachBLL.get(dr["teachID"].ToString());
                DropDownList_teacher.Items.Add(new ListItem(teacher.Name, teacher.Id));
            }

            bind();
        }

        protected void DropDownList_teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind();
        }

        protected void DropDownList_weekDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind();
        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {
            AttendanceBLL attendBLL = new AttendanceBLL();

            Attendance attend = new Attendance();

            attend.Status = DropDownList_status.SelectedValue;
            attend.Remark = "";
            attend.Recorder = "教师";
            attend.RecorderID = DropDownList_teacher.SelectedValue;
            attend.StudID = DropDownList_student.SelectedValue;
            attend.CourTableID = Label_courTableId.Text;

            attendBLL.save(attend);

            Response.Write("<script>alert('添加成功！');location.href='increaseStudentAttendanceRecords.aspx';</script>");
        }
    }
}