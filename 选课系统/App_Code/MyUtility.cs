using System;
using System.IO;
using System.Text;
using System.Web.Security;
using System.Configuration;

namespace sc
{
	/// <summary>
	/// ������
	/// </summary>
	public class MyUtility
	{
		public MyUtility()
		{
		}

        /// <summary>
        /// MD5����
        /// </summary>
        /// <param name="str">�������ַ���</param>
        /// <returns>���ܺ��ַ���</returns>
        public static string MD5(string str)
        {
            string result = "";
            result = FormsAuthentication.HashPasswordForStoringInConfigFile(str,"MD5");
            return result;
        }

        /// <summary>
        /// HTML�ַ�������
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Encode(string str)
        {			
            str = str.Replace("&","&amp;");
            str = str.Replace("'","''");
            str = str.Replace("\"","&quot;");
            str = str.Replace(" ","&nbsp;");
            str = str.Replace("<","&lt;");
            str = str.Replace(">","&gt;");
            str = str.Replace("\n","<br>");
            return str;
        }

        /// <summary>
        /// HTML�ַ�������
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Decode(string str)
        {			
            str = str.Replace("<br>","\n");
            str = str.Replace("&gt;",">");
            str = str.Replace("&lt;","<");
            str = str.Replace("&nbsp;"," ");
            str = str.Replace("&quot;","\"");
            return str;
        }

        /// <summary>
        /// Alert��ʾһ���ַ���
        /// </summary>
        /// <param name="s">��Ҫ��ʾ���ַ���</param>
        /// <returns>Ϊ��Alert���ַ�����Ҫ��html�ַ���</returns>
        public static string Alert(string s)
        {
            return "<script language=\"javascript\">alert(\""+s+"\");</script>";
        }

        /// <summary>
        /// ���˵���i��ҳ��
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Ϊ�˺��˵���i��ҳ����Ҫ��html�ַ���</returns>
        public static string Back(int i)
        {
            return "<script language=\"javascript\">location.href=\"javascript:history.go("+i+");\";</script>";
        }
        /// <summary>
        /// ��鵱ǰʱ���Ƿ���ѡ��ʱ����
        /// </summary>
        /// <returns>
        /// -1:��δ��ѡ��ʱ��
        /// 0: ��ǰʱ�����ѡ��
        /// 1: ѡ��ʱ���ѹ�
        /// </returns>
        public static int CheckTime()
        {
            StreamReader sr = new StreamReader(ConfigurationSettings.AppSettings["time.txt"]);
            string strStart = sr.ReadLine();
            string strEnd = sr.ReadLine();
            sr.Close();
            DateTime dtStart = DateTime.Parse(strStart);
            DateTime dtEnd = DateTime.Parse(strEnd);
            DateTime dtNow = DateTime.Now;
            if ( dtNow > dtEnd )
                return 1;
            if ( dtNow < dtStart )
                return -1;
            return 0;
        }

        
        public static string GetWeekDayString(int i)
        {
            switch(i)
            {
                case 1:
                    return "����һ";
                case 2:
                    return "���ڶ�";
                case 3:
                    return "������";
                case 4:
                    return "������";
                case 5:
                    return "������";
                case 6:
                    return "������";
                case 7:
                    return "������";
                default:
                    return "";
            }
        }

        public static string GetTimeString(int i)
        {
            switch(i)
            {
                case 1:
                    return "��1-2�ڿ�";
                case 2:
                    return "��3-4�ڿ�";
                case 3:
                    return "��5-6�ڿ�";
                case 4:
                    return "��7-8�ڿ�";
                case 5:
                    return "��9-10�ڿ�";
                default:
                    return "";
            }
        }
		
        public static string GetTimeString(string s)
        {
            string r="";
            r += GetWeekDayString(s[0]-'0');
            r += GetTimeString(s[1]-'0');
            return r;
        }
	}
}
