

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace eduHillel_HW10
{
    public static class Program

    {
        static void Main(string[] args)
        {
            string fullName;
            string[] nameParts;

            Console.WriteLine("Enter first and last name:");
            fullName = Console.ReadLine();
            nameParts = fullName.Split(' ');

            if (nameParts.Length != 2)
            {
                Console.WriteLine("Enter only first and last name.");
                return;
            }

            string firstName = nameParts[0];
            string lastName = nameParts[1];

            if (char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
            {
                Console.WriteLine("Last name begins with the same letter as first name.");
            }
            else
            {
                Console.WriteLine("The last name doesn't start with the same letter as the first name.");
            }
        }
    }

}
