using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using DAL.Repositories.Practice;

    public class TehnologijaManager : ManagerBase
    {
        public TehnologijaManager()
        {

        }

        public TehnologijaCollection GetAll()
        {
            TehnologijaRepository repository = new TehnologijaRepository();
            TehnologijaCollection siteTehnologii = repository.GetAll();

            return siteTehnologii;
        }

        public Tehnologija Insert(Domain.Practice.Tehnologija domainObject)
        {
            TehnologijaRepository repository = new TehnologijaRepository();
            Tehnologija siteTehnologii = repository.Insert(domainObject);

            return siteTehnologii;
        }

        public Tehnologija Update(Domain.Practice.Tehnologija domainObject)
        {
            TehnologijaRepository repository = new TehnologijaRepository();
            Tehnologija siteTehnologii = repository.Update(domainObject);

            return siteTehnologii;
        }
    }
}
