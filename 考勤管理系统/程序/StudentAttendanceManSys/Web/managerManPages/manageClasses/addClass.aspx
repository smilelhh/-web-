<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addClass.aspx.cs" Inherits="Web.managerManPages.manageCourses.addClass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/manCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" align="center">
        <table cellspacing="0">
            <tr class="headRow" align="center">
                <td colspan="2" style="color: White;">
                    请填写班级信息
                </td>
            </tr>
            <tr class="tipRow">
                <td colspan="2" style="color: #F02613; border-bottom: solid 1px #389AD0;" align="center">
                </td>
            </tr>
            <tr class="infoRow">
                <td align="right" class="td_left">
                    班级名：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox_className" runat="server" class="textBox"></asp:TextBox>
                    <asp:CustomValidator ID="checkClassName" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="infoRow">
                <td align="right">
                    专业/系：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:DropDownList ID="DropDownList_depart" runat="server" class="dropDownList">
                        <asp:ListItem>软件工程</asp:ListItem>
                        <asp:ListItem>软件+电气</asp:ListItem>
                        <asp:ListItem>软件+道路与铁道</asp:ListItem>
                        <asp:ListItem>软件+会计</asp:ListItem>
                        <asp:ListItem>软件+机械电子</asp:ListItem>
                        <asp:ListItem>软件+交通设备信息</asp:ListItem>
                        <asp:ListItem>软件+交通运输</asp:ListItem>
                        <asp:ListItem>软件+桥梁</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="infoRow">
                <td align="right">
                    年级：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:DropDownList ID="DropDownList_grade" runat="server" class="dropDownList">
                        <asp:ListItem>2002级</asp:ListItem>
                        <asp:ListItem>2003级</asp:ListItem>
                        <asp:ListItem>2004级</asp:ListItem>
                        <asp:ListItem>2005级</asp:ListItem>
                        <asp:ListItem>2006级</asp:ListItem>
                        <asp:ListItem>2007级</asp:ListItem>
                        <asp:ListItem>2008级</asp:ListItem>
                        <asp:ListItem>2009级</asp:ListItem>
                        <asp:ListItem>2010级</asp:ListItem>
                        <asp:ListItem>2011级</asp:ListItem>
                        <asp:ListItem>2012级</asp:ListItem>
                        <asp:ListItem>2013级</asp:ListItem>
                        <asp:ListItem>2014级</asp:ListItem>
                        <asp:ListItem>2015级</asp:ListItem>
                        <asp:ListItem>2016级</asp:ListItem>
                        <asp:ListItem>2017级</asp:ListItem>
                        <asp:ListItem>2018级</asp:ListItem>
                        <asp:ListItem>2019级</asp:ListItem>
                        <asp:ListItem>2020级</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="infoRow">
                <td align="right">
                    班主任：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:DropDownList ID="DropDownList_teacher" runat="server" class="dropDownList">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="footRow">
                <td align="center" colspan="2">
                    <asp:ImageButton ID="ImageButton_submit" runat="server" ImageUrl="~/images/submit.jpg"
                        OnClick="ImageButton_submit_Click" />
                    <asp:ImageButton ID="ImageButton_back" runat="server" ImageUrl="~/images/back.jpg"
                        OnClick="ImageButton_back_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
