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

       
        [Test]
        public void InsertTest()
        {

            Random random = new Random();
            VidOrganizacija vidOrg = new VidOrganizacija();
            vidOrg.Id = random.Next(55, 999);
            vidOrg.Ime = string.Format("Име{0}", Guid.NewGuid().ToString());
            VidOrganizacijaManager manager = new VidOrganizacijaManager();
            VidOrganizacija dodadete = manager.Insert(vidOrg);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(vidOrg.Ime, dodadete.Ime);

            Console.WriteLine("Додаден е нов Вид Организација: ВидОрганизацијаИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }

    }
}
