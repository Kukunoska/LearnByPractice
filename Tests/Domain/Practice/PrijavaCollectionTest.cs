using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>PrijavaCollection</c></summary>
    [TestFixture]
    public class PrijavaCollectionTest
    {
        [Test]
        public void PrijavaCollectionEmptyConsturctorTest()
        {
            PrijavaCollection pce = new PrijavaCollection();
            Assert.IsNotNull(pce);
            Assert.IsEmpty(pce);
        }

        [Test]
        public void PrijavaCollectionConsturctorTest()
        {
            List<Prijava> list = new List<Prijava>();
            PrijavaCollection pc = new PrijavaCollection(list);
            Assert.IsNotNull(pc);
            Assert.IsEmpty(pc);
        }
    }
}
