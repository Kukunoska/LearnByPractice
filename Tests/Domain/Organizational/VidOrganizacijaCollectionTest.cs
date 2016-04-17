using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Organizational
{
    /// <summary>Тестови за класата <c>VidOrganizacija</c></summary>
    [TestFixture]
    public class VidOrganizacijaCollectionTest
    {
        [Test]
        public void VidOrganizacijaCollectionEmptyConsturctorTest()
        {
            VidOrganizacijaCollection voec = new VidOrganizacijaCollection();
            Assert.IsNotNull(voec);
            Assert.IsEmpty(voec);
        }

        [Test]
        public void VidOrganizacijaCollectionConsturctorTest()
        {
            List<VidOrganizacija> list = new List<VidOrganizacija>();
            VidOrganizacijaCollection voc = new VidOrganizacijaCollection(list);
            Assert.IsNotNull(voc);
            Assert.IsEmpty(voc);
        }
    }
}
