using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Data;

namespace Web.studentManPages
{
    public partial class search : System.Web.UI.Page
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
            User user = Session["User"] as User;

            Student stud = new StudentBLL().getByUserId(user.Id);

            Label_name.Text = stud.Name;

            CommonBLL commBLL = new CommonBLL();

            GridView1.DataSource = commBLL.getSingleStudentAttendStatistics(stud.Id,true);
            GridView1.DataBind();
        }
    }
}