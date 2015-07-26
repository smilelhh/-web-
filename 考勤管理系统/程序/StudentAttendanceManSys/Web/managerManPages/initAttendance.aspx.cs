using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using Utility;
using System.Data;
using Utility.Global;

namespace Web.managerManPages
{
    public partial class initAttendance : System.Web.UI.Page
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

                StaffBLL staffBLL = new StaffBLL();
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
                    else
                    {
                        Staff staff = staffBLL.getByUserId(user.Id);
                        if (staff != null && staff.Type.Equals("超级管理员"))
                        {

                            //用户检查通过的情况
                            AttendanceBLL attendBLL = new AttendanceBLL();
                            CourseTableBLL ctBLL = new CourseTableBLL();

                            string filter = "semester='" + GlobalVars.SEMESTER + "'";
                            DataTable dt = PageUtil.getProcessedDataTable(ctBLL.getAll().Tables[0], filter, null, false);

                            foreach (DataRow dr in dt.Rows)
                            {
                                attendBLL.deleteByCourseTableId(dr["ID"].ToString());
                            }

                            Response.Write("<script>alert('考勤初始化成功！');location.href='../mainPages/welcome.aspx';</script>");

                        }
                        else
                        {
                            checkUsername.ErrorMessage = "该用户没有权限！";
                            checkUsername.IsValid = false;
                        }

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