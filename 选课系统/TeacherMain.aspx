<%@ Page language="c#" Inherits="sc.TeacherMain" CodeFile="TeacherMain.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="TeacherHeadControl" Src="TeacherHeadControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>TeacherMain</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:TeacherHeadControl id="TeacherHeadControl1" runat="server"></uc1:TeacherHeadControl>
			<asp:DataGrid id="dgCourse" style="Z-INDEX: 101; LEFT: 40px; POSITION: absolute; TOP: 168px" runat="server"
				Width="880px" Height="56px" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" BackColor="White"
				CellPadding="4" AutoGenerateColumns="False">
				<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
				<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="CId" HeaderText="�γ̱��"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="TId" HeaderText="��ʦ���"></asp:BoundColumn>
					<asp:BoundColumn DataField="CName" HeaderText="�γ�����"></asp:BoundColumn>
					<asp:BoundColumn DataField="CType" HeaderText="�γ����"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="CPreCId" HeaderText="ǰ���γ̱��"></asp:BoundColumn>
					<asp:BoundColumn DataField="CPreCName" HeaderText="ǰ���γ�"></asp:BoundColumn>
					<asp:BoundColumn DataField="CCredit" HeaderText="ѧ��"></asp:BoundColumn>
					<asp:BoundColumn DataField="CMax" HeaderText="�������"></asp:BoundColumn>
					<asp:BoundColumn HeaderText="��ѡ����"></asp:BoundColumn>
					<asp:HyperLinkColumn Text="�����ɼ�" DataNavigateUrlField="CId" DataNavigateUrlFormatString="SC.aspx?CId={0}"></asp:HyperLinkColumn>
					<asp:HyperLinkColumn Text="ʱ��ص����" DataNavigateUrlField="CId" DataNavigateUrlFormatString="CourseTime.aspx?CId={0}"></asp:HyperLinkColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 40px; POSITION: absolute; TOP: 128px; right: 1146px;" runat="server"
				Font-Bold="True" ForeColor="SeaGreen">����ǰ����Ŀγ̣�</asp:Label>
			<asp:Label id="lbCount" style="Z-INDEX: 103; LEFT: 208px; POSITION: absolute; TOP: 128px" runat="server"></asp:Label>
		</form>
	</body>
</HTML>
