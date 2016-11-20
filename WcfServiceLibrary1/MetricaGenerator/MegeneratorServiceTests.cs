using NUnit.Framework;

namespace MetricaGenerator
{
    [TestFixture]
    public class MetricaGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsResultNotZeroLength()
        {
            MetricaGeneratorService testExample = new MetricaGeneratorService();
            string result = testExample.Generate();
            Assert.IsTrue(result.Length > 0);
        }

        [Test]
        public void GeneratorReturnsMatchingResult()
        {
            MetricaGeneratorService testExample = new MetricaGeneratorService();
            string result = testExample.Generate();
            StringAssert.IsMatch(@"^[A-Z]{1}\S{3}\s\d{6}", result);
        }
    }
}