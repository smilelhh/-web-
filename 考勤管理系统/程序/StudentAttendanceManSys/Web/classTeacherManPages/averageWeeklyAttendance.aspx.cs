using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace Web.classTeacherManPages
{
    public partial class averageWeeklyAttendance : System.Web.UI.Page
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

            TeacherBLL teacherBLL = new TeacherBLL();
            Teacher teacher = teacherBLL.getByUserId(user.Id);

            CommonBLL commBLL = new CommonBLL();
            GridView1.DataSource = commBLL.getClassesByTeacherId(teacher.Id);
            GridView1.DataBind();


        }
    }
}