﻿using System;
using System.Linq;
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
            ocena.student.Id = izbranKorisnik.Id;
            ocena.predmet.Id = izbranPredmet.Id;

            OcenaRepository repository = new OcenaRepository();
            Ocena dodadete = repository.Insert(ocena);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(ocena.student.Id, dodadete.student.Id);
            Assert.AreEqual(ocena.predmet.Id, dodadete.predmet.Id);
            Assert.AreEqual(ocena.Ocenka, dodadete.Ocenka);

            Console.WriteLine("Додадена е нова оцена: СтудентИД: {0}, ПредметИД: {1}, Оцена: {2}", dodadete.student.Id, dodadete.predmet.Id, dodadete.Ocenka);
        }
        [Test]
        public void GetByPredmetIdTest()
        {
            OcenaRepository repository = new OcenaRepository();
            OcenaCollection oceniPoPredmet = repository.GetByPredmetId(1041);
            Assert.IsNotNull(oceniPoPredmet);
            Assert.IsTrue(oceniPoPredmet.Count >= 1);
            Assert.IsTrue(oceniPoPredmet.All(ocena => ocena.predmet.Id == 1041));
            foreach (Ocena ocena in oceniPoPredmet)
            {
                Console.WriteLine("Оцена: {0}, Студент: {1}, Предмет: {2}", ocena.Ocenka, ocena.student.Id, ocena.predmet.Id);
            }
        }
        [Test]
        public void GetByStudentIdTest()
        {
            OcenaRepository repository = new OcenaRepository();
            OcenaCollection oceniPoStudent = repository.GetByStudentId(2034);
            Assert.IsNotNull(oceniPoStudent);
            Assert.IsTrue(oceniPoStudent.Count >= 2);
            Assert.IsTrue(oceniPoStudent.All(ocena => ocena.student.Id == 2034));
            foreach (Ocena ocena in oceniPoStudent)
            {
                Console.WriteLine("Оцена: {0}, Студент: {1}, Предмет: {2}", ocena.Ocenka, ocena.student.Id, ocena.predmet.Id);
            }
        }

        [Test]
        public void UpdateTest()
        {
            OcenaRepository repository = new OcenaRepository();
            OcenaCollection siteOceni = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int ocena = random.Next(0, siteOceni.Count);
            Ocena izbranaocena = siteOceni[ocena];

            Console.WriteLine("Се менуваат податоците за оцена ИДСтудент: {0}, ИДПредмет: {1}, оцена: {1}", izbranaocena.student.Id, izbranaocena.predmet.Id, izbranaocena.Ocenka);

            izbranaocena.Ocenka = randomOcena();
            Ocena izmenetaOcena = repository.Update(izbranaocena);

            Assert.IsNotNull(izmenetaOcena);
            Assert.AreEqual(izbranaocena.student.Id, izmenetaOcena.student.Id);
            Assert.AreEqual(izbranaocena.predmet.Id, izmenetaOcena.predmet.Id);
            Assert.AreEqual(izbranaocena.Ocenka, izmenetaOcena.Ocenka);

            Console.WriteLine("Изменетите податоци за оцена ИДСтудент: {0}, ИДПредмет: {1}, оцена: {1}", izmenetaOcena.student.Id, izmenetaOcena.predmet.Id, izmenetaOcena.Ocenka);
        }

    }
}
