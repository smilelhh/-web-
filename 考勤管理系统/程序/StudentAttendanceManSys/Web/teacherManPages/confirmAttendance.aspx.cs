using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.teacherManPages
{
    public partial class confirmAttendance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
 
            }
        }

        protected void continueAttendance_Click(object sender, EventArgs e)
        {
            Session.Remove("attenList");

            Response.Write("<script>location.href='checkWorkAttendance.aspx';</script>");
        }

        protected void viewAttendance_Click(object sender, EventArgs e)
        {
            Response.Write("<script>location.href='viewAttendance.aspx';</script>");
        }
       
    }
}