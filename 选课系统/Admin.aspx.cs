using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace sc
{
    /// <summary>
    /// Admin ��ժҪ˵����
    /// </summary>
    public partial class Admin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // �ڴ˴������û������Գ�ʼ��ҳ��
            if (!IsPostBack)
            {
                Label2.Visible = false;
                Label3.Visible = false;
                Label1.Visible = false;
                txttimeStart.Visible = false;
                btnNew.Visible = false;
                txtTimeEnd.Visible = false;

                StreamReader sr = new StreamReader(ConfigurationSettings.AppSettings["time.txt"]);
                string strStart = sr.ReadLine();
                string strEnd = sr.ReadLine();
                sr.Close();
                DateTime dtStart = DateTime.Parse(strStart);
                DateTime dtEnd = DateTime.Parse(strEnd);
                lbTime.Text = "ѡ��ʱ��Ϊ��" + dtStart.ToString() + "��" + dtEnd.ToString();
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

        protected void lbtnNew_Click(object sender, System.EventArgs e)
        {
            Label2.Visible = true;
            Label3.Visible = true;
            Label1.Visible = true;
            txttimeStart.Visible = true;
            btnNew.Visible = true;
            txtTimeEnd.Visible = true;
        }

        protected void btnNew_Click(object sender, System.EventArgs e)
        {
            DateTime dtStart, dtEnd;
            try
            {
                dtStart = DateTime.Parse(txttimeStart.Text);
                dtEnd = DateTime.Parse(txtTimeEnd.Text);
            }
            catch
            {
                Response.Write(MyUtility.Alert("�������"));
                return;
            }
            StreamWriter sw = new StreamWriter("C:/Users/ted/Desktop/Graduation Design/ѡ��ϵͳ/time.txt", false);
            sw.WriteLine(dtStart.ToString());
            sw.WriteLine(dtEnd.ToString());
            sw.Close();
            lbTime.Text = "ѡ��ʱ��Ϊ��" + dtStart.ToString() + "��" + dtEnd.ToString();
            Label2.Visible = false;
            Label3.Visible = false;
            Label1.Visible = false;
            txttimeStart.Visible = false;
            btnNew.Visible = false;
            txtTimeEnd.Visible = false;
        }
    }
}
