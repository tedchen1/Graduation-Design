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
    <style type="text/css">
<!--
body { background-image: url(img/main.jpg);
}
        </style>
	<body>

		<form id="Form1" method="post" runat="server">
             <div align="center"></div>
			 <FONT face="宋体">
				<asp:dropdownlist id="ddlType" style="Z-INDEX: 103; LEFT: 614px; POSITION: absolute; TOP: 389px; width: 97px;" tabIndex="2"
					runat="server">
					<asp:ListItem Value="1">学生</asp:ListItem>
					<asp:ListItem Value="2">教师</asp:ListItem>
					<asp:ListItem Value="3">系统管理员</asp:ListItem>
				</asp:dropdownlist><asp:textbox id="txtKey" style="Z-INDEX: 102; LEFT: 611px; POSITION: absolute; TOP: 334px; width: 150px;" tabIndex="1"
					runat="server" MaxLength="20" TextMode="Password"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 105; LEFT: 504px; POSITION: absolute; TOP: 287px; right: 791px;" runat="server">用户名：</asp:label><asp:label id="Label3" style="Z-INDEX: 106; LEFT: 508px; POSITION: absolute; TOP: 335px" runat="server">密     码：</asp:label><asp:label id="Label4" style="Z-INDEX: 107; LEFT: 510px; POSITION: absolute; TOP: 391px" runat="server">用户类型：</asp:label></FONT>
        
			
				<asp:button id="btnLogin" style="Z-INDEX: 104; LEFT: 573px; POSITION: absolute; TOP: 444px; width: 90px;"
					tabIndex="3" runat="server" Text="登  录" onclick="btnLogin_Click"></asp:button>
				

			<FONT face="宋体">
				<asp:textbox id="txtUser" style="Z-INDEX: 101; LEFT: 610px; POSITION: absolute; TOP: 289px; width: 150px;" runat="server" MaxLength="20"></asp:textbox></FONT>
        
			
				
				
         
            
         
        </form>
	</body>
</HTML>
