using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using LearnByPractice.DAL.Repositories.Practice;

    public class TehnologijaManager : ManagerBase
    {
        public TehnologijaManager()
        {

        }

        public TehnologijaCollection GetAll()
        {
            TehnologijaRepository manager = new TehnologijaRepository();
            TehnologijaCollection siteTehnologii = manager.GetAll();

            return siteTehnologii;
        }
        public Tehnologija Get(int id)
        {
            TehnologijaRepository manager = new TehnologijaRepository();
            var result = manager.Get(id);
            return result;
        }

        public Tehnologija Insert(Domain.Practice.Tehnologija domainObject)
        {
            TehnologijaRepository manager = new TehnologijaRepository();
            Tehnologija siteTehnologii = manager.Insert(domainObject);

            return siteTehnologii;
        }

        public Tehnologija Update(Domain.Practice.Tehnologija domainObject)
        {
            TehnologijaRepository manager = new TehnologijaRepository();
            Tehnologija siteTehnologii = manager.Update(domainObject);

            return siteTehnologii;
        }
        public Tehnologija Delete(Domain.Practice.Tehnologija domainObject)
        {
            TehnologijaRepository manager = new TehnologijaRepository();
            Tehnologija siteTehnologii = manager.Delete(domainObject);

            return siteTehnologii;
        }
    }
}
