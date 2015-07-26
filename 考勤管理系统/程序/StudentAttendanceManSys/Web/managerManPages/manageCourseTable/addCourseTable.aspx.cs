using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using Utility;

namespace Web.managerManPages.manageCourses
{
    public partial class addCourseTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bind();
        }

        protected void ImageButton_submit_Click(object sender, ImageClickEventArgs e)
        {
            if (check())
            {
                string semester = DropDownList_semester_from.SelectedValue + "-" + DropDownList_semester_to.SelectedValue + "学年" + DropDownList_semester_end.SelectedValue;
                int week_from = Convert.ToInt32(DropDownList_week_from.SelectedValue);
                int week_to = Convert.ToInt32(DropDownList_week_to.SelectedValue);
                string weekDay = DropDownList_weekDay.SelectedValue;
                string place = TextBox_place.Text;
                string courseTime = DropDownList_courseTime.SelectedValue + "节" ;
                string teachId = DropDownList_teacher.SelectedValue;
                string classId = DropDownList_class.SelectedValue;
                string courId = DropDownList_course.SelectedValue;

                CourseTableBLL courTableBLL = new CourseTableBLL();

                CourseTable courTable = new CourseTable();
                courTable.Semester = semester;
                courTable.WeekDay = weekDay;
                courTable.Place = place;
                courTable.CourseTime = courseTime;
                courTable.TeachID = teachId;
                courTable.ClassID = classId;
                courTable.CourId = courId;


                for (int i = week_from; i <= week_to; i++)
                {
                    courTable.Week = i.ToString();
                    courTableBLL.save(courTable);
                }

                Response.Write("<script>alert('添加成功！');location.href='addCourseTable.aspx';</script>");

            }
        }

        protected void ImageButton_back_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("showCourseTable.aspx");
        }

        /// <summary>
        /// 检测页面输入是否正确
        /// </summary>
        /// <returns></returns>
        private Boolean check()
        {
            try
            {
                Boolean flag = true;

                string place = TextBox_place.Text.Trim();

                //检测上课地点输入值是否输入正确
                if (string.IsNullOrEmpty(place))
                {
                    checkPlace.ErrorMessage = "上课地点不能为空！";
                    checkPlace.IsValid = false;
                    flag = false;
                }

                return flag;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        private void bind()
        {
            CourseBLL courBLL = new CourseBLL();
            TeacherBLL teacherBLL = new TeacherBLL();
            ClassBLL classBLL = new ClassBLL();

            //绑定 "课程名称" 数据源
            DropDownList_course.DataSource = courBLL.getAll();
            DropDownList_course.DataTextField = "name";
            DropDownList_course.DataValueField = "ID";
            DropDownList_course.DataBind();

            //绑定 "任课老师" 数据源
            DropDownList_teacher.DataSource = teacherBLL.getTeachers();
            DropDownList_teacher.DataTextField = "name";
            DropDownList_teacher.DataValueField = "ID";
            DropDownList_teacher.DataBind();

            //绑定 "班级名称" 数据源
            DropDownList_class.DataSource = classBLL.getAll();
            DropDownList_class.DataTextField = "name";
            DropDownList_class.DataValueField = "ID";
            DropDownList_class.DataBind();

        }

        protected void DropDownList_semester_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            int semester_from = Convert.ToInt32(DropDownList_semester_from.SelectedValue);

            DropDownList_semester_to.Items.Clear();

            for (int i = semester_from + 1; i <= 2020; i++)
            {
                DropDownList_semester_to.Items.Add(i.ToString());
            }
        }

        protected void DropDownList_semester_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            int semester_to = Convert.ToInt32(DropDownList_semester_to.SelectedValue);

            DropDownList_semester_from.Items.Clear();

            for (int i = 2002; i < semester_to; i++)
            {
                DropDownList_semester_from.Items.Add(i.ToString());
            }
            DropDownList_semester_from.SelectedIndex = DropDownList_semester_from.Items.Count - 1;
        }

        protected void DropDownList_week_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            string week_to = DropDownList_week_to.SelectedValue;

            int week_from = Convert.ToInt32(DropDownList_week_from.SelectedValue);

            DropDownList_week_to.Items.Clear();

            for (int i = week_from; i <= 20; i++)
            {
                DropDownList_week_to.Items.Add(i.ToString());
            }

            PageUtil.bindDropDownList(DropDownList_week_to, week_to);
        }

        protected void DropDownList_week_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            string week_from = DropDownList_week_from.SelectedValue;

            int week_to = Convert.ToInt32(DropDownList_week_to.SelectedValue);

            DropDownList_week_from.Items.Clear();

            for (int i = 1; i < week_to; i++)
            {
                DropDownList_week_from.Items.Add(i.ToString());
            }

            PageUtil.bindDropDownList(DropDownList_week_from, week_from);
        }



    }
}