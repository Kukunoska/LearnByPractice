using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine("ПријаваИД: {0}, СтудентИД: {1}, ", prijavaStudent.prijava.Id, prijavaStudent.student.Ime);
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
            prijavaStudent.student.IdKorisnik = izbranKorisnik.IdKorisnik;

            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudent dodadete = repository.Insert(prijavaStudent);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(prijavaStudent.prijava.Id, dodadete.prijava.Id);
            Assert.AreEqual(prijavaStudent.student.IdKorisnik, dodadete.student.IdKorisnik);

            Console.WriteLine("Пријавен е нов студент: ПријаваИД: {0}, Студент: {1}, ", dodadete.prijava.Id, dodadete.student.Ime);
        }
        [Test]
        public void GetByIdTest()
        {
            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudent prijavaStudent = repository.Get(1);
            Assert.AreEqual(1, prijavaStudent.student.IdKorisnik);
        }
        [Test]
        public void GetByKorisnikID()
        {
            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudentCollection student = repository.GetByKorisnikId(1);
            Assert.IsNotNull(student);
            Assert.IsTrue(student.Count >= 0);
            Assert.IsTrue(student.All(korisnik => korisnik.student.IdKorisnik == 1));
            foreach (PrijavaStudent korisnik in student)
            {
                Console.WriteLine(" ПријаваИД: {0}, Студент: {1}, " , korisnik.prijava.Id, korisnik.student.Ime);
            }
        }
    }
}