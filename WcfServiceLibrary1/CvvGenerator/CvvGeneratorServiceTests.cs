using NUnit.Framework;

namespace CvvGenerator
{
    [TestFixture]
    public class CvvGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsStringForIndividual()
        {
            CvvGeneratorService testExample = new CvvGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result is string);
        }

        [Test]
        public void CheckReturningLength()
        {
            CvvGeneratorService testExample = new CvvGeneratorService();
            string result = testExample.Generate();
            Assert.IsTrue(result.Length == 3);
        }
    }
}