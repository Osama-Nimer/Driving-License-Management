using System;
using System.Data;
using System.Data.SqlClient;
namespace DataLayer
{
    public class CountryDataAccess
    {
        public static bool GetCountryById(int CountryID, ref string CountryName)
        {
            bool IsFound = false;
            string Query = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID";

            using (SqlConnection connection = new SqlConnection(ConnString.ConnectionString))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.AddWithValue("@CountryID", CountryID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsFound = true;
                            CountryName = reader["CountryName"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString()); // Log full exception details
                    throw; // Re-throw the exception
                }
            }

            return IsFound;
        }



        public static bool GetCountryByName(String CountryName, ref int CountryID ){
            bool IsFound =false ;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            String Query = "Select * from Countries where CountryName = @CountryName";
            SqlCommand command =new SqlCommand(Query ,connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read()){
                    IsFound=true;
                    CountryID = (int) reader["CountryID"];
                    reader.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally{
                connection.Close();
            }
            return IsFound;
        }
        
        public static DataTable GetAllCountries(){
            DataTable dt=new DataTable();
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            String Query = "SELECT * FROM Countries order by CountryName";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                    dt.Load(reader);
                reader.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{
                connection.Close();
            }
            return dt;
        }
    }
}