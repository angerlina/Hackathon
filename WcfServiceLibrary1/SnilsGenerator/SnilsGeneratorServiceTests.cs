using NUnit.Framework;

namespace SnilsGenerator
{
    [TestFixture]
    public class SnilsGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsString()
        {
            SnilsGeneratorService testExample = new SnilsGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result is string);
        }

        [Test]
        public void GeneratorReturnsResultWithCorrectLength()
        {
            SnilsGeneratorService testExample = new SnilsGeneratorService();
            string result = testExample.Generate();
            Assert.IsTrue(result.Length == 14);
        }

        [Test]
        public void GeneratorReturnsMathcingResult()
        {
            SnilsGeneratorService testExample = new SnilsGeneratorService();
            string result = testExample.Generate();
            StringAssert.IsMatch(@"^\d{3}\-\d{3}\-\d{3}\s\d{2}", result);
        }
    }
}