<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="averageWeeklyAttendance.aspx.cs"
    Inherits="Web.managerManPages.monitorAttendance.averageWeeklyAttendance" %>

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
                查询周次
                <asp:DropDownList ID="weekId" runat="server">
                    <asp:ListItem>全部周次</asp:ListItem>
                    <asp:ListItem Value="1">第1周</asp:ListItem>
                    <asp:ListItem Value="2">第2周</asp:ListItem>
                    <asp:ListItem Value="3">第3周</asp:ListItem>
                    <asp:ListItem Value="4">第4周</asp:ListItem>
                    <asp:ListItem Value="5">第5周</asp:ListItem>
                    <asp:ListItem Value="6">第6周</asp:ListItem>
                    <asp:ListItem Value="7">第7周</asp:ListItem>
                    <asp:ListItem Value="8">第8周</asp:ListItem>
                    <asp:ListItem Value="9">第9周</asp:ListItem>
                    <asp:ListItem Value="10">第10周</asp:ListItem>
                    <asp:ListItem Value="11">第11周</asp:ListItem>
                    <asp:ListItem Value="12">第12周</asp:ListItem>
                    <asp:ListItem Value="13">第13周</asp:ListItem>
                    <asp:ListItem Value="14">第14周</asp:ListItem>
                    <asp:ListItem Value="15">第15周</asp:ListItem>
                    <asp:ListItem Value="16">第16周</asp:ListItem>
                    <asp:ListItem Value="17">第17周</asp:ListItem>
                    <asp:ListItem Value="18">第18周</asp:ListItem>
                    <asp:ListItem Value="19">第19周</asp:ListItem>
                    <asp:ListItem Value="20">第20周</asp:ListItem>
                </asp:DropDownList>
                &nbsp;
                <asp:Button ID="search" runat="server" Text="查询" OnClick="search_Click" />
                <asp:Label ID="Label2" runat="server" Text="《导出为excel文件》" Style="margin-left: 200px;"></asp:Label>
                <asp:ImageButton ID="ImageButton_excel" runat="server" Height="24px" 
                    ImageUrl="~/images/excel.jpg" onclick="ImageButton_excel_Click" />
                <br />
                <asp:Label ID="Label1" runat="server" Text="全院平均到课率:" Style="margin-left: 400px;"></asp:Label>
                <asp:Label ID="Label_attendRate" runat="server" Text="Label"></asp:Label>
            </div>
            <br />
            <b style="color: Red;">各班周到课率查询 </b>
        </div>
        <div style="margin-top: 20px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True" RowStyle-HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="序号" HeaderStyle-Width="100" DataField="colNumber">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="周次" HeaderStyle-Width="100" DataField="week">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="班级" HeaderStyle-Width="120" DataField="class"></asp:BoundField>
                    <asp:BoundField HeaderText="周平均到课率%" HeaderStyle-Width="180" DataField="AverageAttendaceRate">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:HyperLinkField HeaderText="到课率详细信息" Text="查看" DataNavigateUrlFields="classID,week"
                        DataNavigateUrlFormatString="attendanceDetail.aspx?classID={0}&week={1}" />
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
