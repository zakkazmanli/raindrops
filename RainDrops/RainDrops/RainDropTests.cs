using NUnit.Framework;

namespace RainDrops
{
    [TestFixture]
    public class RainDropTests
    {
        RainDrop _rainDrop;

        [SetUp]
        public void Setup()
        {
            _rainDrop = new RainDrop();
        }

        [TestCase(3)]
        [TestCase(36)]
        [TestCase(81)]
        public void GivenANumberThatOnlyHasAFactorOfThree_ReturnPling(int num)
        {
            Assert.That(_rainDrop.ConvertNumToRainDropString(num), Is.EqualTo("Pling"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        public void GivenANumberThatOnlyHasAFactorOfFive_ReturnPlang(int num)
        {
            Assert.That(_rainDrop.ConvertNumToRainDropString(num), Is.EqualTo("Plang"));
        }

        [TestCase(7)]
        [TestCase(28)]
        [TestCase(49)]
        public void GivenANumberThatOnlyHasAFactorOfSeven_ReturnPlong(int num)
        {
            Assert.That(_rainDrop.ConvertNumToRainDropString(num), Is.EqualTo("Plong"));
        }

        [TestCase(4)]
        [TestCase(23)]
        [TestCase(34)]
        public void GivenANumberThatHasNoStatedFactors_ReturnThatNumber(int num)
        {
            Assert.That(_rainDrop.ConvertNumToRainDropString(num), Is.EqualTo(num.ToString()));
        }

        [TestCase(15, "PlingPlang")]
        [TestCase(30, "PlingPlang")]
        [TestCase(21, "PlingPlong")]
        [TestCase(42, "PlingPlong")]
        [TestCase(35, "PlangPlong")]
        [TestCase(70, "PlangPlong")]
        public void GivenANumberHasMultipleStatedFactors_ReturnAnExtendedString(int num, string expected)
        {
            Assert.That(_rainDrop.ConvertNumToRainDropString(num), Is.EqualTo(expected));
        }
    }
}