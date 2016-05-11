using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Education;
using LearnByPractice.BLL.Managers.Education;


namespace LearnByPractice.Tests.BLL.Managers.Education
{
    public class PredmetManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            PredmetManager manager = new PredmetManager();
            PredmetCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 2);

            foreach (Predmet predmet in all)
            {
                Console.WriteLine("предметИД: {0}, шифраПредмет{1}, Име: {2},", predmet.Id, predmet.ShifraNaPredmet, predmet.Ime);
            }
        }
    }
}
