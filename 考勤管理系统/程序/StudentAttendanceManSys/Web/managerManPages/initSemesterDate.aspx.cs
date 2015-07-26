using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility.Global;

namespace Web.managerManPages
{
    public partial class initSemesterDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {
            DateTime semester = Calendar_semester.SelectedDate;
            int year = semester.Year != 1 ? semester.Year : Calendar_semester.TodaysDate.Year;
            int month = semester.Year != 1 ? semester.Month : Calendar_semester.TodaysDate.Month;
            GlobalVars.SEMESTER = year + "-" + (year + 1) + "学年";
            if (month < 8)
            {
                GlobalVars.SEMESTER += "下学期";
            }
            else
                GlobalVars.SEMESTER += "上学期";

            Response.Write("<script>alert('初始化成功！当前学期为：" + GlobalVars.SEMESTER + "');location.href='../mainPages/welcome.aspx';</script>");
        }

    }
}