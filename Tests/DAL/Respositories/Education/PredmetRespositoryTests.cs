using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Guid guid = new Guid();
            predmet.ShifraNaPredmet = string.Format("ШП:{0}", guid.ToString());
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
    }
}
