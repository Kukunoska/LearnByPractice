using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>OblastCollection</c></summary>
    [TestFixture]
    public class OblastCollectionTest
    {
        [Test]
        public void OblastCollectionEmptyConsturctorTest()
        {
            OblastCollection oe = new OblastCollection();
            Assert.IsNotNull(oe);
            Assert.IsEmpty(oe);
        }

        [Test]
        public void OblastCollectionConsturctorTest()
        {
            List<Oblast> list = new List<Oblast>();
            OblastCollection oc = new OblastCollection(list);
            Assert.IsNotNull(oc);
            Assert.IsEmpty(oc);
        }
    }
}
