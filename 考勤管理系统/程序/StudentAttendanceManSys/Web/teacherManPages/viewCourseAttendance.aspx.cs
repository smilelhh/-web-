using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using DAL;
using Utility;
using System.Data;

namespace Web.teacherManPages
{
    public partial class viewCourseAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }
        public void bind()
        {
            string teachId = Request.QueryString["teachID"];
            string classId = Request.QueryString["classID"];
            string courseId = Request.QueryString["courId"];

           // ClassBLL classBll = new ClassBLL();
            CourseBLL courseBll = new CourseBLL();

            CommonBLL commonBll = new CommonBLL();

            //courseName.Text = classBll.get(classId).Name;
            courseName.Text = courseBll.get(courseId).Name;

            DataTable dt = commonBll.getCourseDetailAttendaceRate(teachId, classId, courseId, true);

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
    }
}