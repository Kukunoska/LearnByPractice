using NUnit.Framework;
using LearnByPractice.Domain.Organizational;

namespace LearnByPractice.Tests.Domain.Organizational
{
    /// <summary>Тестови за класата <c>VidOrganizacija</c></summary>
    [TestFixture]
    public class VidOrganizacijaTest
    {
        [Test]
        public void VidOrganizacijaConstructorTest()
        {
            VidOrganizacija vo = new VidOrganizacija();
            Assert.AreEqual(0, vo.Id);
            Assert.IsNull(vo.Ime);
        }
    }
}
