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
    public partial class manageAttendanceRecord : System.Web.UI.Page
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
            string studID = Request.QueryString["studID"].ToString();

            CommonBLL commBLL = new CommonBLL();

            DataTable dt = commBLL.getDetailStudentAttendStatistics(studID, true);

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

        protected void ImageButton_edit_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;

            string id = linkButton.CommandArgument;

            Response.Redirect("modifyStudentAttendanceRecord.aspx?id=" + id);
        }

        protected void ImageButton_delete_Click(object sender, EventArgs e)
        {
            LinkButton linkButton = sender as LinkButton;

            string id = linkButton.CommandArgument;

            Attendance attend = new Attendance();
            attend.Id = id;

            AttendanceBLL attendBLL = new AttendanceBLL();
            attendBLL.delete(attend);

            Response.Write("<script>alert('删除成功！');location.href='attendanceStatistics.aspx';</script>");
        }


    }
}