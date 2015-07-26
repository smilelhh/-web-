<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alertPassword.aspx.cs"
    Inherits="Web.alertPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 60px;">
        <b style="font-size: large;">修改密码</b>
        <div style="margin-top: 50px;">
            &nbsp;
            <div style="float: left; margin-left: 40%;">
                <b>当前密码：</b>
                <asp:TextBox ID="TextBox_oldPWD" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div style="float: left;">
                <asp:CustomValidator ID="checkOldPWD" runat="server" ErrorMessage="" ForeColor="Red"></asp:CustomValidator>
            </div>
            <br />
            <br />
            <div style="float: left; margin-left: 41.3%;">
                <b>新密码：</b>
                <asp:TextBox ID="TextBox_newPSD1" runat="server" TextMode="Password"></asp:TextBox></div>
            <div style="float: left;">
                <asp:CustomValidator ID="checkNewPWD1" runat="server" ErrorMessage="" ForeColor="Red"></asp:CustomValidator>
            </div>
            <br />
            <br />
            <div style="float: left; margin-left: 38.7%;">
                <b>确认新密码：</b>
                <asp:TextBox ID="TextBox_newPSD2" runat="server" TextMode="Password"></asp:TextBox></div>
            <div style="float: left;">
                <asp:CustomValidator ID="checkNewPWD2" runat="server" ErrorMessage="" ForeColor="Red"></asp:CustomValidator>
            </div>
        </div>
        <div style="margin-top: 50px;">
            <asp:Button ID="Button_submit" runat="server" Text="确定" OnClick="Button_submit_Click" />
        </div>
    </div>
    </form>
</body>
</html>
