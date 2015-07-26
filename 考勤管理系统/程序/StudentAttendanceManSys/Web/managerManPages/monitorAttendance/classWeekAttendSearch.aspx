<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="classWeekAttendSearch.aspx.cs"
    Inherits="Web.managerManPages.monitorAttendance.classWeekAttendSearch" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
    <style type="text/css">
        .anpager .cpb
        {
            background: #1F3A87 none repeat scroll 0 0;
            border: 1px solid #CCCCCC;
            color: #FFFFFF;
            font-weight: bold;
            margin: 5px 4px 0 0;
            padding: 4px 5px 0;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            按班级查询：
            <asp:DropDownList ID="DropDownList_class" runat="server">
            </asp:DropDownList>
            &nbsp; 周次：
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
            &nbsp;
            <asp:Button ID="Button_search" runat="server" Text="查询" 
                onclick="Button_search_Click" />
        </div>
        <br />
        <div align="center">
            《<asp:Label ID="Label_className" runat="server" Text="Label"></asp:Label>》班《<asp:Label
                ID="Label_week" runat="server" Text="Label"></asp:Label>》出勤统计
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
                    <asp:BoundField HeaderText="周次" HeaderStyle-Width="90" DataField="week"></asp:BoundField>
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
                    <asp:BoundField HeaderText="病假" HeaderStyle-Width="90" DataField="sickleave">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:HyperLinkField HeaderText="详细记录" Text="详细记录" DataNavigateUrlFields="studID,week"
                        DataNavigateUrlFormatString="weekDetailedRecords.aspx?studID={0}&week={1}" />
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
