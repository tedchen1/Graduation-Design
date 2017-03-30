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
         <style type="text/css">
         body {
             background-image:url(img/bg6.jpg);
             background-size: cover; 
         }
     </style>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Label id="lbSId" style="Z-INDEX: 104; LEFT: 540px; POSITION: absolute; TOP: 351px" runat="server"></asp:Label>
			<asp:TextBox id="txtKeyConfirm" style="Z-INDEX: 118; LEFT: 908px; POSITION: absolute; TOP: 485px"
				runat="server" TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtKey" style="Z-INDEX: 117; LEFT: 910px; POSITION: absolute; TOP: 397px" runat="server"
				TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtSPhone" style="Z-INDEX: 116; LEFT: 540px; POSITION: absolute; TOP: 612px"
				runat="server"></asp:TextBox>
			<asp:TextBox id="txtSAddress" style="Z-INDEX: 115; LEFT: 540px; POSITION: absolute; TOP: 570px"
				runat="server"></asp:TextBox>
			<asp:TextBox id="txtSAge" style="Z-INDEX: 114; LEFT: 540px; POSITION: absolute; TOP: 482px" runat="server"></asp:TextBox>
			<asp:Label id="Label11" style="Z-INDEX: 113; LEFT: 803px; POSITION: absolute; TOP: 486px" runat="server">密码确认</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 112; LEFT: 820px; POSITION: absolute; TOP: 400px" runat="server">新密码</asp:Label>
			<asp:Label id="lbSCredit" style="Z-INDEX: 111; LEFT: 540px; POSITION: absolute; TOP: 524px"
				runat="server"></asp:Label>
			<asp:Label id="Label9" style="Z-INDEX: 110; LEFT: 477px; POSITION: absolute; TOP: 485px; bottom: 219px;" runat="server">年龄</asp:Label>
			<asp:Label id="Label8" style="Z-INDEX: 109; LEFT: 477px; POSITION: absolute; TOP: 441px" runat="server">性别</asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 108; LEFT: 477px; POSITION: absolute; TOP: 525px" runat="server">学分</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 107; LEFT: 477px; POSITION: absolute; TOP: 571px" runat="server">地址</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 106; LEFT: 477px; POSITION: absolute; TOP: 398px" runat="server">姓名</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 477px; POSITION: absolute; TOP: 614px" runat="server">电话</asp:Label>
			<uc1:StudentHeadControl id="StudentHeadControl1" runat="server"></uc1:StudentHeadControl>
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 477px; POSITION: absolute; TOP: 352px; bottom: 352px;" runat="server">学号</asp:Label>
			<asp:TextBox id="txtSName" style="Z-INDEX: 102; LEFT: 540px; POSITION: absolute; TOP: 395px"
				runat="server"></asp:TextBox>
			<asp:DropDownList id="ddlSSex" style="Z-INDEX: 103; LEFT: 540px; POSITION: absolute; TOP: 440px" runat="server"
				Width="88px">
				<asp:ListItem Value="男" Selected="True">男</asp:ListItem>
				<asp:ListItem Value="女">女</asp:ListItem>
			</asp:DropDownList>
			<asp:Button id="btnUpdateKey" style="Z-INDEX: 119; LEFT: 916px; POSITION: absolute; TOP: 557px"
				runat="server" Text="修改密码" onclick="btnUpdateKey_Click"></asp:Button>
			<asp:Button id="btnUpdate" style="Z-INDEX: 120; LEFT: 540px; POSITION: absolute; TOP: 667px"
				runat="server" Text="修改信息" Width="104px" Height="32px" onclick="btnUpdate_Click"></asp:Button>
		</form>
	</body>
</HTML>
