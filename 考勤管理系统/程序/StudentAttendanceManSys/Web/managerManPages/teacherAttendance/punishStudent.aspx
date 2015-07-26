<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="punishStudent.aspx.cs"
    Inherits="Web.managerManPages.teacherAttendace.punishStudent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/showCommon.css" />
    <style type="text/css">
        .button
        {
            margin-top: 10px;
            width: 250px;
            height: 35px;
        }
        p
        {
            margin: 0;
            padding: 0;
            margin-top: 10px;
            width: 300px;
            line-height: 35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div align="center">
            <b style="color: Red;">已达纪律处分学生出勤情况统计</b>
        </div>
        <br />
        <div>
            <div style="float: left; margin-left: 180px;">
                <div align="center">
                    <b>旷课分类</b>
                </div>
                <asp:Button ID="Button1" runat="server" Text="旷课1-8学时学生名单" class="button" 
                    onclick="Button1_Click" />
                <br />
                <asp:Button ID="Button2" runat="server" Text="旷课9学时学生名单" class="button" 
                    onclick="Button2_Click" />
                <br />
                <asp:Button ID="Button3" runat="server" Text="旷课10-19学时学生名单" class="button" 
                    onclick="Button3_Click" />
                <br />
                <asp:Button ID="Button4" runat="server" Text="旷课20-29学时学生名单" class="button" 
                    onclick="Button4_Click" />
                <br />
                <asp:Button ID="Button5" runat="server" Text="旷课30-39学时学生名单" class="button" 
                    onclick="Button5_Click" />
                <br />
                <asp:Button ID="Button6" runat="server" Text="旷课40-49学时学生名单" class="button" 
                    onclick="Button6_Click" />
                <br />
                <asp:Button ID="Button7" runat="server" Text="旷课50学时以上学生名单" class="button" 
                    onclick="Button7_Click" />
                <br />
                <asp:Button ID="Button8" runat="server" Text="旷课达纪律处分全部学生名单" class="button" 
                    onclick="Button8_Click" />
                <br />
            </div>
            <div style="float: right; margin-right: 200px;">
                <div align="center">
                    <b>处分说明</b>
                    <p>
                        旷课1-8学时者，给予警示教育</p>
                    <p>
                        旷课9学时者，给予通报批评</p>
                    <p>
                        旷课10-19学时者，给予警示处分</p>
                    <p>
                        旷课20-29学时者，给予严重警告处分</p>
                    <p>
                        旷课30-39学时者，给予记过处分</p>
                    <p>
                        旷课40-49学时者，给予留校查看处分</p>
                    <p>
                        旷课50学时者，给予开除学籍</p>
                </div>
            </div>
            &nbsp;
        </div>
    </div>
    </form>
</body>
</html>
