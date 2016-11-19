using NUnit.Framework;

namespace WhomPassportIssuedGenerator
{
    [TestFixture]
    public class WhomPassportIssuedGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsResultNotZeroLength()
        {
            WhomPassportIssuedGeneratorService testExample = new WhomPassportIssuedGeneratorService();
            string result = testExample.Generate();
            Assert.IsTrue(result.Length > 0);
        }

        [Test]
        public void GeneratorReturnedResultIsRandom()
        {
            WhomPassportIssuedGeneratorService testExample = new WhomPassportIssuedGeneratorService();
            WhomPassportIssuedGeneratorService testExample2 = new WhomPassportIssuedGeneratorService();
            string firstResult = testExample.Generate();
            string secondResult = testExample2.Generate();
            Assert.IsTrue(firstResult != secondResult);
        }
    }
}