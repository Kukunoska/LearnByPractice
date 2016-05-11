using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using LearnByPractice.DAL.Repositories.Practice;

    public class PrijavaTehnologijaManager : ManagerBase
    {
        public PrijavaTehnologijaManager()
        {

        }

        public PrijavaTehnologijaCollection GetAll()
        {
            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologijaCollection sitePrijavaTehnologii = repository.GetAll();

            return sitePrijavaTehnologii;
        }

        public PrijavaTehnologija Insert(Domain.Practice.PrijavaTehnologija domainObject)
        {
            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologija sitePrijavaTehnologii = repository.Insert(domainObject);

            return sitePrijavaTehnologii;
        }

        public PrijavaTehnologija Update(Domain.Practice.PrijavaTehnologija domainObject)
        {
            PrijavaTehnologijaRepository repository = new PrijavaTehnologijaRepository();
            PrijavaTehnologija sitePrijavaTehnologii = repository.Update(domainObject);

            return sitePrijavaTehnologii;
        }
    }
}
