using NUnit.Framework;
using LearnByPractice.Domain.Organizational;

namespace LearnByPractice.Tests.Domain.Organizational
{
    /// <summary>Тестови за класата <c>Kompanija</c></summary>
    [TestFixture]
    public class KompanijaTest
    {
        [Test]
        public void KompanijaConstructorTest()
        {
            Kompanija k = new Kompanija();
            Assert.AreEqual(0, k.Id);
            Assert.IsNull(k.Ime);
            Assert.IsNull(k.Adresa);
            Assert.IsNull(k.VebStrana);
            Assert.IsNull(k.KontaktTelefon);
            Assert.AreEqual(0, k.vidOrganizacija.Id);
            Assert.IsNull(k.vidOrganizacija.Ime);
        }
    }
}
