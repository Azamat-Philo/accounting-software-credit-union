using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Configuration;

namespace CreditUnionFYP.classes
{
    public class DBClass
    {
        private static string strConString;
        public static void DBConnect(){
            SqlConnection connection = new SqlConnection();
            try
            {
                strConString = System.Configuration.ConfigurationManager.ConnectionStrings["myConnection"].ToString();
                
           
                connection.Open();
                Console.Write("Connect"); 
            }
            catch (Exception e) {
                LogFile lg = new LogFile("Database connection error", e.ToString(), 0);
                lg.WriteLog();
                connection.Close();
            }
        }

        public static void updateQuery(string strQuery)
        { 

        }
    }
}
