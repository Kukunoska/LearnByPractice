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
            Assert.IsNotNull(zemi);

            //Assert.IsTrue(zemi.Count >= x);

            foreach (PrijavaTehnologija prijavaTehnologija in zemi)
            {
                Console.WriteLine("ПријаваИД: {0}, ТехнологијаИД: {1}, ", prijavaTehnologija.IdPrijava, prijavaTehnologija.IdTehnologija);
            }
        }

        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

           /* TehnologijaRepository TehRep = new TehnologijaRepository();
            TehnologijaCollection siteTehnologii = TehRep.GetAll();
            int TehID = random.Next(0, siteTehnologii.Count);
            Tehnologija izbranaTehnologija = siteTehnologii[TehID];*/

            PrijavaTehnologija tehnologija = new PrijavaTehnologija(); 
            // vo domaintehnologija.IdTehnologija = izbranaTehnologija.Ime;

            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologija dodadete = repository.Insert(tehnologija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(tehnologija.IdPrijava, dodadete.IdPrijava);
            Assert.AreEqual(tehnologija.IdTehnologija, dodadete.IdTehnologija);

            Console.WriteLine("Пријавена е новa технологијa: ПријаваИД: {0}, ТехнологијаИД: {1}, ", dodadete.IdPrijava, dodadete.IdTehnologija);
        }
    }
    }

