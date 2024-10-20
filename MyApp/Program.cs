namespace MyApp;
using BuisnessLayer;
using System;
using System.Data;
class Program
{
    static void Main(string[] args)
    {
        clsPepoleBuisness country = clsPepoleBuisness.Find(1030);
        Console.WriteLine(country.FullName);
        Console.WriteLine(country.Address);
        Console.WriteLine(country.Email);
        Console.WriteLine(country.Phone);
        Console.WriteLine(country.PersonID);
        Console.WriteLine(country.DateOfBirth);
        Console.WriteLine(country.CountryInfo.CountryName);
        Console.WriteLine(country.CountryInfo.CountryID);
        Console.WriteLine(country.Gendor);
    }
}
