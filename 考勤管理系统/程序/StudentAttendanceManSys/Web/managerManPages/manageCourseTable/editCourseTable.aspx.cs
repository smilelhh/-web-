using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using Utility;
using Utility.Global;
using System.Data;

namespace Web.managerManPages.manageCourses
{
    public partial class editCourseTable : System.Web.UI.Page
    {

        private static CourseTable ct = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void ImageButton_submit_Click(object sender, ImageClickEventArgs e)
        {
            if (check())
            {
                AttendanceBLL attendBLL = new AttendanceBLL();
                CourseTableBLL ctBLL = new CourseTableBLL();
                string filter = "courId='" + ct.CourId + "' and teachID='" + ct.TeachID + "' and classID='" + ct.ClassID;
                filter += "' and semester='" + ct.Semester + "' and weekDay='" + ct.WeekDay + "' and courseTime='" + ct.CourseTime + "'";

                #region 先删除旧数据
                DataTable dt = PageUtil.getProcessedDataTable(ctBLL.getAll().Tables[0], filter,null, false);

                foreach (DataRow dr in dt.Rows)
                {
                    attendBLL.deleteByCourseTableId(dr["ID"].ToString());
                    CourseTable tempCt = new CourseTable();
                    tempCt.Id = dr["ID"].ToString();
                    ctBLL.delete(tempCt);
                }
                #endregion

                #region 后添加新数据
                string semester = DropDownList_semester_from.SelectedValue + "-" + DropDownList_semester_to.SelectedValue + "学年" + DropDownList_semester_end.SelectedValue;
                int week_from = Convert.ToInt32(DropDownList_week_from.SelectedValue);
                int week_to = Convert.ToInt32(DropDownList_week_to.SelectedValue);
                string weekDay = DropDownList_weekDay.SelectedValue;
                string place = TextBox_place.Text;
                string courseTime = DropDownList_courseTime.SelectedValue + "节";
                string teachId = ct.TeachID;
                string classId = ct.ClassID;
                string courId = ct.CourId;

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
                    ctBLL.save(courTable);
                }
                #endregion

                Response.Write("<script>alert('修改成功！');location.href='showCourseTable.aspx';</script>");

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
            string id = Request.QueryString["ID"].ToString();
            string week = Request.QueryString["week"].ToString();

            CourseBLL courBLL = new CourseBLL();
            TeacherBLL teacherBLL = new TeacherBLL();
            ClassBLL classBLL = new ClassBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();

            ct = ctBLL.get(id);

            #region 页面数据绑定
            Label_course.Text = courBLL.get(ct.CourId).Name;
            Label_teacher.Text = teacherBLL.get(ct.TeachID).Name;
            Label_class.Text = classBLL.get(ct.ClassID).Name;
            PageUtil.bindDropDownList(DropDownList_semester_from, ct.Semester.Substring(0, 4));
            PageUtil.bindDropDownList(DropDownList_semester_to, ct.Semester.Substring(5, 4));
            PageUtil.bindDropDownList(DropDownList_semester_end, ct.Semester.Substring(9, 3));
            PageUtil.bindDropDownList(DropDownList_week_from, week.Split('-')[0]);
            PageUtil.bindDropDownList(DropDownList_week_to, week.Split('-')[1]);
            PageUtil.bindDropDownList(DropDownList_weekDay, ct.WeekDay);
            TextBox_place.Text = ct.Place;
            PageUtil.bindDropDownList(DropDownList_courseTime, ct.CourseTime.Split('节')[0]);
            #endregion
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