using System;
using NUnit.Framework;
using LearnByPractice.DAL.Repositories.Education;
using LearnByPractice.Domain.Education;

namespace LearnByPractice.Tests.DAL.Respositories.Education
{
    public class PredmetRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            PredmetRepository respository = new PredmetRepository();
            PredmetCollection zemi = respository.GetAll();
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

            PredmetRepository repository = new PredmetRepository();
            Predmet dodadete = repository.Insert(predmet);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(predmet.Ime, dodadete.Ime);
            Assert.AreEqual(predmet.ShifraNaPredmet, dodadete.ShifraNaPredmet);

            Console.WriteLine("Додаден е нов предмет: предметИД: {0}, шифраПредмет{1}, Име: {2},", dodadete.Id, dodadete.ShifraNaPredmet, dodadete.Ime);
        }

        [Test]
        public void GetByIdTest()
        {
            PredmetRepository repository = new PredmetRepository();
            Predmet predmet = repository.Get(1);
            Assert.AreEqual(1, predmet.Id);
        }
        [Test]
        public void UpdateTest()
        {
            PredmetRepository repository = new PredmetRepository();
            PredmetCollection sitePredmeti = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int predmetId = random.Next(0, sitePredmeti.Count);
            Predmet izbranPredmet = sitePredmeti[predmetId];

            Console.WriteLine("Се менуваат податоците за предметот ИД: {0}, Име: {1}", izbranPredmet.Id, izbranPredmet.Ime);

            Guid guid;
            guid = Guid.NewGuid();
            izbranPredmet.ShifraNaPredmet = string.Format("ШП:{0}", guid.ToString().Substring(1, 5));
            izbranPredmet.Ime = string.Format("Изменета {0}", guid.ToString());

            Predmet izmenetPredmet = repository.Update(izbranPredmet);

            Assert.IsNotNull(izmenetPredmet);
            Assert.AreEqual(izmenetPredmet.Id, izbranPredmet.Id);
            Assert.AreEqual(izmenetPredmet.Ime, izbranPredmet.Ime);

            Console.WriteLine("Изменетите податоци за предметот: ИД: {0}, Име: {1}", izmenetPredmet.Id, izmenetPredmet.Ime);
        }
    }
}
