using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Education
{

    using model = DAL.Models;
    using domain = LearnByPractice.Domain.Education;

    class PredmetRepository : RepositoryBase
    {
         public PredmetRepository()
        {
        }
        public domain.PredmetCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Predmet> query = context.Predmets;
            domain.PredmetCollection result = new domain.PredmetCollection();
            foreach (model.Predmet modelObject in query)
            {
                domain.Predmet domainObject = new domain.Predmet();
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
              result.Add(domainObject);
            }

            return result;
        }

        public domain.Predmet Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Predmet> query = context.Predmets.Where(c => c.ID == id);

                domain.Predmet domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }


        public domain.Predmet Insert(domain.Predmet domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Predmet modelObject = new model.Predmet();
                domainObject.Ime = modelObject.Ime;
                context.Predmets.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Predmet result = ToDomain(modelObject);

                return result;

            }
        }

        private domain.Predmet ToDomain(model.Predmet modelObject)
        {
            throw new NotImplementedException();
        }
    }
    }

