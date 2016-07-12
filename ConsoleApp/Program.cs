using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class User
    {
        public string Name;
        public string UserName;
        public string Password;
        public string Age;
        public string PhoneNumber;
        public string Birthday;
        public string Email;
    }


    class Program
    {
        static void Main(string[] args)
        {
            User user_object = new User();

            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name ");
            user_object.Name = Console.ReadLine();
            Console.WriteLine("What is your username ");
            user_object.UserName = Console.ReadLine();
            Console.WriteLine("What is your password ");
            user_object.Password = Console.ReadLine();
            Console.WriteLine("What is your age ");
            user_object.Age = Console.ReadLine();
            Console.WriteLine("What is your birthday ");
            user_object.Birthday = Console.ReadLine();
            Console.WriteLine("What is your Email ");
            user_object.Email = Console.ReadLine();
            Console.WriteLine("What is your Phone Number ");
            user_object.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Hello " + user_object.Name);
            Console.WriteLine("Your username is " + user_object.UserName);
            Console.WriteLine("Your password is " + user_object.Password);
            Console.WriteLine("Your are " + user_object.Age + " Years old");
            Console.WriteLine("Your birthday is " + user_object.Birthday);
            Console.WriteLine("Your Email is " + user_object.Email);
            Console.WriteLine("Your PhoneNumber is " + user_object.PhoneNumber);
            Console.ReadLine();
        }
    }

    class WriteTextFile
    {
        static void writeLine()
        {


            string[] lines = { "Name", "UserName", "Password", "Age", "Birthday", "Email", "PhoneNumber" };
            System.IO.File.WriteAllLines(@"E:\WriteLines.txt", lines);

            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            System.IO.File.WriteAllText(@"E:\WriteText.txt", text);
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"E:\WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("Name"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"E:\WriteText2.txt", true))
            {
                file.WriteLine("Name");
                file.WriteLine("UserName");
                file.WriteLine("Password");
                file.WriteLine("Age");
                file.WriteLine("Birthday");
                file.WriteLine("Email");
                file.WriteLine("PhoneNumber");
            }
        }
    }
}
