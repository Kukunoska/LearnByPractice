using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.BLL.Managers.Organizational

{
    using LearnByPractice.Domain.Organizational;
    using DAL.Repositories.Organizational;

    public class KompanijaManager
    {
        public KompanijaManager()
        {

        }

          public KompanijaCollection GetAll() 
      {
         KompanijaManager repository = new KompanijaManager();
           KompanijaCollection siteKompanii = repository.GetAll();

           return siteKompanii;
     }
  
          public KompanijaCollection Insert() 
      {
         KompanijaManager repository = new KompanijaManager();
           KompanijaCollection siteKompanii = repository.Insert();

           return siteKompanii;
     }
     
         /* public KompanijaCollection Update() 
      {
         KompanijaManager repository = new KompanijaManager();
           KompanijaCollection siteKompanii = repository.Update();

           return siteKompanii;
      }
     
  
    */
}
}