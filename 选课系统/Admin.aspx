<%@ Page language="c#" Inherits="sc.Admin" CodeFile="Admin.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="AdminHeaderControl" Src="AdminHeaderControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Admin</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<uc1:AdminHeaderControl id="AdminHeaderControl1" runat="server"></uc1:AdminHeaderControl>
				<asp:Label id="lbTime" style="Z-INDEX: 101; LEFT: 256px; POSITION: absolute; TOP: 208px" runat="server"></asp:Label>
				<asp:LinkButton id="lbtnNew" style="Z-INDEX: 102; LEFT: 256px; POSITION: absolute; TOP: 272px" runat="server" onclick="lbtnNew_Click">�����µ�ѡ��ʱ��</asp:LinkButton>
				<asp:Label id="Label2" style="Z-INDEX: 103; LEFT: 304px; POSITION: absolute; TOP: 352px" runat="server">��</asp:Label>
				<asp:TextBox id="txttimeStart" style="Z-INDEX: 104; LEFT: 328px; POSITION: absolute; TOP: 352px"
					runat="server"></asp:TextBox>
				<asp:TextBox id="txtTimeEnd" style="Z-INDEX: 105; LEFT: 528px; POSITION: absolute; TOP: 352px"
					runat="server"></asp:TextBox>
				<asp:Label id="Label3" style="Z-INDEX: 106; LEFT: 496px; POSITION: absolute; TOP: 352px" runat="server">��</asp:Label>
				<asp:Button id="btnNew" style="Z-INDEX: 107; LEFT: 464px; POSITION: absolute; TOP: 408px" runat="server"
					Text="����" Width="72px" onclick="btnNew_Click"></asp:Button>
				<asp:Label id="Label1" style="Z-INDEX: 108; LEFT: 736px; POSITION: absolute; TOP: 352px" runat="server">���磺2005-02-01</asp:Label></FONT>
		</form>
	</body>
</HTML>
