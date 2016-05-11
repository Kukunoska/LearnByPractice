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
            StudiskaProgramaCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 2);

            foreach (StudiskaPrograma oblast in all)
            {
                Console.WriteLine("СтудискаПрограмаИД: {0}, Име: {1},", oblast.Id, oblast.Ime);
            }

        }
    }
}
