<%@ Control Language="c#" Inherits="sc.AdminHeaderControl" CodeFile="AdminHeaderControl.ascx.cs" %>
<body>
	<FONT face="����">
		<asp:HyperLink id="hlkAdminRoom" style="Z-INDEX: 102; LEFT: 536px; POSITION: absolute; TOP: 80px"
			Runat="server" ForeColor="#000000" NavigateUrl="AdminRoom.aspx">��ѧ¥���������</asp:HyperLink>
		<asp:HyperLink id="hlkLogout" style="Z-INDEX: 103; LEFT: 896px; POSITION: absolute; TOP: 80px"
			ForeColor="#ff0000" NavigateUrl="Logout.aspx" runat="server">�˳�</asp:HyperLink>
		<asp:HyperLink id="hlkAdminUser" style="Z-INDEX: 101; LEFT: 712px; POSITION: absolute; TOP: 80px"
			ForeColor="#000000" NavigateUrl="AdminUser.aspx" runat="server">��ʦ��ѧ����Ϣ¼��</asp:HyperLink>
		<asp:Label id="Label1" style="Z-INDEX: 104; LEFT: 360px; POSITION: absolute; TOP: 24px" runat="server"
			Font-Size="X-Large" Font-Bold="True">ѡ��ϵͳ����</asp:Label>
		<asp:HyperLink id="hlkAdmin" style="Z-INDEX: 105; LEFT: 416px; POSITION: absolute; TOP: 80px" NavigateUrl="Admin.aspx"
			runat="server">������ҳ</asp:HyperLink></FONT>
</body>
