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
	/// SelectedCourse ��ժҪ˵����
	/// </summary>
	public partial class SelectedCourse : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
                string sql = "select Course.CName,Course.CCredit,Course.CType,Teacher.TName,Teacher.TId,SC.* from SC,Teacher,Course where SC.SId like '"+Session["Id"].ToString()+"' and SC.CId = Course.CId and Course.TId like Teacher.TId";
                DataSet ds = Db.ExecuteSelectSql(sql);
                if ( ds != null && ds.Tables.Count > 0 )
                {
                    dgCourse.DataSource = ds.Tables[0];
                    dgCourse.DataBind();
                }
                bool locked= bool.Parse(Session["Locked"].ToString());
                if ( ! locked )
                {
                    lbLock.Text = "����δ����ѡ����Ϣ��";
                    btnLock.Visible = true;
                }
                else
                {
                    lbLock.Text = "ѡ����Ϣ�ѱ�������";
                    Label1.Text = "����Ҫѧϰ�Ŀγ̣����޺�ѡ�޵ģ�:";
                    btnLock.Visible = false;
                    dgCourse.Columns[7].Visible = false;
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
            this.dgCourse.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgCourse_DeleteCommand);

        }
		#endregion

        private void dgCourse_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            int index = e.Item.ItemIndex;
            string cId = dgCourse.Items[index].Cells[0].Text;
            string sql = "delete from SC where SId like '"+Session["Id"].ToString()+"' and CId = "+cId;
            Db.ExecuteSelectSql(sql);
            sql = "select Course.CName,Course.CCredit,Course.CType,Teacher.TName,Teacher.TId,SC.* from SC,Teacher,Course where SC.SId like '"+Session["Id"].ToString()+"' and SC.CId = Course.CId and Course.TId like Teacher.TId";
            DataSet ds = Db.ExecuteSelectSql(sql);
            if ( ds != null && ds.Tables.Count > 0 )
            {
                dgCourse.DataSource = ds.Tables[0];
                dgCourse.DataBind();
            }
        }

        protected void btnLock_Click(object sender, System.EventArgs e)
        {
            string sql = "select count(*) from SC where SId like '"+Session["Id"].ToString()+"'";
            DataSet ds = Db.ExecuteSelectSql(sql);
            int nCourse=0;
            if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
            {
                nCourse = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            if ( nCourse < 2 )
            {
                Response.Write(MyUtility.Alert("������ѡ����������ѡ�޿γ�!"));
                return;
            }
            else
            {
                //�Ƚ����б��޿γ̼��뵽ѡ�α���������
                sql = "select CId from Course where CType = '����'";
                DataSet ds2 = Db.ExecuteSelectSql(sql);
                if ( ds2 != null && ds2.Tables.Count > 0 )
                {
                    for ( int i = 0; i < ds2.Tables[0].Rows.Count; i++ )
                    {
                        string cid = ds2.Tables[0].Rows[i][0].ToString();
                        sql = "insert into SC(SId,CId,Score) values('"+Session["Id"].ToString()+"',"+cid+",0)";
                        Db.ExecuteSql(sql);
                    }
                }
                sql = "update Student set SLocked = 1 where SId like '"+Session["Id"].ToString()+"'";
                if ( Db.ExecuteSql(sql) == 1 )
                {
                    lbLock.Text = "ѡ����Ϣ�ѱ�������";
                    Session["Locked"] = "true";
                    Response.Redirect("Selectedcourse.aspx");
                }
            }
        }
	}
}
