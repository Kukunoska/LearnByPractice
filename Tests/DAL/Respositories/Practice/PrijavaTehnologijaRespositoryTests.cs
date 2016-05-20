using System;
using System.Linq;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.DAL.Repositories.Practice;

namespace LearnByPractice.Tests.DAL.Respositories.Practice
{
    public class PrijavaTehnologijaRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            PrijavaTehnologijaRepository respository = new PrijavaTehnologijaRepository();
            PrijavaTehnologijaCollection zemi = respository.GetAll();
            Assert.IsTrue(zemi.Count >= 2);

            foreach (PrijavaTehnologija prijavaTehnologija in zemi)
            {
                Console.WriteLine("ПријаваИД: {0}, Технологија: {1}, ", prijavaTehnologija.prijava.Id, prijavaTehnologija.tehnologija.Id);
            }
        }

        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            TehnologijaRepository TehRep = new TehnologijaRepository();
            TehnologijaCollection siteTehnologii = TehRep.GetAll();
            int TehID = random.Next(0, siteTehnologii.Count);
            Tehnologija izbranaTehnologija = siteTehnologii[TehID];

            PrijavaRepository PrijavaRep = new PrijavaRepository();
            PrijavaCollection sitePrijavi = PrijavaRep.GetAll();
            int prijava = random.Next(0, sitePrijavi.Count);
            Prijava izbranaprijava = sitePrijavi[prijava];

            PrijavaTehnologija tehnologija = new PrijavaTehnologija();
            tehnologija.prijava.Id = izbranaprijava.Id;
            tehnologija.tehnologija.Id = izbranaTehnologija.Id;

            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologija dodadete = repository.Insert(tehnologija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(tehnologija.prijava.Id, dodadete.prijava.Id);
            Assert.AreEqual(tehnologija.tehnologija.Id, dodadete.tehnologija.Id);

            Console.WriteLine("Пријавена е новa технологијa: ПријаваИД: {0}, Технологија: {1}, ", dodadete.prijava.Id, dodadete.tehnologija.Id);
        }
        [Test]
        public void GetByIdTest()
        {
            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologijaCollection prijavaTeh = repository.Get(8);
            Assert.IsNotNull(prijavaTeh);
            Assert.IsTrue(prijavaTeh.Count >= 1);
            Assert.IsTrue(prijavaTeh.All(tehnologija => tehnologija.prijava.Id == 8));
            foreach (PrijavaTehnologija prijava in prijavaTeh)
            {
                Console.WriteLine(" ПријаваИД: {0}, Технологија: {1}, ", prijava.prijava.Id, prijava.tehnologija.Id);
            }
        }
        [Test]
        public void GetByTehnologijaID()
        {
            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologijaCollection teh = repository.GetByTehnologijaId(13);
            Assert.IsNotNull(teh);
            Assert.IsTrue(teh.Count >= 1);
            Assert.IsTrue(teh.All(tehnologija => tehnologija.tehnologija.Id == 13));
            foreach (PrijavaTehnologija prijava in teh)
            {
                Console.WriteLine(" ПријаваИД: {0}, Технологија: {1}, ", prijava.prijava.Id, prijava.tehnologija.Id);
            }
        }
        [Test]
        public void UpdateTest()
        {
            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologijaCollection sitePrijavi = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int prijavaId = random.Next(0, sitePrijavi.Count);
            PrijavaTehnologija izbranaPrijava = sitePrijavi[prijavaId];

            Console.WriteLine("Се менуваат податоците за пријава ПријаваИД: {0}, Технологија: {1}", izbranaPrijava.prijava.Id, izbranaPrijava.tehnologija.Id);

            PrijavaRepository PRep = new PrijavaRepository();
            PrijavaCollection siteP = PRep.GetAll();
            int PID = random.Next(0, siteP.Count);
            Prijava izbranaP = siteP[PID];
            PrijavaTehnologija prijava = new PrijavaTehnologija();
            prijava.prijava.Id = izbranaP.Id;

            PrijavaTehnologija izmenetaPrijava = repository.Update(izbranaPrijava);

            Assert.IsNotNull(izmenetaPrijava);
            Assert.AreEqual(izbranaPrijava.prijava.Id, izmenetaPrijava.prijava.Id);
            Assert.AreEqual(izbranaPrijava.tehnologija.Id, izmenetaPrijava.tehnologija.Id);

            Console.WriteLine("Изменетите податоци за пријава: ПријаваИД: {0}, Технологија: {1}", izmenetaPrijava.prijava.Id, izmenetaPrijava.tehnologija.Id);
        }
    }
}

