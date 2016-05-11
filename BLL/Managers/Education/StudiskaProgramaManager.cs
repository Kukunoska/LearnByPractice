using System;

namespace LearnByPractice.BLL.Managers.Education
{
    using LearnByPractice.Domain.Education;
    using LearnByPractice.DAL.Repositories.Education;

    public class StudiskaProgramaManager : ManagerBase
    {
        public StudiskaProgramaManager()
        {

        }

        public StudiskaProgramaCollection GetAll()
        {
            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            StudiskaProgramaCollection siteStudiskiProgrami = repository.GetAll();

            return siteStudiskiProgrami;
        }

        public StudiskaPrograma Insert(Domain.Education.StudiskaPrograma domainObject)
        {
            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            StudiskaPrograma siteStudiskiProgrami = repository.Insert(domainObject);

            return siteStudiskiProgrami;
        }

        /* public StudiskaProgramaCollection Update() 
     {
         StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
          StudiskaProgramaCollection siteStudiskiProgrami = repository.Update();

          return siteStudiskiProgrami;
    }*/
    }
}