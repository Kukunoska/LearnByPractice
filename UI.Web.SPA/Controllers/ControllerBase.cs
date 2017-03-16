using System.Web.Http;
using System.Threading;
using System.Net;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers
{
    public abstract class ControllerBase: ApiController
    {
        protected domain::Security.Korisnik TekovenKorisnik()
        {
            domain::Security.Korisnik result = null;
            if ((Thread.CurrentPrincipal != null) && (Thread.CurrentPrincipal.Identity != null))
            {
                var korisnikManager = new managers::Security.KorisnikManager();
                result = korisnikManager.TryGetByKorisnichkoIme(Thread.CurrentPrincipal.Identity.Name);
            }

            return result;
        }

        protected void ProveriDaliImaKorisnik(domain::Security.Korisnik korisnik)
        {
            if (korisnik == null) throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        protected void ProveriDaliImaKorisnik()
        {
            ProveriDaliImaKorisnik(TekovenKorisnik());
        }

        protected void ProveriDaliEAdministrator()
        {
            var korisnik = TekovenKorisnik();
            ProveriDaliImaKorisnik(korisnik);
            if (!korisnik.Administrator) throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        protected void ProveriDaliEMentor()
        {
            var korisnik = TekovenKorisnik();
            ProveriDaliImaKorisnik(korisnik);
            if (!korisnik.Mentor) throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        protected void ProveriDaliEStudent()
        {
            var korisnik = TekovenKorisnik();
            ProveriDaliImaKorisnik(korisnik);
            if (!korisnik.Student) throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}