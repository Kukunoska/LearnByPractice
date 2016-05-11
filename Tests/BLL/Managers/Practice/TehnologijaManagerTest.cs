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
    public class TehnologijaManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            TehnologijaManager manager = new TehnologijaManager();
            TehnologijaCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 0);

            foreach (Tehnologija tehnologija in all)
            {
                Console.WriteLine("ТехнологијаИД: {0}, Име: {1}, Област: {2}, ", tehnologija.Id, tehnologija.Ime, tehnologija.oblast.Ime);
            }
        }

    }
}
