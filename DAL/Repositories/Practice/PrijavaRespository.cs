using System;
using System.Linq;
using model = LearnByPractice.DAL.Models;
using domain = LearnByPractice.Domain.Practice;

namespace LearnByPractice.DAL.Repositories.Practice
{
    public class PrijavaRepository : RepositoryBase
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
                domainObject.kompanija.Ime = modelObject.Organizacija.Ime;
                domainObject.Datum = modelObject.Datum_Na_Prijavuvanje;
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
                modelObject.Organizacija.ID = domainObject.kompanija.Id;
                modelObject.Datum_Na_Prijavuvanje = domainObject.Datum;
                context.SubmitChanges();
                domain.Prijava result = ToDomain(modelObject);

                return result;

            }
        }
        public domain.Prijava Update(domain.Prijava domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Prijava> query = context.Prijavas.Where(p => p.ID == domainObject.Id);
                model.Prijava modelObject = query.Single();
                modelObject.Organizacija.ID = domainObject.kompanija.Id;
                context.SubmitChanges();
                domain.Prijava result = ToDomain(modelObject);
                return result;
            }
        }

        private domain.Prijava ToDomain(model.Prijava modelObject)
        {
            domain.Prijava domainObject = new domain.Prijava();
            domainObject.Id = modelObject.ID;
            domainObject.kompanija.Ime = modelObject.Organizacija.Ime;
            domainObject.Datum = modelObject.Datum_Na_Prijavuvanje;
            return domainObject;
        }
    }

}