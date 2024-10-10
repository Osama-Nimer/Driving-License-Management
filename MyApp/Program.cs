namespace MyApp;
using BuisnessLayer;
class Program
{
    static void Main(string[] args)
    {
        if(clsPepoleBuisness._DeletePerson(1032))
            System.Console.WriteLine("Deleted !");
            
    }
}
