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

        public Oblast Get(int id)
        {
            OblastRepository manager = new OblastRepository();
            var result = manager.Get(id);
            return result;
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
        public Oblast Delete(Domain.Practice.Oblast domainObject)
        {
            OblastRepository manager = new OblastRepository();
            Oblast siteOblasti = manager.Delete(domainObject);

            return siteOblasti;
        }
    }
}