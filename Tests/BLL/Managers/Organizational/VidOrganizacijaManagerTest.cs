using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.BLL.Managers.Organizational;


namespace LearnByPractice.Tests.BLL.Managers.Organizational
{
    public class VidOrganizacijaTest
    {
        [Test]
        public void GetAllTest()
        {
            VidOrganizacijaManager manager = new VidOrganizacijaManager();
            VidOrganizacijaCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 2);

            foreach (VidOrganizacija vidOrg in all)
            {
                Console.WriteLine("ВидОрганизацијаИД: {0}, Име: {1},", vidOrg.Id, vidOrg.Ime);
            }

        }
    }
}
