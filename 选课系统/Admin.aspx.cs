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
    /// Admin 的摘要说明。
    /// </summary>
    public partial class Admin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
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
                lbTime.Text = "选课时间为：" + dtStart.ToString() + "到" + dtEnd.ToString();
            }
        }

        #region Web 窗体设计器生成的代码
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
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
                Response.Write(MyUtility.Alert("输入错误"));
                return;
            }
            StreamWriter sw = new StreamWriter("C:/Users/ted/Desktop/Graduation Design/选课系统/time.txt", false);
            sw.WriteLine(dtStart.ToString());
            sw.WriteLine(dtEnd.ToString());
            sw.Close();
            lbTime.Text = "选课时间为：" + dtStart.ToString() + "到" + dtEnd.ToString();
            Label2.Visible = false;
            Label3.Visible = false;
            Label1.Visible = false;
            txttimeStart.Visible = false;
            btnNew.Visible = false;
            txtTimeEnd.Visible = false;
        }
    }
}
