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
            domain.KorisnikCollection result = new domain.KorisnikCollection();
            foreach (model.Korisnik modelObject in query)
            {
                domain.Korisnik domainObject = new domain.Korisnik();
                domainObject.Id = modelObject.ID;
                domainObject.Username = modelObject.Korisnichko_Ime;
                //domainObject.Password = modelObject.Lozinka;
                domainObject.Ime = modelObject.Ime;
                domainObject.Prezime = modelObject.Prezime;
                domainObject.Pol = ToDomain(modelObject.Pol);
                domainObject.studiskaPrograma.Ime = modelObject.Studiska_Programa.Ime;
                domainObject.organizacija.Ime = modelObject.Organizacija.Ime;
                domainObject.Email = modelObject.Email;
                domainObject.Mobilen = modelObject.Telefonski_Broj;

                result.Add(domainObject);
            }

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

        private domain.KorisnikCollection ToDomainObjects(List<model.Korisnik> list)
        {
            domain.KorisnikCollection domainObjects = new domain.KorisnikCollection();
            foreach (model.Korisnik modelObject in list)
            {

                domain.Korisnik domainObject = new domain.Korisnik();
                domainObject.Id = modelObject.ID;
                domainObject.Username = modelObject.Korisnichko_Ime;
                //domainObject.Password = modelObject.Lozinka;
                domainObject.Ime = modelObject.Ime;
                domainObject.Prezime = modelObject.Prezime;
                domainObject.Pol = ToDomain(modelObject.Pol);
                domainObject.studiskaPrograma.Ime = modelObject.Studiska_Programa.Ime;
                domainObject.organizacija.Ime = modelObject.Organizacija.Ime;
                domainObject.Email = modelObject.Email;
                domainObject.Mobilen = modelObject.Telefonski_Broj;

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
                //modelObject.Lozinka = domainObject.Password;
                modelObject.Ime = domainObject.Ime;
                modelObject.Prezime = domainObject.Prezime;
                modelObject.Pol = ToModel(domainObject.Pol);
                modelObject.Studiska_Programa.Ime = domainObject.studiskaPrograma.Ime;
                modelObject.Organizacija.Ime = domainObject.organizacija.Ime;
                modelObject.Email = domainObject.Email;
                modelObject.Telefonski_Broj = domainObject.Mobilen;
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
                //modelObject.Lozinka = domainObject.Password;
                modelObject.Ime = domainObject.Ime;
                modelObject.Prezime = domainObject.Prezime;
                modelObject.Pol = ToModel(domainObject.Pol);
                modelObject.Studiska_Programa.Ime = domainObject.studiskaPrograma.Ime;
                modelObject.Organizacija.ID = domainObject.organizacija.Id;
                modelObject.Email = domainObject.Email;
                modelObject.Telefonski_Broj = domainObject.Mobilen;
                context.SubmitChanges();
                domain.Korisnik result = ToDomain(modelObject);
                return result;
            }
        }


        private domain.Korisnik ToDomain(model.Korisnik modelObject)
        {
            domain.Korisnik domainObject = new domain.Korisnik();
            domainObject.Id = modelObject.ID;
            domainObject.Username = modelObject.Korisnichko_Ime;
            //domainObject.Password = modelObject.Lozinka;
            domainObject.Ime = modelObject.Ime;
            domainObject.Prezime = modelObject.Prezime;
            domainObject.Pol = ToDomain(modelObject.Pol);
            domainObject.studiskaPrograma.Ime = modelObject.Studiska_Programa.Ime;
            domainObject.organizacija.Ime = modelObject.Organizacija.Ime;
            domainObject.Email = modelObject.Email;
            domainObject.Mobilen = modelObject.Telefonski_Broj;

            return domainObject;
        }


    }
}
