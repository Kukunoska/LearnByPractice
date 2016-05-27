using System;
using System.Linq;
using model = LearnByPractice.DAL.Models;
using domain = LearnByPractice.Domain.Practice;

namespace LearnByPractice.DAL.Repositories.Practice
{
    public class TehnologijaRepository : RepositoryBase
    {
        public TehnologijaRepository()
        {
        }
        public domain.TehnologijaCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Tehnologija> query = context.Tehnologijas;
            domain.TehnologijaCollection result = new domain.TehnologijaCollection();
            foreach (model.Tehnologija modelObject in query)
            {
                domain.Tehnologija domainObject = new domain.Tehnologija();
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
                domainObject.oblast.Id = modelObject.Oblast_ID;
                result.Add(domainObject);
            }

            return result;
        }

        public domain.Tehnologija Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Tehnologija> query = context.Tehnologijas.Where(c => c.ID == id);

                domain.Tehnologija domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }

        private domain.Tehnologija ToDomain(model.Tehnologija tehnologija)
        {
            domain.Tehnologija domainObject = new domain.Tehnologija();
            domainObject.Id = tehnologija.ID;
            domainObject.Ime = tehnologija.Ime;
            domainObject.oblast.Id = tehnologija.Oblast_ID;
            return domainObject;
        }


        public domain.Tehnologija Insert(domain.Tehnologija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Tehnologija modelObject = new model.Tehnologija();
                modelObject.Ime = domainObject.Ime;
                modelObject.Oblast_ID = domainObject.oblast.Id;
                context.Tehnologijas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Tehnologija result = ToDomain(modelObject);

                return result;

            }
        }
        public domain.Tehnologija Update(domain.Tehnologija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Tehnologija> query = context.Tehnologijas.Where(p => p.ID == domainObject.Id);
                model.Tehnologija modelObject = query.Single();
                modelObject.Ime = domainObject.Ime;
                modelObject.Oblast_ID = domainObject.oblast.Id;
                context.SubmitChanges();
                domain.Tehnologija result = ToDomain(modelObject);
                return result;
            }
        }
    }
}

