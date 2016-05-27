using System;
using System.Collections.Generic;
using System.Linq;
using model = LearnByPractice.DAL.Models;
using domain = LearnByPractice.Domain.Practice;

namespace LearnByPractice.DAL.Repositories.Practice
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
                domainObject.prijava.Id = modelObject.Prijava_ID;
                domainObject.tehnologija.Id = modelObject.Tehnologija_ID;
                result.Add(domainObject);
            }

            return result;
        }
        public domain.PrijavaTehnologijaCollection Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Prijava_Tehnologija> query = context.Prijava_Tehnologijas.Where(c => c.Prijava_ID == id);

                domain.PrijavaTehnologijaCollection domainObjects = ToDomainObjects(query.ToList());

                return domainObjects;
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
            domain.PrijavaTehnologijaCollection domainObjects = new domain.PrijavaTehnologijaCollection();
            foreach (model.Prijava_Tehnologija modelObject in list)
            {

                domain.PrijavaTehnologija domainObject = ToDomain(modelObject);
                domainObject.prijava.Id = modelObject.Prijava_ID;
                domainObject.tehnologija.Id = modelObject.Tehnologija_ID;
                domainObjects.Add(domainObject);
            }
            return domainObjects;
        }


        private domain.PrijavaTehnologija ToDomain(model.Prijava_Tehnologija prijava_Tehnologija)
        {
            domain.PrijavaTehnologija domainObject = new domain.PrijavaTehnologija();
            domainObject.prijava.Id = prijava_Tehnologija.Prijava_ID;
            domainObject.tehnologija.Id = prijava_Tehnologija.Tehnologija_ID;
            return domainObject;
        }


        public domain.PrijavaTehnologija Insert(domain.PrijavaTehnologija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Prijava_Tehnologija modelObject = new model.Prijava_Tehnologija();
                modelObject.Tehnologija_ID = domainObject.tehnologija.Id;
                modelObject.Prijava_ID = domainObject.prijava.Id;
                context.Prijava_Tehnologijas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.PrijavaTehnologija result = ToDomain(modelObject);

                return result;

            }
        }

        public domain.PrijavaTehnologija Update(domain.PrijavaTehnologija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Prijava_Tehnologija> query = context.Prijava_Tehnologijas.Where(p => p.Prijava_ID == domainObject.prijava.Id);
                model.Prijava_Tehnologija modelObject = query.Single();
                modelObject.Tehnologija_ID = domainObject.tehnologija.Id;
                modelObject.Prijava_ID = domainObject.prijava.Id;
                context.SubmitChanges();
                domain.PrijavaTehnologija result = ToDomain(modelObject);
                return result;
            }
        }
    }
}
