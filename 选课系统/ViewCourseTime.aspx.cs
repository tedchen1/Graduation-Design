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
	/// ViewCourseTime ��ժҪ˵����
	/// </summary>
	public partial class ViewCourseTime : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
                int CId = 0;
                try
                {
                    CId = Int32.Parse( Request.QueryString["CId"] );
                }
                catch
                {
                    CId = 0;
                }
                if ( CId != 0 )
                {
                    string sql = "select CourseTime.*,Building.*,Room.RoomName from CourseTime,Building,Room where CId = "+CId.ToString()+" and CourseTime.RoomId = Room.RoomId and Room.BuildingId = Building.BuildingId";
                    DataSet ds = Db.ExecuteSelectSql(sql);
                    if ( ds != null && ds.Tables.Count > 0 )
                    {
                        dgTime.DataSource = ds.Tables[0];
                        dgTime.DataBind();
                        lbCaption.Text = lbCaption.Text = "�ÿγ����� "+ds.Tables[0].Rows.Count.ToString()+" ��ʱ��Σ�";
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
