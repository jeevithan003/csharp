// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();   
            int n1=random.Next(1,13);
            int n2=random.Next(1,13);   
            int n3=random.Next(1,13);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);


        }



    }
}

