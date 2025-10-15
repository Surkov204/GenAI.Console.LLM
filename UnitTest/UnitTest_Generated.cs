
using System;
using Xunit;

namespace DemoUnitTest_ConsoleApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Fact]
        public void Add_ShouldReturnSumOfTwoNumbers()
        {
            // Arrange (No need to arrange as the method is simple)
            int a = 5;
            int b = 10;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Sub_ShouldReturnDifferenceOfTwoNumbers()
        {
            // Arrange (No need to arrange as the method is simple)
            int a = 20;
            int b = 7;

            // Act
            int result = _calculator.Sub(a, b);

            // Assert
            Assert.Equal(13, result);
        }

        [Fact]
        public void Mul_ShouldReturnProductOfTwoNumbers()
        {
            // Arrange (No need to arrange as the method is simple)
            int a = 4;
            int b = 5;

            // Act
            int result = _calculator.Mul(a, b);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Div_ShouldReturnQuotientOfTwoNumbers()
        {
            // Arrange (No need to arrange as the method is simple)
            int a = 15;
            int b = 3;

            // Act
            double result = _calculator.Div(a, b);

            // Assert
            Assert.Equal(5.0, result);
        }

    } 
}
