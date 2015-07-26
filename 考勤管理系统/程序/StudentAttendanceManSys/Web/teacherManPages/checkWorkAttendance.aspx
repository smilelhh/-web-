<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="checkWorkAttendance.aspx.cs"
    Inherits="Web.teacherManPages.checkWorkAttendance" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 20px;">
        <asp:Label ID="Label1" runat="server" Text="查询周次:"></asp:Label>
        <asp:DropDownList ID="weekId" runat="server">
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
        <asp:Button ID="search" runat="server" Text="查询" OnClick="search_Click" />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="序号" HeaderStyle-Width="60" DataField="ID">
                    <HeaderStyle Width="60px"></HeaderStyle>
                    <ItemStyle Width="60px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="周次" HeaderStyle-Width="60" DataField="week">
                    <HeaderStyle Width="60px"></HeaderStyle>
                    <ItemStyle Width="60px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="星期" HeaderStyle-Width="60" DataField="weekDay">
                    <HeaderStyle Width="60px"></HeaderStyle>
                    <ItemStyle Width="60px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="班级" HeaderStyle-Width="120" DataField="className">
                    <HeaderStyle Width="120px"></HeaderStyle>
                    <ItemStyle Width="80px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="课程名称" HeaderStyle-Width="180" DataField="courseName">
                    <HeaderStyle Width="180px"></HeaderStyle>
                    <ItemStyle Width="100px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="任课教师" HeaderStyle-Width="70" DataField="teacherName">
                    <HeaderStyle Width="70px"></HeaderStyle>
                    <ItemStyle Width="70px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="上课地点" HeaderStyle-Width="90" DataField="place">
                    <HeaderStyle Width="90px"></HeaderStyle>
                    <ItemStyle Width="90px"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="上课时间" HeaderStyle-Width="70" DataField="courseTime">
                    <HeaderStyle Width="70px"></HeaderStyle>
                    <ItemStyle Width="70px"></ItemStyle>
                </asp:BoundField>
                <asp:TemplateField HeaderText="教师是否登记" ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" Text='<%# Eval("recorderID") %>'
                            OnClick="LinkButton1_Click" CommandArgument='<%# Eval("courTableID") %>'></asp:LinkButton>
                    </ItemTemplate>
                    <ControlStyle BackColor="#FFCCFF" BorderColor="Blue" ForeColor="Red" />
                    <ItemStyle Width="80px" />
                </asp:TemplateField>
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
