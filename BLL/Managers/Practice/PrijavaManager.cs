using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using DAL.Repositories.Practice;

    public class PrijavaManager 
    {
        public PrijavaManager()
        {

        }

        public PrijavaCollection GetAll()
        {
            PrijavaManager repository = new PrijavaManager();
            PrijavaCollection sitePrijavi = repository.GetAll();

            return sitePrijavi;
        }

        public PrijavaCollection Insert()
        {
            PrijavaManager repository = new PrijavaManager();
            PrijavaCollection sitePrijavi = repository.Insert();

            return sitePrijavi;
        }

        /* public PrijavaCollection Update() 
     {
          PrijavaManager repository = new PrijavaManager();
          PrijavaCollection sitePrijavi = repository.Update();

          return sitePrijavi; 
      }*/
    }
}
