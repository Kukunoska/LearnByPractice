using System;

namespace LearnByPractice.BLL.Managers.Practice
{
    using LearnByPractice.Domain.Practice;
    using DAL.Repositories.Practice;

    public class PrijavaStudentManager 
    {
        public PrijavaStudentManager()
        {

        }

        public PrijavaStudentCollection GetAll()
        {
            PrijavaStudentManager repository = new PrijavaStudentManager();
            PrijavaStudentCollection sitePrijavaStudent = repository.GetAll();

            return sitePrijavaStudent;
        }

        public PrijavaStudentCollection Insert()
        {
            PrijavaStudentManager repository = new PrijavaStudentManager();
            PrijavaStudentCollection sitePrijavaStudent = repository.Insert();

            return sitePrijavaStudent;
        }

        /*public PrijavaStudentCollection Update() 
    {
       PrijavaStudentManager repository = new PrijavaStudentManager();
         PrijavaStudentCollection sitePrijavaStudent = repository.Update();

         return sitePrijavaStudent;
   }*/
    }
}