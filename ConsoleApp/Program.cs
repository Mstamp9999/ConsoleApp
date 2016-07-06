using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_input = "";
            string user_tag = "";
            string user_pass = "";
            string user_age = "";
            string user_bdate = "";
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name ");
            user_input = Console.ReadLine();
            Console.WriteLine("What is your username ");
            user_tag = Console.ReadLine();
            Console.WriteLine("What is your password ");
            user_pass = Console.ReadLine();
            Console.WriteLine("What is your age ");
            user_age = Console.ReadLine();
            Console.WriteLine("What is your birthday ");
            user_bdate = Console.ReadLine();
            
            Console.WriteLine("Hello " + user_input);
            Console.WriteLine("Your username is " + user_tag);
            Console.WriteLine("Your password is " + user_pass);
            Console.WriteLine("Your age is " + user_age + " Years old");
            Console.WriteLine("Your birthday is " + user_bdate);
            Console.ReadLine();
        }
    }
}
