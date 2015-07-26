using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Utility;

namespace Web.managerManPages.teacherAttendace
{
    public partial class advancedSearchAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClassBLL classBLL = new ClassBLL();
                CourseBLL courBLL = new CourseBLL();
                TeacherBLL teachBLL = new TeacherBLL();
                //绑定页面查询条件的数据
                DropDownList_class.DataSource = classBLL.getAll();
                DropDownList_class.DataTextField = "name";
                DropDownList_class.DataBind();
                DropDownList_class.Items.Insert(0, "全部班级");

                DropDownList_course.DataSource = courBLL.getAll();
                DropDownList_course.DataTextField = "name";
                DropDownList_course.DataBind();
                DropDownList_course.Items.Insert(0, "全部课程");

                DropDownList_teacher.DataSource = teachBLL.getTeachers();
                DropDownList_teacher.DataTextField = "name";
                DropDownList_teacher.DataBind();
                DropDownList_teacher.Items.Insert(0, "全部教师");

                bind();
            }
        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        private void bind()
        {
            string filter = "1=1 ";
            filter += DropDownList_class.SelectedValue.Equals("全部班级") ? "" : " and className='" + DropDownList_class.SelectedValue + "'";
            filter += DropDownList_course.SelectedValue.Equals("全部课程") ? "" : " and courseName='" + DropDownList_course.SelectedValue + "'";
            filter += DropDownList_teacher.SelectedValue.Equals("全部教师") ? "" : " and teacherName='" + DropDownList_teacher.SelectedValue + "'";
            filter += DropDownList_week.SelectedValue.Equals("周次") ? "" : " and week='" + DropDownList_week.SelectedValue + "'";
            filter += DropDownList_weekDay.SelectedValue.Equals("星期") ? "" : " and weekDay='" + DropDownList_weekDay.SelectedValue + "'";
            filter += DropDownList_courseTime.SelectedValue.Equals("上课时间") ? "" : " and courseTime='" + DropDownList_courseTime.SelectedValue + "'";


            string sort = "";
            switch (RadioButtonList1.SelectedIndex)
            {
                case 0:
                    if (RadioButtonList2.SelectedIndex == 0)
                        sort += "className asc ";
                    else
                        sort += "className desc ";
                    break;
                case 1:
                    if (RadioButtonList2.SelectedIndex == 0)
                        sort += "teacherName asc ";
                    else
                        sort += "teacherName desc ";
                    break;
                case 2:
                    if (RadioButtonList2.SelectedIndex == 0)
                        sort += "week asc ";
                    else
                        sort += "week desc ";
                    break;
                case 3:
                    if (RadioButtonList2.SelectedIndex == 0)
                        sort += "attendaceRate asc ";
                    else
                        sort += "attendaceRate desc ";
                    break;

            }

            CommonBLL commBLL = new CommonBLL();

            DataTable dt = PageUtil.getProcessedDataTable(commBLL.getAttendaceRate(true), filter, sort);

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.getPaged(dt, from, to);
            GridView1.DataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind();
        }

        protected void Button_search_Click(object sender, EventArgs e)
        {
            bind();
        }
    }
}