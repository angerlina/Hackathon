using NUnit.Framework;

namespace RankGenerator
{
    [TestFixture]
    public class RankGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsString()
        {
            RankGeneratorService testExample = new RankGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result is string);
        }

        [Test]
        public void GeneratorReturnsResultNotZeroLength()
        {
            RankGeneratorService testExample = new RankGeneratorService();
            string result = testExample.Generate();
            Assert.IsTrue(result.Length > 0);
        }
    }
}