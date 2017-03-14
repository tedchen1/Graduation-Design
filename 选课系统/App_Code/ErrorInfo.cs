using System;

namespace sc
{
	/// <summary>
	/// ������Ϣ��
	/// </summary>
	public class ErrorInfo
	{
        public const int ERR_DATABASE = 0;
        public const int ERR_NOSTUDENT = 1;
        public const int ERR_NOTEACHER = 2;
        public const int ERR_NOADMIN = 3;
        public const int ERR_KEYERROR = 4;
        public const int ERR_SCTIMEEARLY = 5;
        public const int ERR_SCTIMELATE = 6;
        public const int ERR_NOTLOGIN = 7;
        public const int ERR_NOTTEACHER = 8;
        public const int ERR_NOTADMIN = 9;

		public ErrorInfo()
		{
		}

        public static string Message(int errorCode)
        {
            switch(errorCode)
            {
                case    ERR_DATABASE :
                    return "���ݿ����";
                case    ERR_NOSTUDENT:
                    return "û�и�ѧ����";
                case    ERR_NOTEACHER:
                    return "û�и���ʦ��";
                case ERR_NOADMIN:
                    return "û�и�ϵͳ����Ա��";
                case    ERR_KEYERROR:
                    return "�������";
                case    ERR_SCTIMEEARLY:
                    return "ѡ��ʱ��δ��������ѡ�Σ�";
                case ERR_SCTIMELATE:
                    return "ѡ��ʱ���ѹ�������ѡ�Σ�";
                case ERR_NOTLOGIN:
                    return "δ��½�������ȵ�½��";
                case ERR_NOTTEACHER:
                    return "�Բ�����������ʦ��û��Ȩ�ޣ�";
                case ERR_NOTADMIN:
                    return "�Բ���������ϵͳ����Ա��û��Ȩ�ޣ�";
                default:
                    return  "";
            }
        }
	}
}
