using NUnit.Framework;

namespace ContragentTypeGenerator
{
    [TestFixture]
    public class ContragentTypeGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsResultNotZeroLength()
        {
            ContragentTypeGeneratorService testExample = new ContragentTypeGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result.Length > 0);
        }
    }
}