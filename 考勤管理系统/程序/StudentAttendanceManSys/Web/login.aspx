<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Web.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>登陆页面</title>
    <link href="css/login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div style="width: 100%; height: 100%;">
        <div class="login_top">
        </div>
        <div class="login_content">
            <div class="login_content_left">
                <div class="left_content">
                    <div>
                        <img alt="" src="images/logo.png" width="279" height="68" />
                    </div>
                    <div class="left_txt">
                        <div style="line-height: 25px;">
                            <p>
                                1.本系统主要针对目前高校学生上课出勤管理...</p>
                        </div>
                        <div style="line-height: 25px;">
                            <p>
                                2.本系统总体由三大功能模块：考勤系统模块...</p>
                        </div>
                        <div style="line-height: 25px;">
                            <p>
                                3.本系统主要针对目前高校学生上课出勤管理...</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="login_content_right">
                <div class="right_content">
                    <div class="top">
                        登陆考勤管理系统
                    </div>
                    <div class="middle">
                        <form id="form2" runat="server" method="post">
                        <div class="form_line">
                            <div class="line_label">
                                账 号：</div>
                            <div class="line_textInput">
                                <asp:TextBox ID="TextBox_userName" runat="server" Style="width: 120px;"></asp:TextBox><asp:CustomValidator
                                    Style="margin-left: 25px;" ID="checkUsername" runat="server" ErrorMessage="账号不存在！"
                                    ControlToValidate="TextBox_userName" ForeColor="Red"></asp:CustomValidator>
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                        <div class="form_line">
                            <div class="line_label">
                                密 码：</div>
                            <div class="line_textInput">
                                <div style="float: left;">
                                    <asp:TextBox ID="TextBox_password" runat="server" TextMode="Password" Style="width: 120px;"></asp:TextBox></div>
                                <div style="float: left; margin-top: 2px;">
                                    <img alt="" src="images/luck.gif" />
                                    <asp:CustomValidator ID="checkPassword" runat="server" ErrorMessage="密码输入错误！" ControlToValidate="TextBox_userName"
                                        ForeColor="Red"></asp:CustomValidator></div>
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                        <div class="form_line">
                            <div class="line_label">
                                角 色：</div>
                            <div class="line_textInput">
                                <asp:DropDownList ID="DropDownList_userType" runat="server">
                                    <asp:ListItem Value="1">教师</asp:ListItem>
                                    <asp:ListItem Value="2">班主任</asp:ListItem>
                                    <asp:ListItem Value="3">班长</asp:ListItem>
                                    <asp:ListItem Value="4">学生</asp:ListItem>
                                    <asp:ListItem Value="5">管理员</asp:ListItem>
                                    <asp:ListItem Value="6">考勤维护员</asp:ListItem>
                                </asp:DropDownList>
                                <asp:CustomValidator Style="margin-left: 25px;" ID="checkUserType" runat="server"
                                    ErrorMessage="用户类型不匹配！" ControlToValidate="TextBox_userName" ForeColor="Red"></asp:CustomValidator>
                            </div>
                            <div class="clear">
                            </div>
                        </div>
                        <div class="form_line">
                            <asp:Button ID="Button_submit" runat="server" Text="登 陆" OnClick="Button_submit_Click" />
                            <input type="reset" value="重 置" style="margin-left: 10%;" />
                        </div>
                        </form>
                    </div>
                    <div class="bottom">
                        <img alt="" src="images/login-wel.gif" />
                    </div>
                </div>
            </div>
        </div>
        <div class="login_bottom">
            Copyright &copy; 2013-2014
        </div>
    </div>
</body>
</html>
