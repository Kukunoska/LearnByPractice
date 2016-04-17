using System;
using System.Collections.Generic;
using System.Linq;
using model = DAL.Models;
using domain = LearnByPractice.Domain.Practice;

namespace DAL.Repositories.Practice
{

    public class PrijavaTehnologijaRepository : RepositoryBase
    {
        public PrijavaTehnologijaRepository()
        {
        }
        public domain.PrijavaTehnologijaCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Prijava_Tehnologija> query = context.Prijava_Tehnologijas;
            domain.PrijavaTehnologijaCollection result = new domain.PrijavaTehnologijaCollection();
            foreach (model.Prijava_Tehnologija modelObject in query)
            {
                domain.PrijavaTehnologija domainObject = new domain.PrijavaTehnologija();
                domainObject.IdPrijava = modelObject.Prijava_ID;
                domainObject.IdTehnologija = modelObject.Tehnologija_ID;
                result.Add(domainObject);
            }

            return result;
        }
        public domain.PrijavaTehnologija Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Prijava_Tehnologija> query = context.Prijava_Tehnologijas.Where(c => c.Prijava_ID == id);

                domain.PrijavaTehnologija domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }

        public domain.PrijavaTehnologijaCollection GetByTehnologijaId(int TehId)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Prijava_Tehnologija> query = context.Prijava_Tehnologijas.Where(c => c.Tehnologija_ID == TehId);
                domain.PrijavaTehnologijaCollection domainObjects = ToDomainObjects(query.ToList());

                return domainObjects;
            }
        }

        private domain.PrijavaTehnologijaCollection ToDomainObjects(List<model.Prijava_Tehnologija> list)
        {
            throw new NotImplementedException();
        }

        private domain.PrijavaTehnologija ToDomain(model.Prijava_Tehnologija prijava_Tehnologija)
        {
            throw new NotImplementedException();
        }


        public domain.PrijavaTehnologija Insert(domain.PrijavaTehnologija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Prijava_Tehnologija modelObject = new model.Prijava_Tehnologija();
                modelObject.Tehnologija_ID = domainObject.IdTehnologija;
                modelObject.Prijava_ID = domainObject.IdPrijava;
                context.Prijava_Tehnologijas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.PrijavaTehnologija result = ToDomain(modelObject);

                return result;

            }
        }
    }
}
