<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="punishStudentShow.aspx.cs"
    Inherits="Web.managerManPages.teacherAttendance.punishStudentShow" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 10px;">
        <b style="color: Red;">旷课<asp:Label ID="Label_schoolHour" runat="server" Text="Label">学时的学生名单</asp:Label></b>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True" RowStyle-HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="序号" HeaderStyle-Width="90" DataField="colNumber">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="姓名" HeaderStyle-Width="90" DataField="name">
                    <ItemStyle />
                </asp:BoundField>
                <asp:BoundField HeaderText="班级" HeaderStyle-Width="120" DataField="className">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="旷课" HeaderStyle-Width="90" DataField="truancy">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="迟到" HeaderStyle-Width="90" DataField="late">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="早退" HeaderStyle-Width="90" DataField="leaveEarly">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="事假" HeaderStyle-Width="90" DataField="thingLeave">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="病假" HeaderStyle-Width="90" DataField="sickLeave">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:HyperLinkField HeaderText="详细记录" Text="详细记录" DataNavigateUrlFields="studID"
                    DataNavigateUrlFormatString="punishStudentDetail.aspx?studID={0}" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
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
