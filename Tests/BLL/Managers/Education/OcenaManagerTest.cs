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
    public class OcenaManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            OcenaManager manager = new OcenaManager();
            OcenaCollection all = manager.GetAll();
             Assert.IsNotNull(all);

            foreach (Ocena ocena in all)
            {
                Console.WriteLine("ИД: {0}, Име: {1}, Вид: {2}", ocena.student.IdKorisnik, ocena.predmet.Id, ocena.Ocenka);
            }
}
