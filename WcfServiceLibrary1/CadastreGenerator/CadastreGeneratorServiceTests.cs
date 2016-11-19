using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CadastreGenerator
{
    [TestFixture]
    public class CadastreGeneratorServiceTests
    {
        [Test]
        public void GenerateMethodReturnsString()
        {
            CadastreGeneratorService testExample = new CadastreGeneratorService();
            var result = testExample.Generate();
            Assert.IsTrue(result is string);
        }

        [Test]
        public void GenerateMethodReturnsMathingResult()
        {
            CadastreGeneratorService testExample = new CadastreGeneratorService();
            var result = testExample.Generate();
            StringAssert.IsMatch(@"\d{2}:\d{2}:\d{6,7}:\d{2}", result);
        }


    }
}