using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.BLL.Managers.Education
{
    using LearnByPractice.Domain.Education;
    using DAL.Repositories.Education;

    public class PredmetManager
    {
        public PredmetManager()
        {

        }

          public PredmetCollection GetAll() 
      {
           PredmetManager repository = new PredmetManager();
           PredmetCollection sitePredmeti = repository.GetAll();

           return sitePredmeti;
     }
     
          public PredmetCollection Insert() 
      {
           PredmetManager repository = new PredmetManager();
           PredmetCollection sitePredmeti = repository.Insert();

           return sitePredmeti;
     }
      
        /*  public PredmetCollection Update() 
      {
           PredmetManager repository = new PredmetManager();
           PredmetCollection sitePredmeti = repository.Update();

           return sitePredmeti;
     }
     }*/
      
      

}
}

