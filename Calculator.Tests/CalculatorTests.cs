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

    

    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_WhenInputIsDivisibleOnlyBy3_ShouldReturnFizz()
        {
            var fizzbuzz = new FizzBuzz();

            var output = fizzbuzz.GetOutput(3);

            Assert.AreEqual(output, "Fizz");
        }

        [Test]
        public void GetOutput_WhenInputIsDivisibleOnlyBy5_ShouldReturnBuzz()
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_WhenInputIsDivisibleBy3And5_ShouldReturnFizzBuzz()
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.GetOutput(15);


            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_WhenInputIsNotDivisibleBy3Or5_ShouldReturnInput()
        {
            var fizzbuzz = new FizzBuzz();

            var result = fizzbuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
