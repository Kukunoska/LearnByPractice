using NUnit.Framework;
using LearnByPractice.Domain.Education;

namespace LearnByPractice.Tests.Domain.Education
{
    /// <summary>Тестови за класата <c>Ocena</c></summary>
    [TestFixture]
    public class OcenaTest
    {
        [Test]
        public void OcenaConsturctorTest()
        {
            Ocena o = new Ocena();
            Assert.AreEqual(0, o.Ocenka);
            Assert.AreEqual(0, o.student.IdKorisnik);
            Assert.AreEqual(0, o.predmet.Id);
        }
    }
}
