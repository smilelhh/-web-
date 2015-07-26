<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="advancedSearchAttendance.aspx.cs"
    Inherits="Web.managerManPages.teacherAttendace.advancedSearchAttendance" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            查询条件：<br />
            <asp:DropDownList ID="DropDownList_class" runat="server">
            </asp:DropDownList>
            &nbsp;
            <asp:DropDownList ID="DropDownList_course" runat="server">
            </asp:DropDownList>
            &nbsp;
            <asp:DropDownList ID="DropDownList_teacher" runat="server">
            </asp:DropDownList>
            &nbsp;
            <asp:DropDownList ID="DropDownList_week" runat="server">
                <asp:ListItem>周次</asp:ListItem>
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
            <asp:DropDownList ID="DropDownList_weekDay" runat="server">
                <asp:ListItem>星期</asp:ListItem>
                <asp:ListItem>星期一</asp:ListItem>
                <asp:ListItem>星期二</asp:ListItem>
                <asp:ListItem>星期三</asp:ListItem>
                <asp:ListItem>星期四</asp:ListItem>
                <asp:ListItem>星期五</asp:ListItem>
                <asp:ListItem>星期六</asp:ListItem>
            </asp:DropDownList>
            &nbsp;
            <asp:DropDownList ID="DropDownList_courseTime" runat="server">
                <asp:ListItem>上课时间</asp:ListItem>
                <asp:ListItem>1-2节</asp:ListItem>
                <asp:ListItem>3-4节</asp:ListItem>
                <asp:ListItem>5-6节</asp:ListItem>
                <asp:ListItem>7-8节</asp:ListItem>
                <asp:ListItem>9-10节</asp:ListItem>
                <asp:ListItem>5-7节</asp:ListItem>
            </asp:DropDownList>
            <br />
            排序条件：<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True">班级</asp:ListItem>
                <asp:ListItem>任课老师</asp:ListItem>
                <asp:ListItem>周次</asp:ListItem>
                <asp:ListItem>到课率</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True">升序</asp:ListItem>
                <asp:ListItem>降序</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button_search" runat="server" Text="查询" OnClick="Button_search_Click" />
        </div>
        <br />
        <div align="center">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
                ForeColor="#333333" GridLines="None" ShowHeaderWhenEmpty="True" RowStyle-HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="序号" HeaderStyle-Width="90" DataField="colNumber">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="周次" HeaderStyle-Width="90" DataField="week">
                        <ItemStyle />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="星期" HeaderStyle-Width="90" DataField="weekDay">
                        <ItemStyle />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="班级" HeaderStyle-Width="120" DataField="className">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="课程" HeaderStyle-Width="90" DataField="courseName">
                        <ItemStyle />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="任课老师" HeaderStyle-Width="90" DataField="teacherName">
                        <ItemStyle />
                    </asp:BoundField>
                    <asp:BoundField HeaderText="上课时间" HeaderStyle-Width="90" DataField="courseTime">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField HeaderText="到课率" HeaderStyle-Width="90" DataField="attendaceRate"
                        DataFormatString="{0}%">
                        <ItemStyle></ItemStyle>
                    </asp:BoundField>
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
