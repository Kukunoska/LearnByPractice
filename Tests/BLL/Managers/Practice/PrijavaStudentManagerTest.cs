using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.BLL.Managers.Practice;
using LearnByPractice.Domain.Security;
using LearnByPractice.BLL.Managers.Security;


namespace LearnByPractice.Tests.BLL.Managers.Practice
{
    public class PrijavaStudentManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            PrijavaStudentManager manager = new PrijavaStudentManager();
            PrijavaStudentCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 0);

            foreach (PrijavaStudent prijavaStudent in all)
            {
                Console.WriteLine("ПријаваИД: {0}, СтудентИД: {1}, ", prijavaStudent.prijava.Id, prijavaStudent.student.Ime);
            }
        }
            [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            KorisnikManager KorMan = new KorisnikManager();
            KorisnikCollection siteKorisnici = KorMan.GetAll();
            int KorID = random.Next(0, siteKorisnici.Count);
            Korisnik izbranKorisnik = siteKorisnici[KorID];

            PrijavaStudent prijavaStudent = new PrijavaStudent();
            prijavaStudent.student.Id = izbranKorisnik.Id;

            PrijavaStudentManager manager = new PrijavaStudentManager();
            PrijavaStudent dodadete = manager.Insert(prijavaStudent);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(prijavaStudent.prijava.Id, dodadete.prijava.Id);
            Assert.AreEqual(prijavaStudent.student.Id, dodadete.student.Id);

            Console.WriteLine("Пријавен е нов студент: ПријаваИД: {0}, Студент: {1}, ", dodadete.prijava.Id, dodadete.student.Id);
        }
    
        [Test]
        public void UpdateTest()
        {
            PrijavaStudentManager manager = new PrijavaStudentManager();
            PrijavaStudentCollection sitePrijavi = manager.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int prijavaId = random.Next(0, sitePrijavi.Count);
            PrijavaStudent izbranaPrijava = sitePrijavi[prijavaId];

            Console.WriteLine("Се менуваат податоците за пријава ПријаваИД: {0}, Студент: {1}", izbranaPrijava.prijava.Id, izbranaPrijava.student.Id);

            PrijavaManager PMan = new PrijavaManager();
            PrijavaCollection siteP = PMan.GetAll();
            int PID = random.Next(0, siteP.Count);
            Prijava izbranaP = siteP[PID];
            PrijavaStudent prijava = new PrijavaStudent();
            prijava.prijava.Id = izbranaP.Id;

            PrijavaStudent izmenetaPrijava = manager.Update(izbranaPrijava);

            Assert.IsNotNull(izmenetaPrijava);
            Assert.AreEqual(izbranaPrijava.prijava.Id, izmenetaPrijava.prijava.Id);
            Assert.AreEqual(izbranaPrijava.student.Id, izmenetaPrijava.student.Id);

            Console.WriteLine("Изменетите податоци за пријава: ПријаваИД: {0}, Студент: {1}", izmenetaPrijava.prijava.Id, izmenetaPrijava.student.Id);
        }
    }
}


