<%@ Control Language="c#" Inherits="sc.AdminHeaderControl" CodeFile="AdminHeaderControl.ascx.cs" %>


<body>
	<FONT face="����">
        <div style="background-color:#7b95ce">
       <img id="bg"  src="img/head.jpg"  />
        </div>
		<asp:HyperLink id="hlkLogout" style="Z-INDEX: 103; LEFT: 867px; POSITION: absolute; TOP: 207px"
			ForeColor="#ff0000" NavigateUrl="Logout.aspx" runat="server">�˳�</asp:HyperLink>
		<asp:HyperLink id="hlkAdmin" style="Z-INDEX: 105; LEFT: 358px; POSITION: absolute; TOP: 209px" NavigateUrl="Admin.aspx"
			runat="server">������ҳ</asp:HyperLink>
		</FONT>

	<FONT face="����">
		<asp:HyperLink id="hlkAdminRoom" style="Z-INDEX: 102; LEFT: 466px; POSITION: absolute; TOP: 209px; right: 741px;"
			Runat="server" ForeColor="#000000" NavigateUrl="AdminRoom.aspx">��ѧ¥���������</asp:HyperLink>
		</FONT>
	<FONT face="����">
        <asp:HyperLink id="hlkAdminUser" style="Z-INDEX: 103; LEFT: 658px; POSITION: absolute; TOP: 209px; "
			ForeColor="#000000" NavigateUrl="AdminUser.aspx" runat="server">��ʦ��ѧ����Ϣ¼��</asp:HyperLink>
	
</body>
