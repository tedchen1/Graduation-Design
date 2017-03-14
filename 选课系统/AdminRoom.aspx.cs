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
	/// AdminRoom ��ժҪ˵����
	/// </summary>
	public partial class AdminRoom : System.Web.UI.Page
	{
    
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            if ( !IsPostBack )
            {
                string sql = "select * from Building";
                DataSet ds = Db.ExecuteSelectSql(sql);
                if ( ds != null && ds.Tables.Count > 0 )
                {
                    DataView dv = new DataView(ds.Tables[0]);
                    ddlBuilding.DataSource = dv;
                    ddlBuilding.DataTextField = "BuildingName";
                    ddlBuilding.DataValueField = "BuildingId";
                    ddlBuilding.DataBind();
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
            this.dgView.PageIndexChanged += new System.Web.UI.WebControls.DataGridPageChangedEventHandler(this.dgView_PageIndexChanged);
            this.dgView.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.dgView_DeleteCommand);

        }
		#endregion

        protected void btnAddBuilding_Click(object sender, System.EventArgs e)
        {
            if ( txtBuilding.Text.Trim() == "" )
            {
                Response.Write(MyUtility.Alert("�������ѧ¥���ƣ�"));
                return;
            }
            string sql = "insert into Building(BuildingName) values('"+txtBuilding.Text.Trim()+"')";
            Db.ExecuteSql(sql);
            sql = "select * from Building";
            DataSet ds = Db.ExecuteSelectSql(sql);
            if ( ds != null && ds.Tables.Count > 0 )
            {
                DataView dv = new DataView(ds.Tables[0]);
                ddlBuilding.DataSource = dv;
                ddlBuilding.DataTextField = "BuildingName";
                ddlBuilding.DataValueField = "BuildingId";
                ddlBuilding.DataBind();
            }
        }

        protected void lkbDeleteBuilding_Click(object sender, System.EventArgs e)
        {
            if ( ddlBuilding.SelectedIndex < 0 )
            {
                Response.Write(MyUtility.Alert("��ѡ��һ����ѧ¥��"));
                return;
            }
            string sql = "select count(*) from Room where BuildingId = "+ddlBuilding.SelectedItem.Value;
            DataSet ds = Db.ExecuteSelectSql(sql);
            int roomNum = 0;
            if ( ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 )
            {
               roomNum = (int)ds.Tables[0].Rows[0][0];
            }
            if ( roomNum > 0 )
            {
                Response.Write(MyUtility.Alert("����ɾ���ý�ѧ¥���н��ң�"));
                return;
            }
            else
            {
                sql = "delete from Building where BuildingId = "+ddlBuilding.SelectedItem.Value;
                Db.ExecuteSql(sql);
                sql = "select * from Building";
                DataSet ds2 = Db.ExecuteSelectSql(sql);
                if ( ds2 != null && ds2.Tables.Count > 0 )
                {
                    DataView dv = new DataView(ds2.Tables[0]);
                    ddlBuilding.DataSource = dv;
                    ddlBuilding.DataTextField = "BuildingName";
                    ddlBuilding.DataValueField = "BuildingId";
                    ddlBuilding.DataBind();
                }
            }
        }

        protected void lkbView_Click(object sender, System.EventArgs e)
        {
            if ( ddlBuilding.SelectedIndex < 0 )
            {
                Response.Write(MyUtility.Alert("��ѡ��һ����ѧ¥��"));
                return;
            }
            dgView.DataSource = null;
            dgView.DataBind();
            string sql = "select RoomId,RoomName,RoomSize from Room where BuildingId = "+ddlBuilding.SelectedItem.Value;
            DataSet ds = Db.ExecuteSelectSql(sql);
            if ( ds != null && ds.Tables.Count > 0 )
            {
                dgView.DataSource = ds.Tables[0];
             
                dgView.DataBind();
            }
        }

        protected void btnAddRoom_Click(object sender, System.EventArgs e)
        {
            if ( ddlBuilding.SelectedIndex < 0 )
            {
                Response.Write(MyUtility.Alert("��ѡ��һ����ѧ¥��"));
                return;
            }
            if ( txtRoomName.Text.Trim() == "" )
            {
                Response.Write(MyUtility.Alert("��ѡ����������ƣ�"));
                return;
            }
            if ( txtRoomSize.Text.Trim() == "" )
            {
                Response.Write(MyUtility.Alert("��������������ɵ�������"));
                return;
            }
            int size = 0;
            try
            {
                size = Int32.Parse(txtRoomSize.Text.Trim());
            }
            catch
            {
                Response.Write(MyUtility.Alert("��������ȷ�Ľ��������ɵ�������"));
                return;
            }
            string sql = "insert into Room(RoomName,BuildingId,RoomSize) values('"+txtRoomName.Text.Trim()+"',"+ddlBuilding.SelectedItem.Value+","+size.ToString()+")";
            Db.ExecuteSql(sql);
            sql = "select RoomId,RoomName,RoomSize from Room where BuildingId = "+ddlBuilding.SelectedItem.Value;
            DataSet ds = Db.ExecuteSelectSql(sql);
            if ( ds != null && ds.Tables.Count > 0 )
            {
                dgView.DataSource = ds.Tables[0];
                dgView.DataBind();
            }
        }

        //��Excel�ļ��е���
        private void LinkButton1_Click(object sender, System.EventArgs e)
        {
        
        }

        private void dgView_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            int index = e.Item.ItemIndex;
            string sId = dgView.Items[index].Cells[0].Text;
            string sql = "delete from Room where RoomId = "+sId;
            Db.ExecuteSql(sql);
            sql = "select RoomId,RoomName,RoomSize from Room where BuildingId = "+ddlBuilding.SelectedItem.Value;
            DataSet ds = Db.ExecuteSelectSql(sql);
            if ( ds != null && ds.Tables.Count > 0 )
            {
                dgView.DataSource = ds.Tables[0];    
                dgView.DataBind();
            }
        }

        private void dgView_PageIndexChanged(object source, System.Web.UI.WebControls.DataGridPageChangedEventArgs e)
        {
            dgView.CurrentPageIndex = e.NewPageIndex;
            string sql = "select RoomId,RoomName,RoomSize from Room where BuildingId = "+ddlBuilding.SelectedItem.Value;
            DataSet ds = Db.ExecuteSelectSql(sql);
            if ( ds != null && ds.Tables.Count > 0 )
            {
                dgView.DataSource = ds.Tables[0];
                
                dgView.DataBind();
            }
            
        }

    }
}
