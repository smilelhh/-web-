<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAttendance.aspx.cs"
    Inherits="Web.teacherManPages.viewAttendance" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top:50px;">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="序号" ItemStyle-Width="80" DataField="ID">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="学号" ItemStyle-Width="80" DataField="stuId">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="姓名" ItemStyle-Width="80" DataField="name">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="性别" ItemStyle-Width="80" DataField="gender">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="出勤状态" ItemStyle-Width="80" DataField="status">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="备注" ItemStyle-Width="80" DataField="remark">
                    <ItemStyle></ItemStyle>
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
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </webdiyer:AspNetPager>
    </div>
    </form>
</body>
</html>
