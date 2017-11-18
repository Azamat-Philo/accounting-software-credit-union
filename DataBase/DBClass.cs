using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DataBase
{
    public class DBClass
    {
        public static SqlConnection connection;
        private static string strConString;
        public static void DBConnect()
        {

            strConString = System.Configuration.ConfigurationManager.ConnectionStrings["myConnection"].ToString();
            try
            {
                connection = new SqlConnection(strConString);
                connection.Open();
                Console.Write("Connect");
            }
            catch (Exception e)
            {
                LogValidationManagement.LogFile.LogData(System.Reflection.MethodBase.GetCurrentMethod(), e.ToString(), 0);
                connection.Close();
            }
        }

        public static void DBClose()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                LogValidationManagement.LogFile.LogData(System.Reflection.MethodBase.GetCurrentMethod(), e.ToString(), 0);
                connection.Close();
            }
        }

        public void updateSt(string strQuery)
        {
            SqlCommand drCommand = new SqlCommand(strQuery);
        }

        public SqlDataReader selectOneRow(string strQuery)
        {
            SqlCommand drCommand = null;
            SqlDataReader reader = null;
            try
            {
                DBConnect();
                drCommand = new SqlCommand(strQuery);
                reader = drCommand.ExecuteReader();
                reader.Read();
            }
            catch (Exception ex)
            {
                LogValidationManagement.LogFile.LogData(System.Reflection.MethodBase.GetCurrentMethod(), ex.ToString(), 0);
            }
            if (reader.HasRows)
                return reader;
            else
                return reader = null;

        }

        public SqlDataReader selectMultipleRow(string strQuery)
        {


            SqlCommand drCommand = null;
            SqlDataReader reader = null;
            try
            {
                drCommand = new SqlCommand(strQuery);
                reader = drCommand.ExecuteReader();
                reader.Read();
            }
            catch (Exception ex)
            {
                LogValidationManagement.LogFile.LogData(System.Reflection.MethodBase.GetCurrentMethod(), ex.ToString(), 0);
            }
            if (reader.HasRows)
                return reader;
            else
                return reader = null;


        }

        public int insertQuery(string strQuery)
        {
            int result = 0;
            try
            {
                DBConnect();
                SqlCommand drCommand = new SqlCommand(strQuery, connection);
                result = drCommand.ExecuteNonQuery();
            } catch (SqlException ex) {
                LogValidationManagement.LogFile.LogData(System.Reflection.MethodBase.GetCurrentMethod(), ex.ToString(), 0);
                DBClose();
            }
            return result;
        }
    }
}
