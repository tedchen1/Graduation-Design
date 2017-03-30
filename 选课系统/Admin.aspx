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
     <style type="text/css">
         body {
             background-image:url(img/bg3.jpg);
             background-size: cover; 
         }
     </style>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<uc1:AdminHeaderControl id="AdminHeaderControl1" runat="server"></uc1:AdminHeaderControl>
				<asp:Label id="lbTime" style="Z-INDEX: 101; LEFT: 379px; POSITION: absolute; TOP: 271px" runat="server"></asp:Label>
				<asp:LinkButton id="lbtnNew" style="Z-INDEX: 102; LEFT: 365px; POSITION: absolute; TOP: 319px" runat="server" onclick="lbtnNew_Click">设置新的选课时间</asp:LinkButton>
				<asp:Label id="Label2" style="Z-INDEX: 103; LEFT: 383px; POSITION: absolute; TOP: 378px" runat="server">从</asp:Label>
				<asp:TextBox id="txttimeStart" style="Z-INDEX: 104; LEFT: 443px; POSITION: absolute; TOP: 377px; right: 779px; width: 153px;"
					runat="server"></asp:TextBox>
				<asp:TextBox id="txtTimeEnd" style="Z-INDEX: 105; LEFT: 691px; POSITION: absolute; TOP: 376px; width: 153px;"
					runat="server"></asp:TextBox>
				<asp:Label id="Label3" style="Z-INDEX: 106; LEFT: 643px; POSITION: absolute; TOP: 378px; height: 20px;" runat="server">到</asp:Label>
				<asp:Button id="btnNew" style="Z-INDEX: 107; LEFT: 598px; POSITION: absolute; TOP: 447px" runat="server"
					Text="设置" Width="72px" onclick="btnNew_Click"></asp:Button>
				<asp:Label id="Label1" style="Z-INDEX: 108; LEFT: 871px; POSITION: absolute; TOP: 377px" runat="server">例如：2005-02-01</asp:Label></FONT>
		</form>
	</body>
</HTML>
