<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewDetaiAttendance.aspx.cs"
    Inherits="Web.teacherManPages.viewDetaiAttendance" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

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
        <asp:Label ID="Label1" runat="server" Text="查看详细记录" Font-Bold="True" Font-Size="Larger"
            ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="colNumber" ItemStyle-Width="80px" HeaderText="序号">
                    <FooterStyle VerticalAlign="Middle" />
                    <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="className" ItemStyle-Width="120px" HeaderText="班级名称">
                    <ItemStyle Width="120px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="courseName" ItemStyle-Width="120px" HeaderText="课程名称">
                    <ControlStyle Font-Size="Medium" />
                    <ControlStyle Font-Size="Medium"></ControlStyle>
                    <ItemStyle Width="120px"></ItemStyle>
                </asp:BoundField>
                <asp:HyperLinkField DataNavigateUrlFields="classID,courId" DataNavigateUrlFormatString="viewStudentsAttendance.aspx?classID={0}&courId={1}"
                    HeaderText="查看" Text="查看">
                    <ControlStyle ForeColor="#0066FF" />
                    <ControlStyle ForeColor="#0066FF"></ControlStyle>
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
            <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>
            <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>
            <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>
            <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
        </asp:GridView>
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" CssClass="anpager" FirstPageText="首页"
            LastPageText="尾页" NextPageText="下一页" OnPageChanged="AspNetPager1_PageChanged"
            PrevPageText="上一页" AlwaysShow="True" CurrentPageButtonClass="cpb" Style="margin-top: 20px;">
        </webdiyer:AspNetPager>
    </div>
    </form>
</body>
</html>
