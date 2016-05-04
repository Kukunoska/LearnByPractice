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
    public class StudiskaProgramaRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            StudiskaProgramaRepository respository = new StudiskaProgramaRepository();
            StudiskaProgramaCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);

            //Assert.IsTrue(zemi.Count >= x);

            foreach (StudiskaPrograma oblast in zemi)
            {
                Console.WriteLine("СтудискаПрограмаИД: {0}, Име: {1},", oblast.Id, oblast.Ime);
            }
        }

        [Test]
        public void InsertTest()
        {


            StudiskaPrograma studProg = new StudiskaPrograma();
            studProg.Ime = string.Format("СтудискаПрограма {0}", Guid.NewGuid().ToString());

            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            StudiskaPrograma dodadete = repository.Insert(studProg);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(studProg.Ime, dodadete.Ime);

            Console.WriteLine("Додаденa е новa студиска програма: СтудискаПрограмаИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }
    }
}
