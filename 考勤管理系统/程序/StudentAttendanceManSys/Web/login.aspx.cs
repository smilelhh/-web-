using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using Utility;

namespace Web
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                string userName = TextBox_userName.Text.Trim();
                string password = TextBox_password.Text.Trim();
                string userType = DropDownList_userType.SelectedValue;

                UserBLL userBLL = new UserBLL();
                User user = userBLL.getByUsername(userName);
                if (user != null)
                {
                    //取得加密后的密码
                    string encryptPWD = EncryptUtil.MD5Encrypt(password);

                    if (!user.Password.Equals(encryptPWD))
                    {
                        //密码不匹配的情况

                        checkPassword.ErrorMessage = "密码输入错误！";
                        checkPassword.IsValid = false;

                    }
                    else if (!user.Type.Equals("3-4") && !user.Type.Equals(userType))
                    {
                        //处理用户不是班长类型的情况

                        //用户类型不匹配的情况

                        checkUserType.ErrorMessage = "用户类型不匹配！";
                        checkUserType.IsValid = false;
                    }
                    else
                    {
                        if (user.Type.Equals("3-4"))
                        {
                            //处理用户类型是班长的情况

                            if (userType.Equals("3"))
                            {
                                user.Type = "3";
                            }
                            else if (userType.Equals("4"))
                            {
                                user.Type = "4";
                            }
                            else
                            {
                                //用户类型不匹配的情况

                                checkUserType.ErrorMessage = "用户类型不匹配！";
                                checkUserType.IsValid = false;
                                return;
                            }
                        }

                        //用户检查通过的情况

                        Session.Add("User", user);
                        Response.Redirect("~/mainPages/index.aspx");


                    }
                }
                else
                {
                    checkUsername.ErrorMessage = "账号不存在！";
                    checkUsername.IsValid = false;
                }
            }

        }

        private Boolean checkEmpty()
        {
            Boolean flag = false;
            if (string.IsNullOrEmpty(TextBox_userName.Text))
            {
                checkUsername.ErrorMessage = "账号不能为空！";
                checkUsername.IsValid = false;
                flag = true;
            }

            if (string.IsNullOrEmpty(TextBox_password.Text))
            {
                checkPassword.ErrorMessage = "密码不能为空！";
                checkPassword.IsValid = false;
                flag = true;
            }

            return flag;
        }

    }
}