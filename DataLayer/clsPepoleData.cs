namespace DataLayer;

using System.Data;
using System.Data.SqlClient;
public class clsPepoleData
{
    public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string SecondName,
    ref string ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth,
    ref short Gendor, ref string Address, ref string Phone, ref string Email,
    ref int NationalityCountryID, ref string ImagePath)
    {
        bool isFound = false;
        SqlConnection conn = new SqlConnection(ConnString.ConnectionString);
        String Query = "select * from People where PersonID = @PersonID";
        SqlCommand command = new SqlCommand(Query, conn);
        command.Parameters.AddWithValue("@PersonID", PersonID);
        try
        {
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                isFound = true;
                FirstName = (String)reader["FirstName"];
                SecondName = (String)reader["SecondName"];
                if (reader["ThirdName"] != DBNull.Value)
                    ThirdName = (String)reader["ThirdName"];
                else
                    ThirdName = "";
                LastName = (String)reader["LastName"];
                NationalNo = (String)reader["NationalNo"];
                DateOfBirth = (DateTime)reader["DateOfBirth"];
                Gendor = (short)reader["Gendor"];
                Address = (String)reader["Address"];
                Phone = (String)reader["Phone"];
                if (reader["Email"] != DBNull.Value)
                    Email = (String)reader["Email"];
                else
                    Email = "";

                NationalityCountryID = (int)reader["NationalityCountryID"];

                if (reader["ImagePath"] != DBNull.Value)
                    ImagePath = (String)reader["ImagePath"];
                else
                    ImagePath = "";

                reader.Close();
            }
            else
                isFound = false;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return isFound;
    }

    public static bool GetPersonInfoByNationalNo(String NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
    ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
    ref short Gendor, ref string Address, ref string Phone, ref string Email,
    ref int NationalityCountryID, ref string ImagePath)
    {
        bool isFound = false;
        SqlConnection conn = new SqlConnection(ConnString.ConnectionString);
        String Query = "select * from People where NationalNo = @NationalNo";
        SqlCommand command = new SqlCommand(Query, conn);
        command.Parameters.AddWithValue("@NationalNo", NationalNo);
        try
        {
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                isFound = true;
                PersonID = (int)reader["PersonID"];
                FirstName = (String)reader["FirstName"];
                SecondName = (String)reader["SecondName"];
                if (reader["ThirdName"] != DBNull.Value)
                    ThirdName = (String)reader["ThirdName"];
                else
                    ThirdName = "";
                LastName = (String)reader["LastName"];
                DateOfBirth = (DateTime)reader["DateOfBirth"];
                Gendor = (short)reader["Gendor"];
                Address = (String)reader["Address"];
                Phone = (String)reader["Phone"];
                if (reader["Email"] != DBNull.Value)
                    Email = (String)reader["Email"];
                else
                    Email = "";

                NationalityCountryID = (int)reader["NationalityCountryID"];

                if (reader["ImagePath"] != DBNull.Value)
                    ImagePath = (String)reader["ImagePath"];
                else
                    ImagePath = "";

                reader.Close();
            }
            else
                isFound = false;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();

        }
        return isFound;
    }

    public static int AddNewPerson(string FirstName, string SecondName,
     string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
     short Gendor, string Address, string Phone, string Email,
     int NationalityCountryID, string ImagePath)
    {
        int id = -1;
        SqlConnection conn = new SqlConnection(ConnString.ConnectionString);
        string Query = @"INSERT INTO People(FirstName,SecondName,ThirdName,LastName,NationalNo,DateOfBirth,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath)
                     VALUES(@FirstName,@SecondName,@ThirdName,@LastName,@NationalNo,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);
                     SELECT SCOPE_IDENTITY();";


        SqlCommand command = new SqlCommand(Query, conn);
        command.Parameters.AddWithValue("@FirstName", FirstName);
        command.Parameters.AddWithValue("@SecondName", SecondName);
        if (ThirdName != "" && ThirdName != null)
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
        else
            command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
        command.Parameters.AddWithValue("@LastName", LastName);
        command.Parameters.AddWithValue("@NationalNo", NationalNo);
        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
        command.Parameters.AddWithValue("@Gendor", Gendor);
        command.Parameters.AddWithValue("@Address", Address);
        command.Parameters.AddWithValue("@Phone", Phone);
        if (Email != "" && Email != null)
            command.Parameters.AddWithValue("@Email", Email);
        else
            command.Parameters.AddWithValue("@Email", System.DBNull.Value);
        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
        if (ImagePath != "" && ImagePath != null)
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
        else
            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
        try
        {
            conn.Open();
            object result = command.ExecuteScalar();
            if (result != null && int.TryParse(result.ToString(), out int InseredID))
                id = InseredID;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
        finally { conn.Close(); }
        return id;
    }

    public static bool DeletePersonById(int PersonID)
    {
        int rows = 0;
        SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
        String Query = @"DELETE FROM People
                        WHERE PersonID = @PersonID";
        SqlCommand command = new SqlCommand(Query, connection);
        command.Parameters.AddWithValue("@PersonID", PersonID);
        try
        {
            connection.Open();
            rows = command.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally { connection.Close(); }
        return (rows > 0);

    }

    public static bool UpdatePerson(int PersonID, string FirstName, string SecondName,
   string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
   short Gendor, string Address, string Phone, string Email,
    int NationalityCountryID, string ImagePath)
    {

        int rowsAffected = 0;
        SqlConnection connection = new SqlConnection(ConnString.ConnectionString);

        string query = @"Update  People  
                    set FirstName = @FirstName,
                        SecondName = @SecondName,
                        ThirdName = @ThirdName,
                        LastName = @LastName, 
                        NationalNo = @NationalNo,
                        DateOfBirth = @DateOfBirth,
                        Gendor=@Gendor,
                        Address = @Address,  
                        Phone = @Phone,
                        Email = @Email, 
                        NationalityCountryID = @NationalityCountryID,
                        ImagePath =@ImagePath
                        where PersonID = @PersonID";

        SqlCommand command = new SqlCommand(query, connection);

        command.Parameters.AddWithValue("@PersonID", PersonID);
        command.Parameters.AddWithValue("@FirstName", FirstName);
        command.Parameters.AddWithValue("@SecondName", SecondName);

        if (ThirdName != "" && ThirdName != null)
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
        else
            command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


        command.Parameters.AddWithValue("@LastName", LastName);
        command.Parameters.AddWithValue("@NationalNo", NationalNo);
        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
        command.Parameters.AddWithValue("@Gendor", Gendor);
        command.Parameters.AddWithValue("@Address", Address);
        command.Parameters.AddWithValue("@Phone", Phone);

        if (Email != "" && Email != null)
            command.Parameters.AddWithValue("@Email", Email);
        else
            command.Parameters.AddWithValue("@Email", System.DBNull.Value);

        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

        if (ImagePath != "" && ImagePath != null)
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
        else
            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


        try
        {
            connection.Open();
            rowsAffected = command.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        finally
        {
            connection.Close();
        }

        return (rowsAffected > 0);
    }



    public static DataTable GetAllPepole()
    {
        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection(ConnString.ConnectionString);
        string query = @"SELECT People.PersonID, People.NationalNo,
                        People.FirstName, People.SecondName, People.ThirdName, People.LastName,
                        People.DateOfBirth, People.Gendor,  
                            CASE
                            WHEN People.Gendor = 0 THEN 'Male'

                            ELSE 'Female'

                            END as GendorCaption ,
                        People.Address, People.Phone, People.Email, 
                        People.NationalityCountryID, Countries.CountryName, People.ImagePath
                        FROM            People INNER JOIN
                                    Countries ON People.NationalityCountryID = Countries.CountryID
                            ORDER BY People.FirstName";
        SqlCommand command = new SqlCommand (query,connection);
        try
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
                dt.Load(reader);
            reader.Close();
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }  
        return dt;                 
    }
}
