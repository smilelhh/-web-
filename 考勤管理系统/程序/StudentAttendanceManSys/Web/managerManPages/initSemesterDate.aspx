<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="initSemesterDate.aspx.cs"
    Inherits="Web.managerManPages.initSemesterDate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <b style="font-size: x-large;">新学期日期初始化</b>
        <br />
        <br />
        <b>&nbsp;&nbsp;&nbsp;请正确选择开学第一天的日期，然后单击“确定”。</b>
        <br />
        <br />
        <asp:Calendar ID="Calendar_semester" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66"
            BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt"
            ForeColor="#663399" Height="300px" ShowGridLines="True" Width="320px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
        <br />
        <asp:Button ID="Button_submit" runat="server" Text="确定" 
            onclick="Button_submit_Click" />
    </div>
    </form>
</body>
</html>
