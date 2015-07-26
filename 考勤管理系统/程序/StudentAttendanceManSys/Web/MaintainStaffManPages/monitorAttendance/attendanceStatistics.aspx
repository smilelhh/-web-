<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="attendanceStatistics.aspx.cs"
    Inherits="Web.MaintainStaffManPages.monitorAttendance.attendanceStatistics" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 10px;">
        <div>
            <b>请选择学生所在的班级：<asp:DropDownList ID="DropDownList_class" runat="server" Height="16px"
                Width="120px">
            </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button_search" runat="server" Text="确  定" Width="80px" OnClick="Button_search_Click" />
                &nbsp; </b>
        </div>
        <br />
        <br />
        <div>
            <b style="color: Red;">《<asp:Label ID="Label_className" runat="server" Text=""></asp:Label>》&nbsp;班学生出勤情况统计
            </b>
        </div>
        <div style="margin-top: 20px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True" RowStyle-HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="序号" ItemStyle-Width="60" DataField="colNumber">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="姓名" ItemStyle-Width="100" DataField="name">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="className" HeaderText="班级" />
                    <asp:BoundField HeaderText="旷课" ItemStyle-Width="90" DataField="truancy">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="迟到" ItemStyle-Width="90" DataField="late">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="早退" ItemStyle-Width="90" DataField="leaveEarly">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="事假" ItemStyle-Width="90" DataField="thingLeave">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="病假" ItemStyle-Width="90" DataField="sickLeave">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:HyperLinkField HeaderText="管理" Text="管理" DataNavigateUrlFields="studID" DataNavigateUrlFormatString="manageAttendanceRecord.aspx?studID={0}" />
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
