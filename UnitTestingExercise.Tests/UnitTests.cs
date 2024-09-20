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
            var cal = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = cal.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 5, 3)]
        [InlineData(7, 9, -2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var cal = new Calculator();

            //Act
            var actual = cal.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 6, 30)]
        [InlineData(20, 5, 100)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var cal = new Calculator();

            //Act
            var actual = cal.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(22, 2, 11)]
        [InlineData(75, 3, 25)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var cal = new Calculator();

            //Act
            var actual = cal.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
