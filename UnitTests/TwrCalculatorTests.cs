using TWR;

namespace UnitTests
{
    public class TwrCalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateTwr_When_No_Daily_Returns_Should_Return_Zero()
        {
            var twr = TwrCalculator.CalculateTwr(Enumerable.Empty<double>());
            Assert.AreEqual(0, twr);
        }

        [Test]
        public void CalculateTwr_When_Single_Daily_Return_Is_Zero_Should_Return_Zero()
        {
            var twr = TwrCalculator.CalculateTwr(new[] { 0.0 });
            Assert.AreEqual(0, twr);
        }

        [Test]
        public void CalculateTwr_Assignment_Test()
        {
            var twr = TwrCalculator.CalculateTwr(new[]
            {
                0.0,
                0.0,
                -0.006253657,
                -0.00361612,
                -0.004777986,
                -0.026842209,
                0.000095331,
                0,
                0,
                -0.004793408
            });

            Assert.Less(twr, 0);
        }
    }
}