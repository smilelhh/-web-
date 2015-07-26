using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Utility;
using Model;

namespace Web.managerManPages.manageTeachers
{
    public partial class showTeachers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                bind();
            }
        }

        protected void ImageButton_add_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("addTeacher.aspx");
        }

        protected void ImageButton_edit_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;

            string id = imageButton.CommandArgument;

            Response.Redirect("editTeacher.aspx?id=" + id);
        }

        protected void ImageButton_delete_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;

            string id = imageButton.CommandArgument;

            TeacherBLL teachBLL = new TeacherBLL();
            UserBLL userBLL = new UserBLL();

            Teacher teacher = teachBLL.get(id);
            User user = userBLL.get(teacher.UserID);

            teachBLL.delete(teacher);
            userBLL.delete(user);

            Response.Write("<script>alert('删除成功！');location.href='showTeachers.aspx';</script>");
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            bind();
        }

        protected void DropDownList_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind();
        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        private void bind()
        {
            CommonBLL commonBLL = new CommonBLL();

            DataTable dt = commonBLL.getTeachers();

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;

            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.getPaged(dt, from, to);
            GridView1.DataBind();
        }


    }
}