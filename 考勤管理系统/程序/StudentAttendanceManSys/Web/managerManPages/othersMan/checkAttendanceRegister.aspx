<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkAttendanceRegister.aspx.cs"
    Inherits="Web.managerManPages.othersMan.checkAttendanceRegister" %>

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
        <asp:Label ID="Label1" runat="server" Text="查询周次:"></asp:Label>
        <asp:DropDownList ID="DropDownList_week" runat="server">
            <asp:ListItem>全部周次</asp:ListItem>
            <asp:ListItem>第1周</asp:ListItem>
            <asp:ListItem>第2周</asp:ListItem>
            <asp:ListItem>第3周</asp:ListItem>
            <asp:ListItem>第4周</asp:ListItem>
            <asp:ListItem>第5周</asp:ListItem>
            <asp:ListItem>第6周</asp:ListItem>
            <asp:ListItem>第7周</asp:ListItem>
            <asp:ListItem>第8周</asp:ListItem>
            <asp:ListItem>第9周</asp:ListItem>
            <asp:ListItem>第10周</asp:ListItem>
            <asp:ListItem>第11周</asp:ListItem>
            <asp:ListItem>第12周</asp:ListItem>
            <asp:ListItem>第13周</asp:ListItem>
            <asp:ListItem>第14周</asp:ListItem>
            <asp:ListItem>第15周</asp:ListItem>
            <asp:ListItem>第16周</asp:ListItem>
            <asp:ListItem>第17周</asp:ListItem>
            <asp:ListItem>第18周</asp:ListItem>
            <asp:ListItem>第19周</asp:ListItem>
            <asp:ListItem>第20周</asp:ListItem>
        </asp:DropDownList>
        &nbsp
        <asp:Button ID="search" runat="server" Text="查 询" OnClick="search_Click" Width="80px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 《 导出为excel文件 》<asp:ImageButton
            ID="ImageButton_excel" runat="server" Height="24px" 
            ImageUrl="~/images/excel.jpg" onclick="ImageButton_excel_Click" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="序号" HeaderStyle-Width="60" DataField="colNumber">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="周次" HeaderStyle-Width="60" DataField="week">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="星期" HeaderStyle-Width="60" DataField="weekDay">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="班级" HeaderStyle-Width="120" DataField="className">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="课程名称" HeaderStyle-Width="180" DataField="courseName">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="任课教师" HeaderStyle-Width="70" DataField="teacherName">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="上课地点" HeaderStyle-Width="90" DataField="place">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="上课时间" HeaderStyle-Width="70" DataField="courseTime">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="教师是否登记" HeaderStyle-Width="60" DataField="teacherRecord">
                </asp:BoundField>
                <asp:BoundField HeaderText="班长是否登记" HeaderStyle-Width="60" DataField="monitorRecord">
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
        </webdiyer:AspNetPager>
    </div>
    </form>
</body>
</html>
