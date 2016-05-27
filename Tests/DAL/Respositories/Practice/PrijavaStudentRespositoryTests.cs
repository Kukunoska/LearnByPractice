using System;
using System.Linq;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.Domain.Security;
using LearnByPractice.DAL.Repositories.Practice;
using LearnByPractice.DAL.Repositories.Security;

namespace LearnByPractice.Tests.DAL.Respositories.Practice
{
    public class PrijavaStudentRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            PrijavaStudentRepository respository = new PrijavaStudentRepository();
            PrijavaStudentCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);
            Assert.IsTrue(zemi.Count >= 0);

            foreach (PrijavaStudent prijavaStudent in zemi)
            {
                Console.WriteLine("ПријаваИД: {0}, СтудентИД: {1}, ", prijavaStudent.prijava.Id, prijavaStudent.student.Id);
            }
        }

        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            KorisnikRepository KorRep = new KorisnikRepository();
            KorisnikCollection siteKorisnici = KorRep.GetAll();
            int KorID = random.Next(0, siteKorisnici.Count);
            Korisnik izbranKorisnik = siteKorisnici[KorID];

            PrijavaStudent prijavaStudent = new PrijavaStudent();
            prijavaStudent.student.Id = izbranKorisnik.Id;

            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudent dodadete = repository.Insert(prijavaStudent);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(prijavaStudent.prijava.Id, dodadete.prijava.Id);
            Assert.AreEqual(prijavaStudent.student.Id, dodadete.student.Id);

            Console.WriteLine("Пријавен е нов студент: ПријаваИД: {0}, Студент: {1}, ", dodadete.prijava.Id, dodadete.student.Id);
        }
        [Test]
        public void GetByIdTest()
        {
            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudentCollection prijavaK = repository.Get(2);
            Assert.IsNotNull(prijavaK);
            Assert.IsTrue(prijavaK.Count >= 1);
            Assert.IsTrue(prijavaK.All(student => student.prijava.Id == 2));
            foreach (PrijavaStudent prijava in prijavaK)
            {
                Console.WriteLine(" ПријаваИД: {0}, Технологија: {1}, ", prijava.prijava.Id, prijava.student.Id);
            }
        }
        [Test]
        public void GetByKorisnikID()
        {
            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudentCollection student = repository.GetByKorisnikId(1);
            Assert.IsNotNull(student);
            Assert.IsTrue(student.Count >= 1);
            Assert.IsTrue(student.All(korisnik => korisnik.student.Id == 1));
            foreach (PrijavaStudent korisnik in student)
            {
                Console.WriteLine(" ПријаваИД: {0}, Студент: {1}, ", korisnik.prijava.Id, korisnik.student.Id);
            }
        }
        [Test]
        public void UpdateTest()
        {
            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudentCollection sitePrijavi = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int prijavaId = random.Next(0, sitePrijavi.Count);
            PrijavaStudent izbranaPrijava = sitePrijavi[prijavaId];

            Console.WriteLine("Се менуваат податоците за пријава ПријаваИД: {0}, Студент: {1}", izbranaPrijava.prijava.Id, izbranaPrijava.student.Id);

            PrijavaRepository PRep = new PrijavaRepository();
            PrijavaCollection siteP = PRep.GetAll();
            int PID = random.Next(0, siteP.Count);
            Prijava izbranaP = siteP[PID];
            PrijavaStudent prijava = new PrijavaStudent();
            prijava.prijava.Id = izbranaP.Id;

            PrijavaStudent izmenetaPrijava = repository.Update(izbranaPrijava);

            Assert.IsNotNull(izmenetaPrijava);
            Assert.AreEqual(izbranaPrijava.prijava.Id, izmenetaPrijava.prijava.Id);
            Assert.AreEqual(izbranaPrijava.student.Id, izmenetaPrijava.student.Id);

            Console.WriteLine("Изменетите податоци за пријава: ПријаваИД: {0}, Студент: {1}", izmenetaPrijava.prijava.Id, izmenetaPrijava.student.Id);
        }
    }
}