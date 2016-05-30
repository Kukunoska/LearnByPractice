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
    public class OblastManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            OblastManager manager = new OblastManager();
            OblastCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 3);

            foreach (Oblast oblast in all)
            {
                Console.WriteLine("ОбластИД: {0}, Име: {1},", oblast.Id, oblast.Ime);
            }
        }
        [Test]
        public void InsertTest()
        {
            Oblast oblast = new Oblast();
            oblast.Ime = string.Format("Име {0}", Guid.NewGuid().ToString());

            OblastManager manager = new OblastManager();
            Oblast dodadete = manager.Insert(oblast);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(oblast.Ime, dodadete.Ime);

            Console.WriteLine("Додаденa е новa oбласт: ОбластИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }
       
        [Test]
        public void UpdateTest()
        {
            OblastManager manager = new OblastManager();
            OblastCollection siteOblasti = manager.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int oblastId = random.Next(0, siteOblasti.Count);
            Oblast izbranaOblast = siteOblasti[oblastId];

            Console.WriteLine("Се менуваат податоците за област ИД: {0}, Име: {1}", izbranaOblast.Id, izbranaOblast.Ime);

            izbranaOblast.Ime = string.Format("Изменета {0}", Guid.NewGuid().ToString());

            Oblast izmenetaOblast = manager.Update(izbranaOblast);

            Assert.IsNotNull(izmenetaOblast);
            Assert.AreEqual(izbranaOblast.Id, izmenetaOblast.Id);
            Assert.AreEqual(izbranaOblast.Ime, izmenetaOblast.Ime);

            Console.WriteLine("Изменетите податоци за областа: ИД: {0}, Име: {1}", izmenetaOblast.Id, izmenetaOblast.Ime);
        }
    }
}