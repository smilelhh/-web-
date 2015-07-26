<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewCourseAttendance.aspx.cs"
    Inherits="Web.teacherManPages.viewCourseAttendance" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <br />
        <asp:Label ID="courseName" runat="server" Text="课程名" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="课程考勤记录" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="colNumber" HeaderText="序号" ItemStyle-Width="90px">
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="className" HeaderText="班级" ItemStyle-Width="120px">
                    <ItemStyle Width="120px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="week" HeaderText="周次" ItemStyle-Width="120px">
                    <ItemStyle Width="120px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="weekDay" HeaderText="星期" ItemStyle-Width="100px">
                    <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="courseTime" HeaderText="上课时间" ItemStyle-Width="120px">
                    <ItemStyle Width="120px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="place" HeaderText="上课地点" ItemStyle-Width="120px">
                    <ItemStyle Width="120px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="attendanceRate" HeaderText="到课率" ItemStyle-Width="100px">
                    <ControlStyle Font-Size="X-Large" />
                    <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:HyperLinkField DataNavigateUrlFields="courTableID" DataNavigateUrlFormatString="viewNotnormal.aspx?courTableID={0}"
                    HeaderText="详细信息" Text="查看">
                    <ControlStyle ForeColor="#003399" />
                </asp:HyperLinkField>
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
