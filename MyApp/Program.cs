namespace MyApp;
using BuisnessLayer;
class Program
{
    static void Main(string[] args)
    {
        clsPepoleBuisness person =  clsPepoleBuisness.Find(1032);
        if(person!=null){
            person.FirstName ="Osama";
            person.SecondName="Fares";
            person.ThirdName="";
            person.LastName="Nimer";
            person.NationalNo = "444";
            person.DateOfBirth = new DateTime(2004,01,27,12,30,40);
            person.Gendor=0;
            person.Address="Amman-Jawa";
            person.Email="";
            person.NationalityCountryID =962;
            person.ImagePath="/dsad/dsad/dsdad";

            if(person.Save())
                System.Console.WriteLine("Updated !");
        }
        
    }
}
