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
	/// TeacherMain ��ժҪ˵����
	/// </summary>
	public partial class TeacherMain : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
                // string sql1 = "select * from Course";
              
                String tid = Session["Id"].ToString();
                //String tid = "1";
                Console.WriteLine("session id = " + tid);

                string sql = "select x.*,(select CName from Course as y where y.CId = x.CPreCId) as CPreCName from Course as x where x.TId like '"+tid+"'";
                DataSet ds = Db.ExecuteSelectSql(sql);
                if ( ds != null && ds.Tables.Count > 0 )
                {
                    if ( ds.Tables[0].Rows.Count > 0 )
                    {
                        lbCount.Text = "��һ�������� "+ds.Tables[0].Rows.Count.ToString()+" �ſγ�!";
                        dgCourse.DataSource = ds.Tables[0];
                        dgCourse.DataBind(); 
                        for ( int i = 0; i < ds.Tables[0].Rows.Count; i++ )
                        {
                            if ( dgCourse.Items[i].Cells[3].Text == "����" )
                                dgCourse.Items[i].Cells[8].Text = "����";
                            else
                            {
                                sql = "select count(*) from SC where CId = "+ds.Tables[0].Rows[i]["CId"].ToString();
                                DataSet ds1 = Db.ExecuteSelectSql(sql);
                                if ( ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0 )
                                    dgCourse.Items[i].Cells[8].Text = ds1.Tables[0].Rows[0][0].ToString();
                            }
                        }
                    }
                    else
                    {
                        lbCount.Text = "����ʱ��û�п���γ�!";
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
