using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using Utility;

namespace Web.managerManPages.manageCourses
{
    public partial class editClass : System.Web.UI.Page
    {
        private static Class clazz = null;

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
                string monitorID = DropDownList_monitor.SelectedValue.Trim().Equals("无") ? "" : DropDownList_monitor.SelectedValue.Trim();

                if (!clazz.MonitorID.Equals(monitorID))
                {
                    StudentBLL stuBLL = new StudentBLL();
                    UserBLL userBLL = new UserBLL();

                    if (!string.IsNullOrEmpty(clazz.MonitorID))
                    {
                        User user = userBLL.getByUsername(stuBLL.get(clazz.MonitorID).StuId);
                        user.Type = "4";
                        userBLL.update(user);
                    }

                    if (!string.IsNullOrEmpty(monitorID))
                    {
                        User user = userBLL.getByUsername(stuBLL.get(monitorID).StuId);
                        user.Type = "3-4";
                        userBLL.update(user);
                    }

                }

                clazz.Depart = depart;
                clazz.Grade = grade;
                clazz.Name = className;
                clazz.TeacherID = teacherID;
                clazz.MonitorID = monitorID;

                classBLL.update(clazz);

                Response.Write("<script>alert('修改成功！');location.href='showClasses.aspx';</script>");

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

        private void bind()
        {

            string id = Request.QueryString["id"].ToString();

            ClassBLL classBLL = new ClassBLL();
            clazz = classBLL.get(id);

            //初始化DropDownList_teacher的绑定值
            TeacherBLL teachBLL = new TeacherBLL();
            DropDownList_teacher.DataSource = teachBLL.getClassTeachers();
            DropDownList_teacher.DataTextField = "name";
            DropDownList_teacher.DataValueField = "ID";
            DropDownList_teacher.DataBind();

            //初始化DropDownList_monitor的绑定值
            StudentBLL studBLL = new StudentBLL();
            DropDownList_monitor.DataSource = studBLL.getByClassId(id);
            DropDownList_monitor.DataTextField = "name";
            DropDownList_monitor.DataValueField = "ID";
            DropDownList_monitor.DataBind();
            DropDownList_monitor.Items.Insert(0, "无");

            TextBox_className.Text = clazz.Name;
            PageUtil.bindDropDownList(DropDownList_depart, clazz.Depart);
            PageUtil.bindDropDownList(DropDownList_grade, clazz.Grade);
            PageUtil.bindDropDownList(DropDownList_teacher, clazz.TeacherID);
            PageUtil.bindDropDownList(DropDownList_monitor, clazz.MonitorID);

        }


    }
}