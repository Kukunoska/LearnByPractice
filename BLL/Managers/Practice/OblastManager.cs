using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using DAL.Repositories.Practice;

    public class OblastManager 
    {
        public OblastManager()
        {

        }

        public OblastCollection GetAll()
        {
            OblastManager repository = new OblastManager();
            OblastCollection siteOblasti = repository.GetAll();

            return siteOblasti;
        }

        public OblastCollection Insert()
        {
            OblastManager repository = new OblastManager();
            OblastCollection siteOblasti = repository.Insert();

            return siteOblasti;
        }

        /* public OblastCollection Update() 
     {
          OblastManager repository = new OblastManager();
          OblastCollection siteOblasti = repository.Update();

          return siteOblasti;
    }*/
    }
}