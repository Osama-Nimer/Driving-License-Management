namespace DataLayer;
using System.Data.SqlClient;
public class clsPepoleData
{
    public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName,
    ref string ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth,
    ref short Gendor,ref string Address,  ref string Phone, ref string Email,
    ref int NationalityCountryID, ref string ImagePath){
        bool isFound=false;
         SqlConnection conn = new SqlConnection(ConnString.ConnectionString);
         String Query = "select * from People where PersonID = @PersonID";
         SqlCommand command =new SqlCommand(Query,conn);
         command.Parameters.AddWithValue("@PersonID",PersonID);
         try
         {
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read()){
                isFound=true;
                FirstName = (String )reader["FirstName"];
                SecondName = (String )reader["SecondName"];
                if(reader["ThirdName"] != DBNull.Value)
                    ThirdName = (String) reader["ThirdName"];
                else
                    ThirdName = "";
                LastName = (String)reader["LastName"];
                NationalNo = (String)reader["NationalNo"];
                DateOfBirth = (DateTime)reader["DateOfBirth"];
                Gendor = (short)reader["Gendor"];
                Address = (String) reader["Address"];
                Phone = (String) reader["Phone"];
                if(reader["Email"] != DBNull.Value)
                    Email = (String) reader["Email"];
                else
                    Email = "";
                
                NationalityCountryID = (int) reader["NationalityCountryID"]; 

                if(reader["ImagePath"] != DBNull.Value)
                    ImagePath = (String) reader["ImagePath"];
                else
                    ImagePath = "";

                    reader.Close();
            }
            else
                isFound=false;
                
         }
         catch (Exception e)
         {
            Console.WriteLine(e.Message);
         } 
         finally{
            conn.Close();
            
         }
         return isFound;
    }

    public static bool GetPersonInfoByNationalNo( int NationalNo,ref int PersonID, ref string FirstName, ref string SecondName,
    ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
    ref short Gendor,ref string Address,  ref string Phone, ref string Email,
    ref int NationalityCountryID, ref string ImagePath){
        bool isFound=false;
         SqlConnection conn = new SqlConnection(ConnString.ConnectionString);
         String Query = "select * from People where NationalNo = @NationalNo";
         SqlCommand command =new SqlCommand(Query,conn);
         command.Parameters.AddWithValue("@NationalNo",NationalNo);
         try
         {
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read()){
                isFound=true;
                PersonID = (int) reader["PersonID"];
                FirstName = (String )reader["FirstName"];
                SecondName = (String )reader["SecondName"];
                if(reader["ThirdName"] != DBNull.Value)
                    ThirdName = (String) reader["ThirdName"];
                else
                    ThirdName = "";
                LastName = (String)reader["LastName"];
                DateOfBirth = (DateTime)reader["DateOfBirth"];
                Gendor = (short)reader["Gendor"];
                Address = (String) reader["Address"];
                Phone = (String) reader["Phone"];
                if(reader["Email"] != DBNull.Value)
                    Email = (String) reader["Email"];
                else
                    Email = "";
                
                NationalityCountryID = (int) reader["NationalityCountryID"]; 

                if(reader["ImagePath"] != DBNull.Value)
                    ImagePath = (String) reader["ImagePath"];
                else
                    ImagePath = "";

                    reader.Close();
            }
            else
                isFound=false;
                
         }
         catch (Exception e)
         {
            Console.WriteLine(e.Message);
         } 
         finally{
            conn.Close();
            
         }
         return isFound;
    }
}
