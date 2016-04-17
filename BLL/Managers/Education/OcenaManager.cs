using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LearnByPractice.BLL.Managers.Education
{
    using LearnByPractice.Domain.Education;
    using DAL.Repositories.Education;
    

   public class OcenaManager
    {
        public OcenaManager()
    {

    }

        public OcenaCollection GetAll()
        {
            OcenaManager repository = new OcenaManager();
            OcenaCollection siteOceni = repository.GetAll();

            return siteOceni;
        }


        public OcenaCollection Insert()
        {
            OcenaManager repository = new OcenaManager();
            OcenaCollection siteOceni = repository.Insert();
           // public domain.Ocena Insert(domain.Ocena domainObject)

            return siteOceni;
        }

       /* public OcenaCollection Update()
        {
            OcenaManager repository = new OcenaManager();
            OcenaCollection siteOceni = repository.Update();

            return siteOceni;
        }*/
    }
      
      
}
    
