using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using System.Data;
using Utility;

namespace Web.classTeacherManPages
{
    public partial class viewDetailedAttendanceInformation : System.Web.UI.Page
    {
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
            string courTableID = Request.QueryString["courTableID"];

            CourseTableBLL ctBLL = new CourseTableBLL();
            TeacherBLL teacherBLL = new TeacherBLL();
            CourseBLL courBLL = new CourseBLL();
            ClassBLL classBLL = new ClassBLL();


            CourseTable ct = ctBLL.get(courTableID);
            Class clazz = classBLL.get(ct.ClassID);

            #region 页面数据绑定
            className.Text = clazz.Name;
            courseName.Text = courBLL.get(ct.CourId).Name;
            teacherName.Text = teacherBLL.get(ct.TeachID).Name;
            week.Text = "第" + ct.Week + "周";
            weekDay.Text = ct.WeekDay;
            classtTime.Text = ct.CourseTime;
            classAddress.Text = ct.Place;

            CommonBLL commBLL = new CommonBLL();

            DataTable dt = commBLL.getAbsentStudent(courTableID, true);

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.getPaged(dt, from, to);
            GridView1.DataBind();
            #endregion
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind();
        }
    }
}