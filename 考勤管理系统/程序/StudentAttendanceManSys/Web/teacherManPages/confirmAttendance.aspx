<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmAttendance.aspx.cs" Inherits="Web.teacherManPages.confirmAttendance" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align ="center">
        <asp:Label ID="confirmComplete" runat="server" Text="登记完成" Font-Size="XX-Large" 
            ForeColor="Red"></asp:Label>
            <br /><br /><br />
        <asp:LinkButton ID="continueAttendance" runat="server" Font-Size="XX-Large" onclick="continueAttendance_Click" 
            >继续登记考勤</asp:LinkButton>
        <br /><br /><br />
        <asp:LinkButton ID="viewAttendance" runat="server" Font-Size="XX-Large" 
            onclick="viewAttendance_Click">单击查看本次考勤记录</asp:LinkButton>
    </div>
    </form>
</body>
</html>
