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

        public static int AddNewApplicationType(string Title, float Fees)
        {
            int ApplicationTypeID = -1;

            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);

            string query = @"Insert Into ApplicationTypes (ApplicationTypeTitle,ApplicationFees)
                            Values (@Title,@Fees)
                            
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", Title);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationTypeID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return ApplicationTypeID;

        }

        public static bool UpdateApplicationType(int ApplicationTypeID, string Title, float Fees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);

            string query = @"Update  ApplicationTypes  
                            set ApplicationTypeTitle = @Title,
                                ApplicationFees = @Fees
                                where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Fees", Fees);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }

}
