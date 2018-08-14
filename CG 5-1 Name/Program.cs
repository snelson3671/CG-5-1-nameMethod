using System;

namespace CG_5_1_MethodNames
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user to type their first and last name
            Console.WriteLine("Type your first name and press enter.  ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type your last name and press enter.   ");
            string lastName = Console.ReadLine();

            //Call the method created below, putting the variable firstName
            // then the variable lastName into it 
            Console.Write("Your name spelled backwards is:    ");
            ReverseString(firstName);
            ReverseString(lastName);
            
            Console.ReadLine();
        }

        //Create a method called ReverseString allowing the caller 
        //to pass in a strings called firstName and lastName
        static void ReverseString(string fullName)
        {
            //change the variable fullName to a character array and name it characters
            char[] characters = fullName.ToCharArray();
            //reverse the characters in the array
            Array.Reverse(characters);

            //write each character in the array then write a space
            foreach (char item in characters)
            {
                Console.Write(item);
            }

                Console.Write(" ");
            
            
        }

    }
}
