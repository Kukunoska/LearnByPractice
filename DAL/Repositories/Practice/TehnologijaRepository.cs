using System;
using System.Linq;
using model = LearnByPractice.DAL.Models;
using domain = LearnByPractice.Domain.Practice;
using System.Data.Linq;
using LearnByPractice.Domain.Practice;

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
            DataLoadOptions options = new DataLoadOptions();
            options.LoadWith<model.Tehnologija>(tehnologija => tehnologija.Oblast);
            context.LoadOptions = options;
            IQueryable<model.Tehnologija> query = context.Tehnologijas;
            domain.TehnologijaCollection result = new domain.TehnologijaCollection();
            foreach (model.Tehnologija modelObject in query)
            {
                domain.Tehnologija domainObject = new domain.Tehnologija();
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
                domainObject.oblast.Id = modelObject.Oblast_ID;
                if (modelObject.Oblast != null)
                {
                    domainObject.oblast.Id = modelObject.Oblast.ID;
                    domainObject.oblast.Ime = modelObject.Oblast.Ime;
                }
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

        public domain.TehnologijaCollection GetByOblastId(int a)
        {
            model.LearnByPracticeDataContext context = CreateContext();
            DataLoadOptions options = new DataLoadOptions();
            options.LoadWith<model.Tehnologija>(tehnologija => tehnologija.Oblast);
            context.LoadOptions = options;
            var tehnologii = from t in context.Tehnologijas
                             where t.Oblast_ID == a
                             select t;
            domain.TehnologijaCollection result = new domain.TehnologijaCollection();
            foreach (model.Tehnologija teh in tehnologii)
            {
                domain.Tehnologija domainObject = new domain.Tehnologija();
                domainObject.Id = teh.ID;
                domainObject.Ime = teh.Ime;
                domainObject.oblast.Id = teh.Oblast_ID;
                if (teh.Oblast != null)
                {
                    domainObject.oblast.Id = teh.Oblast.ID;
                    domainObject.oblast.Ime = teh.Oblast.Ime;
                }
                result.Add(domainObject);
            }
            return result;
        }
    }
}

