<%@ Page language="c#" Inherits="sc.SelectedCourse" CodeFile="SelectedCourse.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="StudentHeadControl" Src="StudentHeadControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SelectedCourse</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
         <style type="text/css">
         body {
             background-image:url(img/bg6.jpg);
             background-size: cover; 
         }
     </style>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:StudentHeadControl id="StudentHeadControl1" runat="server"></uc1:StudentHeadControl>
			<asp:DataGrid id="dgCourse" style="Z-INDEX: 101; LEFT: 368px; POSITION: absolute; TOP: 394px" runat="server"
				BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4"
				AutoGenerateColumns="False" Width="737px">
				<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
				<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="CId" HeaderText="�γ̱��"></asp:BoundColumn>
					<asp:HyperLinkColumn DataNavigateUrlField="CId" DataNavigateUrlFormatString="ViewCourse.aspx?CId={0}"
						DataTextField="CName" HeaderText="�γ�����"></asp:HyperLinkColumn>
					<asp:HyperLinkColumn DataNavigateUrlField="TId" DataNavigateUrlFormatString="ViewTeacher.aspx?TId={0}"
						DataTextField="TName" HeaderText="�ڿ���ʦ"></asp:HyperLinkColumn>
					<asp:BoundColumn DataField="CCredit" HeaderText="�γ�ѧ��"></asp:BoundColumn>
					<asp:BoundColumn DataField="CType" HeaderText="�γ����"></asp:BoundColumn>
					<asp:BoundColumn DataField="Score" HeaderText="�γ̳ɼ�"></asp:BoundColumn>
					<asp:HyperLinkColumn Text="�Ͽ�ʱ��ص�" DataNavigateUrlField="CId" DataNavigateUrlFormatString="ViewCourseTime.aspx?CId={0}"></asp:HyperLinkColumn>
					<asp:ButtonColumn Text="ȡ��ѡ��" CommandName="Delete"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:Button id="btnLock" style="Z-INDEX: 102; LEFT: 789px; POSITION: absolute; TOP: 344px; bottom: 353px;" runat="server"
				Text="����ѡ����Ϣ" onclick="btnLock_Click"></asp:Button>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 373px; POSITION: absolute; TOP: 347px" runat="server">���Ѿ�ѡ�޵Ŀγ̣�</asp:Label>
			<asp:Label id="lbLock" style="Z-INDEX: 104; LEFT: 622px; POSITION: absolute; TOP: 348px" runat="server"></asp:Label>
		</form>
	</body>
</HTML>
