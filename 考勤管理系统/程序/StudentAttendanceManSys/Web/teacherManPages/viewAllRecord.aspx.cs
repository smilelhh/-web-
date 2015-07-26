using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;
using System.Data;
using Utility;

namespace Web.teacherManPages
{
    public partial class viewAllRecord : System.Web.UI.Page
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
            User user = (User)Session["user"];
            TeacherBLL teacherBll = new TeacherBLL();
            Teacher teacher = teacherBll.getByUserId(user.Id);
            CommonBLL commonBll = new CommonBLL();

            DataTable dt = commonBll.getAllRecordByRecordId(teacher.Id);

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