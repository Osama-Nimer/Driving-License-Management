using System;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class TestTypsDataAccess
    {
        public static bool GetTestTypeByID(int TestTypeID ,ref string TestTypeTitle 
        ,ref string TestTypeDescription , ref float TestTypeFees){
            bool IsFound = false ;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = @"Select * from TestTypes where TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(Query , connection);
            command.Parameters.AddWithValue("@TestTypeID",TestTypeID);
            try
            {
              connection.Open();
              SqlDataReader reader = command.ExecuteReader();
              if(reader.Read())
              {
                IsFound = true;
                TestTypeTitle = (string)reader["TestTypeTitle"];
                TestTypeDescription = (string)reader["TestTypeDescription"];
                TestTypeFees = (float)reader["TestTypeFees"];
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


        public static DataTable GetAllTestTyps(){
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = "Select * from TestTypes";
            SqlCommand command = new SqlCommand(Query,connection);
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
                Console.WriteLine(e.Message);
            }
            finally{
                connection.Close();
            }
            return dt;
        }

        public static int AddNewTestType(string Title, string Description, float Fees)
        {
            int TestTypeID = -1;

            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);

            string query = @"Insert Into TestTypes (TestTypeTitle,TestTypeTitle,TestTypeFees)
                            Values (@TestTypeTitle,@TestTypeDescription,@ApplicationFees)
                            where TestTypeID = @TestTypeID;
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeTitle", Title);
            command.Parameters.AddWithValue("@TestTypeDescription", Description);
            command.Parameters.AddWithValue("@ApplicationFees", Fees);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestTypeID = insertedID;
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


            return TestTypeID;

        }

        public static bool UpdateTestType(int TestTypeID, string Title, string Description, float Fees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);

            string query = @"Update  TestTypes  
                            set TestTypeTitle = @TestTypeTitle,
                                TestTypeDescription=@TestTypeDescription,
                                TestTypeFees = @TestTypeFees
                                where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", Title);
            command.Parameters.AddWithValue("@TestTypeDescription", Description);
            command.Parameters.AddWithValue("@TestTypeFees", Fees);

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
