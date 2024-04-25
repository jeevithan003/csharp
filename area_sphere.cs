// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Channels;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            //area of a sphere
            double rad;
            Console.WriteLine("enter the radius of the sphere");
            rad=Convert.ToDouble(Console.ReadLine());
             double r_s=rad*rad;
            Console.WriteLine("the area of the sphere is  " + 4 * 3.14 * r_s);


        }



    }
}

