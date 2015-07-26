using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Utility;

namespace Web.MaintainStaffManPages.monitorAttendance
{
    public partial class attendanceStatistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClassBLL classBLL = new ClassBLL();
                //绑定页面查询条件的数据
                DropDownList_class.DataSource = classBLL.getAll();
                DropDownList_class.DataTextField = "name";
                DropDownList_class.DataBind();
                DropDownList_class.Items.Insert(0, "全院");
                bind();
            }
        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        private void bind()
        {
            string filter = "1=1 ";
            filter += DropDownList_class.SelectedValue.Equals("全院") ? "" : " and className='" + DropDownList_class.SelectedValue + "'";

            Label_className.Text = DropDownList_class.SelectedValue;

            CommonBLL commBLL = new CommonBLL();

            DataTable dt = PageUtil.getProcessedDataTable(commBLL.getStudentAttendStatistics(false), filter);

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

        protected void Button_search_Click(object sender, EventArgs e)
        {
            bind();
        }


    }
}