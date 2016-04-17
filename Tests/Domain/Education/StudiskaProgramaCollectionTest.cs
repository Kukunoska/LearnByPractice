using NUnit.Framework;
using LearnByPractice.Domain.Education;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Education
{
    /// <summary>Тестови за класата <c>StudiskaProgramaCollection</c></summary>
    [TestFixture]
    public class StudiskaProgramaCollectionTest
    {
        [Test]
        public void StudiskaProgramaCollectionEmptyConsturctorTest()
        {
            StudiskaProgramaCollection spce = new StudiskaProgramaCollection();
            Assert.IsNotNull(spce);
            Assert.IsEmpty(spce);
        }

        [Test]
        public void StudiskaProgramaCollectionConsturctorTest()
        {
            List<StudiskaPrograma> list = new List<StudiskaPrograma>();
            StudiskaProgramaCollection spc = new StudiskaProgramaCollection(list);
            Assert.IsNotNull(spc);
            Assert.IsEmpty(spc);
        }
    }
}
