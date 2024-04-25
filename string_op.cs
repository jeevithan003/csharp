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
            string name = "jennifer lopez";
            String n2 = "jlo";
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Replace("lopez","jeevith"));
            
            Console.WriteLine(name.Equals(n2));
            Console.WriteLine(name.Length);

            


        }



    }
}

