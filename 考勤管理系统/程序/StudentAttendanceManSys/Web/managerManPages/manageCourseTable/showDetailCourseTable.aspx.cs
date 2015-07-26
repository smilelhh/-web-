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

namespace Web.managerManPages.manageCourses
{
    public partial class showDetailCourseTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void ImageButton_add_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("addCourseTable.aspx");
        }

        protected void ImageButton_edit_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;

            string[] arg = imageButton.CommandArgument.Split(',');
            string id = arg[0];
            string week = arg[1];

            Response.Redirect("editCourseTable.aspx?ID=" + id + "&week=" + week);
        }

        protected void ImageButton_delete_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;

            string id = imageButton.CommandArgument;

            AttendanceBLL attendBLL = new AttendanceBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();
            CourseTable ct = ctBLL.get(id);

            string filter = "courId='" + ct.CourId + "' and teachID='" + ct.TeachID + "' and classID='" + ct.ClassID;
            filter += "' and semester='" + ct.Semester + "' and weekDay='" + ct.WeekDay + "' and courseTime='" + ct.CourseTime + "'";

            DataTable dt = PageUtil.getProcessedDataTable(ctBLL.getAll().Tables[0], filter,null,false);

            foreach (DataRow dr in dt.Rows)
            {
                attendBLL.deleteByCourseTableId(dr["ID"].ToString());
                CourseTable tempCt = new CourseTable();
                tempCt.Id = dr["ID"].ToString();
                ctBLL.delete(tempCt);
            }

            Response.Write("<script>alert('删除成功！');location.href='showCourseTable.aspx';</script>");
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind();
        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        private void bind()
        {
            string id = Request.QueryString["ID"];

            CommonBLL commonBLL = new CommonBLL();

            DataTable dt = commonBLL.getDetailCourseTables(id);

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;

            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.getPaged(dt, from, to);
            GridView1.DataBind();
        }

    }
}