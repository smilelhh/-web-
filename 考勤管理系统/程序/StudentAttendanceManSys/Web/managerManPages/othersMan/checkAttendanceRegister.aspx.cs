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

namespace Web.managerManPages.othersMan
{
    public partial class checkAttendanceRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        /// <summary>
        /// 页面数据绑定
        /// </summary>
        private void bind()
        {
            CommonBLL commBLL = new CommonBLL();

            string filter = "1=1 ";
            filter += DropDownList_week.SelectedValue.Equals("全部周次") ? "" : " and week='" + DropDownList_week.SelectedValue + "'"; ;
            DataTable dt = PageUtil.getProcessedDataTable(commBLL.getComparedAttendance(), filter);

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

        protected void search_Click(object sender, EventArgs e)
        {
            bind();
        }

        //以下有两种方法从GridView导出excel

        //方法一
        //protected void ImageButton_excel_Click(object sender, ImageClickEventArgs e)
        //{
        //    ExcelUtil.WriteToExcel(GridView1);
        //}


        //方法二
        protected void ImageButton_excel_Click(object sender, ImageClickEventArgs e)
        {
            ExcelOut(this.GridView1);
        }
        public void ExcelOut(GridView gv)
        {
            if (gv.Rows.Count > 0)
            {
                Response.Clear();
                Response.ClearContent();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + DateTime.Now.ToString("_yyyyMMdd_HHmmss") + ".xls");
                Response.ContentEncoding = System.Text.Encoding.UTF8;
                Response.ContentType = "application/ms-excel";
                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                gv.RenderControl(htw);
                Response.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
            else
            {
                Response.Write("没有数据");
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //base.VerifyRenderingInServerForm(control);
        }

    }
}