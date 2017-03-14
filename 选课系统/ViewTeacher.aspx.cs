using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace sc
{
	/// <summary>
	/// ViewTeacher 的摘要说明。
	/// </summary>
	public partial class ViewTeacher : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
            if ( ! IsPostBack )
            {
                string TId = Request.QueryString["TId"];
                if ( TId != null )
                {
                    string sql = "select * from Teacher where TId like '"+TId+"'";
                    DataSet ds = Db.ExecuteSelectSql(sql);
                    if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
                    {
                        lbTId.Text = TId;
                        lbTName.Text = ds.Tables[0].Rows[0]["TName"].ToString();
                        lbTSex.Text = ds.Tables[0].Rows[0]["TSex"].ToString();
                        lbTAge.Text = ds.Tables[0].Rows[0]["TAge"].ToString();
                        lbTPhone.Text = ds.Tables[0].Rows[0]["TPhone"].ToString();
                        lbTEMail.Text = ds.Tables[0].Rows[0]["TMail"].ToString();
                    
                    }
                }
            }
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
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    

        }
		#endregion
	}
}
