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

namespace Web.managerManPages.manageStudents
{
    public partial class showStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClassBLL classBLL = new ClassBLL();

                DropDownList_class.DataSource = classBLL.getAll();
                DropDownList_class.DataTextField = "name";
                DropDownList_class.DataBind();
                DropDownList_class.Items.Insert(0, "全院");

                bind();
            }
        }

        protected void ImageButton_add_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("addStudent.aspx");
        }

        protected void ImageButton_edit_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;

            string id = imageButton.CommandArgument;

            Response.Redirect("editStudent.aspx?id=" + id);
        }

        protected void ImageButton_delete_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;

            string id = imageButton.CommandArgument;

            ClassBLL classBLL = new ClassBLL();
            StudentBLL stuBLL = new StudentBLL();
            UserBLL userBLL = new UserBLL();

            Student stu = stuBLL.get(id);
            User user = userBLL.get(stu.UserID);

            stuBLL.delete(stu);
            userBLL.delete(user);

            Class clazz = classBLL.get(stu.ClassID);
            clazz.StudCount = (Convert.ToInt32(clazz.StudCount) - 1).ToString();
            classBLL.update(clazz);

            Response.Write("<script>alert('删除成功！');location.href='showStudents.aspx';</script>");
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
            Label_className.Text = DropDownList_class.SelectedValue;

            CommonBLL commonBLL = new CommonBLL();

            string filter = "1=1 ";
            filter += DropDownList_class.SelectedValue.Equals("全院") ? "" : " and className='" + DropDownList_class.SelectedValue + "'";

            string sort = "stuId";

            DataTable dt = PageUtil.getProcessedDataTable(commonBLL.getStudents(), filter, sort);

            AspNetPager1.RecordCount = dt.Rows.Count;

            int from = (AspNetPager1.CurrentPageIndex - 1) * AspNetPager1.PageSize + 1;

            int to = from + AspNetPager1.PageSize - 1 > AspNetPager1.RecordCount ? AspNetPager1.RecordCount : from + AspNetPager1.PageSize - 1;

            GridView1.DataSource = PageUtil.getPaged(dt, from, to);
            GridView1.DataBind();
        }




    }
}