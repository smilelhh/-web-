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

namespace Web.teacherManPages
{
    public partial class checkResult : System.Web.UI.Page
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

            CourseTableBLL ctBLL = new CourseTableBLL();
            TeacherBLL teachBll = new TeacherBLL();
            CourseBLL courBLL = new CourseBLL();
            ClassBLL classBLL = new ClassBLL();


            CourseTable ct = ctBLL.get(attenList[0].CourTableID);
            Class clazz = classBLL.get(ct.ClassID);

            #region 页面数据绑定
            className.Text = clazz.Name;
            courseName.Text = courBLL.get(ct.CourId).Name;
            teacherName.Text = teachBll.get(ct.TeachID).Name;
            week.Text = "第" + ct.Week + "周";
            weekDay.Text = ct.WeekDay;
            classtTime.Text = ct.CourseTime;
            classAddress.Text = ct.Place;

            lateNumber.Text = attenList.Where(x => x.Status.Equals("迟到")).ToList().Count.ToString();
            absences.Text = attenList.Where(x => !x.Status.Equals("正常")).ToList().Count.ToString();
            allNumber.Text = clazz.StudCount;
            attRate.Text = FormatUtil.doubleToPercent(attenList.Where(x => x.Status.Equals("正常")).ToList().Count / Convert.ToDouble(clazz.StudCount));

            DataTable dt = transferListToDataTable(attenList);

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;
            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.resort(PageUtil.getPaged(dt, from, to));
            GridView1.DataBind();
            #endregion
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
            dt.Columns.Add("stuName", Type.GetType("System.String"));
            dt.Columns.Add("gender", Type.GetType("System.String"));
            dt.Columns.Add("status", Type.GetType("System.String"));
            dt.Columns.Add("remark", Type.GetType("System.String"));

            foreach (Attendance att in attenList)
            {
                Student stud = stuBLL.get(att.StudID);
                DataRow dr = dt.NewRow();
                dr[1] = stud.Name;
                dr[2] = stud.Gender;
                dr[3] = att.Status;
                dr[4] = att.Remark;

                dt.Rows.Add(dr);
            }

            return dt;
        }

        protected void btnSure_Click(object sender, EventArgs e)
        {
            AttendanceBLL attendBLL = new AttendanceBLL();

            List<Attendance> attenList = Session["attenList"] as List<Attendance>;

            foreach (Attendance att in attenList)
            {
                attendBLL.save(att);
            }

            Response.Write("<script>location.href='confirmAttendance.aspx';</script>");
        }

        protected void btnAlter_Click(object sender, EventArgs e)
        {
            List<Attendance> attenList = Session["attenList"] as List<Attendance>;
            Response.Write("<script>location.href='unCheckin.aspx?courTableID=" + attenList[0].CourTableID + "';</script>");
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind();
        }
    }
}