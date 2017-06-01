using System;
using System.Linq;
using domain = LearnByPractice.Domain.Organizational;
using model = LearnByPractice.DAL.Models;

namespace LearnByPractice.DAL.Repositories.Organizational
{
    public class VidOrganizacijaRespository : RepositoryBase
    {
        public VidOrganizacijaRespository()
        {
        }

        public domain.VidOrganizacijaCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Vid_Organizacija> query = context.Vid_Organizacijas;
            domain.VidOrganizacijaCollection result = new domain.VidOrganizacijaCollection();
            foreach (model.Vid_Organizacija modelObject in query)
            {
                domain.VidOrganizacija domainObject = new domain.VidOrganizacija();
                domainObject.Id = modelObject.ID;
                domainObject.Ime = modelObject.Ime;
                result.Add(domainObject);
            }

            return result;
        }

        public domain.VidOrganizacija Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Vid_Organizacija> query = context.Vid_Organizacijas.Where(c => c.ID == id);

                domain.VidOrganizacija domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }


        public domain.VidOrganizacija Insert(domain.VidOrganizacija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Vid_Organizacija modelObject = new model.Vid_Organizacija();
                modelObject.Ime = domainObject.Ime;
                context.Vid_Organizacijas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.VidOrganizacija result = ToDomain(modelObject);
                return result;

            }
        }
        public domain.VidOrganizacija Update(domain.VidOrganizacija domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Vid_Organizacija> query = context.Vid_Organizacijas.Where(p => p.ID == domainObject.Id);
                model.Vid_Organizacija modelObject = query.Single();
                modelObject.Ime = domainObject.Ime;
                context.SubmitChanges();
                domain.VidOrganizacija result = ToDomain(modelObject);
                return result;
            }
        }
        public domain.VidOrganizacija Delete(domain.VidOrganizacija domainObject)
        {
            using (var context = CreateContext())
            {
                var modelObject = context.Vid_Organizacijas.Single(org => org.ID == domainObject.Id);
                context.Vid_Organizacijas.DeleteOnSubmit(modelObject);
                context.SubmitChanges();
                var deletedObject = ToDomain(modelObject);
                return deletedObject;
            }
        }

        private domain.VidOrganizacija ToDomain(model.Vid_Organizacija vid_Organizacija)
        {
            domain.VidOrganizacija domainObject = new domain.VidOrganizacija();
            domainObject.Id = vid_Organizacija.ID;
            domainObject.Ime = vid_Organizacija.Ime;
            return domainObject;
        }

    }

}

