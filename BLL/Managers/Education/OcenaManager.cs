using System;

namespace LearnByPractice.BLL.Managers.Education
{
    using LearnByPractice.Domain.Education;
    using DAL.Repositories.Education;

    public class OcenaManager : ManagerBase
    {
        public OcenaManager()
        {

        }

        public OcenaCollection GetAll()
        {
            OcenaRepository repository = new OcenaRepository();
            OcenaCollection siteOceni = repository.GetAll();

            return siteOceni;
        }

        public Ocena Insert(Domain.Education.Ocena domainObject)
        {

            OcenaRepository repository = new OcenaRepository();
            Ocena siteOceni = repository.Insert(domainObject);
            return siteOceni;

        }
         public Ocena Update( Domain.Education.Ocena domainObject)
         {
             OcenaRepository repository = new OcenaRepository();
             Ocena siteOceni = repository.Update(domainObject);

             return siteOceni;
         }
    }

}

