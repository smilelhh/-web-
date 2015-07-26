using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace Web.mainPage
{
    public partial class menu1 : System.Web.UI.MasterPage
    {
        public string Type { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                int type = Convert.ToInt32((Session["User"] as User).Type);
                switch (type)
                {
                    case 1:
                        Type = "type_teacher";
                        break;
                    case 2:
                        Type = "type_classTeacher";
                        break;
                    case 3:
                        Type = "type_monitor";                       
                        break;
                    case 4:
                        Type = "type_student";
                        break;
                    case 5:
                        Type = "type_manager";
                        break;
                    case 6:
                        Type = "type_attMaintenance";
                        break;
                }
            }
        }
    }
}