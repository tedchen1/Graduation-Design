<%@ Register TagPrefix="uc1" TagName="TeacherHeadControl" Src="TeacherHeadControl.ascx" %>
<%@ Page language="c#" Inherits="sc.WebForm1" CodeFile="CourseTime.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CourseTime</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<asp:label id="Label5" style="Z-INDEX: 113; LEFT: 80px; POSITION: absolute; TOP: 352px" runat="server">�Ͽ�ʱ��</asp:label><asp:label id="Label12" style="Z-INDEX: 114; LEFT: 128px; POSITION: absolute; TOP: 392px" runat="server">�ӵ�</asp:label><asp:dropdownlist id="ddlCWeekStart" style="Z-INDEX: 103; LEFT: 176px; POSITION: absolute; TOP: 392px"
					runat="server" Width="72px" AutoPostBack="True" onselectedindexchanged="ddlCWeekStart_SelectedIndexChanged"></asp:dropdownlist><asp:label id="Label11" style="Z-INDEX: 110; LEFT: 280px; POSITION: absolute; TOP: 392px" runat="server">�ܵ���</asp:label><asp:dropdownlist id="ddlCWeekEnd" style="Z-INDEX: 104; LEFT: 368px; POSITION: absolute; TOP: 392px"
					runat="server" Width="72px"></asp:dropdownlist><asp:label id="Label10" style="Z-INDEX: 109; LEFT: 464px; POSITION: absolute; TOP: 392px" runat="server"
					Width="72px">�ܣ�ÿ��</asp:label><asp:dropdownlist id="ddlWeek" style="Z-INDEX: 105; LEFT: 552px; POSITION: absolute; TOP: 392px" runat="server"
					Width="88px"></asp:dropdownlist><asp:dropdownlist id="ddlTime" style="Z-INDEX: 106; LEFT: 672px; POSITION: absolute; TOP: 392px" runat="server"
					Width="112px"></asp:dropdownlist><asp:label id="lbTime2" style="Z-INDEX: 112; LEFT: 80px; POSITION: absolute; TOP: 440px" runat="server">�Ͽεص�</asp:label><asp:dropdownlist id="ddlBuilding" style="Z-INDEX: 101; LEFT: 128px; POSITION: absolute; TOP: 480px"
					runat="server" Width="104px" AutoPostBack="True" onselectedindexchanged="ddlBuilding_SelectedIndexChanged"></asp:dropdownlist><asp:label id="Label9" style="Z-INDEX: 108; LEFT: 256px; POSITION: absolute; TOP: 480px" runat="server">��ѧ¥</asp:label><asp:dropdownlist id="ddlRoom" style="Z-INDEX: 102; LEFT: 344px; POSITION: absolute; TOP: 480px" runat="server"
					Width="152px"></asp:dropdownlist><asp:label id="Label13" style="Z-INDEX: 111; LEFT: 528px; POSITION: absolute; TOP: 480px" runat="server"
					Width="32px">����</asp:label><asp:label id="lbCaption" style="Z-INDEX: 116; LEFT: 64px; POSITION: absolute; TOP: 120px"
					runat="server"></asp:label><asp:linkbutton id="lkbAddTime" style="Z-INDEX: 117; LEFT: 752px; POSITION: absolute; TOP: 120px"
					runat="server" onclick="lkbAddTime_Click">����µ��Ͽ�ʱ��</asp:linkbutton>
				<uc1:TeacherHeadControl id="TeacherHeadControl1" runat="server"></uc1:TeacherHeadControl></FONT>
			<FONT face="����">
				<asp:datagrid id="dgTime" style="Z-INDEX: 115; LEFT: 56px; POSITION: absolute; TOP: 144px" runat="server"
					Width="833px" Height="104px" AllowPaging="True" PageSize="5" CellPadding="4" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#3366CC" AutoGenerateColumns="False">
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
						<asp:ButtonColumn Text="ɾ��" CommandName="Delete"></asp:ButtonColumn>
					</Columns>
					<PagerStyle NextPageText="��һҳ" PrevPageText="��һҳ" HorizontalAlign="Left" ForeColor="#003399"
						BackColor="#99CCCC"></PagerStyle>
				</asp:datagrid></FONT>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
			<FONT face="����">
				<asp:button id="btnAddTime" style="Z-INDEX: 107; LEFT: 662px; POSITION: absolute; TOP: 470px"
					runat="server" Width="144px" Text="����Ͽ�ʱ��" Height="48px" onclick="btnAddTime_Click"></asp:button></FONT>
            </p>
        </form>
	</body>
</HTML>
