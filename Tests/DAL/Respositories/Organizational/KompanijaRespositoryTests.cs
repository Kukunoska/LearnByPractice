﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //Assert.IsTrue(zemi.Count >= x);

            foreach (Kompanija kompanija in zemi)
            {
                Console.WriteLine("КомпанијаИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", kompanija.Id, kompanija.Ime, kompanija.Adresa, kompanija.KontaktTelefon, kompanija.VebStrana, kompanija.vidOrganizacija.Ime);
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
            kompanija.Ime = string.Format("Компанија {0}", Guid.NewGuid().ToString());
            kompanija.Adresa = string.Format("Компанија {0}", Guid.NewGuid().ToString());
            kompanija.KontaktTelefon= string.Format("Компанија {0}", Guid.NewGuid().ToString());
            kompanija.VebStrana = string.Format("Компанија {0}", Guid.NewGuid().ToString());
            kompanija.vidOrganizacija.Ime = izbranVidOrg.Ime;

            KompanijaRepository repository = new KompanijaRepository();
            Kompanija dodadete = repository.Insert(kompanija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(kompanija.Ime, dodadete.Ime);
            Assert.AreEqual(kompanija.Adresa, dodadete.Adresa);
            Assert.AreEqual(kompanija.KontaktTelefon, dodadete.KontaktTelefon);
            Assert.AreEqual(kompanija.VebStrana, dodadete.VebStrana);
            Assert.AreEqual(kompanija.vidOrganizacija.Ime, dodadete.vidOrganizacija.Ime);

            Console.WriteLine("Додаденa е новa Компанија: КомпанијаИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", dodadete.Id, dodadete.Ime, dodadete.Adresa, dodadete.KontaktTelefon, dodadete.VebStrana, dodadete.vidOrganizacija.Ime);
        }
    }
}