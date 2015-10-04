using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
            
        }

		static void DisplayPatternA()
		{
            // your implementation here
            int i, j, k;
            Console.WriteLine("Patten A");
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                {
                    //Console.Write("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
    }

		static void DisplayPatternB()
		{
            // your implementation here
            Console.WriteLine("Patten B");
            int i, j, k;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                {
                    // Console.Write(" ");
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
          
        static void DisplayPatternC()
        {
            // your implementation here
            Console.WriteLine("Patten C");
            int i, j, k;
            for (i = 10; i >= 1; i--) 
            {
                for (j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

		static void DisplayPatternD()
		{
            // your implementation here 
            Console.WriteLine("Patten D");
            int i, j, k;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
	}
}
