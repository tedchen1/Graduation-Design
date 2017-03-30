<%@ Page language="c#" Inherits="sc.AdminRoom" CodeFile="AdminRoom.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="AdminHeaderControl" Src="AdminHeaderControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AdminRoom</title>
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
			<FONT face="����">
				<asp:Label id="Label2" style="Z-INDEX: 101; LEFT: 295px; POSITION: absolute; TOP: 288px" runat="server">���ӽ�ѧ¥��</asp:Label>
				<asp:TextBox id="txtBuilding" style="Z-INDEX: 102; LEFT: 433px; POSITION: absolute; TOP: 288px; width: 110px;"
					runat="server"></asp:TextBox>
				<asp:Button id="btnAddBuilding" style="Z-INDEX: 103; LEFT: 578px; POSITION: absolute; TOP: 318px"
					runat="server" Text="���ӽ�ѧ¥" Width="82px" onclick="btnAddBuilding_Click"></asp:Button>
				<asp:DataGrid id="dgView" style="Z-INDEX: 104; LEFT: 721px; POSITION: absolute; TOP: 385px" runat="server"
					Width="264px" Height="268px" AllowPaging="True" BorderColor="LightGray" CellSpacing="1" BorderWidth="1px"
					AutoGenerateColumns="False">
					<HeaderStyle Font-Bold="True" HorizontalAlign="Center" ForeColor="#FF0066" VerticalAlign="Middle"
						BackColor="#009999"></HeaderStyle>
					<FooterStyle ForeColor="#FF0033"></FooterStyle>
					<Columns>
						<asp:BoundColumn Visible="False" DataField="RoomId" HeaderText="���"></asp:BoundColumn>
						<asp:BoundColumn DataField="RoomName" HeaderText="��������"></asp:BoundColumn>
						<asp:BoundColumn DataField="RoomSize" HeaderText="���Ҵ�С"></asp:BoundColumn>
						<asp:ButtonColumn Text="ɾ��" CommandName="Delete"></asp:ButtonColumn>
					</Columns>
					<PagerStyle NextPageText="��һҳ" PrevPageText="��һҳ" ForeColor="#FF0066"></PagerStyle>
				</asp:DataGrid>
				<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 328px" runat="server">���ӽ��ң�</asp:Label>
				<asp:TextBox id="txtRoomName" style="Z-INDEX: 106; LEFT: 435px; POSITION: absolute; TOP: 355px; width: 107px;"
					runat="server"></asp:TextBox>
				<asp:TextBox id="txtRoomSize" style="Z-INDEX: 107; LEFT: 430px; POSITION: absolute; TOP: 417px; width: 110px;"
					runat="server"></asp:TextBox>
				<asp:Button id="btnAddRoom" style="Z-INDEX: 108; LEFT: 570px; POSITION: absolute; TOP: 413px"
					runat="server" Text="���ӽ���" Width="88px" onclick="btnAddRoom_Click"></asp:Button>
				<asp:LinkButton id="lkbView" style="Z-INDEX: 109; LEFT: 711px; POSITION: absolute; TOP: 335px" runat="server" onclick="lkbView_Click">�鿴</asp:LinkButton>
				<asp:DropDownList id="ddlBuilding" style="Z-INDEX: 110; LEFT: 864px; POSITION: absolute; TOP: 282px"
					runat="server" Width="154px"></asp:DropDownList>
				<asp:Label id="Label1" style="Z-INDEX: 111; LEFT: 711px; POSITION: absolute; TOP: 285px" runat="server">���н�ѧ¥��</asp:Label>
				<asp:Label id="Label5" style="Z-INDEX: 112; LEFT: 305px; POSITION: absolute; TOP: 420px; right: 970px;" runat="server">�������ƣ�</asp:Label>
				<asp:Label id="Label6" style="Z-INDEX: 113; LEFT: 298px; POSITION: absolute; TOP: 355px" runat="server">����������</asp:Label>
				<uc1:AdminHeaderControl id="AdminHeaderControl1" runat="server"></uc1:AdminHeaderControl>
				<asp:LinkButton id="lkbDeleteBuilding" style="Z-INDEX: 115; LEFT: 770px; POSITION: absolute; TOP: 335px"
					runat="server" onclick="lkbDeleteBuilding_Click">ɾ��</asp:LinkButton>
				<asp:Label id="Label4" style="Z-INDEX: 116; LEFT: 841px; POSITION: absolute; TOP: 330px" runat="server"
					Width="152px" Font-Size="Smaller">(ע��ɾ����ѧ¥ǰ����ɾ���ý�ѧ¥���н��ң���</asp:Label></FONT>
		</form>
	</body>
</HTML>
