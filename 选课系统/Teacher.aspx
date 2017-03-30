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
          <style type="text/css">
         body {
             background-image:url(img/bg2.jpg);
             background-size: cover; 
         }
     </style>
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 409px; POSITION: absolute; TOP: 494px" runat="server">教师电子邮件</asp:Label>
			<asp:TextBox id="txtKeyConfirm" style="Z-INDEX: 116; LEFT: 914px; POSITION: absolute; TOP: 377px; width: 146px;"
				runat="server" TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtTMail" style="Z-INDEX: 115; LEFT: 550px; POSITION: absolute; TOP: 487px"
				runat="server"></asp:TextBox>
			<asp:TextBox id="txtTAge" style="Z-INDEX: 114; LEFT: 550px; POSITION: absolute; TOP: 403px" runat="server"></asp:TextBox>
			<asp:TextBox id="txtKey" style="Z-INDEX: 113; LEFT: 916px; POSITION: absolute; TOP: 329px; width: 144px;" runat="server"
				TextMode="Password"></asp:TextBox>
			<asp:TextBox id="txtTPhone" style="Z-INDEX: 112; LEFT: 550px; POSITION: absolute; TOP: 446px"
				runat="server"></asp:TextBox>
			<asp:Label id="Label7" style="Z-INDEX: 109; LEFT: 446px; POSITION: absolute; TOP: 326px" runat="server">教师姓名</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 108; LEFT: 446px; POSITION: absolute; TOP: 287px; right: 849px;" runat="server">教师编号</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 107; LEFT: 446px; POSITION: absolute; TOP: 405px" runat="server">教师年龄</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 106; LEFT: 446px; POSITION: absolute; TOP: 364px; right: 913px;" runat="server">教师性别</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 446px; POSITION: absolute; TOP: 448px" runat="server">教师电话</asp:Label>
			<uc1:TeacherHeadControl id="TeacherHeadControl1" runat="server"></uc1:TeacherHeadControl>
			<asp:Label id="lbTId" style="Z-INDEX: 101; LEFT: 550px; POSITION: absolute; TOP: 288px" runat="server"></asp:Label>
			<asp:TextBox id="txtTName" style="Z-INDEX: 102; LEFT: 550px; POSITION: absolute; TOP: 326px"
				runat="server"></asp:TextBox>
			<asp:DropDownList id="ddlTSex" style="Z-INDEX: 103; LEFT: 550px; POSITION: absolute; TOP: 362px" runat="server"
				Width="96px"></asp:DropDownList>
			<asp:Label id="Label1" style="Z-INDEX: 117; LEFT: 840px; POSITION: absolute; TOP: 329px" runat="server">新密码</asp:Label>
			<asp:Label id="Label8" style="Z-INDEX: 118; LEFT: 820px; POSITION: absolute; TOP: 382px" runat="server">密码确认</asp:Label>
			<asp:Button id="btnUpdate" style="Z-INDEX: 119; LEFT: 579px; POSITION: absolute; TOP: 546px"
				runat="server" Text="修改信息" Width="104px" Height="32px" onclick="btnUpdate_Click"></asp:Button>
			<asp:Button id="btnUpdatekey" style="Z-INDEX: 120; LEFT: 914px; POSITION: absolute; TOP: 447px"
				runat="server" Text="修改密码" Width="104px" onclick="btnUpdatekey_Click"></asp:Button>
			</FORM>
			<FONT face="宋体"></FONT>
		</form>
	</body>
</HTML>
