<%@ Page language="c#" Inherits="sc.Teacher" CodeFile="Teacher.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="TeacherHeadControl" Src="TeacherHeadControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Teacher</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 128px; POSITION: absolute; TOP: 352px" runat="server">��ʦ�����ʼ�</asp:Label>
			<asp:TextBox id="txtKeyConfirm" style="Z-INDEX: 116; LEFT: 664px; POSITION: absolute; TOP: 192px"
				runat="server" TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtTMail" style="Z-INDEX: 115; LEFT: 264px; POSITION: absolute; TOP: 352px"
				runat="server"></asp:TextBox>
			<asp:TextBox id="txtTAge" style="Z-INDEX: 114; LEFT: 264px; POSITION: absolute; TOP: 272px" runat="server"></asp:TextBox>
			<asp:TextBox id="txtKey" style="Z-INDEX: 113; LEFT: 664px; POSITION: absolute; TOP: 152px" runat="server"
				TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtTPhone" style="Z-INDEX: 112; LEFT: 264px; POSITION: absolute; TOP: 312px"
				runat="server"></asp:TextBox>
			<asp:Label id="Label7" style="Z-INDEX: 109; LEFT: 128px; POSITION: absolute; TOP: 192px" runat="server">��ʦ����</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 108; LEFT: 128px; POSITION: absolute; TOP: 152px" runat="server">��ʦ���</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 107; LEFT: 128px; POSITION: absolute; TOP: 272px" runat="server">��ʦ����</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 106; LEFT: 128px; POSITION: absolute; TOP: 232px" runat="server">��ʦ�Ա�</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 312px" runat="server">��ʦ�绰</asp:Label>
			<uc1:TeacherHeadControl id="TeacherHeadControl1" runat="server"></uc1:TeacherHeadControl>
			<asp:Label id="lbTId" style="Z-INDEX: 101; LEFT: 264px; POSITION: absolute; TOP: 152px" runat="server"></asp:Label>
			<asp:TextBox id="txtTName" style="Z-INDEX: 102; LEFT: 264px; POSITION: absolute; TOP: 192px"
				runat="server"></asp:TextBox>
			<asp:DropDownList id="ddlTSex" style="Z-INDEX: 103; LEFT: 264px; POSITION: absolute; TOP: 232px" runat="server"
				Width="96px"></asp:DropDownList>
			<asp:Label id="Label1" style="Z-INDEX: 117; LEFT: 528px; POSITION: absolute; TOP: 152px" runat="server">������</asp:Label>
			<asp:Label id="Label8" style="Z-INDEX: 118; LEFT: 528px; POSITION: absolute; TOP: 192px" runat="server">����ȷ��</asp:Label>
			<asp:Button id="btnUpdate" style="Z-INDEX: 119; LEFT: 224px; POSITION: absolute; TOP: 424px"
				runat="server" Text="�޸���Ϣ" Width="104px" Height="32px" onclick="btnUpdate_Click"></asp:Button>
			<asp:Button id="btnUpdatekey" style="Z-INDEX: 120; LEFT: 624px; POSITION: absolute; TOP: 264px"
				runat="server" Text="�޸�����" Width="104px" onclick="btnUpdatekey_Click"></asp:Button>
			</FORM>
			<FONT face="����"></FONT>
		</form>
	</body>
</HTML>
