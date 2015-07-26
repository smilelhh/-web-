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
    public partial class editStaff : System.Web.UI.Page
    {
        private static Staff staff = null;

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
                StaffBLL staffBLL = new StaffBLL();
                UserBLL userBLL = new UserBLL();

                string username = TextBox_username.Text.Trim();
                string name = TextBox_name.Text.Trim();
                string gender = RadioButton_male.Checked ? "男" : "女";
                string birth = DropDownList_yearPart1.SelectedValue + DropDownList_yearPart2.SelectedValue + DropDownList_yearPart3.SelectedValue + DropDownList_yearPart4.SelectedValue;
                birth += DropDownList_month.SelectedValue;
                string phone = TextBox_phone.Text.Trim();
                string type = DropDownList_type.SelectedValue;

                User user = userBLL.get(staff.UserId);
                if (!user.UserName.Equals(username) || !staff.Type.Equals(type))
                {
                    user.UserName = username;
                    user.Type = type.Equals("考勤维护员") ? "6" : "5";
                    userBLL.update(user);
                }

                staff.Name = name;
                staff.Gender = gender;
                staff.Birth = birth;
                staff.Phone = phone;
                staff.Type = type;
                staffBLL.update(staff);

                Response.Write("<script>alert('修改成功！');location.href='showStaffs.aspx';</script>");

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

        private void bind()
        {

            string id = Request.QueryString["id"].ToString();

            
            StaffBLL staffBLL = new StaffBLL();
            staff = staffBLL.get(id);

            UserBLL userBLL = new UserBLL();
            User user = userBLL.get(staff.UserId);

            TextBox_username.Text = user.UserName;
            TextBox_name.Text = staff.Name;
            if (staff.Gender.Equals("女")) RadioButton_female.Checked = true;
            PageUtil.bindDropDownList(DropDownList_yearPart1, staff.Birth[0].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart2, staff.Birth[1].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart3, staff.Birth[2].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart4, staff.Birth[3].ToString());
            PageUtil.bindDropDownList(DropDownList_month, staff.Birth.Substring(4, 2));
            TextBox_phone.Text = staff.Phone;
            PageUtil.bindDropDownList(DropDownList_type, staff.Type);
        }


    }
}