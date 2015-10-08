using System;
using System.Text.RegularExpressions;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

        static void Main(string[] args)
        {
            double totalCost=0;
            double sum = 0;
            // your implementation here
            while (true)
            {
                Console.Write("Please enter purchased gas type, Q/q to quit:");
                string userInput = Console.ReadLine();
                if (UserEnteredSentinelValue(userInput))
                {
                    Console.WriteLine("Application terminated");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }
                else if (UserEnteredValidGasType(userInput))
                {
                    Console.Write("Please enter purchased gas amount, Q/q to quit:");
                    string gasAmount = Console.ReadLine();
                    if (UserEnteredSentinelValue(gasAmount))
                    {
                        Console.WriteLine("Application terminated");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        System.Environment.Exit(1);
                    }
                    else {
                        char charInput = Convert.ToChar(userInput);
                        GasType gastype = GasTypeMapper(charInput);
                        Double price = GasPriceMapper(gastype);
                        CalculateTotalCost(gastype, int.Parse(gasAmount), ref totalCost);
                        sum = sum + totalCost;
                        Console.Write("Your TotalCost for this purchased gas is:" + sum);
                        Console.ReadLine();
                    }
                }
            }
        }


        // use this method to check and see if sentinel value is entered
        public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;

            // your implementation here
            if (userInput.ToUpper().Equals("Q"))// Q or q
            {
                result = true;
            }

            return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;

            // your implementation here
            if (userInput.ToUpper().Equals("R")||
                userInput.ToUpper().Equals("P")||
                userInput.ToUpper().Equals("D")||
                userInput.ToUpper().Equals("M"))
            {
                result = true;
            }
            return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
			var result = false;

            // your implementation here
            //string pattern = "^-?\\d+$|^(-?\\d+)(\\.\\d+)?$";
            //Regex regex = new Regex(pattern);
            double input;
            if (Double.TryParse(userInput, out input))
            {
                result = true;
            }
                return result;
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
			GasType gasType = GasType.None;

            // your implementation here
            switch (c)
            {
                default:
                    gasType = GasType.None;
                    break;
                case 'R':
                case 'r':
                    gasType = GasType.RegularGas;
                    break;
                case 'M':
                case 'm':
                    gasType = GasType.MidgradeGas;
                    break;
                case 'P':
                case 'p':
                    gasType = GasType.PremiumGas;
                    break;
                case 'D':
                case 'd':
                    gasType = GasType.DieselFuel;
                    break;
            }
            return gasType;
		}

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;
            // your implementation here
            switch (gasType)
            {
                //case GasType.None:
                //   result = 0.0;
                //    break;
                case GasType.RegularGas:
                    result = 1.94;
                    break;
                case GasType.MidgradeGas:
                    result = 2;
                    break;
                case GasType.PremiumGas:
                    result = 2.24;
                    break;
                case GasType.DieselFuel:
                    result = 2.17;
                    break;
            }
            return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            // your implementation here
            double gasprice;
            gasprice = GasPriceMapper(gasType);
            totalCost = gasAmount * gasprice;
        }
	}
}
