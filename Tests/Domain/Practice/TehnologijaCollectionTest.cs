using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c> TehnologijaCollection</c></summary>
    [TestFixture]
    public class TehnologijaCollectionTest
    {
        [Test]
        public void TehnologijaCollectionEmptyConsturctorTest()
        {
            TehnologijaCollection tce = new TehnologijaCollection();
            Assert.IsNotNull(tce);
            Assert.IsEmpty(tce);
        }

        [Test]
        public void TehnologijaCollectionConsturctorTest()
        {
            List<Tehnologija> list = new List<Tehnologija>();
            TehnologijaCollection tc = new TehnologijaCollection(list);
            Assert.IsNotNull(tc);
            Assert.IsEmpty(tc);
        }
    }
}
