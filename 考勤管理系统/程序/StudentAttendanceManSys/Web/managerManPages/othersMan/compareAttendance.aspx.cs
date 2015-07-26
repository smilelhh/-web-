using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using BLL;
using Utility;

namespace Web.managerManPages.othersMan
{
    public partial class compareAttendance : System.Web.UI.Page
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

            Label_className.Text = DropDownList_class.SelectedValue;

            CommonBLL commBLL = new CommonBLL();

            string filter = "1=1 ";
            filter += DropDownList_class.SelectedValue.Equals("全院") ? "" : " and className='" + DropDownList_class.SelectedValue + "'";

            DataTable dt = PageUtil.getProcessedDataTable(commBLL.getComparedAttendStatistics(), filter);

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.getPaged(dt, from, to);
            GridView1.DataBind();
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                TableCellCollection tcHeader = e.Row.Cells;
                tcHeader.Clear();

                TableHeaderCell cell = new TableHeaderCell();
                cell.Text = "序号";
                cell.RowSpan = 2;
                cell.BackColor = Color.FromArgb(184, 204, 228);
                cell.Width = 60;
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "姓名";
                cell.BackColor = Color.FromArgb(184, 204, 228);
                cell.RowSpan = 2;
                cell.Width = 90;
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "班级";
                cell.BackColor = Color.FromArgb(184, 204, 228);
                cell.RowSpan = 2;
                cell.Width = 120;
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "老师";
                cell.BackColor = Color.FromArgb(151, 72, 7);
                cell.ColumnSpan = 6;
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "班长</th></tr><tr>";
                cell.BackColor = Color.FromArgb(49, 132, 155);
                cell.ColumnSpan = 6;
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "旷课";
                cell.BackColor = Color.FromArgb(229, 224, 236);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "迟到";
                cell.BackColor = Color.FromArgb(229, 224, 236);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "早退";
                cell.BackColor = Color.FromArgb(229, 224, 236);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "事假";
                cell.BackColor = Color.FromArgb(229, 224, 236);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "病假";
                cell.BackColor = Color.FromArgb(229, 224, 236);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "详细记录";
                cell.BackColor = Color.FromArgb(229, 224, 236);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "旷课";
                cell.BackColor = Color.FromArgb(219, 229, 241);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "迟到";
                cell.BackColor = Color.FromArgb(219, 229, 241);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "早退";
                cell.BackColor = Color.FromArgb(219, 229, 241);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "事假";
                cell.BackColor = Color.FromArgb(219, 229, 241);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "病假";
                cell.BackColor = Color.FromArgb(219, 229, 241);
                tcHeader.Add(cell);

                cell = new TableHeaderCell();
                cell.Text = "详细记录";
                cell.BackColor = Color.FromArgb(219, 229, 241);
                tcHeader.Add(cell);
            }
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
            ExcelUtil.WriteToExcel(GridView1);
        }
    }
}