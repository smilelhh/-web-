<%@ Page Language="C#" MasterPageFile="~/mainPages/menu.Master" AutoEventWireup="true"
    CodeBehind="index.aspx.cs" Inherits="Web.mainPage.index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_head" runat="server">
    <%--<meta http-equiv="refresh" content="300" />--%>
    <link href="../css/index.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function doAction(strtitle) {
            var title = document.getElementById("title");
            title.innerHTML = strtitle;
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div>
            <div class="index_header_left">
                <img alt="" src="../images/left-top-right.gif" /></div>
            <div class="index_header_center">
                <div id="title" class="title">
                    欢迎界面</div>
            </div>
            <div class="index_header_right">
                <img alt="" src="../images/nav-right-bg.gif" />
            </div>
            <div class="clear">
            </div>
        </div>
        <div style="height: 90%;">
            <div class="index_content_left">
            </div>
            <div class="index_content_center">
                <iframe name="frame" src="welcome.aspx" scrolling="yes" frameborder="0" width="100%" height="100%">
                </iframe>
            </div>
            <div class="index_content_right">
            </div>
            <div class="clear">
            </div>
        </div>
        <div>
            <div class="index_footer_left">
                <img alt="" src="../images/buttom_left2.gif" />
            </div>
            <div class="index_footer_center">
                <img alt="" src="../images/buttom_bgs.gif" />
            </div>
            <div class="index_footer_right">
                <img alt="" src="../images/buttom_right2.gif" />
            </div>
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
