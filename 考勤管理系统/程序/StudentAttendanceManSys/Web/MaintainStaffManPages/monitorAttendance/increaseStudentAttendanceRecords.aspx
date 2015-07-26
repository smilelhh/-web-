<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="increaseStudentAttendanceRecords.aspx.cs"
    Inherits="Web.MaintainStaffManPages.monitorAttendance.increaseStudentAttendanceRecords" %>

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
        .style2
        {
            height: 21px;
        }
        .style3
        {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin-top: 50px;">
        <div>
            <b style="color: Red;">增加学生考勤记录 </b>
        </div>
        <div style="margin-top: 50px; margin-left: 300px;">
            <table class="style1" align="center">
                <tr>
                    <td class="style3">
                        班级：
                    </td>
                    <td class="style3">
                        <asp:DropDownList ID="DropDownList_class" runat="server" Style="margin-left: 0px"
                            Width="100px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_class_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        课程名称：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_course" runat="server" Width="250px" AutoPostBack="True"
                            OnSelectedIndexChanged="DropDownList_course_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        任课教师：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_teacher" runat="server" Width="250px" AutoPostBack="True"
                            OnSelectedIndexChanged="DropDownList_teacher_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        学生姓名：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_student" runat="server" Width="80px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        考勤情况：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_status" runat="server" Width="60px">
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
                    <td class="style3">
                        周次：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_week" runat="server" Width="80px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        星期：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_weekDay" runat="server" Width="80px" AutoPostBack="True"
                            OnSelectedIndexChanged="DropDownList_weekDay_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        上课时间：
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList_courseTime" runat="server" Width="80px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style3">
                        上课地点：
                    </td>
                    <td>
                        <asp:Label ID="Label_place" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Label ID="Label_courTableId" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button_submit" runat="server" Text="确定" Width="80px" OnClick="Button_submit_Click" />
    </div>
    </form>
</body>
</html>
