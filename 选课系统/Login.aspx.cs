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
using System.Data.SqlClient;
using System.Configuration;


namespace sc
{
	/// <summary>
	/// WebForm1 ��ժҪ˵����
	/// </summary>
	public partial class Login : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
           /* int chk = MyUtility.CheckTime();
            if ( chk < 0 )
                Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_SCTIMEEARLY.ToString());
            else if ( chk > 0 )
                Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_SCTIMELATE.ToString());
//            string sql = " update Admin set AKey = '"+MyUtility.MD5("admin")+"'";
//            Db.ExecuteSql(sql);*/
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

        protected void btnLogin_Click(object sender, System.EventArgs e)
        {
            int type = Int32.Parse(ddlType.SelectedItem.Value);
            string user = txtUser.Text.Trim();
            string inputkey = txtKey.Text.Trim();
            string key = "";
            string sql = "";
            DataSet ds;
            switch( type )
            {
                case    1://ѧ��
                    sql = "select SKey from Student where SId like '"+user+"'";
                    ds = Db.ExecuteSelectSql(sql);
                    if ( ds!=null&&ds.Tables.Count>0&&ds.Tables[0].Rows.Count>0&&!ds.Tables[0].Rows[0].IsNull(0) )
                    {
                        key = ds.Tables[0].Rows[0][0].ToString();
                        if ( MyUtility.MD5(inputkey) == key )//������ȷ��½�ɹ�
                        {
                            Session["Id"] = user;
                            Session["Type"] = type;
                            //Response.Write(MyUtility.Alert("ѧ��"+user+"��½�ɹ�"));
                            Response.Redirect("StudentMain.aspx");
                        }
                        else//�������
                        {
                            Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_KEYERROR.ToString());
                        }
                    }
                    else//�����ڸ�ѧ��
                    {
                        Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_NOSTUDENT.ToString());
                    }
                    break;
                case    2://��ʦ
                    sql = "select TKey from Teacher where TId like '"+user+"'";
                    ds = Db.ExecuteSelectSql(sql);
                    if(ds!=null&&ds.Tables.Count>0&&ds.Tables[0].Rows.Count>0&&!ds.Tables[0].Rows[0].IsNull(0))
                    {
                        key = ds.Tables[0].Rows[0][0].ToString();
                        if ( MyUtility.MD5(inputkey) == key )//������ȷ��½�ɹ�
                        {
                            Session["Id"] = user;
                            Session["Type"] = type;
                            //Response.Write(MyUtility.Alert("��ʦ"+user+"��½�ɹ�"));
                            Response.Redirect("TeacherMain.aspx");
                        }
                        else
                        {
                            Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_KEYERROR.ToString());
                        }
                    }
                    else
                    {
                        Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_NOTEACHER.ToString());
                    }
                    break;
                case    3://ϵͳ����Ա
                    sql = "select AKey from Admin where AId like '"+user+"'";
                    ds = Db.ExecuteSelectSql(sql);
                    if(ds!=null&&ds.Tables.Count>0&&ds.Tables[0].Rows.Count>0&&!ds.Tables[0].Rows[0].IsNull(0))
                    {
                        key = ds.Tables[0].Rows[0][0].ToString();
                        if ( MyUtility.MD5(inputkey) != key )//������ȷ��½�ɹ�
                        {
                            Session["Id"] = user;
                            Session["Type"] = type;
                           // Response.Write(MyUtility.Alert("ϵͳ����Ա"+user+"��½�ɹ�"));

                            Response.Redirect("Admin.aspx");
                        }
                        else//�������
                        {
                            Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_KEYERROR.ToString());
                            //Console.WriteLine(MyUtility.MD5(inputkey));
                        }
                    }
                    else//�����ڸ�ϵͳ����Ա
                    {
                        Response.Redirect("Error.aspx?code="+ErrorInfo.ERR_NOADMIN.ToString());
                    }
                    break;
                default:
                    break;
            }
        }
	}
}
