using System;
using System.Collections.Generic;
using System.Linq;



namespace DAL.Repositories.Security
{
    using model = DAL.Models;
    using domain = LearnByPractice.Domain.Security;

    class KorisnikRepository : RepositoryBase
    {

        public KorisnikRepository()
        {
        }
        public domain.KorisnikCollection GetAll() 
    {
        model.LearnByPracticeDataContext context = CreateContext();
        IQueryable<model.Korisnik> query = context.Korisniks;
                domain.KorisnikCollection result = new domain.KorisnikCollection();
                foreach (model.Korisnik modelObject in query)
                {
                    domain.Korisnik domainObject = new domain.Korisnik();
                    domainObject.IdKorisnik = modelObject.ID;
                    domainObject.Username = modelObject.Korisnichko_Ime;
                    //domainObject.Password = modelObject.Lozinka;
                    domainObject.Ime = modelObject.Ime;
                    domainObject.Prezime = modelObject.Prezime;
                    //domainObject.Pol = modelObject.Pol;
                    //domainObject.StudiskaPrograma = modelObject.Studiska_Programa;
                    // domainObject.Organizacija = modelObject.Organizacija;
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
            throw new NotImplementedException();
        }

        public domain.Korisnik Insert(domain.Korisnik domainObject)
        {
            using (model.LearnByPracticeDataContext context = CreateContext())
            {
                model.Korisnik modelObject = new model.Korisnik();
                domainObject.Username = modelObject.Korisnichko_Ime;
                //domainObject.Password = modelObject.Lozinka;
                domainObject.Ime = modelObject.Ime;
                domainObject.Prezime = modelObject.Prezime;
                //domainObject.Pol = modelObject.Pol;
                // domainObject.StudiskaPrograma = modelObject.Studiska_Programa;
                // domainObject.Organizacija = modelObject.Organizacija;
                domainObject.Email = modelObject.Email;
                domainObject.Mobilen = modelObject.Telefonski_Broj;
                context.Korisniks.InsertOnSubmit(modelObject);
                context.SubmitChanges();
                domain.Korisnik result = ToDomain(modelObject);

                return result;

            }
        }

        private domain.Korisnik ToDomain(model.Korisnik korisnik)
        {
            throw new NotImplementedException();
        }


    }
}

