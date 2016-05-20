using System;
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
        public void InsertTest()
        {
            StudiskaPrograma studProg = new StudiskaPrograma();
            Random random = new Random(DateTime.Now.Millisecond);
            studProg.Id = random.Next(99, 9999);
            studProg.Ime = string.Format("СП{0}", Guid.NewGuid().ToString());

            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            StudiskaPrograma dodadete = repository.Insert(studProg);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(studProg.Ime, dodadete.Ime);

            Console.WriteLine("Додаденa е новa студиска програма: СтудискаПрограмаИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }

        [Test]
        public void GetByIdTest()
        {
            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            StudiskaPrograma studiskaPrograma = repository.Get(1);
            Assert.AreEqual(1, studiskaPrograma.Id);
        }
        [Test]
        public void UpdateTest()
        {
            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            StudiskaProgramaCollection siteSP = repository.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int sPId = random.Next(0, siteSP.Count);
            StudiskaPrograma izbranaSP = siteSP[sPId];

            Console.WriteLine("Се менуваат податоците за студиската програма ИД: {0}, Име: {1}", izbranaSP.Id, izbranaSP.Ime);

            izbranaSP.Ime = string.Format("Изменета {0}", Guid.NewGuid().ToString());

            StudiskaPrograma izmenetaSP = repository.Update(izbranaSP);

            Assert.IsNotNull(izmenetaSP);
            Assert.AreEqual(izbranaSP.Id, izmenetaSP.Id);
            Assert.AreEqual(izbranaSP.Ime, izmenetaSP.Ime);

            Console.WriteLine("Изменетите податоци за студиската програма : ИД: {0}, Име: {1}", izmenetaSP.Id, izmenetaSP.Ime);
        }
    }
}
