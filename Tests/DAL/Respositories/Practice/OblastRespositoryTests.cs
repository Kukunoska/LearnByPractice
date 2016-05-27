using System;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.DAL.Repositories.Practice;

namespace LearnByPractice.Tests.DAL.Respositories.Practice
{
    public class OblastRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            OblastRepository respository = new OblastRepository();
            OblastCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);

            Assert.IsTrue(zemi.Count >= 3);

            foreach (Oblast oblast in zemi)
            {
                Console.WriteLine("ОбластИД: {0}, Име: {1},", oblast.Id, oblast.Ime);
            }
        }

        [Test]
        public void InsertTest()
        {


            Oblast oblast = new Oblast();
            oblast.Ime = string.Format("Име {0}", Guid.NewGuid().ToString());

            OblastRepository repository = new OblastRepository();
            Oblast dodadete = repository.Insert(oblast);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(oblast.Ime, dodadete.Ime);

            Console.WriteLine("Додаденa е новa oбласт: ОбластИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }
        [Test]
        public void GetByIdTest()
        {
            OblastRepository repository = new OblastRepository();
            Oblast oblast = repository.Get(1);
            Assert.AreEqual(1, oblast.Id);
        }
        [Test]
        public void UpdateTest()
        {
            OblastRepository repository = new OblastRepository();
            OblastCollection siteOblasti = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int oblastId = random.Next(0, siteOblasti.Count);
            Oblast izbranaOblast = siteOblasti[oblastId];

            Console.WriteLine("Се менуваат податоците за област ИД: {0}, Име: {1}", izbranaOblast.Id, izbranaOblast.Ime);

            izbranaOblast.Ime = string.Format("Изменета {0}", Guid.NewGuid().ToString());

            Oblast izmenetaOblast = repository.Update(izbranaOblast);

            Assert.IsNotNull(izmenetaOblast);
            Assert.AreEqual(izbranaOblast.Id, izmenetaOblast.Id);
            Assert.AreEqual(izbranaOblast.Ime, izmenetaOblast.Ime);

            Console.WriteLine("Изменетите податоци за областа: ИД: {0}, Име: {1}", izmenetaOblast.Id, izmenetaOblast.Ime);
        }
    }
}