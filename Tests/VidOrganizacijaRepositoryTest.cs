using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories.Organizational;
using LearnByPractice.Domain.Organizational;
using DAL.Models;



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
        VidOrganizacija v = new VidOrganizacija();
        v.Id = 1;
        v.Ime = "Образовна институција";
        Assert.AreEqual(v, vor.Get(1));
        }
    }
}
