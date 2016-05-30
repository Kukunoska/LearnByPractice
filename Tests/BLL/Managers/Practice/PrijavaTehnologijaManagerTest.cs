using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.BLL.Managers.Practice;


namespace LearnByPractice.Tests.BLL.Managers.Practice
{
    public class PrijavaTehnologijaManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            PrijavaTehnologijaManager manager = new PrijavaTehnologijaManager();
            PrijavaTehnologijaCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 2);

            foreach (PrijavaTehnologija prijavaTehnologija in all)
            {
                Console.WriteLine("ПријаваИД: {0}, Технологија: {1}, ", prijavaTehnologija.prijava.Id, prijavaTehnologija.tehnologija.Ime);
            }
        }


        [Test]
        public void InsertTest()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            TehnologijaManager TehMan = new TehnologijaManager();
            TehnologijaCollection siteTehnologii = TehMan.GetAll();
            int TehID = random.Next(0, siteTehnologii.Count);
            Tehnologija izbranaTehnologija = siteTehnologii[TehID];

            PrijavaManager PrijavaMan = new PrijavaManager();
            PrijavaCollection sitePrijavi = PrijavaMan.GetAll();
            int prijava = random.Next(0, sitePrijavi.Count);
            Prijava izbranaprijava = sitePrijavi[prijava];

            PrijavaTehnologija tehnologija = new PrijavaTehnologija();
            tehnologija.prijava.Id = izbranaprijava.Id;
            tehnologija.tehnologija.Id = izbranaTehnologija.Id;

            PrijavaTehnologijaManager manager = new PrijavaTehnologijaManager();
            PrijavaTehnologija dodadete = manager.Insert(tehnologija);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(tehnologija.prijava.Id, dodadete.prijava.Id);
            Assert.AreEqual(tehnologija.tehnologija.Id, dodadete.tehnologija.Id);

            Console.WriteLine("Пријавена е новa технологијa: ПријаваИД: {0}, Технологија: {1}, ", dodadete.prijava.Id, dodadete.tehnologija.Id);
        }
       
        [Test]
        public void UpdateTest()
        {
            PrijavaTehnologijaManager manager = new PrijavaTehnologijaManager();
            PrijavaTehnologijaCollection sitePrijavi = manager.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int prijavaId = random.Next(0, sitePrijavi.Count);
            PrijavaTehnologija izbranaPrijava = sitePrijavi[prijavaId];

            Console.WriteLine("Се менуваат податоците за пријава ПријаваИД: {0}, Технологија: {1}", izbranaPrijava.prijava.Id, izbranaPrijava.tehnologija.Id);

            PrijavaManager PMan = new PrijavaManager();
            PrijavaCollection siteP = PMan.GetAll();
            int PID = random.Next(0, siteP.Count);
            Prijava izbranaP = siteP[PID];
            PrijavaTehnologija prijava = new PrijavaTehnologija();
            prijava.prijava.Id = izbranaP.Id;

            PrijavaTehnologija izmenetaPrijava = manager.Update(izbranaPrijava);

            Assert.IsNotNull(izmenetaPrijava);
            Assert.AreEqual(izbranaPrijava.prijava.Id, izmenetaPrijava.prijava.Id);
            Assert.AreEqual(izbranaPrijava.tehnologija.Id, izmenetaPrijava.tehnologija.Id);

            Console.WriteLine("Изменетите податоци за пријава: ПријаваИД: {0}, Технологија: {1}", izmenetaPrijava.prijava.Id, izmenetaPrijava.tehnologija.Id);
        }
    }
}

