using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using LearnByPractice.DAL.Repositories.Practice;

    public class OblastManager : ManagerBase
    {
        public OblastManager()
        {

        }

        public OblastCollection GetAll()
        {
            OblastRepository manager = new OblastRepository();
            OblastCollection siteOblasti = manager.GetAll();

            return siteOblasti;
        }

        public Oblast Insert(Domain.Practice.Oblast domainObject)
        {
            OblastRepository manager = new OblastRepository();
            Oblast siteOblasti = manager.Insert(domainObject);

            return siteOblasti;
        }

         public Oblast Update(Domain.Practice.Oblast domainObject) 
     {
          OblastRepository manager = new OblastRepository();
          Oblast siteOblasti = manager.Update(domainObject);

          return siteOblasti;
    }
    }
}