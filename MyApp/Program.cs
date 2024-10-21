namespace MyApp;
using BuisnessLayer;
using System;
using System.Data;
class Program
{
    static void Main(string[] args)
    {
        User user =User.FindUserbyUserID(19);
        Console.WriteLine((user == null));

    }
}
