using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.managerManPages.teacherAttendace
{
    public partial class punishStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("punishStudentShow.aspx?punishType=1");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("punishStudentShow.aspx?punishType=2");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("punishStudentShow.aspx?punishType=3");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("punishStudentShow.aspx?punishType=4");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("punishStudentShow.aspx?punishType=5");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("punishStudentShow.aspx?punishType=6");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("punishStudentShow.aspx?punishType=7");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("punishStudentShow.aspx?punishType=8");
        }
    }
}