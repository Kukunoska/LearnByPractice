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
            StudiskaProgramaRepository manager = new StudiskaProgramaRepository();
            StudiskaProgramaCollection siteStudiskiProgrami = manager.GetAll();

            return siteStudiskiProgrami;
        }
        public StudiskaPrograma Get(int id)
        {
            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            var result = repository.Get(id);
            return result;
        }
        public StudiskaPrograma Insert(Domain.Education.StudiskaPrograma domainObject)
        {
            StudiskaProgramaRepository manager = new StudiskaProgramaRepository();
            StudiskaPrograma siteStudiskiProgrami = manager.Insert(domainObject);

            return siteStudiskiProgrami;
        }

        public StudiskaPrograma Update(Domain.Education.StudiskaPrograma domainObject)
        {
            StudiskaProgramaRepository manager = new StudiskaProgramaRepository();
            StudiskaPrograma siteStudiskiProgrami = manager.Update(domainObject);

            return siteStudiskiProgrami;
        }

        public StudiskaPrograma Delete(Domain.Education.StudiskaPrograma domainObject)
        {
            StudiskaProgramaRepository repository = new StudiskaProgramaRepository();
            StudiskaPrograma izbrishanaStudiska = repository.Delete(domainObject);

            return izbrishanaStudiska;
        }
    }
}