<%@ Page language="c#" Inherits="sc.ViewStudent" CodeFile="ViewStudent.aspx.cs" %>
<%@ Register TagPrefix="uc1" TagName="TeacherHeadControl" Src="TeacherHeadControl.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ViewStudent</title>
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
			<asp:Label id="Label1" style="Z-INDEX: 109; LEFT: 657px; POSITION: absolute; TOP: 329px" runat="server">学号</asp:Label>
			<asp:Label id="lbSPhone" style="Z-INDEX: 114; LEFT: 721px; POSITION: absolute; TOP: 592px"
				runat="server"></asp:Label>
			<asp:Label id="lbSName" style="Z-INDEX: 113; LEFT: 732px; POSITION: absolute; TOP: 370px; bottom: 334px;" runat="server"></asp:Label>
			<asp:Label id="lbSSex" style="Z-INDEX: 112; LEFT: 727px; POSITION: absolute; TOP: 417px" runat="server"></asp:Label>
			<asp:Label id="lbSAge" style="Z-INDEX: 111; LEFT: 728px; POSITION: absolute; TOP: 462px" runat="server"></asp:Label>
			<asp:Label id="lbSAddress" style="Z-INDEX: 110; LEFT: 721px; POSITION: absolute; TOP: 547px"
				runat="server"></asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 102; LEFT: 656px; POSITION: absolute; TOP: 370px" runat="server">姓名</asp:Label>
			<asp:Label id="Label8" style="Z-INDEX: 106; LEFT: 656px; POSITION: absolute; TOP: 417px" runat="server">性别</asp:Label>
			<asp:Label id="Label9" style="Z-INDEX: 107; LEFT: 655px; POSITION: absolute; TOP: 462px; bottom: 242px;" runat="server">年龄</asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 105; LEFT: 655px; POSITION: absolute; TOP: 506px" runat="server">学分</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 104; LEFT: 654px; POSITION: absolute; TOP: 548px" runat="server">地址</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 101; LEFT: 654px; POSITION: absolute; TOP: 591px" runat="server">电话</asp:Label>
			<asp:Label id="lbSCredit" style="Z-INDEX: 108; LEFT: 722px; POSITION: absolute; TOP: 506px"
				runat="server"></asp:Label>
			<asp:Label id="lbSId" style="Z-INDEX: 100; LEFT: 734px; POSITION: absolute; TOP: 332px" runat="server"></asp:Label>
			<uc1:TeacherHeadControl id="TeacherHeadControl1" runat="server"></uc1:TeacherHeadControl>
		</form>
	</body>
</HTML>
