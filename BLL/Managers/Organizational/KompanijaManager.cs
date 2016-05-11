using System;

namespace LearnByPractice.BLL.Managers.Organizational
{
    using LearnByPractice.Domain.Organizational;
    using LearnByPractice.DAL.Repositories.Organizational;

    public class KompanijaManager : ManagerBase
    {
        public KompanijaManager()
        {

        }

        public KompanijaCollection GetAll()
        {
            KompanijaRepository repository = new KompanijaRepository();
            KompanijaCollection siteKompanii = repository.GetAll();

            return siteKompanii;
        }

        public Kompanija Insert(Domain.Organizational.Kompanija domainObject)
        {
            KompanijaRepository repository = new KompanijaRepository();
            Kompanija siteKompanii = repository.Insert(domainObject);

            return siteKompanii;
        }

        /* public KompanijaCollection Update() 
     {
        KompanijaRepository repository = new KompanijaRepository();
          KompanijaCollection siteKompanii = repository.Update();

          return siteKompanii;
     }*/
    }
}