using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Security;
using LearnByPractice.BLL.Managers.Security;


namespace LearnByPractice.Tests.BLL.Managers.Security
{
   public class KorisnikManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            KorisnikManager manager = new KorisnikManager();
            KorisnikCollection all = manager.GetAll();
            Assert.IsNotNull(all);

            Assert.IsTrue(all.Count >= 0);

            foreach (Korisnik korisnik in all)
            {
                Console.WriteLine("KорисникИД: {0}, Име: {1}, Презиме: {2}, Пол: {3}, Студиска Програма: {4}, Организација: {5}, Еmail: {6}, Мобилен: {7}, ", korisnik.IdKorisnik, korisnik.Ime, korisnik.Prezime, korisnik.Pol, korisnik.studiskaPrograma.Ime, korisnik.organizacija.Ime, korisnik.Email, korisnik.Mobilen);
            }
        }

    }
}
