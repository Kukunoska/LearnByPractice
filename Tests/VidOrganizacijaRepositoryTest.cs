using System;
using NUnit.Framework;
using DAL.Repositories.Organizational;
using LearnByPractice.Domain.Organizational;

namespace LearnByPractice.Tests.DAL.Organizational
{
    /// <summary>Тестови за <c>VidOrganizacijaRepository</c></summary>
    [TestFixture]
    public class VidOrganizacijaRepositoryTest
    {
        [Test]
        public void VidOrganizacijaRepositoryGetTest()
        {
            VidOrganizacijaRespository vor = new VidOrganizacijaRespository();
            VidOrganizacija v = vor.Get(1);
            Assert.AreEqual(1, v.Id);
            Assert.AreEqual("Образовна институција", v.Ime);
            Console.WriteLine("ID: {0}, Име: {1}", v.Id, v.Ime);
        }
    }
}
