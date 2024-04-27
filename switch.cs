// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Threading.Channels;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            string club;
            Console.WriteLine("grab your tream in pl");
            club = Console.ReadLine();
            switch (club)
            {
                case "man_united":
                    Console.WriteLine("david_becham and Cristinao ronaldo");
                    break;
                case "chelsea":
                    Console.WriteLine("drogba");
                    break;
                case "liverpool":
                    Console.WriteLine("vrigil_vandigk");
                    break;
                case "man_city":
                    Console.WriteLine("HAALAND and kdb")
                        ; break;

                case "arsenal":
                    Console.WriteLine("hendry");
                    break;
                default:
                    Console.WriteLine("invalid to preoceed");
                    break;
            }
            Console.ReadKey();




        }



    }
}

