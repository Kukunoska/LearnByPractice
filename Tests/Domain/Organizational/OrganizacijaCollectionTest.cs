using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using System.Collections.Generic;

namespace LearnByPractice.Tests.Domain.Organizational
{
    /// <summary>Тестови за класата <c>OrganizacijaCollection</c></summary>
    [TestFixture]
    public class OrganizacijaCollectionTest
    {
        [Test]
        public void OrganizacijaCollectionEmptyConsturctorTest()
        {
            OrganizacijaCollection orgce = new OrganizacijaCollection();
            Assert.IsNotNull(orgce);
            Assert.IsEmpty(orgce);
        }

        [Test]
        public void OrganizacijaCollectionConsturctorTest()
        {
            List<Organizacija> list = new List<Organizacija>();
            OrganizacijaCollection kc= new OrganizacijaCollection(list);
            Assert.IsNotNull(kc);
            Assert.IsEmpty(kc);
        }
    }
}
