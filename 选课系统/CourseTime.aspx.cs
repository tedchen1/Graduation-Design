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
	/// WebForm1 ��ժҪ˵����
	/// </summary>
	public partial class WebForm1 : System.Web.UI.Page
	{
    
        private static int CId = 0;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( ! IsPostBack )
            {
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
                    else
                        lbCaption.Text = "�ÿγ̻�û�������Ͽ�ʱ��ص㣡�뾡�����ã�";
                }

                Label13.Visible = false;
                ddlRoom.Visible = false;
                Label9.Visible = false;
                ddlBuilding.Visible = false;
                lbTime2.Visible = false;
                Label10.Visible = false;
                ddlCWeekEnd.Visible = false;
                Label11.Visible = false;
                ddlCWeekStart.Visible = false;
                Label12.Visible = false;
                Label5.Visible = false;
                btnAddTime.Visible = false;
                ddlWeek.Visible = false;
                ddlTime.Visible = false;
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
            this.dgTime.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgTime_DeleteCommand);

        }
		#endregion

        protected void lkbAddTime_Click(object sender, System.EventArgs e)
        {
            //��ѧ¥
            ddlBuilding.Items.Clear();
            ddlBuilding.Items.Add("��ѡ��");
            string sql = "select BuildingId,BuildingName from Building";
            DataSet ds1 = Db.ExecuteSelectSql(sql);
            if ( ds1 != null && ds1.Tables.Count > 0 )
            {
                for ( int i = 0; i < ds1.Tables[0].Rows.Count; i++ )
                    ddlBuilding.Items.Add( new ListItem( ds1.Tables[0].Rows[i]["BuildingName"].ToString(), ds1.Tables[0].Rows[i]["BuildingId"].ToString() ) );
            }
            ddlBuilding.SelectedIndex = 0;

            //����
            ddlRoom.Items.Clear();
            ddlRoom.Items.Add("��ѡ��");
            ddlRoom.SelectedIndex = 0;

            //��ʼ�ܴ�
            ddlCWeekStart.Items.Clear();
            ddlCWeekStart.Items.Add("��ѡ��");
            for ( int i = 1; i <= 22; i++ )
                ddlCWeekStart.Items.Add( i.ToString() );
            ddlCWeekStart.SelectedIndex = 0;

            //�����ܴ�
            ddlCWeekEnd.Items.Clear();
            ddlCWeekEnd.Items.Add("��ѡ��");
            ddlCWeekEnd.SelectedIndex = 0;

            //��һ�ο�ʱ�䣬�ڶ��ο�ʱ��
            ddlWeek.Items.Clear();  
            ddlWeek.Items.Add("��ѡ��");
            for ( int i = 1; i <= 7; i++ )
            {
                if ( i == 7 )
                {
                    ddlWeek.Items.Add( new ListItem( "������", "7") );
                }
                else
                {
                    ddlWeek.Items.Add( new ListItem( "����"+i.ToString(), i.ToString() ) ) ;
                }
            }
            ddlWeek.SelectedIndex = 0;

            ddlTime.Items.Clear();
            ddlTime.Items.Add("��ѡ��");
            for ( int i = 1; i <= 6; i++ )
            {
                int t1 = 2 * i - 1;
                int t2 = 2 * i;
                ddlTime.Items.Add( new ListItem("��"+t1.ToString()+"-"+t2.ToString()+"�ڿ�", t1.ToString()+t2.ToString() ) );
            }
            ddlTime.SelectedIndex = 0;

            Label13.Visible = true;
            ddlRoom.Visible = true;
            Label9.Visible = true;
            ddlBuilding.Visible = true;
            lbTime2.Visible = true;
            Label10.Visible = true;
            ddlCWeekEnd.Visible = true;
            Label11.Visible = true;
            ddlCWeekStart.Visible = true;
            Label12.Visible = true;
            Label5.Visible = true;
            btnAddTime.Visible = true;
            ddlWeek.Visible = true;
            ddlTime.Visible = true;
        }

        protected void ddlCWeekStart_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ( ddlCWeekStart.SelectedIndex > 0 )
            {
                ddlCWeekEnd.Items.Clear();
                ddlCWeekEnd.Items.Add("��ѡ��");
                int start = Int32.Parse(ddlCWeekStart.SelectedItem.Value);
                for ( int i = start; i <= 23; i++ )
                    ddlCWeekEnd.Items.Add( i.ToString() );
                ddlCWeekEnd.SelectedIndex = 0;
            }
        }

        protected void ddlBuilding_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ( ddlBuilding.SelectedIndex > 0 )
            {
                ddlRoom.Items.Clear();
                ddlRoom.Items.Add("��ѡ��");
                string sql = "select * from Room where BuildingId = "+ddlBuilding.SelectedItem.Value;
                DataSet ds = Db.ExecuteSelectSql(sql);
                if ( ds != null && ds.Tables.Count > 0 )
                {
                    
                    for ( int i = 0; i < ds.Tables[0].Rows.Count; i++ )
                        ddlRoom.Items.Add( new ListItem(ds.Tables[0].Rows[i]["RoomName"].ToString()+"(����"+ds.Tables[0].Rows[i]["RoomSize"].ToString()+"��)", ds.Tables[0].Rows[i]["RoomId"].ToString() ) );
                }
                ddlRoom.SelectedIndex = 0;
            }
        }

        protected void btnAddTime_Click(object sender, System.EventArgs e)
        {
            #region check input
            if ( ddlBuilding.SelectedIndex <= 0 )
            {
                Response.Write( MyUtility.Alert("��ѡ��εĽ�ѧ¥��") );
                return;
            }
            if ( ddlRoom.SelectedIndex <= 0 )
            {
                Response.Write( MyUtility.Alert("��ѡ��εĽ��ң�") );
                return;
            }
            if ( ddlCWeekStart.SelectedIndex <= 0 )
            {
                Response.Write( MyUtility.Alert("��ѡ��γ̿�ʼ�ܴΣ�") );
                return;
            }
            if ( ddlCWeekEnd.SelectedIndex <= 0 )
            {
                Response.Write( MyUtility.Alert("��ѡ��γ̽����ܴΣ�") );
                return;
            }
            if ( ddlWeek.SelectedIndex <= 0 || ddlTime.SelectedIndex <= 0 )
            {
                Response.Write( MyUtility.Alert("��ѡ���Ͽε�ʱ�䣡") );
                return;
            }
            #endregion

            string sql = "select * from CourseTime where RoomId = "+ddlRoom.SelectedItem.Value+" and CTime like '"+ddlWeek.SelectedItem.Text+ddlTime.SelectedItem.Text+"'";
            DataSet ds = Db.ExecuteSelectSql(sql);
            bool flag = true;
            if ( ds != null && ds.Tables.Count > 0 )
            {
                int ws = Int32.Parse(ddlCWeekStart.SelectedItem.Text);
                int we = Int32.Parse(ddlCWeekEnd.SelectedItem.Text);
                for ( int i = 0; i < ds.Tables[0].Rows.Count; i++ )
                {
                    int nws = Int32.Parse(ds.Tables[0].Rows[i]["CWeekStart"].ToString());
                    int nwe = Int32.Parse(ds.Tables[0].Rows[i]["CWeekEnd"].ToString());
                    if ( we < nws || ws > nwe )
                        flag = true;
                    else
                        flag = false;
                }
            }
            if ( flag == false )
            {
                Response.Write(MyUtility.Alert("��ѡ���ʱ��ص�������γ��г�ͻ����Ǹ�����ٴ�ѡ��"));
                return;
            }
            else
            {
                if ( CId != 0 )
                {
                    sql = "insert into CourseTime(CId,RoomId,CWeekStart,CWeekEnd,CTime) "+
                        "values("+CId.ToString()+
                        ","+ddlRoom.SelectedItem.Value+
                        ","+ddlCWeekStart.SelectedItem.Text+
                        ","+ddlCWeekEnd.SelectedItem.Text+
                        ",'"+ddlWeek.SelectedItem.Text+ddlTime.SelectedItem.Text+"')";
                    Db.ExecuteSql(sql);
                }   
            }

            Label13.Visible = false;
            ddlRoom.Visible = false;
            Label9.Visible = false;
            ddlBuilding.Visible = false;
            lbTime2.Visible = false;
            Label10.Visible = false;
            ddlCWeekEnd.Visible = false;
            Label11.Visible = false;
            ddlCWeekStart.Visible = false;
            Label12.Visible = false;
            Label5.Visible = false;
            btnAddTime.Visible = false;
            ddlWeek.Visible = false;
            ddlTime.Visible = false;

            sql = "select CourseTime.*,Building.*,Room.RoomName from CourseTime,Building,Room where CId = "+CId.ToString()+" and CourseTime.RoomId = Room.RoomId and Room.BuildingId = Building.BuildingId";
            DataSet ds1 = Db.ExecuteSelectSql(sql);
            if ( ds1 != null && ds1.Tables.Count > 0 )
            {
                dgTime.DataSource = ds1.Tables[0];
                dgTime.DataBind();
                lbCaption.Text = "�ÿγ����� "+ds1.Tables[0].Rows.Count.ToString()+" ��ʱ��Σ�";
            }
            else
                lbCaption.Text = "�ÿγ̻�û�������Ͽ�ʱ��ص㣡�뾡�����ã�";

        }

        private void dgTime_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            int index = e.Item.ItemIndex;
            string sWeekStart = dgTime.Items[index].Cells[0].Text.Trim();
            string sWeekEnd = dgTime.Items[index].Cells[1].Text.Trim();
            string sRoomId = dgTime.Items[index].Cells[4].Text.Trim();
            string sTime = dgTime.Items[index].Cells[6].Text.Trim();
            string sql = "delete from CourseTime where CId = "+CId.ToString()+
                " and CWeekStart = "+sWeekStart+
                " and CWeekEnd = "+sWeekEnd+
                " and RoomId = "+sRoomId+
                " and CTime like '"+sTime+"'";
            Db.ExecuteSql(sql);

            sql = "select CourseTime.*,Building.*,Room.RoomName from CourseTime,Building,Room where CId = "+CId.ToString()+" and CourseTime.RoomId = Room.RoomId and Room.BuildingId = Building.BuildingId";
            DataSet ds1 = Db.ExecuteSelectSql(sql);
            if ( ds1 != null && ds1.Tables.Count > 0 )
            {
                dgTime.DataSource = ds1.Tables[0];
                dgTime.DataBind();
                lbCaption.Text = "�ÿγ����� "+ds1.Tables[0].Rows.Count.ToString()+" ��ʱ��Σ�";
            }
            else
                lbCaption.Text = "�ÿγ̻�û�������Ͽ�ʱ��ص㣡�뾡�����ã�";       
        }
	}
}
