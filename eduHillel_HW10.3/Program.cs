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
            string textInput;
            string result;

            Console.WriteLine("Input text with spacebars:");
            textInput = Console.ReadLine();
            result = textInput.Replace(" ", "");
            Console.WriteLine("Result without spacebars:");
            Console.WriteLine(result);
        }
    }
}