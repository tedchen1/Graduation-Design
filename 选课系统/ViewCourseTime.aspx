<%@ Page language="c#" Inherits="sc.ViewCourseTime" CodeFile="ViewCourseTime.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="StudentHeadControl" Src="StudentHeadControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ViewCourseTime</title>
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
			<asp:label id="lbCaption" style="Z-INDEX: 116; LEFT: 265px; POSITION: absolute; TOP: 372px"
				runat="server"></asp:label>
			<asp:datagrid id="dgTime" style="Z-INDEX: 115; LEFT: 259px; POSITION: absolute; TOP: 416px" runat="server"
				PageSize="5" CellPadding="4" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#3366CC"
				AutoGenerateColumns="False" Height="104px" Width="833px">
				<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
				<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="CWeekStart" HeaderText="��ʼ�ܴ�"></asp:BoundColumn>
					<asp:BoundColumn DataField="CWeekEnd" HeaderText="�����ܴ�"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="BuildingId" HeaderText="��ѧ¥���"></asp:BoundColumn>
					<asp:BoundColumn DataField="BuildingName" HeaderText="��ѧ¥"></asp:BoundColumn>
					<asp:BoundColumn Visible="False" DataField="RoomId" HeaderText="���ұ��"></asp:BoundColumn>
					<asp:BoundColumn DataField="RoomName" HeaderText="����"></asp:BoundColumn>
					<asp:BoundColumn DataField="CTime" HeaderText="�Ͽ�ʱ��">
						<HeaderStyle Width="300px"></HeaderStyle>
					</asp:BoundColumn>
				</Columns>
				<PagerStyle NextPageText="��һҳ" PrevPageText="��һҳ" HorizontalAlign="Left" ForeColor="#003399"
					BackColor="#99CCCC"></PagerStyle>
			</asp:datagrid>
			<uc1:StudentHeadControl id="StudentHeadControl1" runat="server"></uc1:StudentHeadControl>
		</form>
	</body>
</HTML>
