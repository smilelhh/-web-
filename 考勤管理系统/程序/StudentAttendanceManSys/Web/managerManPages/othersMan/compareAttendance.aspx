<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compareAttendance.aspx.cs"
    Inherits="Web.managerManPages.othersMan.compareAttendance" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 10px;">
        <b>
            <asp:Label ID="Label1" runat="server" Text="按班级查询:"></asp:Label>
            <asp:DropDownList ID="DropDownList_class" runat="server">
            </asp:DropDownList>
            &nbsp
            <asp:Button ID="search" runat="server" Text="查 询" OnClick="search_Click" Width="80px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 《 导出为excel文件 》<asp:ImageButton
                ID="ImageButton_excel" runat="server" Height="24px" 
            ImageUrl="~/images/excel.jpg" onclick="ImageButton_excel_Click" />
        </b>
        <br />
        <b style="color: Red;">《<asp:Label ID="Label_className" runat="server" Text="Label"></asp:Label>》&nbsp;班学生出勤情况统计
        </b>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True" OnRowCreated="GridView1_RowCreated">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="序号" DataField="colNumber" />
                <asp:BoundField HeaderText="姓名" DataField="name" />
                <asp:BoundField HeaderText="班级" DataField="className" />
                <asp:BoundField HeaderText="旷课" DataField="t_truancy" />
                <asp:BoundField HeaderText="迟到" DataField="t_late" />
                <asp:BoundField HeaderText="早退" DataField="t_leaveEarly" />
                <asp:BoundField HeaderText="事假" DataField="t_thingLeave" />
                <asp:BoundField HeaderText="病假" DataField="t_sickleave" />
                <asp:HyperLinkField HeaderText="详细记录" Text="查看" DataNavigateUrlFields="studID" DataNavigateUrlFormatString="manageCourseTable.aspx?studID={0}&recorder=1">
                </asp:HyperLinkField>
                <asp:BoundField HeaderText="旷课" DataField="m_truancy" />
                <asp:BoundField HeaderText="迟到" DataField="m_late" />
                <asp:BoundField HeaderText="早退" DataField="m_leaveEarly" />
                <asp:BoundField HeaderText="事假" DataField="m_thingLeave" />
                <asp:BoundField HeaderText="病假" DataField="m_sickleave" />
                <asp:HyperLinkField HeaderText="详细记录" Text="查看" DataNavigateUrlFields="studID" DataNavigateUrlFormatString="manageCourseTable.aspx?studID={0}&recorder=2">
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
