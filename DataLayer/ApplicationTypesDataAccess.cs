using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class ApplicationTypesDataAccess
    {
        public static bool GetApplicationTypeByID(int ApplicationTypeID , ref string ApplicationTypeTitle, ref float ApplicationFees){
            bool IsFound = false;
            SqlConnection connection = new SqlConnection (ConnString.ConnectionString);
            string Query = "Select * from ApplicationTypes Where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@ApplicationTypeID",ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()){
                    IsFound = true; 
                    ApplicationTypeTitle = (string) reader["ApplicationTypeTitle"];
                    ApplicationFees = (float) reader["ApplicationFees"];
                }
                else
                    IsFound = false;
                
                reader.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{connection.Close();}
            return IsFound;
        }
    
        public static DataTable GetAllApplicationTypes(){
            DataTable dt = new DataTable();
            SqlConnection connection =new SqlConnection(ConnString.ConnectionString);
            string Query = "Select * from ApplicationTypes order by ApplicationTypeTitle";
            SqlCommand command = new SqlCommand(Query,connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                    dt.Load(reader);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                connection.Close();
            }
            return dt;
        }
    
        //Add !

        //Update !

    }
}