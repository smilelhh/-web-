using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace Web.managerManPages.manageCourses
{
    public partial class addClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }
        }

        protected void ImageButton_submit_Click(object sender, ImageClickEventArgs e)
        {
            if (check())
            {
                ClassBLL classBLL = new ClassBLL();

                string className = TextBox_className.Text.Trim();
                string depart = DropDownList_depart.SelectedValue.Trim();
                string grade = DropDownList_grade.SelectedValue.Trim();
                string teacherID = DropDownList_teacher.SelectedValue.Trim();

                Class clazz = new Class();
                clazz.Depart = depart;
                clazz.Grade = grade;
                clazz.Name = className;
                clazz.StudCount = "0";
                clazz.MonitorID = null;
                clazz.TeacherID = teacherID;

                classBLL.save(clazz);

                Response.Write("<script>alert('添加成功！');location.href='addClass.aspx';</script>");

            }
        }

        protected void ImageButton_back_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("showClasses.aspx");
        }

        /// <summary>
        /// 检测页面输入是否正确
        /// </summary>
        /// <returns></returns>
        private Boolean check()
        {
            try
            {
                Boolean flag = true;

                string className = TextBox_className.Text.Trim();

                //检测班级名输入值是否输入正确
                if (string.IsNullOrEmpty(className))
                {
                    checkClassName.ErrorMessage = "班级名不能为空！";
                    checkClassName.IsValid = false;
                    flag = false;
                }

                return flag;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        private void bind()
        {

            TeacherBLL teachBLL = new TeacherBLL();

            DropDownList_teacher.DataSource = teachBLL.getClassTeachers();
            DropDownList_teacher.DataTextField = "name";
            DropDownList_teacher.DataValueField = "ID";
            DropDownList_teacher.DataBind();
        }


    }
}