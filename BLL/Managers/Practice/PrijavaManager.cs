using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using LearnByPractice.DAL.Repositories.Practice;

    public class PrijavaManager : ManagerBase
    {
        public PrijavaManager()
        {

        }

        public PrijavaCollection GetAll()
        {
            PrijavaRepository manager = new PrijavaRepository();
            PrijavaCollection sitePrijavi = manager.GetAll();

            return sitePrijavi;
        }

        public Prijava Insert(Domain.Practice.Prijava domainObject)
        {
            PrijavaRepository manager = new PrijavaRepository();
            Prijava sitePrijavi = manager.Insert(domainObject);

            return sitePrijavi;
        }

         public Prijava Update(Domain.Practice.Prijava domainObject) 
     {
          PrijavaRepository manager = new PrijavaRepository();
          Prijava sitePrijavi = manager.Update(domainObject);

          return sitePrijavi; 
      }
    }
}
