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
            TehnologijaManager repository = new TehnologijaManager();
            TehnologijaCollection siteTehnologii = repository.GetAll();

            return siteTehnologii;
        }

        public TehnologijaCollection Insert()
        {
            TehnologijaManager repository = new TehnologijaManager();
            TehnologijaCollection siteTehnologii = repository.Insert();

            return siteTehnologii;
        }

        /*public TehnologijaCollection Update() 
    {
         TehnologijaManager repository = new TehnologijaManager();
         TehnologijaCollection siteTehnologii = repository.Update();

         return siteTehnologii;
   }*/
    }
}
