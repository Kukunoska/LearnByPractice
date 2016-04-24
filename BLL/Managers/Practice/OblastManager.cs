using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using DAL.Repositories.Practice;

    public class OblastManager : ManagerBase
    {
        public OblastManager()
        {

        }

        public OblastCollection GetAll()
        {
            OblastRepository repository = new OblastRepository();
            OblastCollection siteOblasti = repository.GetAll();

            return siteOblasti;
        }

        public Oblast Insert(Domain.Practice.Oblast domainObject)
        {
            OblastRepository repository = new OblastRepository();
            Oblast siteOblasti = repository.Insert(domainObject);

            return siteOblasti;
        }

         public Oblast Update(Domain.Practice.Oblast domainObject) 
     {
          OblastRepository repository = new OblastRepository();
          Oblast siteOblasti = repository.Update(domainObject);

          return siteOblasti;
    }
    }
}