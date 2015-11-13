using Business;
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
            List<Item> display = new List<Item>();
            //
            //Bicycle
            Console.Write("Please enter time of travel(min): ");
            string inputTime = Console.ReadLine();
            double t = 0;
            while (!Business.ItemHelper.ValidateQty(inputTime, ref t))
            {
                Console.WriteLine("Invalid amount of time. Please enter time of travel(min): ");
                inputTime = Console.ReadLine();
            }
            Bicycle b = new Bicycle();
            b.type = "Bicycle";
            b.ammount = t;
            double bicycleCO2 = b.CalculateCarbonFootprints(t);
            b.carbonOutput = bicycleCO2;
            display.Add(b);
            //Car
            Console.Write("Please enter used gas of a Car(Gallon): ");
            string inputGas = Console.ReadLine();
            double gas = 0;
            while (!Business.ItemHelper.ValidateQty(inputGas, ref gas))
            {
                Console.WriteLine("Invalid amount of gas. Please enter used gas of a Car(Gallon): ");
                inputGas = Console.ReadLine();
            }
            Car car = new Car();
            car.type = "Car";
            car.ammount = gas;
            double carCO2 = car.CalculateCarbonFootprints(gas);
            car.carbonOutput = carCO2;
            display.Add(car);

            //Building
            Console.Write("Please enter area of the Building: ");
            string inputArea = Console.ReadLine();
            double area = 0;
            while (!Business.ItemHelper.ValidateQty(inputArea, ref area))
            {
                Console.WriteLine("Invalid amount of area. Please enter area of the Building: ");
                inputArea = Console.ReadLine();
            }
            Building building = new Building();
            building.type = "Building";
            building.ammount = area;
            double buildingCO2 = building.CalculateCarbonFootprints(area);
            building.carbonOutput = buildingCO2;
            display.Add(building);

            Console.WriteLine();
            foreach (var n in display)
            {
                Console.WriteLine(n.type + "'s Carbon Output is " + n.carbonOutput);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
