using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Organizational
{

    using model = DAL.Models;
    using domain = LearnByPractice.Domain.Organizational;

    class KompanijaRepository : RepositoryBase
    {
         public KompanijaRepository()
        {
        }
        public domain.KompanijaCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Organizacija> query = context.Organizacijas;
            domain.KompanijaCollection result = new domain.KompanijaCollection();
            foreach (model.Organizacija modelObject in query)
            {
                domain.Kompanija domainObject = new domain.Kompanija();
                domainObject.IdKompanija = modelObject.ID;
                domainObject.ImeKompanija = modelObject.Ime;
                //domainObject = modelObject;
              result.Add(domainObject);
            }

            return result;
        }

        public domain.Kompanija Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Organizacija> query = context.Organizacijas.Where(c => c.ID == id);

                domain.Kompanija domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }


        public domain.Kompanija Insert(domain.Kompanija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Organizacija modelObject = new model.Organizacija();
                domainObject.ImeKompanija = modelObject.Ime;
                context.Organizacijas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Kompanija result = ToDomain(modelObject);

                return result;

            }
        }

        private domain.Kompanija ToDomain(model.Organizacija modelObject)
        {
            throw new NotImplementedException();
        }

    }
    }

