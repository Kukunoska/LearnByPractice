using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.BLL.Managers.Practice;


namespace LearnByPractice.Tests.BLL.Managers.Practice
{
    public class PrijavaStudentManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            PrijavaStudentManager manager = new PrijavaStudentManager();
            PrijavaStudentCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 0);

            foreach (PrijavaStudent prijavaStudent in all)
            {
                Console.WriteLine("ПријаваИД: {0}, СтудентИД: {1}, ", prijavaStudent.prijava.Id, prijavaStudent.student.Ime);
            }
        }

    }
}
