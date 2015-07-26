using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using Utility;

namespace Web.managerManPages.manageStaffs
{
    public partial class addStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton_submit_Click(object sender, ImageClickEventArgs e)
        {
            if (check())
            {

                StaffBLL staffBLL = new StaffBLL();
                UserBLL userBLL = new UserBLL();

                string username = TextBox_username.Text.Trim();
                string name = TextBox_name.Text.Trim();
                string gender = RadioButton_male.Checked ? "男" : "女";
                string birth = DropDownList_yearPart1.SelectedValue + DropDownList_yearPart2.SelectedValue + DropDownList_yearPart3.SelectedValue + DropDownList_yearPart4.SelectedValue;
                birth += DropDownList_month.SelectedValue;
                string phone = TextBox_phone.Text.Trim();
                string type = DropDownList_type.SelectedValue;


                if (userBLL.getByUsername(username) == null)
                {
                    #region 在用户表中创建新用户
                    User user = new User();
                    user.UserName = username;
                    user.Password = EncryptUtil.MD5Encrypt("12345678");
                    user.Type = type.Equals("考勤维护员") ? "6" : "5";
                    userBLL.save(user);
                    #endregion


                    Staff staff = new Staff();
                    staff.Name = name;
                    staff.Gender = gender;
                    staff.Birth = birth;
                    staff.Phone = phone;
                    staff.Type = type;
                    staff.UserId = userBLL.getByUsername(username).Id;

                    staffBLL.save(staff);
                    Response.Write("<script>alert('添加成功！');location.href='addStaff.aspx';</script>");
                }
                else
                    Response.Write("<script>alert('添加失败，用户名已存在！');location.href='addStaff.aspx';</script>");
            }

        }

        protected void ImageButton_back_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("showStaffs.aspx");
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

                string username = TextBox_username.Text.Trim();
                string name = TextBox_name.Text.Trim();
                string phone = TextBox_phone.Text.Trim();

                //检测用户名输入值是否输入正确
                if (string.IsNullOrEmpty(username))
                {
                    checkUsername.ErrorMessage = "用户名不能为空！";
                    checkUsername.IsValid = false;
                    flag = false;
                }

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

                return flag;
            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}