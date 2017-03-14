<%@ Register TagPrefix="uc1" TagName="StudentHeadControl" Src="StudentHeadControl.ascx" %>
<%@ Page language="c#" Inherits="sc.Student" CodeFile="Student.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Student</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lbSId" style="Z-INDEX: 104; LEFT: 240px; POSITION: absolute; TOP: 136px" runat="server"></asp:Label>
			<asp:TextBox id="txtKeyConfirm" style="Z-INDEX: 118; LEFT: 680px; POSITION: absolute; TOP: 184px"
				runat="server" TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtKey" style="Z-INDEX: 117; LEFT: 680px; POSITION: absolute; TOP: 128px" runat="server"
				TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtSPhone" style="Z-INDEX: 116; LEFT: 240px; POSITION: absolute; TOP: 432px"
				runat="server"></asp:TextBox>
			<asp:TextBox id="txtSAddress" style="Z-INDEX: 115; LEFT: 240px; POSITION: absolute; TOP: 384px"
				runat="server"></asp:TextBox>
			<asp:TextBox id="txtSAge" style="Z-INDEX: 114; LEFT: 240px; POSITION: absolute; TOP: 296px" runat="server"></asp:TextBox>
			<asp:Label id="Label11" style="Z-INDEX: 113; LEFT: 576px; POSITION: absolute; TOP: 192px" runat="server">����ȷ��</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 112; LEFT: 576px; POSITION: absolute; TOP: 128px" runat="server">������</asp:Label>
			<asp:Label id="lbSCredit" style="Z-INDEX: 111; LEFT: 240px; POSITION: absolute; TOP: 344px"
				runat="server"></asp:Label>
			<asp:Label id="Label9" style="Z-INDEX: 110; LEFT: 136px; POSITION: absolute; TOP: 296px" runat="server">����</asp:Label>
			<asp:Label id="Label8" style="Z-INDEX: 109; LEFT: 136px; POSITION: absolute; TOP: 240px" runat="server">�Ա�</asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 108; LEFT: 136px; POSITION: absolute; TOP: 344px" runat="server">ѧ��</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 107; LEFT: 136px; POSITION: absolute; TOP: 392px" runat="server">��ַ</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 106; LEFT: 136px; POSITION: absolute; TOP: 184px" runat="server">����</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 136px; POSITION: absolute; TOP: 440px" runat="server">�绰</asp:Label>
			<uc1:StudentHeadControl id="StudentHeadControl1" runat="server"></uc1:StudentHeadControl>
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 136px; POSITION: absolute; TOP: 136px" runat="server">ѧ��</asp:Label>
			<asp:TextBox id="txtSName" style="Z-INDEX: 102; LEFT: 240px; POSITION: absolute; TOP: 176px"
				runat="server"></asp:TextBox>
			<asp:DropDownList id="ddlSSex" style="Z-INDEX: 103; LEFT: 240px; POSITION: absolute; TOP: 232px" runat="server"
				Width="88px">
				<asp:ListItem Value="��" Selected="True">��</asp:ListItem>
				<asp:ListItem Value="Ů">Ů</asp:ListItem>
			</asp:DropDownList>
			<asp:Button id="btnUpdateKey" style="Z-INDEX: 119; LEFT: 648px; POSITION: absolute; TOP: 256px"
				runat="server" Text="�޸�����" onclick="btnUpdateKey_Click"></asp:Button>
			<asp:Button id="btnUpdate" style="Z-INDEX: 120; LEFT: 192px; POSITION: absolute; TOP: 496px"
				runat="server" Text="�޸���Ϣ" Width="104px" Height="32px" onclick="btnUpdate_Click"></asp:Button>
		</form>
	</body>
</HTML>
