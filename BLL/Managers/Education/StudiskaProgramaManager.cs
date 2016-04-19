using System;

namespace LearnByPractice.BLL.Managers.Education
{
    using LearnByPractice.Domain.Education;
    using DAL.Repositories.Education;

    public class StudiskaProgramaManager 
    {
        public StudiskaProgramaManager()
        {

        }

        public StudiskaProgramaCollection GetAll()
        {
            StudiskaProgramaManager repository = new StudiskaProgramaManager();
            StudiskaProgramaCollection siteStudiskiProgrami = repository.GetAll();

            return siteStudiskiProgrami;
        }

        public StudiskaProgramaCollection Insert()
        {
            StudiskaProgramaManager repository = new StudiskaProgramaManager();
            StudiskaProgramaCollection siteStudiskiProgrami = repository.Insert();

            return siteStudiskiProgrami;
        }

        /* public StudiskaProgramaCollection Update() 
     {
         StudiskaProgramaManager repository = new StudiskaProgramaRManager();
          StudiskaProgramaCollection siteStudiskiProgrami = repository.Update();

          return siteStudiskiProgrami;
    }*/
    }
}