<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editCourseTable.aspx.cs"
    Inherits="Web.managerManPages.manageCourses.editCourseTable" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../../css/manCommon.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" align="center">
        <table style="margin-top: 30px; width: 40%;" cellspacing="0">
            <tr class="headRow" align="center">
                <td colspan="2" style="color: White;">
                    请填写课程安排信息
                </td>
            </tr>
            <tr class="tipRow">
                <td colspan="2" style="color: #F02613; border-bottom: solid 1px #389AD0;" align="center">
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right" class="td_left">
                    课程名称：
                </td>
                <td align="left" >
                    &nbsp;&nbsp;
                    <asp:Label ID="Label_course" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    任课老师：
                </td>
                <td align="left">
                    &nbsp;&nbsp;
                    <asp:Label ID="Label_teacher" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    班级名称：
                </td>
                <td align="left">
                    &nbsp;&nbsp;
                    <asp:Label ID="Label_class" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    学期&nbsp;：
                </td>
                <td align="left">
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList_semester_from" runat="server" 
                        AutoPostBack="True" 
                        onselectedindexchanged="DropDownList_semester_from_SelectedIndexChanged">
                        <asp:ListItem>2002</asp:ListItem>
                        <asp:ListItem>2003</asp:ListItem>
                        <asp:ListItem>2004</asp:ListItem>
                        <asp:ListItem>2005</asp:ListItem>
                        <asp:ListItem>2006</asp:ListItem>
                        <asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2008</asp:ListItem>
                        <asp:ListItem>2009</asp:ListItem>
                        <asp:ListItem>2010</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2019</asp:ListItem>
                        <asp:ListItem>2020</asp:ListItem>
                    </asp:DropDownList>
                    到
                    <asp:DropDownList ID="DropDownList_semester_to" runat="server" 
                        onselectedindexchanged="DropDownList_semester_to_SelectedIndexChanged" 
                        AutoPostBack="True">
                        <asp:ListItem>2003</asp:ListItem>
                        <asp:ListItem>2004</asp:ListItem>
                        <asp:ListItem>2005</asp:ListItem>
                        <asp:ListItem>2006</asp:ListItem>
                        <asp:ListItem>2007</asp:ListItem>
                        <asp:ListItem>2008</asp:ListItem>
                        <asp:ListItem>2009</asp:ListItem>
                        <asp:ListItem>2010</asp:ListItem>
                        <asp:ListItem>2011</asp:ListItem>
                        <asp:ListItem>2012</asp:ListItem>
                        <asp:ListItem>2013</asp:ListItem>
                        <asp:ListItem>2014</asp:ListItem>
                        <asp:ListItem>2015</asp:ListItem>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2019</asp:ListItem>
                        <asp:ListItem>2020</asp:ListItem>
                    </asp:DropDownList>
                    学年
                    <asp:DropDownList ID="DropDownList_semester_end" runat="server">
                        <asp:ListItem>上学期</asp:ListItem>
                        <asp:ListItem>下学期</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    周次&nbsp;：
                </td>
                <td align="left">
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList_week_from" runat="server" 
                        onselectedindexchanged="DropDownList_week_from_SelectedIndexChanged" 
                        AutoPostBack="True">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                    </asp:DropDownList>
                    到<asp:DropDownList ID="DropDownList_week_to" runat="server" 
                        onselectedindexchanged="DropDownList_week_to_SelectedIndexChanged" 
                        AutoPostBack="True">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                    </asp:DropDownList>
                    周
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    星期&nbsp;：
                </td>
                <td align="left">
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList_weekDay" runat="server">
                        <asp:ListItem>星期一</asp:ListItem>
                        <asp:ListItem>星期二</asp:ListItem>
                        <asp:ListItem>星期三</asp:ListItem>
                        <asp:ListItem>星期四</asp:ListItem>
                        <asp:ListItem>星期五</asp:ListItem>
                        <asp:ListItem>星期六</asp:ListItem>
                        <asp:ListItem>星期天</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    上课地点：
                </td>
                <td align="left">
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox_place" runat="server" class="textBox"></asp:TextBox>
                    <asp:CustomValidator ID="checkPlace" runat="server" ErrorMessage="CustomValidator"
                        ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr class="infoRow" style="height: 35px;">
                <td align="right">
                    上课时间：
                </td>
                <td align="left">
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList_courseTime" runat="server">
                        <asp:ListItem>1-2</asp:ListItem>
                        <asp:ListItem>3-4</asp:ListItem>
                        <asp:ListItem>5-6</asp:ListItem>
                        <asp:ListItem>7-8</asp:ListItem>
                        <asp:ListItem>9-10</asp:ListItem>
                        <asp:ListItem>5-7</asp:ListItem>
                    </asp:DropDownList>
                    节
                </td>
            </tr>
            <tr class="footRow">
                <td align="center" colspan="2">
                    <asp:ImageButton ID="ImageButton_submit" runat="server" ImageUrl="~/images/submit.jpg"
                        OnClick="ImageButton_submit_Click" />
                    <asp:ImageButton ID="ImageButton_back" runat="server" ImageUrl="~/images/back.jpg"
                        OnClick="ImageButton_back_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
