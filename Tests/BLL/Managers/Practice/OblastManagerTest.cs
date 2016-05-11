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

    }
}
