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
	/// ViewTeacher ��ժҪ˵����
	/// </summary>
	public partial class ViewTeacher : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
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

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    

        }
		#endregion
	}
}
