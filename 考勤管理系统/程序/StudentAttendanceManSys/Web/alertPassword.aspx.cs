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
    public partial class alertPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {
            if (!checkEmpty())
            {
                string oldPSD = TextBox_oldPWD.Text.Trim();
                string newPSD1 = TextBox_newPSD1.Text.Trim();
                string newPSD2 = TextBox_newPSD2.Text.Trim();

                UserBLL userBLL = new UserBLL();

                User user = Session["User"] as User;

                if (newPSD1.Equals(newPSD2))
                {
                    //新密码和确定密码相同的情况

                    //取得加密后的密码
                    string encryptPWD = EncryptUtil.MD5Encrypt(oldPSD);

                    if (!user.Password.Equals(encryptPWD))
                    {
                        //当前密码不匹配的情况

                        checkOldPWD.ErrorMessage = "当前密码输入错误！";
                        checkOldPWD.IsValid = false;

                    }
                    else
                    {
                        user.Password = EncryptUtil.MD5Encrypt(newPSD1);
                        userBLL.update(user);

                        Response.Write("<script>alert('密码修改成功！');location = 'logout.aspx';</script>"); 
                    }
                }
                else
                {
                    //新密码和确定密码不相同的情况

                    checkNewPWD2.ErrorMessage = "两次输入密码不一致！";
                    checkNewPWD2.IsValid = false;

                }
            }

        }

        private Boolean checkEmpty()
        {
            Boolean flag = false;
            if (string.IsNullOrEmpty(TextBox_oldPWD.Text))
            {
                checkOldPWD.ErrorMessage = "当前密码不能为空！";
                checkOldPWD.IsValid = false;
                flag = true;
            }

            if (string.IsNullOrEmpty(TextBox_newPSD1.Text))
            {
                checkNewPWD1.ErrorMessage = "新密码不能为空！";
                checkNewPWD1.IsValid = false;
                flag = true;
            }

            if (string.IsNullOrEmpty(TextBox_newPSD2.Text))
            {
                checkNewPWD2.ErrorMessage = "确定密码不能为空！";
                checkNewPWD2.IsValid = false;
                flag = true;
            }

            return flag;
        }
    }
}