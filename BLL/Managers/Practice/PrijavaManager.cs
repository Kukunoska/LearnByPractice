using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using DAL.Repositories.Practice;

    public class PrijavaManager : ManagerBase
    {
        public PrijavaManager()
        {

        }

        public PrijavaCollection GetAll()
        {
            PrijavaRepository repository = new PrijavaRepository();
            PrijavaCollection sitePrijavi = repository.GetAll();

            return sitePrijavi;
        }

        public Prijava Insert(Domain.Practice.Prijava domainObject)
        {
            PrijavaRepository repository = new PrijavaRepository();
            Prijava sitePrijavi = repository.Insert(domainObject);

            return sitePrijavi;
        }

         public Prijava Update(Domain.Practice.Prijava domainObject) 
     {
          PrijavaRepository repository = new PrijavaRepository();
          Prijava sitePrijavi = repository.Update(domainObject);

          return sitePrijavi; 
      }
    }
}
