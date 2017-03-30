<%@ Page language="c#" Inherits="sc.ViewTeacher" CodeFile="ViewTeacher.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="TeacherHeadControl" Src="TeacherHeadControl.ascx" %>
<%@ Register TagPrefix="uc1" TagName="StudentHeadControl" Src="StudentHeadControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ViewTeacher</title>
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
			<asp:Label id="Label4" style="Z-INDEX: 107; LEFT: 544px; POSITION: absolute; TOP: 452px" runat="server">教师性别</asp:Label>
			<asp:Label id="lbTEMail" style="Z-INDEX: 112; LEFT: 655px; POSITION: absolute; TOP: 581px"
				runat="server"></asp:Label>
			<asp:Label id="lbTName" style="Z-INDEX: 111; LEFT: 655px; POSITION: absolute; TOP: 403px; height: 20px;" runat="server"></asp:Label>
			<asp:Label id="lbTSex" style="Z-INDEX: 110; LEFT: 655px; POSITION: absolute; TOP: 453px" runat="server"></asp:Label>
			<asp:Label id="lbTAge" style="Z-INDEX: 109; LEFT: 655px; POSITION: absolute; TOP: 498px" runat="server"></asp:Label>
			<asp:Label id="lbTPhone" style="Z-INDEX: 108; LEFT: 655px; POSITION: absolute; TOP: 540px"
				runat="server"></asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 106; LEFT: 542px; POSITION: absolute; TOP: 406px" runat="server">教师姓名</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 105; LEFT: 540px; POSITION: absolute; TOP: 360px" runat="server">教师编号</asp:Label>
			<asp:Label id="lbTId" style="Z-INDEX: 100; LEFT: 655px; POSITION: absolute; TOP: 361px" runat="server"></asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 504px; POSITION: absolute; TOP: 582px" runat="server">教师电子邮件</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 546px; POSITION: absolute; TOP: 540px" runat="server">教师电话</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 104; LEFT: 544px; POSITION: absolute; TOP: 498px" runat="server">教师年龄</asp:Label>
			<uc1:StudentHeadControl id="StudentHeadControl1" runat="server"></uc1:StudentHeadControl>
		</form>
	</body>
</HTML>
