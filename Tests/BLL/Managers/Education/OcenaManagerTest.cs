using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Education;
using LearnByPractice.BLL.Managers.Education;
using LearnByPractice.BLL.Managers.Security;
using LearnByPractice.Domain.Security;


namespace LearnByPractice.Tests.BLL.Managers.Education
{
    public class OcenaManagerTest
    {
        [Test]
        public void GetAllTest()
        {

            OcenaManager manager = new OcenaManager();
            OcenaCollection zemi = manager.GetAll();
            Assert.IsNotNull(zemi);

            foreach (Ocena ocena in zemi)
            {
                Console.WriteLine("ИД: {0}, Име: {1}, Вид: {2}", ocena.student.Id, ocena.predmet.Id, ocena.Ocenka);
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

            KorisnikManager korisnikMan = new KorisnikManager();
            KorisnikCollection siteKorisnici = korisnikMan.GetAll();
            int KorisnikID = random.Next(0, siteKorisnici.Count);
            Korisnik izbranKorisnik = siteKorisnici[KorisnikID];

            PredmetManager predmetMan = new PredmetManager();
            PredmetCollection sitePredmeti = predmetMan.GetAll();
            int PredmetID = random.Next(0, sitePredmeti.Count);
            Predmet izbranPredmet = sitePredmeti[PredmetID];

            Ocena ocena = new Ocena();
            ocena.Ocenka = randomOcena();
            ocena.student.Id = izbranKorisnik.Id;
            ocena.predmet.Id = izbranPredmet.Id;

            OcenaManager manager = new OcenaManager();
            Ocena dodadete = manager.Insert(ocena);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(ocena.student.Id, dodadete.student.Id);
            Assert.AreEqual(ocena.predmet.Id, dodadete.predmet.Id);
            Assert.AreEqual(ocena.Ocenka, dodadete.Ocenka);

            Console.WriteLine("Додадена е нова оцена: СтудентИД: {0}, ПредметИД: {1}, Оцена: {2}", dodadete.student.Id, dodadete.predmet.Id, dodadete.Ocenka);
        }
       
        [Test]
        public void UpdateTest()
        {
            OcenaManager manager = new OcenaManager();
            OcenaCollection siteOceni = manager.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int ocena = random.Next(0, siteOceni.Count);
            Ocena izbranaocena = siteOceni[ocena];

            Console.WriteLine("Се менуваат податоците за оцена ИДСтудент: {0}, ИДПредмет: {1}, оцена: {1}", izbranaocena.student.Id, izbranaocena.predmet.Id, izbranaocena.Ocenka);

            izbranaocena.Ocenka = randomOcena();
            Ocena izmenetaOcena = manager.Update(izbranaocena);

            Assert.IsNotNull(izmenetaOcena);
            Assert.AreEqual(izbranaocena.student.Id, izmenetaOcena.student.Id);
            Assert.AreEqual(izbranaocena.predmet.Id, izmenetaOcena.predmet.Id);
            Assert.AreEqual(izbranaocena.Ocenka, izmenetaOcena.Ocenka);

            Console.WriteLine("Изменетите податоци за оцена ИДСтудент: {0}, ИДПредмет: {1}, оцена: {1}", izmenetaOcena.student.Id, izmenetaOcena.predmet.Id, izmenetaOcena.Ocenka);
        }

    }
}
