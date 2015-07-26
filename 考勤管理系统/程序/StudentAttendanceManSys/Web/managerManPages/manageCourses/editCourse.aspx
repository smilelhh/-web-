<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editCourse.aspx.cs" Inherits="Web.managerManPages.manageCourses.editCourse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/manCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" align="center">
        <table cellspacing="0">
            <tr class="headRow" align="center">
                <td colspan="2" style="color: White;">
                    请填写课程信息
                </td>
            </tr>
            <tr class="tipRow">
                <td colspan="2" style="color: #F02613; border-bottom: solid 1px #389AD0;" align="center">
                    注：学分和课时请输入数字！
                </td>
            </tr>
            <tr class="infoRow">
                <td align="right" class="td_left">
                    课程名：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox_courName" runat="server" class="textBox"></asp:TextBox>
                    <asp:CustomValidator ID="checkCourName" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="infoRow">
                <td align="right">
                    学分：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox_credit" runat="server" class="textBox"></asp:TextBox>
                    <asp:CustomValidator ID="checkCredit" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="infoRow">
                <td align="right">
                    课时：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox_schoolHour" runat="server" class="textBox"></asp:TextBox>
                    <asp:CustomValidator ID="checkSchoolHour" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="footRow">
                <td align="center" colspan="2">
                    <asp:ImageButton ID="ImageButton_submit" runat="server" ImageUrl="~/images/submit.jpg"
                        OnClick="ImageButton_submit_Click" OnClientClick="return confirm('确定修改吗？');" />
                    <asp:ImageButton ID="ImageButton_back" runat="server" ImageUrl="~/images/back.jpg"
                        OnClick="ImageButton_back_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
