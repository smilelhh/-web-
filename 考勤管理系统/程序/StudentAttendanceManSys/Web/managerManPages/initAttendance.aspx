<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="initAttendance.aspx.cs"
    Inherits="Web.managerManPages.initAttendance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 60px;">
        <b style="font-size: large;">初始化本学期考勤信息</b>
        <div style="margin-top: 50px;">
            &nbsp;
            <div style="float: left; margin-left: 40%;">
                <b>用户名：</b>
                <asp:TextBox ID="TextBox_userName" runat="server"></asp:TextBox>
            </div>
            <div style="float: left;">
                <asp:CustomValidator ID="checkUsername" runat="server" ErrorMessage="" ForeColor="Red"></asp:CustomValidator>
            </div>
            <br />
            <br />
            <div style="float: left; margin-left: 40%;">
                <b>&nbsp;密&nbsp;码：</b>
                <asp:TextBox ID="TextBox_password" runat="server" TextMode="Password"></asp:TextBox></div>
            <div style="float: left;">
                <asp:CustomValidator ID="checkPassword" runat="server" ErrorMessage="" ForeColor="Red"></asp:CustomValidator>
            </div>
        </div>
        <div style="margin-top: 50px;">
            <asp:Button ID="Button_submit" runat="server" Text="确定" OnClick="Button_submit_Click" />
        </div>
    </div>
    </form>
</body>
</html>
