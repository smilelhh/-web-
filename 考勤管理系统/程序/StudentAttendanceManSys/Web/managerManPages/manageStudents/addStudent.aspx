<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addStudent.aspx.cs" Inherits="Web.managerManPages.manageStudents.addStudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/manCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" align="center">
        <table cellspacing="0" style="width: 40%; margin-top: 20px;">
            <tr class="headRow" align="center">
                <td colspan="2" style="color: White;">
                    请填写学生信息
                </td>
            </tr>
            <tr class="tipRow">
                <td colspan="2" style="color: #F02613; border-bottom: solid 1px #389AD0;" align="center">
                    注：联系电话只限于手机号码，且以13或15开头！
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right" class="td_left">
                    学号：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox_stuId" runat="server" CssClass="textBox"></asp:TextBox>
                    <asp:CustomValidator ID="checkStuId" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    姓名：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox_name" runat="server" CssClass="textBox"></asp:TextBox>
                    <asp:CustomValidator ID="checkName" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    性别：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:RadioButton ID="RadioButton_male" runat="server" GroupName="gender"
                        Checked="true" Text="男" /><asp:RadioButton ID="RadioButton_female" runat="server"
                            GroupName="gender" Text="女" />
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    出生年月：
                </td>
                <td align="left">
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList_yearPart1" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownList_yearPart2" runat="server">
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem Selected="True">9</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownList_yearPart3" runat="server">
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownList_yearPart4" runat="server">
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                    </asp:DropDownList>
                    年
                    <asp:DropDownList ID="DropDownList_month" runat="server">
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                    月
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    联系电话：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox_phone" runat="server" CssClass="textBox"></asp:TextBox>
                    <asp:CustomValidator ID="checkPhone" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="infoRow" style="height: 90px;">
                <td align="right">
                    地址：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:TextBox ID="TextBox_address" runat="server" CssClass="textBox" TextMode="MultiLine"
                        Width="200px" Height="80px"></asp:TextBox>
                    <asp:CustomValidator ID="checkAddress" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    班级：
                </td>
                <td align="left">
                    &nbsp;&nbsp;<asp:DropDownList ID="DropDownList_class" runat="server">
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
