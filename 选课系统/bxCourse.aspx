<%@ Page language="c#" Inherits="sc.bxCourse" CodeFile="bxCourse.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="StudentHeadControl" Src="StudentHeadControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>bxCourse</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
         <style type="text/css">
         body {
             background-image:url(img/bg6.jpg);
             background-size: cover; 
         }
     </style>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<uc1:studentheadcontrol id="StudentHeadControl1" runat="server"></uc1:studentheadcontrol><br>
			<br>
			<asp:DataGrid id="dgCourse" style="Z-INDEX: 101; LEFT: 250px; POSITION: absolute; TOP: 429px" runat="server"
				Width="712px" Height="128px" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" BackColor="White"
				CellPadding="4" AutoGenerateColumns="False">
				<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
				<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
				<Columns>
					<asp:BoundColumn Visible="False" DataField="CId" HeaderText="�γ̱��"></asp:BoundColumn>
					<asp:HyperLinkColumn DataNavigateUrlField="CId" DataNavigateUrlFormatString="ViewCourse.aspx?CId={0}"
						DataTextField="CName" HeaderText="�γ�����"></asp:HyperLinkColumn>
					<asp:BoundColumn Visible="False" DataField="TId" HeaderText="��ʦ���"></asp:BoundColumn>
					<asp:HyperLinkColumn DataNavigateUrlField="TId" DataNavigateUrlFormatString="ViewTeacher.aspx?TId={0}"
						DataTextField="TName" HeaderText="�ڿ���ʦ"></asp:HyperLinkColumn>
					<asp:BoundColumn DataField="CCredit" HeaderText="�γ�ѧ��"></asp:BoundColumn>
					<asp:HyperLinkColumn Text="�鿴�Ͽ�ʱ��ص�" DataNavigateUrlField="CId" DataNavigateUrlFormatString="ViewCourseTime.aspx?CId={0}"></asp:HyperLinkColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:Label id="Label1" style="Z-INDEX: 102; LEFT: 260px; POSITION: absolute; TOP: 394px" runat="server">���޿γ��б�  (���޿γ̲���Ҫѡ����������ѡ����Ϣʱ���Զ����뵽����ѡ���б��У���</asp:Label></form>
	</body>
</HTML>
