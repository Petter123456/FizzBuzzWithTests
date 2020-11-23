using System.Collections.Generic;
using FluentAssertions;

namespace FizzBuzzTests1
{
    public class FizzBuzzTests
    {
        public void If_Number_Is_Dividable_By_3_FizzBuzz_Should_Return_Fizz(
            FizzBuzz.Program sut
            )
        {
            //Arrange
            var numbers = new List<int>(); 
            for (int number = 0; number < 300; number++)
            {
                if (number % 3 == 0)
                {
                    numbers.Add(number); 
                }
            }

            //Assert
            foreach (var number in numbers)
            {
                var test = sut.FizzBuzz(number);
                test.Should().BeEquivalentTo("Fizz");
            }
        }
    }
}
