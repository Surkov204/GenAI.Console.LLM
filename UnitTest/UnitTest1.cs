using Xunit;
using DemoUnitTest_ConsoleApp;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsCorrectResult()
        {
            var calc = new Calculator();
            var result = calc.Add(6, 3);
            Console.WriteLine($"result ---> : {result}");
            Assert.Equal(9, result);
        }
    }
}