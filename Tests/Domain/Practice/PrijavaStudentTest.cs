using NUnit.Framework;
using LearnByPractice.Domain.Practice;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>PrijavaStudent</c></summary>
    [TestFixture]
    public class PrijavaStudentTest
    {
        [Test]
        public void PrijavaStudentConstructorTest()
        {
            PrijavaStudent ps = new PrijavaStudent();
            Assert.AreEqual(0, ps.IdPrijava);
            Assert.AreEqual(0, ps.IdStudent);
        }
    }
}
