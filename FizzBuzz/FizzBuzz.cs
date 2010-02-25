namespace FizzBuzz
{
    public class FizzBuzz
    {
        /// <summary>
        /// Returns:
        /// "Fizz" if the number is divisible by 3,
        /// "Buzz" if the number is divisible by 5,
        /// "FizzBuzz" if the number is divisible by both 3 and 5,
        /// the number if it's not divisible by either 3 or 5
        /// </summary>
        /// <param name="number">the integer to get output for</param>
        /// <returns>a string with the proper output as described in the summary</returns>
        public static string GetOutput(int number)
        {
            string output;

            if ((number % 3 == 0) && (number % 5 == 0))
            {
                output = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                output = "Fizz";
            }
            else if (number % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = number.ToString();
            }

            return output;
        }
    }
}
