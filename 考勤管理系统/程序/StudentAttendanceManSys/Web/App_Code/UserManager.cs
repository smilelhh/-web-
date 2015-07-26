using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.App_Code
{
    /// <summary>
    /// 权限管理基类
    /// </summary>
    public class UserManager : System.Web.UI.Page
    {
        //**********以下为两种方法实现判断当前用户是否登陆****************

        /// <summary>
        /// 第一种方法：重写OnLoad方法
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //判断当前用户是否登陆，如果未登陆就返回登陆页面
            if (Session["User"] == null)
            {
                Response.Redirect("~/login.aspx");
            }

        }


        /// <summary>
        /// 第二种方法：添加一个加载事件
        /// </summary>
        /**
        public UserManager()
        {
            this.Load += new EventHandler(UserManager_Load);
        }

        void UserManager_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
        }
        **/

        //********************************************
    }
}