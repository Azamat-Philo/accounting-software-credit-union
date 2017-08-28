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
        private string strConString;
        public void DBConnect(){
            SqlConnection connection = new SqlConnection();
            try
            {
                strConString = System.Configuration.ConfigurationManager.ConnectionStrings["myConnection"].ToString();
                
           
                connection.Open();
                Console.Write("Connect"); 
            }
            catch (Exception e) {
               
               connection.Close();
            }
        }

        public static void updateQuery(string strQuery)
        { 

        }
    }
}
