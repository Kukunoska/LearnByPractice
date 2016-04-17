using NUnit.Framework;
using LearnByPractice.Domain.Security;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Security
{
    /// <summary>Тестови за класата <c> KorisnikCollection</c></summary>
    [TestFixture]
    public class KorisnikCollectionTest
    {
        [Test]
        public void KorisnikCollectionEmptyConsturctorTest()
        {
            KorisnikCollection kce = new KorisnikCollection();
            Assert.IsNotNull(kce);
            Assert.IsEmpty(kce);
        }

        [Test]
        public void KorisnikCollectionConsturctorTest()
        {
            List<Korisnik> list = new List<Korisnik>();
            KorisnikCollection kc = new KorisnikCollection(list);
            Assert.IsNotNull(kc);
            Assert.IsEmpty(kc);
        }
    }
}
