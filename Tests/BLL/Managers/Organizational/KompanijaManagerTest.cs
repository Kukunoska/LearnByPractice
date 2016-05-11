using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.BLL.Managers.Organizational;


namespace LearnByPractice.Tests.BLL.Managers.Organizational
{
    public class KompanijaManagerTest
    {
        [Test]
        public void GetAllTest()
        {
            KompanijaManager manager = new KompanijaManager();
            KompanijaCollection all = manager.GetAll();
            Assert.IsNotNull(all);
            Assert.IsTrue(all.Count >= 2);

            foreach (Kompanija kompanija in all)
            {
                Console.WriteLine("КомпанијаИД: {0}, Име: {1}, Адреса: {2}, Контакт Телефон: {3}, Веб трана: {4}, Вид Организација: {5}, ", kompanija.Id, kompanija.Ime, kompanija.Adresa, kompanija.KontaktTelefon, kompanija.VebStrana, kompanija.vidOrganizacija.Ime);
            }

        }
    }
}
