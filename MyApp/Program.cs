namespace MyApp;
using BuisnessLayer;
class Program
{
    static void Main(string[] args)
    {
        clsPepoleBuisness person = new clsPepoleBuisness();
        person.FirstName ="Osama";
        person.SecondName="Fares";
        person.ThirdName="";
        person.LastName="Nimer";
        person.NationalNo = "444";
        person.DateOfBirth = new DateTime(2004,01,27,12,30,40);
        person.Gendor=0;
        person.Address="Amman-Jawa";
        person.Email="";
        person.NationalityCountryID =90;
        person.ImagePath="/dsad/dsad/dsdad";

        if(person.Save())
            System.Console.WriteLine($"new Person Added by Id = {person.PersonID}");
        
    }
}
