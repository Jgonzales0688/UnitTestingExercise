using System;
using Xunit;
using UnitTestingExercise;


namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {// Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(2, 5, 3, 10)]
        [InlineData(2, 2, 2, 6)]
        [InlineData(2, 1, 1, 4)]
        [InlineData(2, 9, 6, 17)]//Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            //Arrange -- create a Calculator object
            var instance = new Calculator();

            //Act -- call the Add method that is located in the Calculator class and store its result in a variable named actual
            var actual = instance.Add(num1, num2,num3);

            //Assert
            Assert.Equal(expected, actual);
            
        }

       

        [Theory]
        [InlineData(3, 3, 0)]
        [InlineData(8, 2, 6)]
        [InlineData(2, 1, 1)]
        [InlineData(2, 9, 7)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,2,6)]
        [InlineData(8, 2, 16)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 9, 18)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(8, 2, 4)]
        [InlineData(2, 1, 2)]
        [InlineData(18, 9, 2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var instance = new Calculator();
            //Act
            var actual = instance.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
