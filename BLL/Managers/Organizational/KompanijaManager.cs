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
            KompanijaRepository manager = new KompanijaRepository();
            KompanijaCollection siteKompanii = manager.GetAll();

            return siteKompanii;
        }

        public Kompanija Get(int id)
        {
            var repository = new KompanijaRepository();
            var result = repository.Get(id);
            return result;
        }

        public Kompanija Insert(Domain.Organizational.Kompanija domainObject)
        {
            KompanijaRepository manager = new KompanijaRepository();
            Kompanija siteKompanii = manager.Insert(domainObject);

            return siteKompanii;
        }

        public Kompanija Update(Domain.Organizational.Kompanija domainObject)
        {
            KompanijaRepository manager = new KompanijaRepository();
            Kompanija siteKompanii = manager.Update(domainObject);

            return siteKompanii;
        }
    }
}