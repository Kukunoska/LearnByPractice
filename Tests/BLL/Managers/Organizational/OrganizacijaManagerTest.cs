using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.BLL.Managers.Organizational;


namespace LearnByPractice.Tests.BLL.Managers.Organizational
{
    public class OrganizacijaManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            OrganizacijaManager manager = new OrganizacijaManager();
            OrganizacijaCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 2);

            foreach (Organizacija organizacija in all)
            {
                Console.WriteLine("ИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", organizacija.Id, organizacija.Ime, organizacija.Adresa, organizacija.KontaktTelefon, organizacija.VebStrana, organizacija.vidOrganizacija.Ime);
            }
        }

       [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            VidOrganizacijaManager vidOrgMan = new VidOrganizacijaManager();
            VidOrganizacijaCollection siteVidOrg = vidOrgMan.GetAll();
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


            OrganizacijaManager manager = new OrganizacijaManager();
            Organizacija dodadete = manager.Insert(organizacija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(organizacija.Ime, dodadete.Ime);
            Assert.AreEqual(organizacija.Adresa, dodadete.Adresa);
            Assert.AreEqual(organizacija.KontaktTelefon, dodadete.KontaktTelefon);
            Assert.AreEqual(organizacija.VebStrana, dodadete.VebStrana);
            Assert.AreEqual(organizacija.vidOrganizacija.Id, dodadete.vidOrganizacija.Id);

            Console.WriteLine("Додаденa е новa организација: ИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", dodadete.Id, dodadete.Ime, dodadete.Adresa, dodadete.KontaktTelefon, dodadete.VebStrana, dodadete.vidOrganizacija.Ime);
        }
       
        [Test]
        public void UpdateTest()
        {
            OrganizacijaManager manager = new OrganizacijaManager();
            OrganizacijaCollection siteK = manager.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int KId = random.Next(0, siteK.Count);
            Organizacija izbranaК = siteK[KId];

            Console.WriteLine("Се менуваат податоците за организацијата ИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", izbranaК.Id, izbranaК.Ime, izbranaК.Adresa, izbranaК.KontaktTelefon, izbranaК.VebStrana, izbranaК.vidOrganizacija.Ime);

            VidOrganizacijaManager vidOrgMan = new VidOrganizacijaManager();
            VidOrganizacijaCollection siteVidOrg = vidOrgMan.GetAll();
            int VidOrgID = random.Next(0, siteVidOrg.Count);
            VidOrganizacija izbranVidOrg = siteVidOrg[VidOrgID];

            Guid guid;
            guid = Guid.NewGuid();
            izbranaК.Ime = string.Format("Име:{0}", guid.ToString());
            izbranaК.Adresa = string.Format("Адреса:{0}", guid.ToString());
            izbranaК.KontaktTelefon = string.Format("Tel:{0}", guid.ToString().Substring(1, 9));
            izbranaК.VebStrana = string.Format("Веб страна: {0}", guid.ToString());
            izbranaК.vidOrganizacija.Id = izbranVidOrg.Id;

            Organizacija izmenetaК = manager.Update(izbranaК);

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
