// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("hello this is firts c# programe");
            Console.WriteLine("belove c# share code will beepp the console");
            Console.Beep();
        }



    }
}

2.

// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {

            const double e = 2.714;
            Console.WriteLine("the constant value for the e is  "+e);
        }



    }
}

3.// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {

            int a20;
         
            double c = 235.53;
            string name = "jeevithan";
            bool isgoal=false;

        }



    }
}

// type caasting in c#

// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {

            //type casting in c#
            int a = 321;
            string b=Convert.ToString(a);
            Console.WriteLine(b.GetType());
            string c = "false";
             bool d= Convert.ToBoolean(c);
            Console.WriteLine(d.GetType());

        }



    }
}



// read and print output in c#
// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp11
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("favourite football palyer");
            string player = Console.ReadLine();
            Console.WriteLine(player);
            Console.ReadKey();        }



    }
}

































