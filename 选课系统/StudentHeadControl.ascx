<%@ Control Language="c#" Inherits="sc.StudentHeadControl" CodeFile="StudentHeadControl.ascx.cs" %>
<DIV style="WIDTH: 100%; POSITION: relative; HEIGHT: 99px"
	id="DIV1" runat="server">
	<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 408px; POSITION: absolute; TOP: 16px" runat="server"
		Font-Size="X-Large" Font-Bold="True">ѡ��ϵͳ</asp:Label>
	<asp:HyperLink id="HyperLink4" style="Z-INDEX: 102; LEFT: 200px; POSITION: absolute; TOP: 72px"
		runat="server" NavigateUrl="StudentMain.aspx">ѧ����ҳ</asp:HyperLink>
	<asp:HyperLink id="HyperLink1" style="Z-INDEX: 103; LEFT: 312px; POSITION: absolute; TOP: 72px"
		runat="server" NavigateUrl="Student.aspx">������Ϣ</asp:HyperLink>
	<asp:HyperLink id="HyperLink2" style="Z-INDEX: 104; LEFT: 424px; POSITION: absolute; TOP: 72px"
		runat="server" NavigateUrl="bxCourse.aspx">���޿γ�</asp:HyperLink>
	<asp:HyperLink id="hlkQuit" style="Z-INDEX: 105; LEFT: 744px; POSITION: absolute; TOP: 72px" runat="server"
		NavigateUrl="Logout.aspx" ForeColor="Red">�˳�</asp:HyperLink>
	<asp:HyperLink id="HyperLink3" style="Z-INDEX: 106; LEFT: 536px; POSITION: absolute; TOP: 72px"
		runat="server" NavigateUrl="xxCourse.aspx">ѡ�޿γ�</asp:HyperLink>
	<asp:HyperLink id="HyperLink5" style="Z-INDEX: 107; LEFT: 640px; POSITION: absolute; TOP: 72px"
		runat="server" NavigateUrl="SelectedCourse.aspx">��ѡ�γ�</asp:HyperLink></DIV>
