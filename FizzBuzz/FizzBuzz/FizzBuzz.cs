namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int number)
		{
            string result = number.ToString();

            // your solution/implementation should go in here
            if (number == 0)
            {
                result = "0";
            }
            else if (number == 1)
            {
                result = number.ToString();
            }
            else
            {
                string Fizz = "Fizz";
                string Buzz = "Buzz";
                string FizzBuzz = "FizzBuzz";
                if (number % 3 == 0 && number % 5 != 0)
                {
                    result = Fizz;
                }
                else if (number % 5 == 0 && number % 3 != 0)
                {
                    result = Buzz;
                }
                else if (number % 5 == 0 && number % 3 == 0)
                {
                    result = FizzBuzz;
                }
            }
          return result;
		}
	}
}
