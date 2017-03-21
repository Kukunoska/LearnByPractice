using System;
using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.DAL.Repositories.Organizational;

namespace LearnByPractice.Tests.DAL.Respositories.Organizational
{
    public class OrganizacijaRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            OrganizacijaRepository respository = new OrganizacijaRepository();
            OrganizacijaCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);
            Assert.IsTrue(zemi.Count >= 2);

            foreach (Organizacija organizacija in zemi)
            {
                Console.WriteLine("ИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", organizacija.Id, organizacija.Ime, organizacija.Adresa, organizacija.KontaktTelefon, organizacija.VebStrana, organizacija.vidOrganizacija.Id);
            }
        }

        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            VidOrganizacijaRespository vidOrgRep = new VidOrganizacijaRespository();
            VidOrganizacijaCollection siteVidOrg = vidOrgRep.GetAll();
            int VidOrgID = random.Next(0, siteVidOrg.Count);
            VidOrganizacija izbranVidOrg = siteVidOrg[VidOrgID];

            Organizacija organizacija = new Organizacija();
            Guid guid;
            guid = Guid.NewGuid();
            organizacija.Ime = string.Format("Име:{0}", guid.ToString());
            organizacija.Adresa = string.Format("Адреса:{0}", guid.ToString());
            organizacija.KontaktTelefon = string.Format("Tel:{0}", guid.ToString().Substring(1, 9));
            organizacija.VebStrana = string.Format("Веб страна: {0}", guid.ToString());
            organizacija.vidOrganizacija.Id = izbranVidOrg.Id;

            OrganizacijaRepository repository = new OrganizacijaRepository();
            Organizacija dodadete = repository.Insert(organizacija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(organizacija.Ime, dodadete.Ime);
            Assert.AreEqual(organizacija.Adresa, dodadete.Adresa);
            Assert.AreEqual(organizacija.KontaktTelefon, dodadete.KontaktTelefon);
            Assert.AreEqual(organizacija.VebStrana, dodadete.VebStrana);
            Assert.AreEqual(organizacija.vidOrganizacija.Id, dodadete.vidOrganizacija.Id);

            Console.WriteLine("Додаденa е новa Организација: ИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", dodadete.Id, dodadete.Ime, dodadete.Adresa, dodadete.KontaktTelefon, dodadete.VebStrana, dodadete.vidOrganizacija.Ime);
        }
        [Test]
        public void GetByIdTest()
        {
            OrganizacijaRepository repository = new OrganizacijaRepository();
            Organizacija organizacija = repository.Get(2);
            Assert.AreEqual(2, organizacija.Id);
        }
        [Test]
        public void UpdateTest()
        {
            OrganizacijaRepository repository = new OrganizacijaRepository();
            OrganizacijaCollection siteK = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int KId = random.Next(0, siteK.Count);
            Organizacija izbranaК = siteK[KId];

            Console.WriteLine("Се менуваат податоците за организацијата ИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", izbranaК.Id, izbranaК.Ime, izbranaК.Adresa, izbranaК.KontaktTelefon, izbranaК.VebStrana, izbranaК.vidOrganizacija.Ime);

            VidOrganizacijaRespository vidOrgRep = new VidOrganizacijaRespository();
            VidOrganizacijaCollection siteVidOrg = vidOrgRep.GetAll();
            int VidOrgID = random.Next(0, siteVidOrg.Count);
            VidOrganizacija izbranVidOrg = siteVidOrg[VidOrgID];

            Guid guid;
            guid = Guid.NewGuid();
            izbranaК.Ime = string.Format("Име:{0}", guid.ToString());
            izbranaК.Adresa = string.Format("Адреса:{0}", guid.ToString());
            izbranaК.KontaktTelefon = string.Format("Tel:{0}", guid.ToString().Substring(1, 9));
            izbranaК.VebStrana = string.Format("Веб страна: {0}", guid.ToString());
            izbranaК.vidOrganizacija.Id = izbranVidOrg.Id;

            Organizacija izmenetaК = repository.Update(izbranaК);

            Assert.IsNotNull(izmenetaК);
            Assert.AreEqual(izbranaК.Id, izmenetaК.Id);
            Assert.AreEqual(izbranaК.Ime, izmenetaК.Ime);
            Assert.AreEqual(izbranaК.Adresa, izmenetaК.Adresa);
            Assert.AreEqual(izbranaК.KontaktTelefon, izmenetaК.KontaktTelefon);
            Assert.AreEqual(izbranaК.VebStrana, izmenetaК.VebStrana);
            Assert.AreEqual(izbranaК.vidOrganizacija.Id, izmenetaК.vidOrganizacija.Id);

            Console.WriteLine("Изменетите податоци за организацијата : ИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", izmenetaК.Id, izmenetaК.Ime, izmenetaК.Adresa, izmenetaК.KontaktTelefon, izmenetaК.VebStrana, izmenetaК.vidOrganizacija.Ime);
        }
    }
}
