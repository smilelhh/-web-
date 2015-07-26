using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using Utility;
using System.Data;

namespace Web.monitorManPages
{
    public partial class unCheckinByMonitor : System.Web.UI.Page
    {
        private static string courTableID = null;

        private static DataTable dt = null;

        private static List<Attendance> attenList = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        public void bind()
        {
            courTableID = Request.QueryString["courTableID"];

            User user = Session["User"] as User;

            StudentBLL studBLL = new StudentBLL();
            CourseTableBLL ctBLL = new CourseTableBLL();
            CourseTable ct = ctBLL.get(courTableID);

            ClassBLL classBll = new ClassBLL();
            Class cla = classBll.get(ct.ClassID);
            className.Text = cla.Name;

            dt = studBLL.getByClassId(ct.ClassID).Tables[0];

            if (Session["attenList"] != null)
            {
                attenList = Session["attenList"] as List<Attendance>;
            }
            else
            {
                attenList = new List<Attendance>();
                foreach (DataRow dr in dt.Rows)
                {
                    Attendance attend = new Attendance();
                    attend.Status = "正常";
                    attend.Remark = "";
                    attend.Recorder = "班长";
                    attend.RecorderID = studBLL.getByUserId(user.Id).Id;
                    attend.StudID = dr["ID"].ToString();
                    attend.CourTableID = courTableID;

                    attenList.Add(attend);
                }
            }


            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.resort(PageUtil.getPaged(dt, from, to));
            GridView1.DataBind();

            initStatusAndRemark();
        }

        protected void submitCheck_Click(object sender, EventArgs e)
        {
            saveCurrentData();

            Session.Add("attenList", attenList);

            Response.Redirect("checkByMonitor.aspx");
        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            saveCurrentData();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            goToNextPage();
        }

        private void goToNextPage()
        {
            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.resort(PageUtil.getPaged(dt, from, to));
            GridView1.DataBind();

            initStatusAndRemark();
        }

        private void saveCurrentData()
        {
            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            for (int i = 0, j = from - 1; i < AspNetPager1.PageSize && j < to; i++, j++)
            {
                Attendance attend = attenList[j];

                attend.Status = ((DropDownList)GridView1.Rows[i].Cells[4].FindControl("classState")).SelectedValue;
                attend.Remark = ((TextBox)GridView1.Rows[i].Cells[5].FindControl("remak")).Text;

            }
        }

        private void initStatusAndRemark()
        {
            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            for (int i = 0, j = from - 1; i < AspNetPager1.PageSize && j < to; i++, j++)
            {
                Attendance attend = attenList[j];

                PageUtil.bindDropDownList((DropDownList)GridView1.Rows[i].Cells[4].FindControl("classState"), attend.Status);
                ((TextBox)GridView1.Rows[i].Cells[5].FindControl("remak")).Text = attend.Remark;
            }
        }




    }
}