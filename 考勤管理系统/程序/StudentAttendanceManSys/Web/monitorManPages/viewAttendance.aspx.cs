using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using BLL;
using Utility;

namespace Web.monitorManPages
{
    public partial class viewAttendance : System.Web.UI.Page
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
            List<Attendance> attenList = Session["attenList"] as List<Attendance>;
            DataTable dt = transferListToDataTable(attenList);

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.resort(PageUtil.getPaged(dt, from, to));
            GridView1.DataBind();
        }
        private DataTable transferListToDataTable(List<Attendance> attenList)
        {

            StudentBLL stuBLL = new StudentBLL();

            DataTable dt = new DataTable();
            //设置自增长列
            DataColumn colNumber = new DataColumn("ID");
            colNumber.AutoIncrement = true;//设置是否为自增列
            colNumber.AutoIncrementSeed = 1;//设置自增初始值
            colNumber.AutoIncrementStep = 1;//设置每次子增值
            dt.Columns.Add(colNumber);
            dt.Columns.Add("stuId", Type.GetType("System.String"));
            dt.Columns.Add("name", Type.GetType("System.String"));
            dt.Columns.Add("gender", Type.GetType("System.String"));
            dt.Columns.Add("status", Type.GetType("System.String"));
            dt.Columns.Add("remark", Type.GetType("System.String"));

            foreach (Attendance att in attenList)
            {
                Student stud = stuBLL.get(att.StudID);
                DataRow dr = dt.NewRow();
                dr[1] = stud.StuId;
                dr[2] = stud.Name;
                dr[3] = stud.Gender;
                dr[4] = att.Status;
                dr[5] = att.Remark;

                dt.Rows.Add(dr);
            }

            return dt;
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind();
        }
    }
}