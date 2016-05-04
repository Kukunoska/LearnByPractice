using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.DAL.Repositories.Education;
using LearnByPractice.DAL.Repositories.Security;
using LearnByPractice.Domain.Education;
using LearnByPractice.Domain.Security;

namespace LearnByPractice.Tests.DAL.Respositories.Education
{
    [TestFixture]
    public class OcenaRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
 
            OcenaRepository repository = new OcenaRepository();
            OcenaCollection zemi = repository.GetAll();
            Assert.IsNotNull(zemi);

            //Assert.IsTrue(zemi.Count >= 3);

            foreach ( Ocena ocena in zemi)
            {
                Console.WriteLine("ИД: {0}, Име: {1}, Вид: {2}", ocena.StudentId, ocena.PredmetId, ocena.Ocenka );
            }
        }
        protected int randomOcena()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomInt = random.Next(5, 11);
            switch (randomInt)
            {
                case 5:
                    return (5);

                case 6:
                    return (6);

                case 7:
                    return (7);

                case 8:
                    return (8);

                case 9:
                    return (9);

                case 10:
                    return (10);

                default:
                    throw new InvalidOperationException("Добиена е случајна вредност надвор од дадените граници.");
            }
        }

        [Test]
        public void InsertTest()
        {            
            Random random = new Random(DateTime.Now.Millisecond);

            KorisnikRepository korisnikRep = new KorisnikRepository();
            KorisnikCollection siteKorisnici = korisnikRep.GetAll();
            int KorisnikID = random.Next(0, siteKorisnici.Count);
            Korisnik izbranKorisnik = siteKorisnici[KorisnikID];
          
            PredmetRepository predmetRep = new PredmetRepository();
            PredmetCollection sitePredmeti = predmetRep.GetAll();
            int PredmetID = random.Next(0, sitePredmeti.Count);
            Predmet izbranPredmet = sitePredmeti[PredmetID];  
            
            Ocena ocena = new Ocena();
            ocena.Ocenka = randomOcena();
            ocena.StudentId = izbranKorisnik.IdKorisnik;
            ocena.PredmetId = izbranPredmet.Id;

            OcenaRepository repository = new OcenaRepository();
            Ocena dodadete = repository.Insert(ocena);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(ocena.StudentId, dodadete.StudentId);
            Assert.AreEqual(ocena.PredmetId, dodadete.PredmetId);
             Assert.AreEqual(ocena.PredmetId, dodadete.Ocenka);

            Console.WriteLine("Додадена е нова оцена: СтудентИД: {0}, ПредметИД: {1}, Оцена: {2}", dodadete.StudentId, dodadete.PredmetId, dodadete.Ocenka);
        }

    }
}
