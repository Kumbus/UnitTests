using NUnit.Framework;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Add_WhenCalled_ShouldReturnSum()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Add(1, 2);

            //Assert
            Assert.AreEqual(3, result);
        }
    }
}