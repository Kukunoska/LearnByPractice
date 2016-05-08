using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.DAL.Repositories.Practice;

namespace LearnByPractice.Tests.DAL.Respositories.Practice
{
    public class TehnologijaRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            TehnologijaRepository respository = new TehnologijaRepository();
            TehnologijaCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);

            Assert.IsTrue(zemi.Count >= 0);

            foreach (Tehnologija tehnologija in zemi)
            {
                Console.WriteLine("ТехнологијаИД: {0}, Име: {1}, Област: {2}, ", tehnologija.Id, tehnologija.Ime, tehnologija.oblast.Ime);
            }
        }

        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            OblastRepository oblastRep = new OblastRepository();
            OblastCollection siteOblasti = oblastRep.GetAll();
            int OblastID = random.Next(0, siteOblasti.Count);
            Oblast izbranaOblast = siteOblasti[OblastID];

            Tehnologija tehnologija = new Tehnologija();
            tehnologija.Ime = string.Format("Технологија {0}", Guid.NewGuid().ToString());
            tehnologija.oblast.Ime = izbranaOblast.Ime;

            TehnologijaRepository repository = new TehnologijaRepository();
            Tehnologija dodadete = repository.Insert(tehnologija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(tehnologija.Ime, dodadete.Ime);
            Assert.AreEqual(tehnologija.oblast.Ime, dodadete.oblast.Ime);

            Console.WriteLine("Додаденa е новa технологијa: ТехнологијаИД: {0}, Име: {1}, Област: {2}, ", dodadete.Id, dodadete.Ime, dodadete.oblast.Ime);
        }
        [Test]
        public void GetByIdTest()
        {
            TehnologijaRepository repository = new TehnologijaRepository();
            Tehnologija teh = repository.Get(1);
            Assert.AreEqual(1, teh.Id);
        }
    }
}
