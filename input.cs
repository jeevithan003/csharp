// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            string club;
            int ucl;
            Console.WriteLine("whats is your fav club in preimer league?");
            club= Console.ReadLine();
            Console.WriteLine("your fav club is "+club);
            Console.WriteLine("how many ucl your club has won");
            ucl=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("YOUR CLUB HAS WON " + ucl + " ucls'S in football history");

            Console.ReadKey();





        }



    }
}

