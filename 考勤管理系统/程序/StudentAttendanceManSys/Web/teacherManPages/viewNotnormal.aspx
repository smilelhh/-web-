<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewNotnormal.aspx.cs"
    Inherits="Web.teacherManPages.viewNotnormal" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp
        <asp:Label ID="Label1" runat="server" Text="周次：" Font-Bold="True"></asp:Label>
        <asp:Label ID="week" runat="server" Width="180px"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="星期：" Font-Bold="True"></asp:Label>
        <asp:Label ID="weekDay" runat="server" Width="210px"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="上课时间：" Font-Bold="True"></asp:Label>
        <asp:Label ID="courseTime" runat="server" Width="120px"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="上课地点：" Font-Bold="True"></asp:Label>
        <asp:Label ID="place" runat="server" Width="120px"></asp:Label>
        <br />
        <br />
        &nbsp
        <asp:Label ID="Label5" runat="server" Text="班级：" Font-Bold="True"></asp:Label>
        <asp:Label ID="classId" runat="server" Width="180px"></asp:Label>
        <asp:Label ID="Label6" runat="server" Text="课程名称：" Font-Bold="True"></asp:Label>
        <asp:Label ID="courseName" runat="server" Width="180px"></asp:Label>
        <asp:Label ID="Label7" runat="server" Text="任课教师：" Font-Bold="True"></asp:Label>
        <asp:Label ID="teacherName" runat="server" Width="120px"></asp:Label>
    </div>
    <br />
    <br />
    <div align="center">
        <asp:Label ID="Label8" runat="server" Text="本课程未正常出勤学生名单" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="colNumber" HeaderText="序号" ItemStyle-Width="130px">
                    <ItemStyle Width="130px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="name" HeaderText="姓名" ItemStyle-Width="150px">
                    <ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="status" HeaderText="出勤状态" ItemStyle-Width="150px">
                    <ItemStyle Width="150px"></ItemStyle>
                </asp:BoundField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="anpager" FirstPageText="首页"
            LastPageText="尾页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"
            PrevPageText="上一页" AlwaysShow="True" CurrentPageButtonClass="cpb" Style="margin-top: 20px;">
        </webdiyer:AspNetPager>
    </div>
    </form>
</body>
</html>
