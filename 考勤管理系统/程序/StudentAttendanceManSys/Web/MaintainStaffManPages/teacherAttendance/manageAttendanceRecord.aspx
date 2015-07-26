<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manageAttendanceRecord.aspx.cs"
    Inherits="Web.MaintainStaffManPages.teacherAttendance.manageAttendanceRecord" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 50px;">
        <div>
            <b>学生出勤记录管理 </b>
        </div>
        <div style="margin-top: 50px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True" RowStyle-HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="序号" HeaderStyle-Width="60" DataField="colNumber">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="姓名" HeaderStyle-Width="90" DataField="name">
                        <ItemStyle Width="90px" />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="班级" HeaderStyle-Width="120" DataField="className">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="出勤状态" HeaderStyle-Width="90" DataField="status"></asp:BoundField>
                    <asp:BoundField HeaderText="课程" HeaderStyle-Width="90" DataField="course"></asp:BoundField>
                    <asp:BoundField HeaderText="任课教师" HeaderStyle-Width="90" DataField="teacher" />
                    <asp:BoundField HeaderText="周次" HeaderStyle-Width="90" DataField="week"></asp:BoundField>
                    <asp:BoundField HeaderText="星期" HeaderStyle-Width="90" DataField="weekDay">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="上课时间" HeaderStyle-Width="90" DataField="courseTime">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="管理">
                        <ItemTemplate>
                            <asp:LinkButton ID="ImageButton_delete" runat="server" OnClick="ImageButton_delete_Click"
                                OnClientClick="return confirm('确定删除该数据吗？');" CommandArgument='<%# Eval("ID") %>'>删除</asp:LinkButton>
                            <asp:LinkButton ID="ImageButton_edit" runat="server" OnClick="ImageButton_edit_Click"
                                CommandArgument='<%# Eval("ID") %>'>修改</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
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
