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
            PrijavaStudentRepository manager = new PrijavaStudentRepository();
            PrijavaStudentCollection sitePrijavaStudent = manager.GetAll();

            return sitePrijavaStudent;
        }

        public PrijavaStudent Insert(Domain.Practice.PrijavaStudent domainObject)
        {
            PrijavaStudentRepository manager = new PrijavaStudentRepository();
            PrijavaStudent sitePrijavaStudent = manager.Insert(domainObject);

            return sitePrijavaStudent;
        }

        public PrijavaStudent Update(Domain.Practice.PrijavaStudent domainObject)
        {
            PrijavaStudentRepository manager = new PrijavaStudentRepository();
            PrijavaStudent sitePrijavaStudent = manager.Update(domainObject);

            return sitePrijavaStudent;
        }
    }
}