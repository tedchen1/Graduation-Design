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
	/// NewCourse ��ժҪ˵����
	/// </summary>
	public partial class NewCourse : System.Web.UI.Page
	{
        protected System.Web.UI.WebControls.Label lbTId;
        protected System.Web.UI.WebControls.Label Label5;
        protected System.Web.UI.WebControls.Label Label9;
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
                //�γ����
                ddlCType.Items.Clear();
                ddlCType.Items.Add("��ѡ��");
                ddlCType.Items.Add("����");
                ddlCType.Items.Add("ѡ��");
                ddlCType.SelectedIndex = 0;

                //�γ�ѧ��
                ddlCCredit.Items.Clear();
                ddlCCredit.Items.Add("��ѡ��");
                ddlCCredit.Items.Add("1");
                ddlCCredit.Items.Add("1.5");
                ddlCCredit.Items.Add("2");
                ddlCCredit.Items.Add("2.5");
                ddlCCredit.Items.Add("3");
                ddlCCredit.Items.Add("3.5");
                ddlCCredit.Items.Add("4");
                ddlCCredit.Items.Add("4.5");
                ddlCCredit.Items.Add("5");
                ddlCCredit.Items.Add("5.5");
                ddlCCredit.Items.Add("6");
                ddlCType.SelectedIndex = 0;

                //�γ��������
                ddlCMax.Items.Clear();
                ddlCMax.Items.Add("��ѡ��");
                ddlCMax.Items.Add("50");
                ddlCMax.Items.Add("100");
                ddlCMax.Items.Add("150");
                ddlCMax.Items.Add("200");
                ddlCMax.SelectedIndex = 0;

                //ǰ���γ�
                ddlCPreCId.Items.Clear();
                ddlCPreCId.Items.Add("��ѡ��");
                string sql = "select CId,CName from Course";
                DataSet ds = Db.ExecuteSelectSql(sql);
                if ( ds != null && ds.Tables.Count > 0 )
                {
                    for ( int i = 0; i < ds.Tables[0].Rows.Count; i++ )
                        ddlCPreCId.Items.Add( new ListItem( ds.Tables[0].Rows[i]["CName"].ToString(), ds.Tables[0].Rows[i]["CId"].ToString() ) );
                }
                ddlCPreCId.SelectedIndex = 0;

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

        protected void btnAdd_Click(object sender, System.EventArgs e)
        {
            if ( txtCName.Text.Trim() == "" )
            {
                Response.Write(MyUtility.Alert("������γ����ƣ�"));
                return;
            }
            if ( ddlCType.SelectedIndex <= 0 )
            {
                Response.Write(MyUtility.Alert("��ѡ��γ����ͣ�"));
                return;
            }
            if ( ddlCCredit.SelectedIndex <= 0 )
            {
                Response.Write(MyUtility.Alert("��ѡ��γ�ѧ�֣�"));
                return;
            }
            if ( ddlCMax.SelectedIndex <= 0 )
            {
                Response.Write(MyUtility.Alert("��ѡ��γ����������"));
                return;
            }
            string sql;
            sql = "select count(*) from Course where TId like '"+Session["Id"].ToString()+"'";
            DataSet ds = Db.ExecuteSelectSql(sql);
            int nCourse = 0;
            if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count >0 )
                nCourse = (int)ds.Tables[0].Rows[0][0];
            if ( nCourse >= 3 )
            {
                Response.Write(MyUtility.Alert("���Ѿ�������3�ſγ��ˣ������ٿ�����"));
                return;
            }
            if ( ddlCPreCId.SelectedIndex <= 0 )
            {
                sql = "insert into Course(TId,CName,CType,CCredit,CMax,CNote) values("+
                    Session["Id"].ToString()+
                    ",'"+txtCName.Text.Trim()+
                    "','"+ddlCType.SelectedItem.Text+
                    "',"+ddlCCredit.SelectedItem.Text+
                    ","+ddlCMax.SelectedItem.Text+
                    ",'"+MyUtility.Encode(txtCNote.Text)+"')";
            }
            else
            {
                sql = "insert into Course(TId,CName,CType,CCredit,CMax,CNote,CPreCId) values("+
                    Session["Id"].ToString()+
                    ",'"+txtCName.Text.Trim()+
                    "','"+ddlCType.SelectedItem.Text+
                    "',"+ddlCCredit.SelectedItem.Text+
                    ","+ddlCMax.SelectedItem.Text+
                    ",'"+MyUtility.Encode(txtCNote.Text)+
                    "',"+ddlCPreCId.SelectedItem.Value+")";
            }
            Db.ExecuteSql(sql);
            Response.Redirect("TeacherMain.aspx");
        }

      
	}
}
