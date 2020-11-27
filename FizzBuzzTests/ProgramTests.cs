using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentAssertions;
using System;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void If_Number_Is_Dividable_By_3_FizzBuzz_Should_Return_Fizz()
        {
            //Arrange
            Program p = new Program();

            var numbers = new List<int>();
            for (int number = 1; number < 300; number++)
            {
                if (number % 3 == 0)
                {
                    numbers.Add(number);
                }
            }

            //Act
            foreach (var number in numbers)
            {
                if (number != 42)
                {
                    var result = p.FizzBuzz(number);

                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        result.Should().BeEquivalentTo("Fizzbuzz");
                    }
                    else
                    {
                        //Assert
                        result.Should().BeEquivalentTo("Fizz");
                    }
                }
            }
        }
        [TestMethod()]
        public void If_Number_Is_Dividable_By_5_FizzBuzz_Should_Return_Buzz()
        {
            //Arrange
            Program p = new Program();

            var numbers = new List<int>();
            for (int number = 1; number < 300; number++)
            {
                if (number % 5 == 0)
                {
                    numbers.Add(number);
                }
            }

            //Act
            foreach (var number in numbers)
            {
                if (number != 42)
                {
                    var result = p.FizzBuzz(number);

                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        result.Should().BeEquivalentTo("Fizzbuzz");
                    }
                    else
                    {
                        //Assert
                        result.Should().BeEquivalentTo("Buzz");

                    }
                }
            }
        }
        [TestMethod()]
        public void If_Number_Is_Dividable_By_5_And_3_FizzBuzz_Should_Return_FizzBuzz()
        {
            //Arrange
            Program p = new Program();

            var numbers = new List<int>();
            for (int number = 1; number < 300; number++)
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
                    numbers.Add(number);
                }
            }

            //Act
            foreach (var number in numbers)
            {
                if (number != 42)
                {
                    var result = p.FizzBuzz(number);

                    result.Should().BeEquivalentTo("Fizzbuzz");
                }
            }
        }

        [TestMethod()]
        public void If_Number_Is_Equal_To_42_FizzBuzz_Should_Return_Answer_to_the_Ultimate_Question_of_Life_the_Universe_and_Everything()
        {
            //Arrange
            Program p = new Program();

            var numbers = new List<int>();
            for (int number = 1; number < 300; number++)
            {
                numbers.Add(number);
            }

            //Act
            foreach (var number in numbers)
            {
                if (number == 42)
                {
                    var result = p.FizzBuzz(number);

                    //Assert
                    result.Should().BeEquivalentTo("Answer to the Ultimate Question of Life, the Universe, and Everything");
                }
            }
        }

        [TestMethod()]
        public void FizzBuzz_Should_Return_String()
        {
            //Arrange
            Program p = new Program();

            var numbers = new List<int>();
            for (int number = 1; number < 300; number++)
            {
                numbers.Add(number);
            }

            //Act
            foreach (var number in numbers)
            {
                    var result = p.FizzBuzz(number);

                    //Assert
                    result.Should().BeOfType<string>();
            }
        }

        [TestMethod()]
        public void If_No_FizzBuzz_Criteria_Is_Met_FizzBuzz_Should_Return_Number()
        {
            //Arrange
            Program p = new Program();

            var numbers = new List<int>();
            for (int number = 1; number < 300; number++)
            {
                numbers.Add(number);
            }

            //Act
            foreach (var number in numbers)
            {
                if (number != 42 && number % 3 != 0 && number % 5 != 0)
                {
                    var result = p.FizzBuzz(number);

                    //Assert
                    result.Should().Be(number.ToString());
                }
            }
        }

        [TestMethod()]
        public void CheckNumber_Should_Return_An_Int()
        {
            //Arrange
            Program p = new Program();

            //Act
            var sut = p.CheckNumber("500");

            //Assert
            sut.Should().BeOfType(typeof(int));
        }
        [TestMethod()]
        public void CheckNumber_Should_Return_a_number_if_valid_input()
        {
            //Arrange
            Program p = new Program();

            //Act
            var sut = p.CheckNumber("100");

            //Assert
            sut.Should().Be(100); 
        }


        [TestMethod()]
        public void CheckNumber_Should_Return_300_if_input_is_not_parsable()
        {
            //Arrange
            Program p = new Program();

            //Act
            var sut = p.CheckNumber("%%%%");

            //Assert
            sut.Should().Be(300);
        }

        [TestMethod()]
        public void CheckNumber_Should_Return_300_if_input_is_higher_than_300()
        {
            //Arrange
            Program p = new Program();

            //Act
            var sut = p.CheckNumber("500");

            //Assert
            sut.Should().Be(300);
        }


        [TestMethod()]
        public void CheckNumber_Should_Return_300_if_input_is_lower_than_or_equal_to_0()
        {
            //Arrange
            Program p = new Program();

            //Act
            var sut = p.CheckNumber("-1");

            //Assert
            sut.Should().Be(300);
        }
    }
}