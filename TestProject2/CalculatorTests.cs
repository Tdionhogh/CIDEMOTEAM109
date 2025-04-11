
    using WpfApp1; // Husk at ændre namespace til det rigtige
    using System;
    using NUnit.Framework;
    // Husk at ændre namespace til det rigtige


    namespace TestProject2
    {
        [TestFixture]
    public class CalculatorTests
    {
     private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator(); // eller mock hvis du tester interface
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = _calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Divide_ByNonZero_ReturnsCorrectResult()
        {
            double result = _calculator.Divide(10, 2);
            Assert.AreEqual(5.0, result);
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
        }
    }

}

