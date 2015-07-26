using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Utility;

namespace Web.managerManPages.monitorAttendance
{
    public partial class averageWeeklyAttendance : System.Web.UI.Page
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

            CommonBLL commBLL = new CommonBLL();

            DataTable dt = commBLL.getWeekAverageAttendaceRate(weekId.SelectedValue, false);

            Label_attendRate.Text = dt.Rows.Count != 0 ? FormatUtil.doubleToPercent(CommonBLL.calculateAverageAttendRate(dt, "AverageAttendaceRate")) : "0";

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.getPaged(dt, from, to);
            GridView1.DataBind();


        }

        protected void search_Click(object sender, EventArgs e)
        {
            bind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind();
        }

        protected void ImageButton_excel_Click(object sender, ImageClickEventArgs e)
        {
            //CommonBLL commBLL = new CommonBLL();

            //GridView gridView = new GridView();
            //gridView.DataSource = commBLL.getWeekAverageAttendaceRate(weekId.SelectedValue, false);
            //gridView.DataBind();
            ExcelUtil.WriteToExcel(GridView1);//(gridView)
        }


    }
}