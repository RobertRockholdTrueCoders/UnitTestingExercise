using System;
using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 5, 7)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:
            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Subtract(minuend,subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(8, 4, 32)]//Add test data <-------
        public void MultiplyTest(int mult1, int mult2, int expected)
        {
            //Start Step 7 here:
            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Multiply(mult1, mult2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(16, 8, 2)]//Add test data <-------
        public void DivideTest(int div1, int div2, int expected)
        {
            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Divide(div1, div2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
