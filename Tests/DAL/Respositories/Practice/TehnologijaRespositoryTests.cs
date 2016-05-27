using System;
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

            Assert.IsTrue(zemi.Count >= 2);

            foreach (Tehnologija tehnologija in zemi)
            {
                Console.WriteLine("ТехнологијаИД: {0}, Име: {1}, Област: {2}, ", tehnologija.Id, tehnologija.Ime, tehnologija.oblast.Id);
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
            tehnologija.Ime = string.Format("Име {0}", Guid.NewGuid().ToString());
            tehnologija.oblast.Id = izbranaOblast.Id;

            TehnologijaRepository repository = new TehnologijaRepository();
            Tehnologija dodadete = repository.Insert(tehnologija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(tehnologija.Ime, dodadete.Ime);
            Assert.AreEqual(tehnologija.oblast.Id, dodadete.oblast.Id);

            Console.WriteLine("Додаденa е новa технологијa: ТехнологијаИД: {0}, Име: {1}, Област: {2}, ", dodadete.Id, dodadete.Ime, dodadete.oblast.Id);
        }
        [Test]
        public void GetByIdTest()
        {
            TehnologijaRepository repository = new TehnologijaRepository();
            Tehnologija teh = repository.Get(1);
            Assert.AreEqual(1, teh.Id);
        }
        [Test]
        public void UpdateTest()
        {
            TehnologijaRepository repository = new TehnologijaRepository();
            TehnologijaCollection siteTeh = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int tehId = random.Next(0, siteTeh.Count);
            Tehnologija izbranaTeh = siteTeh[tehId];

            Console.WriteLine("Се менуваат податоците за технологија ИД: {0}, Име: {1}", izbranaTeh.Id, izbranaTeh.Ime);

            izbranaTeh.Ime = string.Format("Изменета {0}", Guid.NewGuid().ToString());

            Tehnologija izmenetaTeh = repository.Update(izbranaTeh);

            Assert.IsNotNull(izmenetaTeh);
            Assert.AreEqual(izbranaTeh.Id, izmenetaTeh.Id);
            Assert.AreEqual(izbranaTeh.Ime, izmenetaTeh.Ime);

            Console.WriteLine("Изменетите податоци за технологија ИД: {0}, Име: {1}", izmenetaTeh.Id, izmenetaTeh);
        }
    }
}
