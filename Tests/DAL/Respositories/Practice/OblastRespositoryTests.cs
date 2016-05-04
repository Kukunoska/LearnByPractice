using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using LearnByPractice.DAL.Repositories.Practice;

namespace LearnByPractice.Tests.DAL.Respositories.Practice
{
    public class OblastRespositoryTests
    {
         [Test]
        public void GetAllTest()
        {
            OblastRepository respository = new OblastRepository();
            OblastCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);

            //Assert.IsTrue(zemi.Count >= x);

            foreach (Oblast oblast in zemi)
            {
                Console.WriteLine("ОбластИД: {0}, Име: {1},", oblast.Id, oblast.Ime);
            }
        }

        [Test]
        public void InsertTest()
        {
           

            Oblast oblast = new Oblast();
            oblast.Ime = string.Format("Технологија {0}", Guid.NewGuid().ToString());

            OblastRepository repository = new OblastRepository();
            Oblast dodadete = repository.Insert(oblast);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(oblast.Ime, dodadete.Ime);

            Console.WriteLine("Додаденa е новa oбласт: ОбластИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }
    }
    }