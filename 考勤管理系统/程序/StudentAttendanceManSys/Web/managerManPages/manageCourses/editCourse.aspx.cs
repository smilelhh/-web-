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
    public partial class editCourse : System.Web.UI.Page
    {
        private static Course course = null;

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
                CourseBLL courBLL = new CourseBLL();

                string courName = TextBox_courName.Text.Trim();
                string credit = TextBox_credit.Text.Trim();
                string schoolHour = TextBox_schoolHour.Text.Trim();

                course.Name = courName;
                course.Credit = credit;
                course.SchoolHour = schoolHour;

                courBLL.update(course);

                Response.Write("<script>alert('修改成功！');location.href='showCourses.aspx';</script>");

            }
        }

        protected void ImageButton_back_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("showCourses.aspx");
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

                string courName = TextBox_courName.Text.Trim();
                string credit = TextBox_credit.Text.Trim();
                string schoolHour = TextBox_schoolHour.Text.Trim();

                int tempNum = 0;//用于判断输入是否为数字的临时变量

                //检测课程名输入值是否输入正确
                if (string.IsNullOrEmpty(courName))
                {
                    checkCourName.ErrorMessage = "课程名不能为空！";
                    checkCourName.IsValid = false;
                    flag = false;
                }

                //检测学分输入值是否输入正确
                if (string.IsNullOrEmpty(credit))
                {
                    checkCredit.ErrorMessage = "学分不能为空！";
                    checkCredit.IsValid = false;
                    flag = false;
                }
                else if (!int.TryParse(credit, out tempNum))
                {
                    checkCredit.ErrorMessage = "请输入数字！";
                    checkCredit.IsValid = false;
                    flag = false;
                }

                //检测课时输入值是否输入正确
                if (string.IsNullOrEmpty(schoolHour))
                {
                    checkSchoolHour.ErrorMessage = "课时不能为空！";
                    checkSchoolHour.IsValid = false;
                    flag = false;
                }
                else if (!int.TryParse(schoolHour, out tempNum))
                {
                    checkSchoolHour.ErrorMessage = "请输入数字！";
                    checkSchoolHour.IsValid = false;
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

            CourseBLL courBLL = new CourseBLL();
            course = courBLL.get(id);

            TextBox_courName.Text = course.Name;
            TextBox_credit.Text = course.Credit;
            TextBox_schoolHour.Text = course.SchoolHour;

           
        }

        
    }
}