using System;
using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.DAL.Repositories.Organizational;

namespace LearnByPractice.Tests.DAL.Respositories.Organizational
{
    public class KompanijaRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            KompanijaRepository respository = new KompanijaRepository();
            KompanijaCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);
            Assert.IsTrue(zemi.Count >= 2);

            foreach (Kompanija kompanija in zemi)
            {
                Console.WriteLine("КомпанијаИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", kompanija.Id, kompanija.Ime, kompanija.Adresa, kompanija.KontaktTelefon, kompanija.VebStrana, kompanija.vidOrganizacija.Id);
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

            Kompanija kompanija = new Kompanija();
            Guid guid;
            guid = Guid.NewGuid();
            kompanija.Ime = string.Format("Име:{0}", guid.ToString());
            kompanija.Adresa = string.Format("Адреса:{0}", guid.ToString());
            kompanija.KontaktTelefon = string.Format("Tel:{0}", guid.ToString().Substring(1, 9));
            kompanija.VebStrana = string.Format("Веб страна: {0}", guid.ToString());
            kompanija.vidOrganizacija.Id = izbranVidOrg.Id;


            KompanijaRepository repository = new KompanijaRepository();
            Kompanija dodadete = repository.Insert(kompanija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(kompanija.Ime, dodadete.Ime);
            Assert.AreEqual(kompanija.Adresa, dodadete.Adresa);
            Assert.AreEqual(kompanija.KontaktTelefon, dodadete.KontaktTelefon);
            Assert.AreEqual(kompanija.VebStrana, dodadete.VebStrana);
            Assert.AreEqual(kompanija.vidOrganizacija.Id, dodadete.vidOrganizacija.Id);

            Console.WriteLine("Додаденa е новa Компанија: КомпанијаИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", dodadete.Id, dodadete.Ime, dodadete.Adresa, dodadete.KontaktTelefon, dodadete.VebStrana, dodadete.vidOrganizacija.Ime);
        }
        [Test]
        public void GetByIdTest()
        {
            KompanijaRepository repository = new KompanijaRepository();
            Kompanija kompanija = repository.Get(2);
            Assert.AreEqual(2, kompanija.Id);
        }
        [Test]
        public void UpdateTest()
        {
            KompanijaRepository repository = new KompanijaRepository();
            KompanijaCollection siteK = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int KId = random.Next(0, siteK.Count);
            Kompanija izbranaК = siteK[KId];

            Console.WriteLine("Се менуваат податоците за компанијата  КомпанијаИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", izbranaК.Id, izbranaК.Ime, izbranaК.Adresa, izbranaК.KontaktTelefon, izbranaК.VebStrana, izbranaК.vidOrganizacija.Ime);

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

            Kompanija izmenetaК = repository.Update(izbranaК);

            Assert.IsNotNull(izmenetaК);
            Assert.AreEqual(izbranaК.Id, izmenetaК.Id);
            Assert.AreEqual(izbranaК.Ime, izmenetaК.Ime);
            Assert.AreEqual(izbranaК.Adresa, izmenetaК.Adresa);
            Assert.AreEqual(izbranaК.KontaktTelefon, izmenetaК.KontaktTelefon);
            Assert.AreEqual(izbranaК.VebStrana, izmenetaК.VebStrana);
            Assert.AreEqual(izbranaК.vidOrganizacija.Id, izmenetaК.vidOrganizacija.Id);

            Console.WriteLine("Изменетите податоци за компанијата :  КомпанијаИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", izmenetaК.Id, izmenetaК.Ime, izmenetaК.Adresa, izmenetaК.KontaktTelefon, izmenetaК.VebStrana, izmenetaК.vidOrganizacija.Ime);
        }
    }
}
