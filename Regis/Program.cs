using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Regis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Registeration =====");

            Console.WriteLine("Enter your user name");
            string username = Console.ReadLine();


            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            Console.WriteLine("===== login =====");

            Console.WriteLine("Enter ypur user name");
            string inputUserName = Console.ReadLine();

            Console.WriteLine("Enter your password");
            string inputPassword = Console.ReadLine();

            if (inputUserName == username && inputPassword == password)
            {
                
                
                Console.WriteLine("login successfully");
            }
            else {
                if (inputUserName != username)
                {
                    Console.WriteLine("invalid user name");
                }
                else if (inputPassword != password)
                {
                    Console.WriteLine("invalid password");
                }
                else { 
                Console.WriteLine("invalid user name and password");
                }
            }

        }
    }
}
