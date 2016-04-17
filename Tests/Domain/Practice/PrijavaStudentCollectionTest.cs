using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>PrijavaStudentCollection</c></summary>
    [TestFixture]
    public class PrijavaStudentCollectionTest
    {
        [Test]
        public void PrijavaStudentCollectionEmptyConsturctorTest()
        {
            PrijavaStudentCollection psce = new PrijavaStudentCollection();
            Assert.IsNotNull(psce);
            Assert.IsEmpty(psce);
        }

        [Test]
        public void PrijavaStudentCollectionConsturctorTest()
        {
            List<PrijavaStudent> list = new List<PrijavaStudent>();
            PrijavaStudentCollection psc = new PrijavaStudentCollection(list);
            Assert.IsNotNull(psc);
            Assert.IsEmpty(psc);
        }
    }
}
