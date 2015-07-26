using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using Utility;

namespace Web.managerManPages.manageStudents
{
    public partial class editStudent : System.Web.UI.Page
    {
        private static Student stu = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClassBLL classBLL = new ClassBLL();

                DropDownList_class.DataSource = classBLL.getAll();
                DropDownList_class.DataTextField = "name";
                DropDownList_class.DataValueField = "ID";
                DropDownList_class.DataBind();
                bind();
            }
        }

        protected void ImageButton_submit_Click(object sender, ImageClickEventArgs e)
        {
            if (check())
            {
                StudentBLL stuBLL = new StudentBLL();

                string name = TextBox_name.Text.Trim();
                string gender = RadioButton_male.Checked ? "男" : "女";
                string birth = DropDownList_yearPart1.SelectedValue + DropDownList_yearPart2.SelectedValue + DropDownList_yearPart3.SelectedValue + DropDownList_yearPart4.SelectedValue;
                birth += DropDownList_month.SelectedValue;
                string phone = TextBox_phone.Text.Trim();
                string address = TextBox_address.Text.Trim();
                string classID = DropDownList_class.SelectedValue;

                stu.Name = name;
                stu.Gender = gender;
                stu.Birth = birth;
                stu.Phone = phone;
                stu.Address = address;
                stu.ClassID = classID;

                stuBLL.update(stu);

                Response.Write("<script>alert('修改成功！');location.href='showStudents.aspx';</script>");

            }
        }

        protected void ImageButton_back_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("showStudents.aspx");
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
                string address = TextBox_address.Text.Trim();


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

                //检测地址输入值是否输入正确
                if (string.IsNullOrEmpty(address))
                {
                    checkAddress.ErrorMessage = "地址不能为空！";
                    checkAddress.IsValid = false;
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

            StudentBLL stuBLL = new StudentBLL();
            stu = stuBLL.get(id);

            Label_stuId.Text = stu.StuId;
            TextBox_name.Text = stu.Name;
            if (stu.Gender.Equals("女")) RadioButton_female.Checked = true;
            PageUtil.bindDropDownList(DropDownList_yearPart1, stu.Birth[0].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart2, stu.Birth[1].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart3, stu.Birth[2].ToString());
            PageUtil.bindDropDownList(DropDownList_yearPart4, stu.Birth[3].ToString());
            PageUtil.bindDropDownList(DropDownList_month, stu.Birth.Substring(4, 2));
            TextBox_phone.Text = stu.Phone;
            TextBox_address.Text = stu.Address;
            PageUtil.bindDropDownList(DropDownList_class, stu.ClassID);
        }

        
    }
}