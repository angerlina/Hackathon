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
    }
}