using NUnit.Framework;
using LearnByPractice.Domain.Education;

namespace LearnByPractice.Tests.Domain.Education
{
    /// <summary>Тестови за класата <c>Predmet</c></summary>
    [TestFixture]
    public class PredmetTest
    {
        [Test]
        public void PredmetConstructorTest()
        {
            Predmet p = new Predmet();
            Assert.AreEqual(0, p.Id);
            Assert.IsNull(p.Ime);
        }
    }
}
