using NUnit.Framework;
using LearnByPractice.Domain.Education;

namespace LearnByPractice.Tests.Domain.Education
{
    /// <summary>Тестови за класата <c>StudiskaPrograma</c></summary>
    [TestFixture]
    public class StudiskaProgramaTest
    {
        [Test]
        public void StudiskaProgramaConstructorTest()
        {
            StudiskaPrograma sp = new StudiskaPrograma();
            Assert.AreEqual(0, sp.Id);
            Assert.IsNull(sp.Ime);
        }
    }
}
