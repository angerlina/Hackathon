using NUnit.Framework;

namespace LocalityTypeGenerator
{
    [TestFixture]
    public class LocalityTypeGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsString()
        {
            LocalityTypeGeneratorService testExample = new LocalityTypeGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result is string);
        }

        [Test]
        public void GeneratorReturnsStringNotZeroLength()
        {
            LocalityTypeGeneratorService testExample = new LocalityTypeGeneratorService();
            string result = testExample.Generate();
            Assert.IsTrue(result.Length > 0);
        }
    }
}