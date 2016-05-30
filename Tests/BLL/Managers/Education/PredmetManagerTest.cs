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
            PredmetCollection zemi = manager.GetAll();
            Assert.IsNotNull(zemi);
            Assert.IsTrue(zemi.Count >= 2);

            foreach (Predmet predmet in zemi)
            {
                Console.WriteLine("предметИД: {0}, шифраПредмет{1}, Име: {2},", predmet.Id, predmet.ShifraNaPredmet, predmet.Ime);
            }
        }

        [Test]
        public void InsertTest()
        {

            Predmet predmet = new Predmet();
            Guid guid;
            guid = Guid.NewGuid();
            predmet.ShifraNaPredmet = string.Format("ШП:{0}", guid.ToString().Substring(1, 5));
            predmet.Ime = string.Format("П:{0}", guid.ToString());

            PredmetManager manager = new PredmetManager();
            Predmet dodadete = manager.Insert(predmet);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(predmet.Ime, dodadete.Ime);
            Assert.AreEqual(predmet.ShifraNaPredmet, dodadete.ShifraNaPredmet);

            Console.WriteLine("Додаден е нов предмет: предметИД: {0}, шифраПредмет{1}, Име: {2},", dodadete.Id, dodadete.ShifraNaPredmet, dodadete.Ime);
        }

        [Test]
        public void UpdateTest()
        {
            PredmetManager manager = new PredmetManager();
            PredmetCollection sitePredmeti = manager.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int predmetId = random.Next(0, sitePredmeti.Count);
            Predmet izbranPredmet = sitePredmeti[predmetId];

            Console.WriteLine("Се менуваат податоците за предметот ИД: {0}, Име: {1}", izbranPredmet.Id, izbranPredmet.Ime);

            Guid guid;
            guid = Guid.NewGuid();
            izbranPredmet.ShifraNaPredmet = string.Format("ШП:{0}", guid.ToString().Substring(1, 5));
            izbranPredmet.Ime = string.Format("Изменета {0}", guid.ToString());

            Predmet izmenetPredmet = manager.Update(izbranPredmet);

            Assert.IsNotNull(izmenetPredmet);
            Assert.AreEqual(izmenetPredmet.Id, izbranPredmet.Id);
            Assert.AreEqual(izmenetPredmet.Ime, izbranPredmet.Ime);

            Console.WriteLine("Изменетите податоци за предметот: ИД: {0}, Име: {1}", izmenetPredmet.Id, izmenetPredmet.Ime);
        }
    }
}
