<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewStudentsAttendance.aspx.cs"
    Inherits="Web.teacherManPages.viewStudentsAttendance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Label ID="className" runat="server" Text="Label" Font-Size="X-Large" 
            ForeColor="Red"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="班学生出勤情况统计" Font-Size="X-Large" ForeColor="Red"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 《 导出为excel文件 》<asp:ImageButton
            ID="ImageButton_excel" runat="server" Height="24px" 
            ImageUrl="~/images/excel.jpg" onclick="ImageButton_excel_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="colNumber" HeaderText="序号" ItemStyle-Width="80">
                    <ItemStyle Width="80px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="name" HeaderText="姓名" ItemStyle-Width="90">
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="truancy" HeaderText="旷课" ItemStyle-Width="80">
                    <ItemStyle Width="80px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="late" HeaderText="迟到" ItemStyle-Width="80">
                    <ItemStyle Width="80px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="leaveEarly" HeaderText="早退" ItemStyle-Width="80">
                    <ItemStyle Width="80px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="thingLeave" HeaderText="事假" ItemStyle-Width="80">
                    <ItemStyle Width="80px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="sickleave" HeaderText="病假" ItemStyle-Width="80">
                    <ItemStyle Width="80px"></ItemStyle>
                </asp:BoundField>
                <asp:HyperLinkField HeaderText="详细记录" Text="详细记录" DataNavigateUrlFields="studID"
                    DataNavigateUrlFormatString="detailedRecords.aspx?studID={0}" />
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
