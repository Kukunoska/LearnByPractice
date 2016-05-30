using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.BLL.Managers.Practice;


namespace LearnByPractice.Tests.BLL.Managers.Practice
{
    public class TehnologijaManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            TehnologijaManager manager = new TehnologijaManager();
            TehnologijaCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 0);

            foreach (Tehnologija tehnologija in all)
            {
                Console.WriteLine("ТехнологијаИД: {0}, Име: {1}, Област: {2}, ", tehnologija.Id, tehnologija.Ime, tehnologija.oblast.Ime);
            }
        }

        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            OblastManager oblastMan = new OblastManager();
            OblastCollection siteOblasti = oblastMan.GetAll();
            int OblastID = random.Next(0, siteOblasti.Count);
            Oblast izbranaOblast = siteOblasti[OblastID];

            Tehnologija tehnologija = new Tehnologija();
            tehnologija.Ime = string.Format("Име {0}", Guid.NewGuid().ToString());
            tehnologija.oblast.Id = izbranaOblast.Id;

            TehnologijaManager manager = new TehnologijaManager();
            Tehnologija dodadete = manager.Insert(tehnologija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(tehnologija.Ime, dodadete.Ime);
            Assert.AreEqual(tehnologija.oblast.Id, dodadete.oblast.Id);

            Console.WriteLine("Додаденa е новa технологијa: ТехнологијаИД: {0}, Име: {1}, Област: {2}, ", dodadete.Id, dodadete.Ime, dodadete.oblast.Id);
        }
       
        [Test]
        public void UpdateTest()
        {
            TehnologijaManager manager = new TehnologijaManager();
            TehnologijaCollection siteTeh = manager.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int tehId = random.Next(0, siteTeh.Count);
            Tehnologija izbranaTeh = siteTeh[tehId];

            Console.WriteLine("Се менуваат податоците за технологија ИД: {0}, Име: {1}", izbranaTeh.Id, izbranaTeh.Ime);

            izbranaTeh.Ime = string.Format("Изменета {0}", Guid.NewGuid().ToString());

            Tehnologija izmenetaTeh = manager.Update(izbranaTeh);

            Assert.IsNotNull(izmenetaTeh);
            Assert.AreEqual(izbranaTeh.Id, izmenetaTeh.Id);
            Assert.AreEqual(izbranaTeh.Ime, izmenetaTeh.Ime);

            Console.WriteLine("Изменетите податоци за технологија ИД: {0}, Име: {1}", izmenetaTeh.Id, izmenetaTeh);
        }
    }
}
