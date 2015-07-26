using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Utility;

namespace Web.managerManPages.othersMan
{
    public partial class manageCourseTable : System.Web.UI.Page
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

            string recorder = Request.QueryString["recorder"].ToString();

            CommonBLL commBLL = new CommonBLL();

            DataTable dt = null;
            if (recorder.Equals("1"))
                dt = commBLL.getDetailStudentAttendStatistics(studID, true);
            else
                dt = commBLL.getDetailStudentAttendStatistics(studID, false);

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

        protected void DropDownList_teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind();
        }
    }
}