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

            //Assert.IsTrue(zemi.Count >= x);

            foreach (Predmet predmet in zemi)
            {
                Console.WriteLine("предметИД: {0}, Име: {1},", predmet.Id, predmet.Ime);
            }
        }

        [Test]
        public void InsertTest()
        {

            Predmet predmet = new Predmet();
            predmet.Ime = string.Format("предмет {0}", Guid.NewGuid().ToString());

            PredmetRepository repository = new PredmetRepository();
            Predmet dodadete = repository.Insert(predmet);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(predmet.Ime, dodadete.Ime);

            Console.WriteLine("Додаден е нов предмет: предметИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }
    }
}
