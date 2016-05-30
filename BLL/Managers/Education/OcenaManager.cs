using System;

namespace LearnByPractice.BLL.Managers.Education
{
    using LearnByPractice.Domain.Education;
    using LearnByPractice.DAL.Repositories.Education;

    public class OcenaManager : ManagerBase
    {
        public OcenaManager()
        {

        }

        public OcenaCollection GetAll()
        {
            OcenaRepository manager = new OcenaRepository();
            OcenaCollection siteOceni = manager.GetAll();

            return siteOceni;
        }

        public Ocena Insert(Domain.Education.Ocena domainObject)
        {

            OcenaRepository manager = new OcenaRepository();
            Ocena siteOceni = manager.Insert(domainObject);
            return siteOceni;

        }
         public Ocena Update( Domain.Education.Ocena domainObject)
         {
             OcenaRepository manager = new OcenaRepository();
             Ocena siteOceni = manager.Update(domainObject);

             return siteOceni;
         }
    }

}

