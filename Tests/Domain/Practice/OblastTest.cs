using NUnit.Framework;
using LearnByPractice.Domain.Practice;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>Oblast</c></summary>
    [TestFixture]
    public class OblastTest
    {
        [Test]
        public void OblastConstructorTest()
        {
            TehnologijaCollection t = new TehnologijaCollection();
            Oblast o = new Oblast(t);
            Assert.AreEqual(0, o.Id);
            Assert.IsNull(o.Ime);
            Assert.IsNotNull(o.Tehnologii);
            Assert.AreEqual(0, o.Tehnologii.Count);
        }
    }
}
