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
            string type = Console.ReadLine();
            while (!Business.ItemHelper.ValidateItemType(type))
            {
                Console.WriteLine("Invalidate Input. Please enter a type: ");
                Console.ReadLine();
            }
            //check ItemType input
            Console.Write("Please enter qty: ");
            string qty = Console.ReadLine();
            while (!Business.ItemHelper.ValidateQty(qty))
                {
                    Console.WriteLine(qty);
                    Console.ReadLine();
                }
            
        }
    }
}
