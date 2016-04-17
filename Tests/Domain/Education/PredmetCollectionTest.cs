using NUnit.Framework;
using LearnByPractice.Domain.Education;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Education
{
    /// <summary>Тестови за класата <c>PredmetCollection</c></summary>
    [TestFixture]
    public class PredmetCollectionTest
    {
        [Test]
        public void PredmetCollectionEmptyConsturctorTest()
        {
            PredmetCollection pce = new PredmetCollection();
            Assert.IsNotNull(pce);
            Assert.IsEmpty(pce);
        }

        [Test]
        public void PredmetCollectionConsturctorTest()
        {
            List<Predmet> list = new List<Predmet>();
            PredmetCollection pc = new PredmetCollection(list);
            Assert.IsNotNull(pc);
            Assert.IsEmpty(pc);
        }
    }
}
