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
    public class StudiskaProgramaTest
    {
        [Test]
        public void GetAllTest()
        {
            StudiskaProgramaManager manager = new StudiskaProgramaManager();
            StudiskaProgramaCollection zemi = manager.GetAll();
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

            StudiskaProgramaManager manager = new StudiskaProgramaManager();
            StudiskaPrograma dodadete = manager.Insert(studProg);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(studProg.Ime, dodadete.Ime);

            Console.WriteLine("Додаденa е новa студиска програма: СтудискаПрограмаИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }

        [Test]
        public void UpdateTest()
        {
            StudiskaProgramaManager manager = new StudiskaProgramaManager();
            StudiskaProgramaCollection siteSP = manager.GetAll();
            Random random = new Random(DateTime.Now.Millisecond);
            int sPId = random.Next(0, siteSP.Count);
            StudiskaPrograma izbranaSP = siteSP[sPId];

            Console.WriteLine("Се менуваат податоците за студиската програма ИД: {0}, Име: {1}", izbranaSP.Id, izbranaSP.Ime);

            izbranaSP.Ime = string.Format("Изменета {0}", Guid.NewGuid().ToString());

            StudiskaPrograma izmenetaSP = manager.Update(izbranaSP);

            Assert.IsNotNull(izmenetaSP);
            Assert.AreEqual(izbranaSP.Id, izmenetaSP.Id);
            Assert.AreEqual(izbranaSP.Ime, izmenetaSP.Ime);

            Console.WriteLine("Изменетите податоци за студиската програма : ИД: {0}, Име: {1}", izmenetaSP.Id, izmenetaSP.Ime);
        }
    }
}
