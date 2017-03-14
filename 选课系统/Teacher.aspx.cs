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
	/// Teacher ��ժҪ˵����
	/// </summary>
	public partial class Teacher : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
                lbTId.Text = Session["Id"].ToString();
                ddlTSex.Items.Clear();
                ddlTSex.Items.Add("��");
                ddlTSex.Items.Add("Ů");
                string sql = "select * from Teacher where TId like '"+lbTId.Text.Trim()+"'";
                DataSet ds = Db.ExecuteSelectSql(sql);
                if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
                {
                    txtTName.Text = ds.Tables[0].Rows[0]["TName"].ToString();
                    txtTAge.Text = ds.Tables[0].Rows[0]["TAge"].ToString();
                    txtTPhone.Text = ds.Tables[0].Rows[0]["TPhone"].ToString();
                    txtTMail.Text = ds.Tables[0].Rows[0]["TMail"].ToString();
                    if ( ds.Tables[0].Rows[0]["TSex"].ToString() == "��" )
                        ddlTSex.SelectedIndex = 0;
                    else
                        ddlTSex.SelectedIndex = 1;
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
                int age = Int32.Parse(txtTAge.Text.Trim());
            }
            catch
            {
                Response.Write(MyUtility.Alert("�����������"));
                return;
            }
            string sql = "update Teacher set TName = '"+txtTName.Text.Trim()+
                "',TAge = "+txtTAge.Text.Trim()+
                ",TSex = '"+ddlTSex.SelectedItem.Text+
                "',TPhone = '"+txtTPhone.Text.Trim()+
                "',TMail = '"+txtTMail.Text.Trim()+
                "' where TId = '"+Session["Id"].ToString()+"'";
            if ( Db.ExecuteSql(sql) == 1 )
                Response.Write(MyUtility.Alert("�޸ĳɹ���"));
            return;
        }

        protected void btnUpdatekey_Click(object sender, System.EventArgs e)
        {
            if ( txtKey.Text.Trim() != txtKeyConfirm.Text.Trim() )
            {
                Response.Write(MyUtility.Alert("�����������벻�����"));
                return;
            }
            string sql = "update Teacher set TKey = '"+MyUtility.MD5(txtKey.Text.Trim())+"' where TId = '"+Session["Id"].ToString()+"'";
            if ( Db.ExecuteSql(sql) == 1 )
                Response.Write(MyUtility.Alert("�޸ĳɹ���"));
            else
                Response.Write(MyUtility.Alert("�޸�ʧ�ܣ�"));
        }
	}
}
