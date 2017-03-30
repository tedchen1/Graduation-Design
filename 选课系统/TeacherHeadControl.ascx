<%@ Control Language="c#" Inherits="sc.TeacherHeadControl" CodeFile="TeacherHeadControl.ascx.cs" %>

<FONT face="宋体"></FONT>
  <div style="background-color:#7b95ce">
       <img id="bg"  src="img/head.jpg"  />
        </div>
<DIV style="WIDTH: 100%; POSITION: relative; HEIGHT: 104px"
	id="DIV1" runat="server">
	<asp:HyperLink id="HyperLink1" style="Z-INDEX: 102; LEFT: 640px; POSITION: absolute; TOP: 44px"
		runat="server" NavigateUrl="Teacher.aspx">个人信息</asp:HyperLink>
	<asp:HyperLink id="HyperLink2" style="Z-INDEX: 103; LEFT: 796px; POSITION: absolute; TOP: 45px"
		runat="server" NavigateUrl="NewCourse.aspx">开设课程</asp:HyperLink>
	<asp:HyperLink id="hlkQuit" style="Z-INDEX: 104; LEFT: 960px; POSITION: absolute; TOP: 44px" runat="server"
		NavigateUrl="Logout.aspx" ForeColor="Red">退出</asp:HyperLink>
	<asp:HyperLink id="HyperLink4" style="Z-INDEX: 105; LEFT: 468px; POSITION: absolute; TOP: 44px"
		runat="server" NavigateUrl="TeacherMain.aspx">教师首页</asp:HyperLink></DIV>
<FONT face="宋体"></FONT>
