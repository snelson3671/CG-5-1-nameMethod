using System;
using System.Xml.Linq;

namespace CG_5_1_MethodNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your first name and press enter.  ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type your last name and press enter.   ");
            string lastName = Console.ReadLine();

            string fullName = NewString(firstName, lastName);
            Console.WriteLine(fullName);

            Console.ReadLine();
        }

        private static string NewString(string nameA, string nameB)
        {
            string fullName = ($"Hello {nameA} {nameB}");
            return fullName;
        }

    }
}
