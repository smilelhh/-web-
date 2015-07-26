using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility;
using BLL;
using System.Data;

namespace Web.managerManPages.monitorAttendance
{
    public partial class punishStudentShow : System.Web.UI.Page
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
            int punishType = Convert.ToInt32(Request.QueryString["punishType"]);

            string filter = "";

            int min = 0;
            int max = 0;
            switch (punishType)
            {
                case 1:
                    min = 1;
                    max = 8;
                    filter += "truancy>=" + min + " and truancy<=" + max;
                    break;
                case 2:
                    filter += "truancy=9";
                    break;
                case 3:
                    min = 10;
                    max = 19;
                    filter += "truancy>=" + min + " and truancy<=" + max;
                    break;
                case 4:
                    min = 20;
                    max = 29;
                    filter += "truancy>=" + min + " and truancy<=" + max;
                    break;
                case 5:
                    min = 30;
                    max = 39;
                    filter += "truancy>=" + min + " and truancy<=" + max;
                    break;
                case 6:
                    min = 40;
                    max = 49;
                    filter += "truancy>=" + min + " and truancy<=" + max;
                    break;
                case 7:
                    filter += "truancy>=50";
                    break;
                case 8:
                    filter += "truancy>=1";
                    break;
            }

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
    }
}