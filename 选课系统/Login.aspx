<%@ Page language="c#" Inherits="sc.Login" CodeFile="Login.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>��½</title>
		<meta content="True" name="vs_snapToGrid">
		<meta content="True" name="vs_showGrid">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<asp:textbox id="txtUser" style="Z-INDEX: 101; LEFT: 456px; POSITION: absolute; TOP: 224px" runat="server"
					Width="175px" MaxLength="20"></asp:textbox>��ׯѧԺ<asp:button id="btnLogin" style="Z-INDEX: 104; LEFT: 496px; POSITION: absolute; TOP: 352px"
					tabIndex="3" runat="server" Width="93px" Text="��  ¼" onclick="btnLogin_Click"></asp:button><asp:dropdownlist id="ddlType" style="Z-INDEX: 103; LEFT: 496px; POSITION: absolute; TOP: 296px" tabIndex="2"
					runat="server">
					<asp:ListItem Value="1">ѧ��</asp:ListItem>
					<asp:ListItem Value="2">��ʦ</asp:ListItem>
					<asp:ListItem Value="3">ϵͳ����Ա</asp:ListItem>
				</asp:dropdownlist><asp:textbox id="txtKey" style="Z-INDEX: 102; LEFT: 456px; POSITION: absolute; TOP: 256px" tabIndex="1"
					runat="server" Width="175px" MaxLength="20" TextMode="Password"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 105; LEFT: 376px; POSITION: absolute; TOP: 224px" runat="server">�û�����</asp:label><asp:label id="Label3" style="Z-INDEX: 106; LEFT: 384px; POSITION: absolute; TOP: 256px" runat="server">���룺</asp:label><asp:label id="Label4" style="Z-INDEX: 107; LEFT: 384px; POSITION: absolute; TOP: 296px" runat="server">�û����ͣ�</asp:label></FONT></form>
	</body>
</HTML>
