using NUnit.Framework;
using LearnByPractice.Domain.Practice;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>PrijavaTehnologija</c></summary>
    [TestFixture]
    public class PrijavaTehnologijaTest
    {
        [Test]
        public void PrijavaTehnologijaConstructorTest()
        {
            PrijavaTehnologija pt = new PrijavaTehnologija();
            Assert.AreEqual(0, pt.prijava.Id);
            Assert.AreEqual(0, pt.tehnologija.Id);
        }
    }
}
