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

        //Add 

        //Update
    }
}