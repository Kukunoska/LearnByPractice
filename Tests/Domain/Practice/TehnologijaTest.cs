using NUnit.Framework;
using LearnByPractice.Domain.Practice;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>Tehnologija</c></summary>
    [TestFixture]
    public class TehnologijaTest
    {
        [Test]
        public void TehnologijaConstructorTest()
        {
            Tehnologija t = new Tehnologija();
            Assert.AreEqual(0, t.Id);
            Assert.IsNull(t.Ime);
            Assert.AreEqual(0, t.oblast.Id);
            Assert.IsNull(t.oblast.Ime);
        }
    }
}
