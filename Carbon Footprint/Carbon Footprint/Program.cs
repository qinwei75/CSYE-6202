using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbon_Footprint
{
    public class Program
    {
        static void Main(string[] args)
        {
            double totalCost = 0;
            double sum = 0;
            // your implementation here
            while (true)
            {
                Console.Write("Type: Car, Bicycle, Building");
                Console.Write("Please enter a type, Q/q to quit:");
                string userInput = Console.ReadLine();
                if (Business.ItemHelper.ValidateItemType(userInput))
                {
                    Console.WriteLine("Application terminated");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
                //check ItemType input
                else if (Business.ItemHelper.ValidateItemType(userInput))
                {
                    Console.WriteLine(userInput);
                    Console.ReadLine();
                }
            }
        }
    }
}
