using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserDataAccess
    {
        public static bool GetUserByUserID(int UserID , ref int PersonID ,ref string UserName ,ref string Password , ref bool IsActive ){
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = @"Select * From Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand (Query , connection);
            command.Parameters.AddWithValue("@UserID",UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsActive = true;   
                    PersonID = (int) reader["PersonID"];
                    UserName = (string) reader["UserName"];
                    Password = (string) reader["Password"];
                    IsActive = (bool) reader["IsActive"];
                }
                else
                    IsFound = false;
                reader.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}
            return IsFound;
        }
    
        public static bool GetUserByPersonID(int PersonID , ref int  UserID ,ref string UserName ,ref string Password , ref bool IsActive ){
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = @"Select * From Users Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand (Query , connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsActive = true;   
                    UserID = (int) reader["UserID"];
                    UserName = (string) reader["UserName"];
                    Password = (string) reader["Password"];
                    IsActive = (bool) reader["IsActive"];
                }
                else
                    IsFound = false;
                reader.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}
            return IsFound;
        }

        public static bool GetUserByUserNameAndPassword(string UserName , string  Password ,ref int UserID  ,ref int PersonID  , ref bool IsActive ){
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = @"Select * From Users Where UserName = @UserName and Password = @Password";
            SqlCommand command = new SqlCommand (Query , connection);
            command.Parameters.AddWithValue("@UserName",UserName);
            command.Parameters.AddWithValue("@Password",Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    IsActive = true;   
                    UserID = (int) reader["UserID"];
                    PersonID = (int) reader["PersonID"];
                    IsActive = (bool) reader["IsActive"];
                }
                else
                    IsFound = false;
                reader.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}
            return IsFound;
        }



        public static int AddNewUser(int PersonID , string UserName ,string Password , bool IsActive){
            int userID = -1;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = @"INSERT INTO Users(PersonID,UserName,Password,IsActive)
                                VALUES(@PersonID ,@UserName, @Password, @IsActive);
                                select SCOPE_IDENTITY;";
            SqlCommand command = new SqlCommand(Query , connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);
            command.Parameters.AddWithValue("@UserName",UserName);
            command.Parameters.AddWithValue("@Password",Password);
            command.Parameters.AddWithValue("@IsActive",IsActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result!=null && int.TryParse(result.ToString() , out int InsertedID))
                    userID = InsertedID;
                else
                    userID = -1;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}

            return userID;
        }

    
        public static bool UpdateUser(int UserID,int PersonID , string UserName ,string Password , bool IsActive){
            int rows = 0;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = @"UPDATE Users
                            SET PersonID = @PersonID
                                ,UserName = @UserName
                                ,Password = @Password
                                ,IsActive = @IsActive
                            WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(Query , connection);
            command.Parameters.AddWithValue("@UserID",UserID);
            command.Parameters.AddWithValue("@PersonID",PersonID);
            command.Parameters.AddWithValue("@UserName",UserName);
            command.Parameters.AddWithValue("@Password",Password);
            command.Parameters.AddWithValue("@IsActive",IsActive);

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}

            return (rows > 0);
        }

        public static DataTable GetAllUsers(){
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection (ConnString.ConnectionString);
            string Query = "Select * From Users";
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
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}
            return dt;
        }


        public static bool DeleteUser(int UserID){
            int rows = 0 ;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = "Delete From Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand (Query,connection);
            command.Parameters.AddWithValue("@UserID",UserID);
            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);    
            }
            finally{connection.Close();}
            return (rows > 0);
        }

        public static bool IsUserExist(int UserID){
            bool IsFound = false;
            SqlConnection connection = new SqlConnection (ConnString.ConnectionString);
            string Query = "select Found=1 From Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@UserID",UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}
            return IsFound  ;
        }


        public static bool IsUserExist(string UserName){
            bool IsFound = false;
            SqlConnection connection = new SqlConnection (ConnString.ConnectionString);
            string Query = "select Found=1 From Users Where UserName = @UserName";
            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@UserName",UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}
            return IsFound;
        }

        public static bool IsUserExistForPersonID(int PersonID){
            bool IsFound = false;
            SqlConnection connection = new SqlConnection (ConnString.ConnectionString);
            string Query = "select Found=1 From Users Where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}
            return IsFound;
        }

        public static bool ChangePasword(int UserID,string Password){
            int rows = 0;
            SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
            string Query = @"UPDATE Users
                            SET Password = @Password
                            WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(Query , connection);
            command.Parameters.AddWithValue("@UserID",UserID);
            command.Parameters.AddWithValue("@Password",Password);

            try
            {
                connection.Open();
                rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally{connection.Close();}

            return (rows > 0);
        }
    }

}