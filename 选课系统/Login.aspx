<%@ Page language="c#" Inherits="sc.Login" CodeFile="Login.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>登陆</title>
		<meta content="True" name="vs_snapToGrid">
		<meta content="True" name="vs_showGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<asp:textbox id="txtUser" style="Z-INDEX: 101; LEFT: 456px; POSITION: absolute; TOP: 224px" runat="server"
					Width="175px" MaxLength="20"></asp:textbox><asp:dropdownlist id="ddlType" style="Z-INDEX: 103; LEFT: 496px; POSITION: absolute; TOP: 296px" tabIndex="2"
					runat="server">
					<asp:ListItem Value="1">学生</asp:ListItem>
					<asp:ListItem Value="2">教师</asp:ListItem>
					<asp:ListItem Value="3">系统管理员</asp:ListItem>
				</asp:dropdownlist><asp:textbox id="txtKey" style="Z-INDEX: 102; LEFT: 456px; POSITION: absolute; TOP: 256px" tabIndex="1"
					runat="server" Width="175px" MaxLength="20" TextMode="Password"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 105; LEFT: 376px; POSITION: absolute; TOP: 224px; right: 983px;" runat="server">用户名：</asp:label><asp:label id="Label3" style="Z-INDEX: 106; LEFT: 384px; POSITION: absolute; TOP: 256px" runat="server">密码：</asp:label><asp:label id="Label4" style="Z-INDEX: 107; LEFT: 384px; POSITION: absolute; TOP: 296px" runat="server">用户类型：</asp:label></FONT>
         
            <p>
			<FONT face="宋体">
				<asp:button id="btnLogin" style="Z-INDEX: 104; LEFT: 496px; POSITION: absolute; TOP: 352px"
					tabIndex="3" runat="server" Width="93px" Text="登  录" onclick="btnLogin_Click"></asp:button>
				<asp:image id="Image1" style="Z-INDEX: 108; LEFT: 229px; POSITION: absolute; TOP: -17px" runat="server"
					Width="1030px" ImageUrl="img/head.jpg" Height="192px" ImageAlign="Top" ></asp:image></FONT>
         
            </p>
         
        </form>
	</body>
</HTML>
