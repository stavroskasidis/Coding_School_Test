using System;
using UnitTestingSample;
using Xunit;

namespace TestProject1
{
    public class VATCalculatorTests
    {
        [Fact]
        public void Test1()
        {
            var sut = new VATCalculator();

            var actual = sut.CalculateTotalValue(10, 0.24m);

            Assert.Equal(12.4m, actual);
        }

        [Fact]
        public void Test2()
        {
            var sut = new VATCalculator();

            var actual = sut.CalculateNetValue(12.4m, 0.24m);

            Assert.Equal(10, actual);
        }
    }
}
