using System;
using System.Linq;

namespace DAL.Repositories.Practice
{
    using model = DAL.Models;
    using domain = LearnByPractice.Domain.Practice;

    class PrijavaRepository : RepositoryBase
    {
        public PrijavaRepository()
        {
        }
        public domain.PrijavaCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Prijava> query = context.Prijavas;
            domain.PrijavaCollection result = new domain.PrijavaCollection();
            foreach (model.Prijava modelObject in query)
            {
                domain.Prijava domainObject = new domain.Prijava();
                domainObject.Id = modelObject.ID;
                domainObject.IdKompanija = modelObject.Organizacija_ID;
                result.Add(domainObject);
            }

            return result;
        }

        public domain.Prijava Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Prijava> query = context.Prijavas.Where(c => c.ID == id);

                domain.Prijava domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }

        public domain.Prijava Insert(domain.Prijava domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Prijava modelObject = new model.Prijava();
                domainObject.IdKompanija = modelObject.Organizacija_ID;
                context.SubmitChanges();
                domain.Prijava result = ToDomain(modelObject);

                return result;

            }
        }

        private domain.Prijava ToDomain(model.Prijava modelObject)
        {
            throw new NotImplementedException();
        }
    }

}
