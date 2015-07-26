using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace Web.mainPage
{
    public partial class header1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    string username = "";

                    User user = Session["User"] as User;
                    int type = Convert.ToInt32(user.Type);
                    switch (type)
                    {
                        case 1:
                            username = new TeacherBLL().getByUserId(user.Id).Name;
                            break;
                        case 2:
                            username = new TeacherBLL().getByUserId(user.Id).Name;
                            break;
                        case 3:
                            username = new StudentBLL().getByUserId(user.Id).Name;
                            break;
                        case 4:
                            username = new StudentBLL().getByUserId(user.Id).Name;
                            break;
                        case 5:
                            username = new StaffBLL().getByUserId(user.Id).Name;
                            break;
                        case 6:
                            username = new StaffBLL().getByUserId(user.Id).Name;
                            break;
                    }

                    Label_username.Text = username;
                }
            }
        }
    }
}