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
            Console.Write("Please enter used gas of a Car(Gallon): ");
            string gas = Console.ReadLine();
            while (!Business.ItemHelper.ValidateQty(gas))
            {
                Console.WriteLine(gas);
                Console.ReadLine();
            }
            //Building
            Console.Write("Please enter area of a biulding(squarefoot): ");
            string area = Console.ReadLine();
            while (!Business.ItemHelper.ValidateQty(area))
            {
                Console.WriteLine(area);
                Console.ReadLine();
            }


        }
    }
}
