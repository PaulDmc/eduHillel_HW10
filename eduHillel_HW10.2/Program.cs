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
            int eventCount = 1;

            StringBuilder textReport = new StringBuilder();
            textReport.AppendLine("Text report");
            textReport.AppendLine($"{DateTime.Now}");
            textReport.AppendLine("List of Events: ");           

            while (true)
            {
                Console.WriteLine("Insert event. Insert 'finish' or click Enter to complete:");
                textInput = Console.ReadLine();

                if (textInput.ToLower() == "finish" || string.IsNullOrWhiteSpace(textInput))
                    break;
                textReport.AppendLine($"{eventCount}. {textInput};");
                eventCount++;
            }
            Console.WriteLine(textReport.ToString());
        }
    }
}
