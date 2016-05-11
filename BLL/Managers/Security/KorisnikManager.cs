using System;

namespace LearnByPractice.BLL.Managers.Security
{
    using LearnByPractice.Domain.Security;
    using LearnByPractice.DAL.Repositories.Security;

    public class KorisnikManager : ManagerBase
    {
        public KorisnikManager()
        {

        }

        public KorisnikCollection GetAll()
        {
            KorisnikRepository repository = new KorisnikRepository();
            KorisnikCollection siteKorisnici = repository.GetAll();

            return siteKorisnici;
        }

        public Korisnik Insert(Domain.Security.Korisnik domainObject)
        {
            KorisnikRepository repository = new KorisnikRepository();
            Korisnik siteKorisnici = repository.Insert(domainObject);

            return siteKorisnici;
        }

        public Korisnik Update(Domain.Security.Korisnik domainObject)
        {
            KorisnikRepository repository = new KorisnikRepository();
            Korisnik siteKorisnici = repository.Update(domainObject);

            return siteKorisnici;
        }
    }
}
