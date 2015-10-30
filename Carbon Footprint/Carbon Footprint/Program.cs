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
            Console.Write("Type: Car, Bicycle, Building");
            Console.ReadLine();
            Console.Write("Please enter a type: ");
            string userInput = Console.ReadLine();
                while (!Business.ItemHelper.ValidateItemType(userInput))
                {
                    Console.WriteLine("Invalidate Input. Please enter a type: ");
                    Console.ReadLine();
                string type = userInput;
                }
                //check ItemType input
                while (!Business.ItemHelper.ValidateQty(userInput))
                {
                    Console.WriteLine(userInput);
                    Console.ReadLine();
                }
            
        }
    }
}
