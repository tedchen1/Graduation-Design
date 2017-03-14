namespace sc
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		StudentHeadControl 的摘要说明。
	/// </summary>
	public partial class StudentHeadControl : System.Web.UI.UserControl
	{
        protected System.Web.UI.WebControls.HyperLink HyperLink6;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
            string id = (string)Session["Id"];
            if ( id == null )
                Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_NOTLOGIN.ToString());
            string sql = "select SLocked from Student where SId like '"+id+"'";
            DataSet ds = Db.ExecuteSelectSql(sql);
            if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
                Session["Locked"] = ds.Tables[0].Rows[0][0].ToString();
            
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		///		设计器支持所需的方法 - 不要使用代码编辑器
		///		修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{

        }
		#endregion
	}
}
