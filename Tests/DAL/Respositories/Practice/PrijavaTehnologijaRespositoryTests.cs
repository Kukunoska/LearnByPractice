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
                Console.WriteLine("ПријаваИД: {0}, Технологија: {1}, ", prijavaTehnologija.prijava.Id, prijavaTehnologija.tehnologija.Ime);
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

            PrijavaTehnologija tehnologija = new PrijavaTehnologija();
            tehnologija.tehnologija.Id = izbranaTehnologija.Id;

            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologija dodadete = repository.Insert(tehnologija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(tehnologija.prijava.Id, dodadete.prijava.Id);
            Assert.AreEqual(tehnologija.tehnologija.Id, dodadete.tehnologija.Id);

            Console.WriteLine("Пријавена е новa технологијa: ПријаваИД: {0}, Технологија: {1}, ", dodadete.prijava.Id, dodadete.tehnologija.Ime);
        }
        [Test]
        public void GetByIdTest()
        {
            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologija prijavaTeh = repository.Get(1);
            Assert.AreEqual(1, prijavaTeh.tehnologija.Id);
        }
        [Test]
        public void GetByTehnologijaID()
        {
            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologijaCollection teh = repository.GetByTehnologijaId(2);
            Assert.IsNotNull(teh);
            Assert.IsTrue(teh.Count >= 2);
            Assert.IsTrue(teh.All(tehnologija => tehnologija.tehnologija.Id == 1));
            foreach (PrijavaTehnologija prijava in teh)
            {
                Console.WriteLine(" ПријаваИД: {0}, Технологија: {1}, ", prijava.prijava.Id, prijava.tehnologija.Ime);
            }
        }
    }
}

