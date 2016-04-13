using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Practice
{
    using model = DAL.Models;
    using domain = LearnByPractice.Domain.Practice;

    class PrijavaTehnologijaRepository : RepositoryBase
    {
        public PrijavaTehnologijaRepository()
        {
        }
        public domain.PrijavaTehnologiiCollections GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Prijava_Tehnologija> query = context.Prijava_Tehnologijas;
            domain.PrijavaTehnologiiCollections result = new domain.PrijavaTehnologiiCollections();
            foreach (model.Prijava_Tehnologija modelObject in query)
            {
                domain.PrijavaTehnologii domainObject = new domain.PrijavaTehnologii();
                domainObject.IdPrijava = modelObject.Prijava_ID;
                domainObject.IdTehnologii = modelObject.Tehnologija_ID;
                result.Add(domainObject);
            }

            return result;
        }
        public domain.PrijavaTehnologii Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Prijava_Tehnologija> query = context.Prijava_Tehnologijas.Where(c => c.Prijava_ID == id);

                domain.PrijavaTehnologii domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }

        public domain.PrijavaTehnologiiCollections GetByTehnologijaId(int TehId)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Prijava_Tehnologija> query = context.Prijava_Tehnologijas.Where(c => c.Tehnologija_ID == TehId);
                domain.PrijavaTehnologiiCollections domainObjects = ToDomainObjects(query.ToList());

                return domainObjects;
            }
        }

        private domain.PrijavaTehnologiiCollections ToDomainObjects(List<model.Prijava_Tehnologija> list)
        {
            throw new NotImplementedException();
        }

        private domain.PrijavaTehnologii ToDomain(model.Prijava_Tehnologija prijava_Tehnologija)
        {
            throw new NotImplementedException();
        }


        public domain.PrijavaTehnologii Insert(domain.PrijavaTehnologii domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Prijava_Tehnologija modelObject = new model.Prijava_Tehnologija();
                domainObject.IdTehnologii = modelObject.Tehnologija_ID;
                context.Prijava_Tehnologijas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.PrijavaTehnologii result = ToDomain(modelObject);

                return result;

            }
        }
    }
}
