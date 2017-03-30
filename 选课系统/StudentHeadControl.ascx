<%@ Control Language="c#" Inherits="sc.StudentHeadControl" CodeFile="StudentHeadControl.ascx.cs" %>

 <div style="background-color:#7b95ce">
       <img id="bg"  src="img/head.jpg"  />
        </div>
<DIV style="WIDTH: 100%; POSITION: relative; HEIGHT: 99px"
	id="DIV1" runat="server">
	<asp:HyperLink id="HyperLink4" style="Z-INDEX: 102; LEFT: 200px; POSITION: absolute; TOP: 54px"
		runat="server" NavigateUrl="StudentMain.aspx">学生首页</asp:HyperLink>
	<asp:HyperLink id="HyperLink1" style="Z-INDEX: 103; LEFT: 328px; POSITION: absolute; TOP: 54px"
		runat="server" NavigateUrl="Student.aspx">个人信息</asp:HyperLink>
	<asp:HyperLink id="HyperLink2" style="Z-INDEX: 104; LEFT: 464px; POSITION: absolute; TOP: 54px"
		runat="server" NavigateUrl="bxCourse.aspx">必修课程</asp:HyperLink>
	<asp:HyperLink id="hlkQuit" style="Z-INDEX: 105; LEFT: 886px; POSITION: absolute; TOP: 56px" runat="server"
		NavigateUrl="Logout.aspx" ForeColor="Red">退出</asp:HyperLink>
	<asp:HyperLink id="HyperLink3" style="Z-INDEX: 106; LEFT: 604px; POSITION: absolute; TOP: 54px"
		runat="server" NavigateUrl="xxCourse.aspx">选修课程</asp:HyperLink>
	<asp:HyperLink id="HyperLink5" style="Z-INDEX: 107; LEFT: 746px; POSITION: absolute; TOP: 54px"
		runat="server" NavigateUrl="SelectedCourse.aspx">已选课程</asp:HyperLink></DIV>
