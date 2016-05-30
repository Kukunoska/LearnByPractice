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
            PrijavaTehnologijaRepository manager = new PrijavaTehnologijaRepository();
            PrijavaTehnologijaCollection sitePrijavaTehnologii = manager.GetAll();

            return sitePrijavaTehnologii;
        }

        public PrijavaTehnologija Insert(Domain.Practice.PrijavaTehnologija domainObject)
        {
            PrijavaTehnologijaRepository manager = new PrijavaTehnologijaRepository();
            PrijavaTehnologija sitePrijavaTehnologii = manager.Insert(domainObject);

            return sitePrijavaTehnologii;
        }

        public PrijavaTehnologija Update(Domain.Practice.PrijavaTehnologija domainObject)
        {
            PrijavaTehnologijaRepository manager = new PrijavaTehnologijaRepository();
            PrijavaTehnologija sitePrijavaTehnologii = manager.Update(domainObject);

            return sitePrijavaTehnologii;
        }
    }
}
