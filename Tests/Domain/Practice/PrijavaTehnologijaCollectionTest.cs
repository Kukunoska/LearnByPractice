using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>PrijavaTehnologijaCollection</c></summary>
    [TestFixture]
    public class PrijavaTehnologijaCollectionTest
    {
        [Test]
        public void PrijavaTehnologijaCollectionEmptyConsturctorTest()
        {
            PrijavaTehnologijaCollection ptce = new PrijavaTehnologijaCollection();
            Assert.IsNotNull(ptce);
            Assert.IsEmpty(ptce);
        }

        [Test]
        public void PrijavaTehnologijaCollectionConsturctorTest()
        {
            List<PrijavaTehnologija> list = new List<PrijavaTehnologija>();
            PrijavaTehnologijaCollection ptc = new PrijavaTehnologijaCollection(list);
            Assert.IsNotNull(ptc);
            Assert.IsEmpty(ptc);
        }
    }
}
