using System;

namespace FizzBuzz
{

    public class Program
    {
        public string fizz = "Fizz";
        public string buzz = "Buzz";
        public string NumberFortytwo = "Answer to the Ultimate Question of Life, the Universe, and Everything";
        static void Main(string[] args)
        {
            Program p = new Program();

            for (int number = 1; number < 300; number++)
            {
                var num = p.FizzBuzz(number);
                Console.WriteLine(num);
            }
        }
        public string FizzBuzz(int number)
        {
            if (number == 42)
            {
                return NumberFortytwo;
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                var Fizzbuzz = fizz + buzz.ToLower();

                return Fizzbuzz;
            }

            if (number % 3 == 0)
            {
                return fizz;
            }
            else if (number % 5 == 0)
            {
                return buzz;
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
