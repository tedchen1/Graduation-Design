<%@ Register TagPrefix="uc1" TagName="AdminHeaderControl" Src="AdminHeaderControl.ascx" %>
<%@ Page language="c#" Inherits="sc.AdminUser" CodeFile="AdminUser.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>AdminUser</title>
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
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 290px; POSITION: absolute; TOP: 300px" runat="server">教师编号：</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 289px; POSITION: absolute; TOP: 352px" runat="server">教师姓名：</asp:Label>
			<asp:TextBox id="txtTName" style="Z-INDEX: 104; LEFT: 404px; POSITION: absolute; TOP: 298px"
				runat="server"></asp:TextBox>
			<asp:Button id="btnAddTearcher" style="Z-INDEX: 105; LEFT: 609px; POSITION: absolute; TOP: 322px; width: 78px;"
				runat="server" Text="添加老师" onclick="btnAddTearcher_Click"></asp:Button>
			<asp:Label id="Label3" style="Z-INDEX: 106; LEFT: 709px; POSITION: absolute; TOP: 301px; right: 566px;" runat="server">学生学号：</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 107; LEFT: 705px; POSITION: absolute; TOP: 353px; right: 570px;" runat="server">学生姓名：</asp:Label>
			<asp:TextBox id="txtSId" style="Z-INDEX: 108; LEFT: 818px; POSITION: absolute; TOP: 299px" runat="server"></asp:TextBox>
			<asp:TextBox id="txtSName" style="Z-INDEX: 109; LEFT: 822px; POSITION: absolute; TOP: 353px"
				runat="server"></asp:TextBox>
			<asp:DataGrid id="dgViewT" style="Z-INDEX: 111; LEFT: 303px; POSITION: absolute; TOP: 404px" runat="server"
				Width="312px" Height="322px" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" BackColor="White"
				CellPadding="4" AutoGenerateColumns="False" AllowPaging="True">
				<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
				<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="TId" HeaderText="教师编号"></asp:BoundColumn>
					<asp:BoundColumn DataField="TName" HeaderText="教师姓名"></asp:BoundColumn>
					<asp:ButtonColumn Text="删除" CommandName="Delete"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
			<asp:DataGrid id="dgViewS" style="Z-INDEX: 112; LEFT: 718px; POSITION: absolute; TOP: 404px" runat="server"
				Width="312px" Height="322px" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" BackColor="White"
				CellPadding="4" AutoGenerateColumns="False" AllowPaging="True">
				<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
				<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
				<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="SId" HeaderText="学生学号"></asp:BoundColumn>
					<asp:BoundColumn DataField="SName" HeaderText="学生姓名"></asp:BoundColumn>
					<asp:ButtonColumn Text="删除" CommandName="Delete"></asp:ButtonColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
		 
            
			<asp:TextBox id="txtTId" style="Z-INDEX: 103; LEFT: 402px; POSITION: absolute; TOP: 352px" runat="server"></asp:TextBox>
			
            
			<asp:Button id="btnAddStudent" style="Z-INDEX: 110; LEFT: 1030px; POSITION: absolute; TOP: 327px; width: 78px;"
				runat="server" Text="添加学生" onclick="btnAddStudent_Click"></asp:Button>
			
			<uc1:AdminHeaderControl id="AdminHeaderControl1" runat="server"></uc1:AdminHeaderControl>
		</form>
	</body>
</HTML>
