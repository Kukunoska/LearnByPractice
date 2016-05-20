using System;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.DAL.Repositories.Practice;
using LearnByPractice.DAL.Repositories.Organizational;

namespace LearnByPractice.Tests.DAL.Respositories.Practice
{
    class PrijavaRepositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            PrijavaRepository respository = new PrijavaRepository();
            PrijavaCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);

            Assert.IsTrue(zemi.Count >= 2);

            foreach (Prijava prijava in zemi)
            {
                Console.WriteLine("ПријаваИД: {0}, КомпанијаИД: {1}, Дата: {2}, ", prijava.Id, prijava.kompanija.Id, prijava.Datum);
            }
        }

        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            KompanijaRepository KompRep = new KompanijaRepository();
            KompanijaCollection siteKompanii = KompRep.GetAll();
            int KompID = random.Next(0, siteKompanii.Count);
            Kompanija izbranaKompanija = siteKompanii[KompID];

            Prijava prijava = new Prijava();
            prijava.kompanija.Id = izbranaKompanija.Id;

            PrijavaRepository repository = new PrijavaRepository();
            Prijava dodadete = repository.Insert(prijava);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(prijava.kompanija.Id, dodadete.kompanija.Id);
            Assert.AreEqual(prijava.Datum, dodadete.Datum);

            Console.WriteLine("Пријавена е нова компанија: ПријаваИД: {0}, КомпанијаИД: {1}, Дата{2} ", dodadete.Id, dodadete.kompanija.Id, dodadete.Datum);
        }
        [Test]
        public void GetByIdTest()
        {
            PrijavaRepository repository = new PrijavaRepository();
            Prijava prijava = repository.Get(6);
            Assert.AreEqual(6, prijava.Id);
        }
        [Test]
        public void UpdateTest()
        {
            PrijavaRepository repository = new PrijavaRepository();
            PrijavaCollection sitePrijavi = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int prijavaId = random.Next(0, sitePrijavi.Count);
            Prijava izbranaPrijava = sitePrijavi[prijavaId];

            Console.WriteLine("Се менуваат податоците за пријава ИД: {0}, Компанија: {1}", izbranaPrijava.Id, izbranaPrijava.kompanija.Id);

            KompanijaRepository KompRep = new KompanijaRepository();
            KompanijaCollection siteKompanii = KompRep.GetAll();
            int KompID = random.Next(0, siteKompanii.Count);
            Kompanija izbranaKompanija = siteKompanii[KompID];
            Prijava prijava = new Prijava();
            prijava.kompanija.Id = izbranaKompanija.Id;

            Prijava izmenetaPrijava = repository.Update(izbranaPrijava);

            Assert.IsNotNull(izmenetaPrijava);
            Assert.AreEqual(izbranaPrijava.Id, izmenetaPrijava.Id);
            Assert.AreEqual(izbranaPrijava.kompanija.Id, izmenetaPrijava.kompanija.Id);

            Console.WriteLine("Изменетите податоци за пријава: ИД: {0}, Компанија: {1}", izmenetaPrijava.Id, izmenetaPrijava.kompanija.Id);
        }
    }
}
