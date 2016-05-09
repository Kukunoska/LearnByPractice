using System;
using System.Linq;
using model = LearnByPractice.DAL.Models;
using domain = LearnByPractice.Domain.Practice;

namespace LearnByPractice.DAL.Repositories.Practice
{

    public class OblastRepository : RepositoryBase
    {
        public OblastRepository()
        {
        }
        public domain.OblastCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Oblast> query = context.Oblasts;
            domain.OblastCollection result = new domain.OblastCollection();
            foreach (model.Oblast modelObject in query)
            {
                domain.Oblast domainObject = new domain.Oblast();
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
                result.Add(domainObject);
            }

            return result;
        }

        public domain.Oblast Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Oblast> query = context.Oblasts.Where(c => c.ID == id);

                domain.Oblast domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }


        public domain.Oblast Insert(domain.Oblast domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Oblast modelObject = new model.Oblast();
                modelObject.Ime = domainObject.Ime;
                context.Oblasts.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Oblast result = ToDomain(modelObject);

                return result;

            }
        }
        public domain.Oblast Update(domain.Oblast domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Oblast> query = context.Oblasts.Where(p => p.ID == domainObject.Id);
                model.Oblast modelObject = query.Single();
                modelObject.Ime = domainObject.Ime;
                context.SubmitChanges();
                domain.Oblast result = ToDomain(modelObject);
                return result;
            }
        }

        private domain.Oblast ToDomain(model.Oblast modelObject)
        {
            domain.Oblast domainObject = new domain.Oblast();
            domainObject.Id = modelObject.ID;
            domainObject.Ime = modelObject.Ime;
            return domainObject;
        }
    }
}


