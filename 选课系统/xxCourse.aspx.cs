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
	/// xxCourse ��ժҪ˵����
	/// </summary>
	public partial class xxCourse : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
                string sql = "select x.*,TName,(select CName from Course as y where y.CId = x.CPreCId) as CPreCName from Course as x,Teacher where x.CType like 'ѡ��' and x.TId like Teacher.TId";
                DataSet ds = Db.ExecuteSelectSql(sql);
                if ( ds != null && ds.Tables.Count > 0 )
                {
                    dgCourse.DataSource = ds.Tables[0];
                    dgCourse.DataBind();
                    for ( int i = 0; i < ds.Tables[0].Rows.Count; i++ )
                    {
                        sql = "select count(*) from SC where CId = "+ds.Tables[0].Rows[i]["CId"].ToString();
                        DataSet ds1 = Db.ExecuteSelectSql(sql);
                        if ( ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0 )
                            dgCourse.Items[i].Cells[6].Text = ds1.Tables[0].Rows[0][0].ToString();
                    }
                }
                bool locked= bool.Parse(Session["Locked"].ToString());
                if ( ! locked )
                {
                    lbLock.Text = "����δ����ѡ����Ϣ��";
                }
                else
                {
                    lbLock.Text = "ѡ����Ϣ�ѱ�������";
                    dgCourse.Columns[9].Visible = false;
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
            this.dgCourse.ItemCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgCourse_ItemCommand);

        }
		#endregion

        private void dgCourse_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            if ( e.CommandName == "Select" )
            {
                string cid = e.Item.Cells[0].Text;
                string sql = "select * from SC where CId = "+cid+" and SId like '"+Session["Id"].ToString()+"'";
                DataSet ds = Db.ExecuteSelectSql(sql);
                bool flag = false;             //�Ƿ��Ѿ�ѡ�޹���
                if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
                    flag = true;
                if ( flag )
                {
                    Response.Write(MyUtility.Alert("���Ѿ�ѡ�˸ÿγ��ˣ�"));
                    return;
                }
                else
                {
                    sql = "select CPreCId from Course where CId = "+cid;
                    DataSet ds1 = Db.ExecuteSelectSql(sql);
                    if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
                    {
                        string cpcid = ds.Tables[0].Rows[0][0].ToString();
                        bool flag2 = false; //ǰ���γ��жϱ�־
                        //�ж�ǰ���γ��Ƿ��Ǳ��޿�
                        sql = "select CType from Course where CId = "+cpcid;
                        DataSet ds2 = Db.ExecuteSelectSql(sql);
                        if ( ds2 != null && ds2.Tables.Count > 0 && ds2.Tables[0].Rows.Count > 0 )
                        {
                            if ( ds2.Tables[0].Rows[0][0].ToString() == "����" )
                                flag2 = true;
                        }
                        else
                        {
                            //�ж��Ƿ����Ѿ�ѡ���ѡ�޿���
                            sql = "select * from SC where SId like '"+Session["Id"].ToString()+"' and CId = "+cpcid;
                            DataSet ds3 = Db.ExecuteSelectSql(sql);
                            if ( ds3 != null && ds3.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
                                flag2 = true;
                        }
                        if ( flag2 )
                        {//��ǰ���γ̣���ǰ���γ��Ǳ��޿λ����Ѿ�ѡ����ѡ�޿γ�
                            SelectCourse(Int32.Parse(cid));
                            return;
                        }
                        else
                        {//��ǰ���γ̣�ǰ���γ̲����Ǳ��޿Σ�Ҳ�����Ѿ�ѡ���˵�ѡ�޿γ̣�����ѡ
                            Response.Write(MyUtility.Alert("����ѡ��ÿγ̵�ǰ���γ�"));
                            return;
                        }
                    }
                    else //û��ǰ���γ�
                    {
                        SelectCourse(Int32.Parse(cid));
                    }
                }
            }
        }

        private void SelectCourse(int cid)
        {
            int max=0,current=0;
            string sql = "select CMax from Course where CId = "+cid.ToString();
            DataSet ds = Db.ExecuteSelectSql(sql);
            if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
                max = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());
            else
                return;
            sql = "select count(*) from SC where SId like '"+Session["Id"].ToString()+"' and CId = "+cid.ToString();
            DataSet ds1 = Db.ExecuteSelectSql(sql);
            if ( ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0 )
                current = Int32.Parse(ds1.Tables[0].Rows[0][0].ToString());
            else
                return;
            if ( current > max )
            {
                Response.Write(MyUtility.Alert("����������"));
                return;
            }
            sql = "insert into SC values('"+Session["Id"].ToString()+"',"+cid+",0)";
            if ( Db.ExecuteSql(sql) == 1 )
                Response.Write(MyUtility.Alert("ѡ�γɹ�"));
            else
                Response.Write(MyUtility.Alert("ѡ��ʧ��"));
        }
	}
}
