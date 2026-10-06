namespace FractionLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Fraction fraction = new Fraction(2,4);

            Assert.Equal(1, fraction.Numerator);
            Assert.Equal(3, fraction.Denominator);
        }
    }
}
