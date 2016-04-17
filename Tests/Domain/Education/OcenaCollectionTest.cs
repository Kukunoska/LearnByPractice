using NUnit.Framework;
using LearnByPractice.Domain.Education;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Education
{
    /// <summary>Тестови за класата <c>OcenaCollection</c></summary>
    [TestFixture]
    public class OcenaCollectionTest
    {
        [Test]
        public void OcenaCollectionEmptyConsturctorTest()
        {
            OcenaCollection oce = new OcenaCollection();
            Assert.IsNotNull(oce);
            Assert.IsEmpty(oce);
        }

        [Test]
        public void OcenaCollectionConsturctorTest()
        {
            List<Ocena> list = new List<Ocena>();
            OcenaCollection oc = new OcenaCollection(list);
            Assert.IsNotNull(oc);
            Assert.IsEmpty(oc);
        }
    }
}
