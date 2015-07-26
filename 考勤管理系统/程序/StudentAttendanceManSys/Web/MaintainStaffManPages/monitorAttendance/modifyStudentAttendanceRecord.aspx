<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modifyStudentAttendanceRecord.aspx.cs"
    Inherits="Web.MaintainStaffManPages.monitorAttendance.modifyStudentAttendanceRecord" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
    <style type="text/css">
        .style1
        {
            width: 70%;
        }
        
        .style4
        {
            height: 20px;
            width: 215px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 50px;">
        <div>
            <b style="color: Red;">要修改的学生考勤登记如下，请认真核实： </b>
        </div>
        <div style="margin-top: 50px; margin-left: 350px;">
            <table class="style1" align="center">
                <tr>
                    <td class="style4">
                        班级：
                    </td>
                    <td>
                        <asp:Label ID="Label_class" runat="server" ForeColor="Red" Text="Label" Width="120px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        课程名称：
                    </td>
                    <td>
                        <asp:Label ID="Label_course" runat="server" Text="Label" Width="120px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        任课教师：
                    </td>
                    <td>
                        <asp:Label ID="Label_teacher" runat="server" Text="Label" Width="80px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        学生姓名：
                    </td>
                    <td>
                        <asp:Label ID="Label_student" runat="server" ForeColor="Red" Text="Label" Width="80px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        原考勤记录：
                    </td>
                    <td>
                        <asp:Label ID="Label_oldStatus" runat="server" ForeColor="Blue" Text="Label" Width="80px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        现考勤记录改为：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_newStatus" runat="server" Width="80px">
                            <asp:ListItem>正常</asp:ListItem>
                            <asp:ListItem>旷课</asp:ListItem>
                            <asp:ListItem>迟到</asp:ListItem>
                            <asp:ListItem>早退</asp:ListItem>
                            <asp:ListItem>事假</asp:ListItem>
                            <asp:ListItem>病假</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        周次：
                    </td>
                    <td>
                        <asp:Label ID="Label_week" runat="server" ForeColor="Red" Text="Label" Width="80px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        星期：
                    </td>
                    <td>
                        <asp:Label ID="Label_weekDay" runat="server" Text="Label" Width="80px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        上课时间：
                    </td>
                    <td>
                        <asp:Label ID="Label_courseTime" runat="server" Text="Label" Width="80px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        上课地点：
                    </td>
                    <td>
                        <asp:Label ID="Label_place" runat="server" Text="Label" Width="100px"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <asp:Button ID="Button_submit" runat="server" Text="修 改" Width="80px" OnClick="Button_submit_Click" />
    </div>
    </form>
</body>
</html>
