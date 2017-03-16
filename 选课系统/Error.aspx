<%@ Page language="c#" Inherits="sc.Error" CodeFile="Error.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ดํฮ๓</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="หฮฬๅ">
				<asp:Label id="lbError" style="Z-INDEX: 101; LEFT: 504px; POSITION: absolute; TOP: 240px; bottom: 315px;" Runat="server"
					ForeColor="Red" Text=""></asp:Label>
				<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 480px; POSITION: absolute; TOP: 72px" runat="server"
					Font-Size="XX-Large" Font-Bold="True">ดํฮ๓ฃก</asp:Label>
				<asp:HyperLink id="HyperLink1" style="Z-INDEX: 103; LEFT: 832px; POSITION: absolute; TOP: 344px"
					runat="server" NavigateUrl="Login.aspx">สืาณ</asp:HyperLink>
				<asp:HyperLink id="HyperLink2" style="Z-INDEX: 104; LEFT: 888px; POSITION: absolute; TOP: 344px"
					runat="server" NavigateUrl="javascript:history.go(-1)">บ๓อห</asp:HyperLink></FONT>
		</form>
	</body>
</HTML>
