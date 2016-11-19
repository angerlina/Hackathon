using NUnit.Framework;

namespace EmailGenerator
{
    [TestFixture]
    public class EmailGeneratorServiceTests
    {
        [Test]
        public void GeneratorReturnsStringForIndividual()
        {
            EmailGeneratorService testExample = new EmailGeneratorService();
            var result = testExample.Generate("yandex.ru");
            Assert.IsTrue(result is string);
        }

        [Test]
        public void GeneratorReturnsMathingResult()
        {
            string domain = "yandex.ru";
            EmailGeneratorService testExample = new EmailGeneratorService();
            var result = testExample.Generate(domain);
            StringAssert.IsMatch(@"^.{1,}\@.{1,}\..{1,}", result);
        }

        [Test]
        public void ResultEndWithParameter()
        {
            string domain = "yandex.ru";
            EmailGeneratorService testExample = new EmailGeneratorService();
            var result = testExample.Generate(domain);
            StringAssert.EndsWith(domain, result);
        }
    }
}