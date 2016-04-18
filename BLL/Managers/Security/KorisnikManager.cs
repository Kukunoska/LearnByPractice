using System;

namespace LearnByPractice.BLL.Managers.Security
{
    using LearnByPractice.Domain.Security;
    using DAL.Repositories.Security;

    public class KorisnikManager : ManagerBase
    {
        public KorisnikManager()
        {

        }

        public KorisnikCollection GetAll()
        {
            KorisnikManager repository = new KorisnikManager();
            KorisnikCollection siteKorisnici = repository.GetAll();

            return siteKorisnici;
        }

        public KorisnikCollection Insert()
        {
            KorisnikManager repository = new KorisnikManager();
            KorisnikCollection siteKorisnici = repository.Insert();

            return siteKorisnici;
        }

        /* public KorisnikCollection Update() 
     {
        KorisnikManager repository = new KorisnikManager();
          KorisnikCollection siteKorisnici = repository.Update();

          return siteKorisnici;
    }*/
    }
}
