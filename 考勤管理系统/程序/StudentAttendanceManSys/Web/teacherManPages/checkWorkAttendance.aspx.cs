using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;
using Utility;
using System.Data;


namespace Web.teacherManPages
{
    public partial class checkWorkAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            bind();
        }

        private void bind()
        {
            User user = (User)Session["user"];

            TeacherBLL teachBll = new TeacherBLL();
            Teacher teacher = teachBll.getByUserId(user.Id);
            CommonBLL commonBll = new CommonBLL();
            // 根据教师ID得到课程信息
            string filter = "1=1";
            filter += weekId.SelectedIndex == 0 ? "" : " and week='" + weekId.SelectedValue + "'";
            DataTable dt = PageUtil.getProcessedDataTable(commonBll.getWorkAttendanceByTeachID(teacher.Id), filter);

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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Remove("attenList");

            LinkButton button = (LinkButton)sender;
            if (button.Text.Equals("未登记"))
                Response.Redirect("unCheckin.aspx?courTableID=" + button.CommandArgument);
        }
    }
}