﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.DAL.Repositories.Organizational;

namespace LearnByPractice.Tests.DAL.Respositories.Organizational
{
    public class VidOrganizacijaRespositoryTests
    {
        [Test]
        public void GetAllTest()
        {
            VidOrganizacijaRespository respository = new VidOrganizacijaRespository();
            VidOrganizacijaCollection zemi = respository.GetAll();
            Assert.IsNotNull(zemi);

            Assert.IsTrue(zemi.Count >= 2);

            foreach (VidOrganizacija vidOrg in zemi)
            {
                Console.WriteLine("ВидОрганизацијаИД: {0}, Име: {1},", vidOrg.Id, vidOrg.Ime);
            }
        }

        [Test]
        public void InsertTest()
        {


            VidOrganizacija vidOrg = new VidOrganizacija();
            vidOrg.Ime = string.Format("Организација {0}", Guid.NewGuid().ToString());

            VidOrganizacijaRespository repository = new VidOrganizacijaRespository();
            VidOrganizacija dodadete = repository.Insert(vidOrg);

            Assert.IsNotNull(dodadete);
            Assert.AreEqual(vidOrg.Ime, dodadete.Ime);

            Console.WriteLine("Додаден е нов Вид Организација: ВидОрганизацијаИД: {0}, Име: {1}, ", dodadete.Id, dodadete.Ime);
        }
    }
}
