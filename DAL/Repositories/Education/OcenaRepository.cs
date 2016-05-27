using System;
using System.Collections.Generic;
using System.Linq;
using model = LearnByPractice.DAL.Models;
using domain = LearnByPractice.Domain.Education;


namespace LearnByPractice.DAL.Repositories.Education
{


    public class OcenaRepository : RepositoryBase
    {
        public OcenaRepository()
        {
        }
        public domain.OcenaCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Ocenka> query = context.Ocenkas;
            domain.OcenaCollection result = new domain.OcenaCollection();
            foreach (model.Ocenka modelObject in query)
            {
                domain.Ocena domainObject = new domain.Ocena();
                domainObject.student.Id = modelObject.Korisnik_ID;
                domainObject.predmet.Id = modelObject.Predmet_ID;
                domainObject.Ocenka = modelObject.Ocenka1;
                result.Add(domainObject);
            }

            return result;
        }

        public domain.OcenaCollection GetByStudentId(int StudentId)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Ocenka> query = context.Ocenkas.Where(c => c.Korisnik_ID == StudentId);
                domain.OcenaCollection domainObjects = ToDomainObjects(query.ToList());

                return domainObjects;
            }
        }

        public domain.OcenaCollection GetByPredmetId(int PredmetId)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Ocenka> query = context.Ocenkas.Where(c => c.Predmet_ID == PredmetId);
                domain.OcenaCollection domainObjects = ToDomainObjects(query.ToList());

                return domainObjects;
            }
        }

        private domain.OcenaCollection ToDomainObjects(List<model.Ocenka> list)
        {
            domain.OcenaCollection domainObjects = new domain.OcenaCollection();
            foreach (model.Ocenka modelObject in list)
            {

                domain.Ocena domainObject = ToDomain(modelObject);
                domainObject.student.Id = modelObject.Korisnik_ID;
                domainObject.predmet.Id = modelObject.Predmet_ID;
                domainObject.Ocenka = modelObject.Ocenka1;
                domainObjects.Add(domainObject);
            }
            return domainObjects;
        }

        public domain.Ocena Insert(domain.Ocena domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Ocenka modelObject = new model.Ocenka();
                modelObject.Korisnik_ID = domainObject.student.Id;
                modelObject.Predmet_ID = domainObject.predmet.Id;
                modelObject.Ocenka1 = domainObject.Ocenka;
                context.Ocenkas.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Ocena result = ToDomain(modelObject);

                return result;

            }
        }

        public domain.Ocena Update(domain.Ocena domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Ocenka> query = context.Ocenkas.Where(p => p.Korisnik_ID == domainObject.student.Id && p.Predmet_ID == domainObject.predmet.Id);
                model.Ocenka modelObject = query.Single();
                modelObject.Ocenka1 = domainObject.Ocenka;
                context.SubmitChanges();
                domain.Ocena result = ToDomain(modelObject);
                return result;
            }
        }

        private domain.Ocena ToDomain(model.Ocenka modelObject)
        {
            domain.Ocena domainObject = new domain.Ocena();
            domainObject.student.Id = modelObject.Korisnik_ID;
            domainObject.predmet.Id = modelObject.Predmet_ID;
            domainObject.Ocenka = modelObject.Ocenka1;
            return domainObject;
        }
    }
}
