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
    }
}