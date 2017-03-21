using System;
using System.Linq;
using NUnit.Framework;
using LearnByPractice.Domain.Security;
using LearnByPractice.Domain.Education;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.DAL.Repositories.Security;
using LearnByPractice.DAL.Repositories.Education;
using LearnByPractice.DAL.Repositories.Organizational;

namespace LearnByPractice.Tests.DAL.Respositories.Security
{
    public class KorisnikRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {

            KorisnikRepository repository = new KorisnikRepository();
            KorisnikCollection zemi = repository.GetAll();
            Assert.IsNotNull(zemi);
            Assert.IsTrue(zemi.Count >= 0);

            foreach (Korisnik korisnik in zemi)
            {
                Console.WriteLine("KорисникИД: {0}, Име: {1}, Корисничко име: {2}, Презиме: {3}, Пол: {4}, Студиска Програма: {5}, Организација: {6}, Еmail: {7}, Мобилен: {8}, ", korisnik.Id, korisnik.Ime, korisnik.Username, korisnik.Prezime, korisnik.Pol, korisnik.studiskaPrograma.Ime, korisnik.organizacija.Ime, korisnik.Email, korisnik.Mobilen);
            }
        }
        protected PolEnum SlucaenIzbor()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomInt = random.Next(1, 3);
            switch (randomInt)
            {
                case 1:
                    return PolEnum.Mashki;

                case 2:
                    return PolEnum.Zhenski;

                default:
                    throw new InvalidOperationException("Добиена е случајна вредност надвор од дадените граници.");
            }
        }

        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            OrganizacijaRepository orgRep = new OrganizacijaRepository();
            OrganizacijaCollection siteOrg = orgRep.GetAll();
            int Org = random.Next(0, siteOrg.Count);
            Organizacija izbranaOrg = siteOrg[Org];

            StudiskaProgramaRepository studiskaProgRep = new StudiskaProgramaRepository();
            StudiskaProgramaCollection siteStudiskiProg = studiskaProgRep.GetAll();
            int StudProg = random.Next(0, siteStudiskiProg.Count);
            StudiskaPrograma izbranaProg = siteStudiskiProg[StudProg];

            Korisnik korisnik = new Korisnik();
            Guid guid;
            guid = Guid.NewGuid();
            int koris = random.Next(0, 10);
            korisnik.Ime = string.Format("И:{0}", guid.ToString().Substring(1, 16));
            korisnik.Username = string.Format("KИ:{0}", guid.ToString().Substring(1, 16));
            int pass = random.Next(0, 8);
            string binaren = Convert.ToString(pass, 2);
            byte[] bin = binaren.Split().Select(s => Convert.ToByte(s, 2)).ToArray();
            korisnik.PasswordOdNiza = bin;
            korisnik.Prezime = string.Format("П:{0}", guid.ToString().Substring(1, 16));
            korisnik.Pol = SlucaenIzbor();
            korisnik.organizacija.Id = izbranaOrg.Id;
            korisnik.Email = string.Format("E:{0}", guid.ToString());
            korisnik.Mobilen = string.Format("М:{0}", guid.ToString().Substring(1, 12));
            if (koris < 5)
            {
                korisnik.Administrator = false;
                korisnik.Student = true;
                korisnik.Mentor = false;
                korisnik.studiskaPrograma.Id = izbranaProg.Id;
            }
            else
            {
                korisnik.Student = false;
                korisnik.Mentor = true;
                korisnik.studiskaPrograma = null;
                if (koris > 8)
                {
                    korisnik.Administrator = true;
                }
                else { korisnik.Administrator = false; }
            }

            KorisnikRepository repository = new KorisnikRepository();
            Korisnik dodadete = repository.Insert(korisnik);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(korisnik.Ime, dodadete.Ime);
            Assert.AreEqual(korisnik.Username, dodadete.Username);
            Assert.AreEqual(korisnik.PasswordOdNiza, dodadete.PasswordOdNiza);
            Assert.AreEqual(korisnik.Prezime, dodadete.Prezime);
            Assert.AreEqual(korisnik.Pol, dodadete.Pol);
            Assert.AreEqual(korisnik.organizacija.Id, dodadete.organizacija.Id);
            Assert.AreEqual(korisnik.Email, dodadete.Email);
            Assert.AreEqual(korisnik.Mobilen, dodadete.Mobilen);
            Assert.AreEqual(korisnik.Student, dodadete.Student);
            Assert.AreEqual(korisnik.Mentor, dodadete.Mentor);

            Console.WriteLine("Додаден е нов корисник: KорисникИД: {0}, Име: {1}, Корисничко име: {2}, Презиме: {3}, Пол: {4}, Студиска Програма: {5}, Организација: {6}, Еmail: {7}, Мобилен: {8}, ", dodadete.Id, dodadete.Ime, dodadete.Username, dodadete.Prezime, dodadete.Pol, dodadete.studiskaPrograma.Id, dodadete.organizacija.Id, dodadete.Email, dodadete.Mobilen);
        }
        [Test]
        public void GetByIdTest()
        {
            KorisnikRepository repository = new KorisnikRepository();
            Korisnik user = repository.Get(2027);
            Assert.AreEqual(2027, user.Id);
        }

        [Test]
        public void GetByStudiskaProgramaID()
        {
            KorisnikRepository repository = new KorisnikRepository();
            KorisnikCollection korisniciOdStudiskaP = repository.GetByStudiskaProgramaId(1023);
            Assert.IsNotNull(korisniciOdStudiskaP);
            Assert.IsTrue(korisniciOdStudiskaP.All(korisnik => korisnik.studiskaPrograma.Id == 1023));
            foreach (Korisnik korisnik in korisniciOdStudiskaP)
            {
                Console.WriteLine("KорисникИД: {0}, Име: {1}, Корисничко име: {2}, Презиме: {3}, Пол: {4}, Студиска Програма: {5}, Организација: {6}, Еmail: {7}, Мобилен: {8}, ", korisnik.Id, korisnik.Ime, korisnik.Username, korisnik.Prezime, korisnik.Pol, korisnik.studiskaPrograma.Id, korisnik.organizacija.Id, korisnik.Email, korisnik.Mobilen);
            }

        }
        [Test]
        public void UpdateTest()
        {
            KorisnikRepository repository = new KorisnikRepository();
            KorisnikCollection siteKorisnici = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int KId = random.Next(0, siteKorisnici.Count);
            Korisnik izbranKorisnik = siteKorisnici[KId];

            Console.WriteLine("Се менуваат податоците за  корисник:KорисникИД: {0}, Име: {1}, Корисничко име: {2}, Презиме: {3}, Пол: {4}, Студиска Програма: {5}, Организација: {6}, Еmail: {7}, Мобилен: {8}, ", izbranKorisnik.Id, izbranKorisnik.Ime, izbranKorisnik.Username, izbranKorisnik.Prezime, izbranKorisnik.Pol, izbranKorisnik.studiskaPrograma.Id, izbranKorisnik.organizacija.Id, izbranKorisnik.Email, izbranKorisnik.Mobilen);

            OrganizacijaRepository orgRep = new OrganizacijaRepository();
            OrganizacijaCollection siteOrg = orgRep.GetAll();
            int Org = random.Next(0, siteOrg.Count);
            Organizacija izbranaOrg = siteOrg[Org];

            StudiskaProgramaRepository studiskaProgRep = new StudiskaProgramaRepository();
            StudiskaProgramaCollection siteStudiskiProg = studiskaProgRep.GetAll();
            int StudProg = random.Next(0, siteStudiskiProg.Count);
            StudiskaPrograma izbranaProg = siteStudiskiProg[StudProg];

            Guid guid;
            guid = Guid.NewGuid();
            int koris = random.Next(0, 10);
            izbranKorisnik.Ime = string.Format("New{0}", guid.ToString().Substring(1, 16));
            izbranKorisnik.Username = string.Format("New{0}", guid.ToString().Substring(1, 16));
            izbranKorisnik.Prezime = string.Format("New{0}", guid.ToString().Substring(1, 16));
            izbranKorisnik.Pol = SlucaenIzbor();
            izbranKorisnik.organizacija.Id = izbranaOrg.Id;
            izbranKorisnik.Email = string.Format("New{0}", guid.ToString());
            izbranKorisnik.Mobilen = string.Format("New{0}", guid.ToString().Substring(1, 12));
            if (koris < 5)
            {
                izbranKorisnik.Student = true;
                izbranKorisnik.Mentor = false;
                izbranKorisnik.Administrator = false;
                izbranKorisnik.studiskaPrograma.Id = izbranaProg.Id;
            }
            else
            {
                izbranKorisnik.Student = false;
                izbranKorisnik.Mentor = true;
                izbranKorisnik.studiskaPrograma = null;
                if (koris > 8)
                {
                    izbranKorisnik.Administrator = true;
                }
                else { izbranKorisnik.Administrator = false; }
            }

            Korisnik izmenetKorisnik = repository.Update(izbranKorisnik);

            Assert.IsNotNull(izmenetKorisnik);
            Assert.AreEqual(izbranKorisnik.Id, izmenetKorisnik.Id);
            Assert.AreEqual(izbranKorisnik.Ime, izmenetKorisnik.Ime);
            Assert.AreEqual(izbranKorisnik.Username, izmenetKorisnik.Username);
            Assert.AreEqual(izbranKorisnik.Prezime, izmenetKorisnik.Prezime);
            Assert.AreEqual(izbranKorisnik.Pol, izmenetKorisnik.Pol);
            Assert.AreEqual(izbranKorisnik.Email, izmenetKorisnik.Email);
            Assert.AreEqual(izbranKorisnik.Mobilen, izmenetKorisnik.Mobilen);

            Console.WriteLine("Изменетите податоци за корисник: KорисникИД: {0}, Име: {1}, Корисничко име: {2}, Презиме: {3}, Пол: {4}, Студиска Програма: {5}, Организација: {6}, Еmail: {7}, Мобилен: {8}, ", izmenetKorisnik.Id, izmenetKorisnik.Ime, izmenetKorisnik.Username, izmenetKorisnik.Prezime, izmenetKorisnik.Pol, izmenetKorisnik.studiskaPrograma.Id, izmenetKorisnik.organizacija.Id, izmenetKorisnik.Email, izmenetKorisnik.Mobilen);
        }

    }
}
