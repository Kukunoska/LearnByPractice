using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Organizational
{
    /// <summary>Тестови за класата <c>KompanijaCollection</c></summary>
    [TestFixture]
    public class KompanijaCollectionTest
    {
        [Test]
        public void KompanijaCollectionEmptyConsturctorTest()
        {
            KompanijaCollection kce = new KompanijaCollection();
            Assert.IsNotNull(kce);
            Assert.IsEmpty(kce);
        }

        [Test]
        public void KompanijaCollectionConsturctorTest()
        {
            List<Kompanija> list = new List<Kompanija>();
            KompanijaCollection kc= new KompanijaCollection(list);
            Assert.IsNotNull(kc);
            Assert.IsEmpty(kc);
        }
    }
}
