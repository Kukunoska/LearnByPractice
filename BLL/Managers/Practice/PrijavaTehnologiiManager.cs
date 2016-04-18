using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using DAL.Repositories.Practice;

    public class PrijavaTehnologijaManager : ManagerBase
    {
        public PrijavaTehnologijaManager()
        {

        }

        public PrijavaTehnologijaCollection GetAll()
        {
            PrijavaTehnologijaManager repository = new PrijavaTehnologijaManager();
            PrijavaTehnologijaCollection sitePrijavaTehnologii = repository.GetAll();

            return sitePrijavaTehnologii;
        }

        public PrijavaTehnologijaCollection Insert()
        {
            PrijavaTehnologijaManager repository = new PrijavaTehnologijaManager();
            PrijavaTehnologijaCollection sitePrijavaTehnologii = repository.Insert();

            return sitePrijavaTehnologii;
        }

        /* public PrijavaTehnologijaCollection Update() 
     {
        PrijavaTehnologiiManager repository = new PrijavaTehnologiiManager();
          PrijavaTehnologiiCollection sitePrijavaTehnologii = repository.Update();

          return sitePrijavaTehnologii;
    }*/
    }
}
