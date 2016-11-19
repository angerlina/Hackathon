using NUnit.Framework;

namespace KppGenerator
{
    [TestFixture]
    public class KppGeneratorServiceTests
    {
        [Test]
        public void GenerateTestReturnsString()
        {
            KppGeneratorService testExample = new KppGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result is string);

        }

        [Test]
        public void GenerateTestReturnsEnoughSymbols()
        {
            KppGeneratorService testExample = new KppGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result.Length == 9);
        }
    }
}