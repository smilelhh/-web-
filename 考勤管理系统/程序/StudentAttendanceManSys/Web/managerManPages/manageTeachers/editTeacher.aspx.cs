using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using Utility;

namespace Web.managerManPages.manageTeachers
{
    public partial class editTeacher : System.Web.UI.Page
    {
        private static Teacher teacher = null;

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
                TeacherBLL teachBLL = new TeacherBLL();

                string name = TextBox_name.Text.Trim();
                string gender = RadioButton_male.Checked ? "男" : "女";
                string birth = DropDownList_yearPart1.SelectedValue + DropDownList_yearPart2.SelectedValue + DropDownList_yearPart3.SelectedValue + DropDownList_yearPart4.SelectedValue;
                birth += DropDownList_month.SelectedValue;
                string title = DropDownList_title.SelectedValue;
                string phone = TextBox_phone.Text.Trim();
                string email = TextBox_email.Text.Trim();

                if (!teacher.Title.Equals(title))
                {
                    UserBLL userBLL = new UserBLL();
                    User user = userBLL.get(teacher.UserID);
                    user.Type = title.Equals("辅导员") ? "2" : "1";
                    userBLL.update(user);
                }

                teacher.Name = name;
                teacher.Gender = gender;
                teacher.Birth = birth;
                teacher.Title = title;
                teacher.Phone = phone;
                teacher.Email = email;

                teachBLL.update(teacher);

                Response.Write("<script>alert('修改成功！');location.href='showTeachers.aspx';</script>");

            }
        }

        protected void ImageButton_back_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("showTeachers.aspx");
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

                string name = TextBox_name.Text.Trim();
                string phone = TextBox_phone.Text.Trim();
                string email = TextBox_email.Text.Trim();


                //检测姓名输入值是否输入正确
                if (string.IsNullOrEmpty(name))
                {
                    checkName.ErrorMessage = "姓名不能为空！";
                    checkName.IsValid = false;
                    flag = false;
                }

                //检测联系电话输入值是否输入正确
                if (string.IsNullOrEmpty(phone))
                {
                    checkPhone.ErrorMessage = "联系电话不能为空！";
                    checkPhone.IsValid = false;
                    flag = false;
                }
                else
                {
                    string phoneReg = @"^(13|15)\d{9}$";

                    if (!System.Text.RegularExpressions.Regex.IsMatch(phone, phoneReg))
                    {
                        checkPhone.ErrorMessage = "联系电话格式不正确！";
                        checkPhone.IsValid = false;
                        flag = false;
                    }
                }

                //检测邮箱输入值是否输入正确
                if (string.IsNullOrEmpty(email))
                {
                    checkEmail.ErrorMessage = "邮箱不能为空！";
                    checkEmail.IsValid = false;
                    flag = false;
                }
                else
                {
                    string emailReg = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";

                    if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailReg))
                    {
                        checkEmail.ErrorMessage = "邮箱格式不正确！";
                        checkEmail.IsValid = false;
                        flag = false;
                    }
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

            TeacherBLL teachBLL = new TeacherBLL();
            teacher = teachBLL.get(id);

            Label_teachId.Text = teacher.TeacherId;
            TextBox_name.Text = teacher.Name;
            if (teacher.Gender.Equals("女")) RadioButton_female.Checked = true;
            PageUtil.bindDropDownList(DropDownList_yearPart1, teacher.Birth[0].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart2, teacher.Birth[1].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart3, teacher.Birth[2].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart4, teacher.Birth[3].ToString());
            PageUtil.bindDropDownList(DropDownList_month, teacher.Birth.Substring(4, 2));
            PageUtil.bindDropDownList(DropDownList_title, teacher.Title);
            TextBox_phone.Text = teacher.Phone;
            TextBox_email.Text = teacher.Email;
        }


    }
}