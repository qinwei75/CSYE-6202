using System;

namespace FindingPrimeNumbers
{
	public class FindingPrimeNumbers
	{
		public long FindSumOfPrimeNumbers(int n)
		{
			long sum = 0;

            // your solution goes in here
            if (n == 0)
            {
                return 0;
            }
            // if only 1 prime is "2", so sum should be 2
            if (n == 1)
            {
                return 2;
            }


            int j;
            int primenumber = 1;
            // add "2" into the sum
            sum = 2;
            // start loop from "3"
            for (int i = 3; primenumber < n; i++)
            {
                Boolean flag = true;

                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) // not prime
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                {
                    primenumber = ++primenumber;
                    sum = sum + i;
                }
            }

            return sum;
		}
	}
}
