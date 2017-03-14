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
	/// AdminUser ��ժҪ˵����
	/// </summary>
	public partial class AdminUser : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
                string sql = "select * from Teacher";
                DataSet ds1 = Db.ExecuteSelectSql(sql);
                if ( ds1 != null && ds1.Tables.Count > 0 )
                {
                    dgViewT.DataSource = ds1.Tables[0];
                    dgViewT.DataBind();
                }
                sql = "select * from Student";
                DataSet ds2 = Db.ExecuteSelectSql(sql);
                if ( ds2 != null && ds2.Tables.Count > 0 )
                {
                    dgViewS.DataSource = ds2.Tables[0];
                    dgViewS.DataBind();
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
            this.dgViewT.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgViewT_PageIndexChanged);
            this.dgViewT.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgViewT_DeleteCommand);
            this.dgViewS.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgViewS_PageIndexChanged);
            this.dgViewS.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgViewS_DeleteCommand);

        }
		#endregion

        protected void btnAddTearcher_Click(object sender, System.EventArgs e)
        {
            if ( txtTId.Text.Trim() == "" )
            {
                Response.Write( MyUtility.Alert("�������ʦ��ţ�") );
                return;
            }
            if ( txtTName.Text.Trim() == "" )
            {
                Response.Write( MyUtility.Alert("�������ʦ������") );
                return;
            }
            string sql = "insert into Teacher(TId,TKey,TName) values('"+txtTId.Text.Trim()+"','"+MyUtility.MD5(txtTId.Text.Trim())+"','"+txtTName.Text.Trim()+"')";
            try
            {
                if ( Db.ExecuteSql(sql) == 1 )
                {
                    sql = "select * from Teacher";
                    DataSet ds1 = Db.ExecuteSelectSql(sql);
                    if ( ds1 != null && ds1.Tables.Count > 0 )
                    {
                        dgViewT.DataSource = ds1.Tables[0];
                        dgViewT.DataBind();
                    }
                }
                else
                {
                    Response.Write( MyUtility.Alert("���ʧ��-_-,�������Ƿ��Ѿ����ڣ�") );
                    return;
                }
            }
            catch
            {
                Response.Write( MyUtility.Alert("���ʧ��-_-,�������Ƿ��Ѿ����ڣ�") );
                return;
            }
        }

        protected void btnAddStudent_Click(object sender, System.EventArgs e)
        {
            if ( txtSId.Text.Trim() == "" )
            {
                Response.Write( MyUtility.Alert("������ѧ��ѧ�ţ�") );
                return;
            }
            if ( txtSName.Text.Trim() == "" )
            {
                Response.Write( MyUtility.Alert("������ѧ��������") );
                return;
            }
            string sql = "insert into Student(SId,SKey,SName,SCredit,SLocked) values('"+txtSId.Text.Trim()+"','"+MyUtility.MD5(txtSId.Text.Trim())+"','"+txtSName.Text.Trim()+"',0,0)";
            try
            {
                if ( Db.ExecuteSql(sql) == 1 )
                {
                    sql = "select * from Student";
                    DataSet ds1 = Db.ExecuteSelectSql(sql);
                    if ( ds1 != null && ds1.Tables.Count > 0 )
                    {
                        dgViewS.DataSource = ds1.Tables[0];
                        dgViewS.DataBind();
                    }
                }
                else
                {
                    Response.Write( MyUtility.Alert("���ʧ��-_-,����ѧ���Ƿ��Ѿ����ڣ�") );
                    return;
                }
            }
            catch
            {
                Response.Write( MyUtility.Alert("���ʧ��-_-,����ѧ���Ƿ��Ѿ����ڣ�") );
                return;
            }
        }

        private void dgViewT_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            int index = e.Item.ItemIndex;
            string TId = dgViewT.Items[index].Cells[0].Text;
            string sql = "delete from Teacher where TId like '"+TId+"'";
            Db.ExecuteSql(sql);
            sql = "select * from Teacher";
            DataSet ds1 = Db.ExecuteSelectSql(sql);
            if ( ds1 != null && ds1.Tables.Count > 0 )
            {
                dgViewT.DataSource = ds1.Tables[0];
                dgViewT.DataBind();
            }
        }

        private void dgViewT_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            dgViewT.CurrentPageIndex = e.NewPageIndex;
            string sql = "select * from Teacher";
            DataSet ds1 = Db.ExecuteSelectSql(sql);
            if ( ds1 != null && ds1.Tables.Count > 0 )
            {
                dgViewT.DataSource = ds1.Tables[0];
                dgViewT.DataBind();
            }
        }

        private void dgViewS_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            int index = e.Item.ItemIndex;
            string SId = dgViewS.Items[index].Cells[0].Text;
            string sql = "delete from Student where SId like '"+SId+"'";
            Db.ExecuteSql(sql);
            sql = "select * from Student";
            DataSet ds1 = Db.ExecuteSelectSql(sql);
            if ( ds1 != null && ds1.Tables.Count > 0 )
            {
                dgViewS.DataSource = ds1.Tables[0];
                dgViewS.DataBind();
            }
        }

        private void dgViewS_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            dgViewS.CurrentPageIndex = e.NewPageIndex;
            string sql = "select * from Student";
            DataSet ds1 = Db.ExecuteSelectSql(sql);
            if ( ds1 != null && ds1.Tables.Count > 0 )
            {
                dgViewS.DataSource = ds1.Tables[0];
                dgViewS.DataBind();
            }
        }
	}
}
