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
	/// Student ��ժҪ˵����
	/// </summary>
	public partial class Student : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
                string sql = "select * from Student where SId like '"+Session["Id"].ToString()+"'";
                DataSet ds = Db.ExecuteSelectSql(sql);
                if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
                {
                    lbSId.Text = Session["Id"].ToString();
                    txtSName.Text = ds.Tables[0].Rows[0]["SName"].ToString();
                    if ( ds.Tables[0].Rows[0]["SSex"].ToString() == "��" )
                        ddlSSex.SelectedIndex = 0;
                    else
                        ddlSSex.SelectedIndex = 1;
                    txtSAge.Text = ds.Tables[0].Rows[0]["SAge"].ToString();
                    txtSAddress.Text = ds.Tables[0].Rows[0]["SAddress"].ToString();
                    txtSPhone.Text = ds.Tables[0].Rows[0]["SPhone"].ToString();
                    lbSCredit.Text = ds.Tables[0].Rows[0]["SCredit"].ToString();
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

        protected void btnUpdate_Click(object sender, System.EventArgs e)
        {
            try
            {
                int age = Int32.Parse(txtSAge.Text.Trim());
            }
            catch
            {
                Response.Write(MyUtility.Alert("����ȷ�������䣡"));
                return;
            }
            string sql = "update Student set SName = '"+txtSName.Text.Trim()+"'"+
                ",SSex = '"+ddlSSex.SelectedItem.Text+"'"+
                ",SAge = "+txtSAge.Text.Trim()+
                ",SAddress = '"+txtSAddress.Text.Trim()+"'"+
                ",SPhone = '"+txtSPhone.Text.Trim()+"'"+
                " where SId like '"+Session["Id"].ToString()+"'";
            if ( Db.ExecuteSql(sql) == 1 )
                Response.Write(MyUtility.Alert("�޸ĳɹ���"));
            else
                Response.Write(MyUtility.Alert("�޸�ʧ�ܣ�"));
        }

        protected void btnUpdateKey_Click(object sender, System.EventArgs e)
        {
            if ( txtKey.Text.Trim() != txtKeyConfirm.Text.Trim() )
            {
                Response.Write(MyUtility.Alert("�����������벻�����"));
                return;
            }
            string sql = "update Student set SKey = '"+MyUtility.MD5(txtKey.Text.Trim())+"' where SId = '"+Session["Id"].ToString()+"'";
            if ( Db.ExecuteSql(sql) == 1 )
                Response.Write(MyUtility.Alert("�޸ĳɹ���"));
            else
                Response.Write(MyUtility.Alert("�޸�ʧ�ܣ�"));;
        }
	}
}
