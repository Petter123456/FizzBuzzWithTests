using System;

namespace FizzBuzz
{

    public class Program
    {
        private static string userInput;
        private static int number;
        public string fizz = "Fizz";
        public string buzz = "Buzz";
        public string NumberFortytwo = "Answer to the Ultimate Question of Life, the Universe, and Everything";
        public string question = "Please enter a number between 1 - 300 to run FizzBuzz";

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.question);
           
            userInput = Console.ReadLine(); 
            number = p.CheckNumber(userInput); 

            for (int firstNumber = 1; firstNumber < number; firstNumber++)
            {
                var num = p.FizzBuzz(firstNumber);
                Console.WriteLine(num);
            }
        }

        public int CheckNumber(string num)
        {
            try
            {
               var number = Int32.Parse(num);

                if (number >= 301 || number <= 0)
                {
                    Console.WriteLine("The Number you entered was not in range, default value of 300 is added");
                    return 300; 
                }
                return number;
            }
            catch (Exception)
            {
                Console.WriteLine("You entered an invalid number, default value of 300 is added");
                return 300;
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
