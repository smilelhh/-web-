<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="unCheckin.aspx.cs" Inherits="Web.teacherManPages.unCheckin" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../css/showCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <b style="color: Red;">《<asp:Label ID="className" runat="server" Text="班级"></asp:Label>》班考勤登记</b>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="序号" HeaderStyle-Width="60" DataField="ID">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="学号" HeaderStyle-Width="80" DataField="stuId">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="姓名" HeaderStyle-Width="80" DataField="name">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:BoundField HeaderText="性别" HeaderStyle-Width="80" DataField="gender">
                    <ItemStyle></ItemStyle>
                </asp:BoundField>
                <asp:TemplateField HeaderText="出勤状态" HeaderStyle-Width="90">
                    <ItemTemplate>
                        <asp:DropDownList ID="classState" runat="server">
                            <asp:ListItem>正常</asp:ListItem>
                            <asp:ListItem>旷课</asp:ListItem>
                            <asp:ListItem>迟到</asp:ListItem>
                            <asp:ListItem>早退</asp:ListItem>
                            <asp:ListItem>事假</asp:ListItem>
                            <asp:ListItem>病假</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="备注" HeaderStyle-Width="150">
                    <ItemTemplate>
                        <asp:TextBox ID="remak" runat="server"></asp:TextBox>
                    </ItemTemplate>
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
            LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" AlwaysShow="True" CurrentPageButtonClass="cpb"
            Style="margin-top: 20px;" OnPageChanging="AspNetPager1_PageChanging" OnPageChanged="AspNetPager1_PageChanged">
        </webdiyer:AspNetPager>
        <br />
        <asp:Button ID="submitCheck" runat="server" Text="确认" Font-Size="Large" ForeColor="#0099FF"
            OnClick="submitCheck_Click" />
    </div>
    </form>
</body>
</html>
