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

            Assert.IsTrue(zemi.Count >= 2);

            foreach (StudiskaPrograma oblast in zemi)
            {
                Console.WriteLine("СтудискаПрограмаИД: {0}, Име: {1},", oblast.Id, oblast.Ime);
            }
        }

        
        [Test]
        public void GetByIdTest()
        {
            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            StudiskaPrograma studiskaPrograma = repository.Get(1);
            Assert.AreEqual(1, studiskaPrograma.Id);
        }
    }
}
