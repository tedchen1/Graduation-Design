using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace sc
{
	/// <summary>
	/// ���ݿ����Ӳ�����
	/// </summary>
	public class Db
	{
        /// <summary>
        /// ���ݿ������ַ���
        /// </summary>
        protected static string connString = ConfigurationSettings.AppSettings["ConnectionString"];

		public Db()
		{
		}

        /// <summary>
        /// ִ��select���͵�sql���,����select�õ������ݼ�
        /// </summary>
        /// <param name="sqlSelect">select���</param>
        /// <returns>����select�õ������ݼ�</returns>
        public static DataSet ExecuteSelectSql( string sqlSelect )
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlDataAdapter sda = new SqlDataAdapter(sqlSelect,conn);
            DataSet ds = new DataSet();
            try
            {
                sda.Fill(ds);
            }
            catch(SqlException e)
            {
                throw new Exception(e.Message);
            }
            return ds;
        }

        /// <summary>
        /// ִ��insert,update,delete�����,�ı������
        /// </summary>
        /// <param name="sql">sql���</param>
        /// <returns>�ı������</returns>
        public static int ExecuteSql( string sql )
        {
            int rows = -1;
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql,conn);
            try
            {
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }    
            
            return rows;
        }

        /// <summary>
        /// ִ����Ҫ���ظղ����¼��identity��insert���,���ظı�����
        /// </summary>
        /// <param name="sqlInsert">insert���</param>
        /// <param name="identity">identity</param>
        /// <returns>���ظı�����</returns>
        public static int ExecuteInsertSql( string sqlInsert, ref int identity )
        {
            int rows = -1;
            SqlConnection conn = new SqlConnection(connString);			
            SqlCommand cmd = new SqlCommand();
            try
            {
                conn.Open();				
            }
            catch(SqlException e)
            {
                throw new Exception(e.Message);
            }

            SqlTransaction trans = conn.BeginTransaction();
            try
            {											
                cmd.Connection = conn;				
                cmd.Transaction = trans;
                //ִ��insert
                cmd.CommandText = sqlInsert;
                rows = cmd.ExecuteNonQuery();
                //select��identity
                cmd.CommandText = "select @@identity";
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {
                    identity = sdr.GetInt32(0);
                }

                trans.Commit();             
            }
            catch(System.Data.SqlClient.SqlException e)
            {			
                trans.Rollback();
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return rows;
        }

	}
}
