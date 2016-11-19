using NUnit.Framework;

namespace KppGenerator
{
    [TestFixture]
    public class KppGeneratorServiceTests
    {
        [Test]
        public void GenerateTestReturnsString()
        {
            KppGeneratorService testExemplair = new KppGeneratorService();
            var result = testExemplair.Generate();
            Assert.IsTrue(result is string);

        }

        [Test]
        public void GenerateTestReturnsEnoughSymbols()
        {
            KppGeneratorService testExemplair = new KppGeneratorService();
            var result = testExemplair.Generate();
            Assert.IsTrue(result.Length == 9);
        }
    }
}