using NUnit.Framework;

namespace StreetTypeGenerator
{
    [TestFixture]
    public class StreetTypeGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsResultNotZeroLength()
        {
            StreetTypeGeneratorService testExample = new StreetTypeGeneratorService();
            string result = testExample.Generate();
            Assert.IsTrue(result.Length > 0);
        }

        [Test]
        public void GeneratorReturnedResultIsRandom()
        {
            StreetTypeGeneratorService testExample = new StreetTypeGeneratorService();
            StreetTypeGeneratorService testExample2 = new StreetTypeGeneratorService();
            string firstResult = testExample.Generate();
            string secondResult = testExample2.Generate();
            Assert.IsTrue(firstResult != secondResult);
        }
    }
}