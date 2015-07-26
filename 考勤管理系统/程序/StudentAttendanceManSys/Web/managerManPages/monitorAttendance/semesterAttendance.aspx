<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="semesterAttendance.aspx.cs"
    Inherits="Web.managerManPages.monitorAttendance.semesterAttendance" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 50px;">
        <div>
            <div align="center">
                <asp:Label ID="Label1" runat="server" Text="全院平均到课率:" Style="margin-left: 400px;"></asp:Label>
                <asp:Label ID="Label_attendRate" runat="server" Text="Label"></asp:Label>
            </div>
            <br />
            <b style="color: Red;">开学以来各班平均到课率查询</b>
        </div>
        <div style="margin-top: 20px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True" RowStyle-HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="序号" HeaderStyle-Width="100" DataField="colNumber">
                        <ItemStyle></ItemStyle>
                        <HeaderStyle Width="100px"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="班级" HeaderStyle-Width="120" DataField="class">
                        <HeaderStyle Width="120px"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="开学以来平均到课率%" HeaderStyle-Width="180" DataField="semesterAttendaceRate">
                        <ItemStyle></ItemStyle>
                        <HeaderStyle Width="180px"></HeaderStyle>
                    </asp:BoundField>
                    <asp:HyperLinkField HeaderText="各周平均到课率" Text="查看" DataNavigateUrlFields="classID"
                        DataNavigateUrlFormatString="classWeekAttendance.aspx?classID={0}" />
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
    </div>
    </form>
</body>
</html>
