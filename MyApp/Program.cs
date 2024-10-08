namespace MyApp;
using BuisnessLayer;
class Program
{
    static void Main(string[] args)
    {
        
        clsPepoleBuisness clsPepole = clsPepoleBuisness.Find(1030);
        Console.WriteLine(clsPepole.FirstName);
    }
}
