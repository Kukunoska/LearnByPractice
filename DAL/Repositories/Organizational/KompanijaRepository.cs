using System;
using System.Linq;
using model = LearnByPractice.DAL.Models;
using domain = LearnByPractice.Domain.Organizational;
using System.Data.Entity;

namespace LearnByPractice.DAL.Repositories.Organizational
{

    public class KompanijaRepository : RepositoryBase
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
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
                domainObject.Adresa = modelObject.Adresa;
                domainObject.KontaktTelefon = modelObject.Kontakt_Telefon;
                domainObject.VebStrana = modelObject.Veb_Strana;
                domainObject.vidOrganizacija.Id = modelObject.Vid_Organizacija_ID;
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
                modelObject.Ime = domainObject.Ime;
                modelObject.Adresa = domainObject.Adresa;
                modelObject.Kontakt_Telefon = domainObject.KontaktTelefon;
                modelObject.Veb_Strana = domainObject.VebStrana;
                modelObject.Vid_Organizacija_ID = domainObject.vidOrganizacija.Id;
                context.Organizacijas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Kompanija result = ToDomain(modelObject);

                return result;


            }
        }
        public domain.Kompanija Update(domain.Kompanija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Organizacija> query = context.Organizacijas.Where(p => p.ID == domainObject.Id);
                model.Organizacija modelObject = query.Single();
                modelObject.Ime = domainObject.Ime;
                modelObject.Adresa = domainObject.Adresa;
                modelObject.Kontakt_Telefon = domainObject.KontaktTelefon;
                modelObject.Veb_Strana = domainObject.VebStrana;
                modelObject.Vid_Organizacija_ID = domainObject.vidOrganizacija.Id;
                context.SubmitChanges();
                domain.Kompanija result = ToDomain(modelObject);
                return result;
            }
        }

        private domain.Kompanija ToDomain(model.Organizacija modelObject)
        {
            domain.Kompanija domainObject = new domain.Kompanija();
            domainObject.Id = modelObject.ID;
            domainObject.Ime = modelObject.Ime;
            domainObject.Adresa = modelObject.Adresa;
            domainObject.KontaktTelefon = modelObject.Kontakt_Telefon;
            domainObject.VebStrana = modelObject.Veb_Strana;
            domainObject.vidOrganizacija.Id = modelObject.Vid_Organizacija_ID;
            return domainObject;
        }

    }
}
