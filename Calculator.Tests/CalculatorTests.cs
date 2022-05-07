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

        [Test]
        public void Multiply_WhenCalled_ShouldReturnProduct()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Multiply(1, 2);

            //Assert
            Assert.AreEqual(2, result);
        }
    }
}