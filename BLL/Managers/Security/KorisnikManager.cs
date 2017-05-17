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
            KorisnikRepository manager = new KorisnikRepository();
            KorisnikCollection siteKorisnici = manager.GetAll();

            return siteKorisnici;
        }

        public Korisnik Get(int id)
        {
            KorisnikRepository manager = new KorisnikRepository();
            var result = manager.Get(id);
            return result;
        }

        public Korisnik Insert(Domain.Security.Korisnik domainObject)
        {
            KorisnikRepository manager = new KorisnikRepository();
            Korisnik siteKorisnici = manager.Insert(domainObject);

            return siteKorisnici;
        }

        public Korisnik Update(Domain.Security.Korisnik domainObject)
        {
            KorisnikRepository manager = new KorisnikRepository();
            Korisnik siteKorisnici = manager.Update(domainObject);

            return siteKorisnici;
        }
        
        public Korisnik Delete(Domain.Security.Korisnik domainObject)
        {
            var repository = new KorisnikRepository();
            var izbrishanKorisnik = repository.Delete(domainObject);

            return izbrishanKorisnik;
        }

        public Korisnik TryGetByKorisnichkoIme(string korisnichkoIme)
        {
            var repository = new KorisnikRepository();
            var result = repository.TryGetByKorisnichkoIme(korisnichkoIme);
            return result;
        }
    }
}
