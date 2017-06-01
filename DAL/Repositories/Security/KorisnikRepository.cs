using System;
using System.Collections.Generic;
using System.Linq;
using model = LearnByPractice.DAL.Models;
using domain = LearnByPractice.Domain.Security;


namespace LearnByPractice.DAL.Repositories.Security
{

    public class KorisnikRepository : RepositoryBase
    {

        public KorisnikRepository()
        {
        }

        protected domain.PolEnum ToDomain(char Pol)
        {
            switch (Pol)
            {
                case 'М':
                    return domain.PolEnum.Mashki;

                case 'Ж':
                    return domain.PolEnum.Zhenski;

                default: throw new ArgumentOutOfRangeException("Pol", "Неочекувана вредноста на Pol е прочитана од базата на податоци.");
            }
        }

        protected char ToModel(domain.PolEnum Pol)
        {

            switch (Pol)
            {
                case domain.PolEnum.Mashki:
                    return 'М';

                case domain.PolEnum.Zhenski:
                    return 'Ж';

                default:
                    throw new ArgumentOutOfRangeException("Pol", "Обид за запишување на неочекувана вредноста на Pol во базата на податоци.");
            }
        }

        public domain.KorisnikCollection GetAll()
        {
            model.LearnByPracticeDataContext context = CreateContext();
            IQueryable<model.Korisnik> query = context.Korisniks;
            domain.KorisnikCollection result = ToDomainObjects(query);

            return result;
        }


        public domain.Korisnik Get(int id)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Korisnik> query = context.Korisniks.Where(c => c.ID == id);

                domain.Korisnik domainObject = ToDomain(query.Single());

                return domainObject;
            }
        }

        public domain.KorisnikCollection GetByStudiskaProgramaId(int StudiskaProgramaId)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Korisnik> query = context.Korisniks.Where(c => c.Studiska_Programa_ID == StudiskaProgramaId);
                domain.KorisnikCollection domainObjects = ToDomainObjects(query.ToList());

                return domainObjects;
            }
        }

        public domain.Korisnik TryGetByKorisnichkoIme(string korisnichkoIme)
        {
            using (var context = CreateContext())
            {
                var modelObject = context.Korisniks.FirstOrDefault(korisnik => korisnik.Korisnichko_Ime == korisnichkoIme);
                domain.Korisnik result = null;
                if (modelObject != null)
                {
                    result = ToDomain(modelObject);
                }

                return result;
            }
        }

        private domain.KorisnikCollection ToDomainObjects(IEnumerable<model.Korisnik> list)
        {
            domain.KorisnikCollection domainObjects = new domain.KorisnikCollection();
            foreach (model.Korisnik modelObject in list)
            {
                domain.Korisnik domainObject = ToDomain(modelObject);
                domainObjects.Add(domainObject);
            }
            return domainObjects;
        }

        public domain.Korisnik Insert(domain.Korisnik domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Korisnik modelObject = new model.Korisnik();
                modelObject.Korisnichko_Ime = domainObject.Username;
                modelObject.Lozinka = domainObject.PasswordOdNiza;
                modelObject.Ime = domainObject.Ime;
                modelObject.Prezime = domainObject.Prezime;
                modelObject.Pol = ToModel(domainObject.Pol);
                modelObject.Organizacija_ID = domainObject.organizacija.Id;
                modelObject.Email = domainObject.Email;
                modelObject.Telefonski_Broj = domainObject.Mobilen;
                modelObject.Mentor = domainObject.Mentor;
                modelObject.Student = domainObject.Student;
                if (modelObject.Student == true) { modelObject.Studiska_Programa_ID = domainObject.studiskaPrograma.Id; } else { modelObject.Studiska_Programa_ID = null; }
                modelObject.Administrator = domainObject.Administrator;
                context.Korisniks.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Korisnik result = ToDomain(modelObject);
                return result;
            }
        }

        public domain.Korisnik Update(domain.Korisnik domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                IQueryable<model.Korisnik> query = context.Korisniks.Where(p => p.ID == domainObject.Id);
                model.Korisnik modelObject = query.Single();
                modelObject.Korisnichko_Ime = domainObject.Username;
                modelObject.Lozinka = domainObject.PasswordOdNiza;
                modelObject.Ime = domainObject.Ime;
                modelObject.Prezime = domainObject.Prezime;
                modelObject.Pol = ToModel(domainObject.Pol);
                modelObject.Organizacija_ID = domainObject.organizacija.Id;
                modelObject.Email = domainObject.Email;
                modelObject.Telefonski_Broj = domainObject.Mobilen;
                modelObject.Mentor = domainObject.Mentor;
                modelObject.Student = domainObject.Student;
                if (modelObject.Student == true) { modelObject.Studiska_Programa_ID = domainObject.studiskaPrograma.Id; } else { modelObject.Studiska_Programa_ID = null; }
                modelObject.Administrator = domainObject.Administrator;
                context.SubmitChanges();
                domain.Korisnik result = ToDomain(modelObject);
                return result;
            }
        }

        public domain.Korisnik Delete(domain.Korisnik domainObject)
        {
            using (var context = CreateContext())
            {
                var modelObject = context.Korisniks.Single(org => org.ID == domainObject.Id);
                context.Korisniks.DeleteOnSubmit(modelObject);
                context.SubmitChanges();
                var deletedObject = ToDomain(modelObject);
                return deletedObject;
            }
        }

        private domain.Korisnik ToDomain(model.Korisnik modelObject)
        {
            domain.Korisnik domainObject = new domain.Korisnik();
            domainObject.Id = modelObject.ID;
            domainObject.Username = modelObject.Korisnichko_Ime;
            domainObject.PasswordOdNiza = modelObject.Lozinka.ToArray();
            domainObject.Ime = modelObject.Ime;
            domainObject.Prezime = modelObject.Prezime;
            domainObject.Pol = ToDomain(modelObject.Pol);
            domainObject.studiskaPrograma.Id = modelObject.Studiska_Programa_ID.GetValueOrDefault();
            domainObject.organizacija.Id = modelObject.Organizacija_ID;
            domainObject.Email = modelObject.Email;
            domainObject.Mobilen = modelObject.Telefonski_Broj;
            domainObject.Mentor = modelObject.Mentor;
            domainObject.Student = modelObject.Student;
            domainObject.Administrator = modelObject.Administrator;

            return domainObject;
        }


    }
}
