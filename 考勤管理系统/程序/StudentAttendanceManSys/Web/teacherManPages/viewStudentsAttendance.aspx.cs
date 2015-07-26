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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Utility;
using System.IO;

namespace Web.teacherManPages
{
    public partial class viewStudentsAttendance : System.Web.UI.Page
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
            string classID = Request.QueryString["classID"].ToString();

            string courID = Request.QueryString["courId"].ToString();

            //courseName.Text = new CourseBLL().get(courID).Name;//courseName改成className
            className.Text = new ClassBLL().get(classID).Name;

            User user = (User)Session["user"];
            TeacherBLL teacherBll = new TeacherBLL();
            Teacher teacher = teacherBll.getByUserId(user.Id);
            CommonBLL commBLL = new CommonBLL();

            DataTable dt = commBLL.getClassStudentAttendStatistics(classID,teacher.Id, true);

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

        protected void ImageButton_excel_Click(object sender, ImageClickEventArgs e)
        {
            ExcelUtil.WriteToExcel(GridView1);
        }
    }
}