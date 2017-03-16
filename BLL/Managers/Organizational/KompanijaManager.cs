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

        public Kompanija Insert(Kompanija domainObject)
        {
            KompanijaRepository repository = new KompanijaRepository();
            Kompanija kompanija = repository.Insert(domainObject);

            return kompanija;
        }

        public Kompanija Update(Kompanija domainObject)
        {
            KompanijaRepository repository = new KompanijaRepository();
            Kompanija kompanija = repository.Update(domainObject);

            return kompanija;
        }

        public Kompanija Delete(Kompanija domainObject)
        {
            var repository = new KompanijaRepository();
            var izbrishanaKompanija = repository.Delete(domainObject);
            return izbrishanaKompanija;
        }
    }
}