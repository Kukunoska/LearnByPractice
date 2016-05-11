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

    }
}
