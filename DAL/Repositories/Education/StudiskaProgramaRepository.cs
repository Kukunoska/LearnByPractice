using System;
using System.Linq;
using model = DAL.Models;
using domain = LearnByPractice.Domain.Education;

namespace DAL.Repositories.Education
{
    public class StudiskaProgramaRepository : RepositoryBase
    {
        public StudiskaProgramaRepository()
        {
        }
        public domain.StudiskaProgramaCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Studiska_Programa> query = context.Studiska_Programas;
            domain.StudiskaProgramaCollection result = new domain.StudiskaProgramaCollection();
            foreach (model.Studiska_Programa modelObject in query)
            {
                domain.StudiskaPrograma domainObject = new domain.StudiskaPrograma();
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
                result.Add(domainObject);
            }

            return result;
        }

        public domain.StudiskaPrograma Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Studiska_Programa> query = context.Studiska_Programas.Where(c => c.ID == id);

                domain.StudiskaPrograma domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }


        public domain.StudiskaPrograma Insert(domain.StudiskaPrograma domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Studiska_Programa modelObject = new model.Studiska_Programa();
                modelObject.Ime = domainObject.Ime;
                context.Studiska_Programas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.StudiskaPrograma result = ToDomain(modelObject);

                return result;

            }
        }

        private domain.StudiskaPrograma ToDomain(model.Studiska_Programa modelObject)
        {
            throw new NotImplementedException();
        }
    }
}

