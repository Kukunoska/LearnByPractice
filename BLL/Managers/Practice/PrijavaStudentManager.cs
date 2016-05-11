using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using LearnByPractice.DAL.Repositories.Practice;

    public class PrijavaStudentManager : ManagerBase
    {
        public PrijavaStudentManager()
        {

        }

        public PrijavaStudentCollection GetAll()
        {
            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudentCollection sitePrijavaStudent = repository.GetAll();

            return sitePrijavaStudent;
        }

        public PrijavaStudent Insert(Domain.Practice.PrijavaStudent domainObject)
        {
            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudent sitePrijavaStudent = repository.Insert(domainObject);

            return sitePrijavaStudent;
        }

        public PrijavaStudent Update(Domain.Practice.PrijavaStudent domainObject)
        {
            PrijavaStudentRepository repository = new PrijavaStudentRepository();
            PrijavaStudent sitePrijavaStudent = repository.Update(domainObject);

            return sitePrijavaStudent;
        }
    }
}