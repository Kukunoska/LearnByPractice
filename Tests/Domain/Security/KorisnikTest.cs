using NUnit.Framework;
using LearnByPractice.Domain.Security;

namespace LearnByPractice.Tests.Domain.Security
{
    /// <summary>Тестови за класата <c>Korisnik</c></summary>
    [TestFixture]
    public class KorisnikTest
    {
        [Test]
        public void KorisnikConstructorTest()
        {
            Korisnik k = new Korisnik();
            Assert.AreEqual(0, k.IdKorisnik);
            Assert.IsNull(k.Password);
            Assert.IsNull(k.Username);
            Assert.IsNull(k.Ime);
            Assert.IsNull(k.Prezime);
            Assert.AreEqual(PolEnum.Nepoznat, k.Pol);
            Assert.AreEqual(0, k.studiskaPrograma.Id);
            Assert.IsNull(k.studiskaPrograma.Ime);
            Assert.AreEqual(0, k.organizacija.Id);
            Assert.IsNull(k.organizacija.Ime);
            Assert.IsNull(k.organizacija.Adresa);
            Assert.IsNull(k.organizacija.VebStrana);
            Assert.IsNull(k.organizacija.KontaktTelefon);
            Assert.AreEqual(0, k.organizacija.vidOrganizacija.Id);
            Assert.IsNull(k.organizacija.vidOrganizacija.Ime);
            Assert.IsNull(k.Mobilen);
            Assert.IsNull(k.Email);
            Assert.IsFalse(k.Mentor);
            Assert.IsFalse(k.Administrator);
            Assert.IsFalse(k.Student);
        }
    }
}
