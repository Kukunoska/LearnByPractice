using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using System.Threading;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Security
{
    public class KorisniciController : ControllerBase
    {
        [Route("api/security/korisnik/tekoven")]
        [HttpGet]
        public domain::Security.Korisnik Tekoven()
        {
            return TekovenKorisnik();
        }

        [Route("api/security/korisnik/site")]
        [HttpGet]
        public IEnumerable<domain::Security.Korisnik> site()
        {
            ProveriDaliImaKorisnik();

            var korisniciManager = new managers.Security.KorisnikManager();
            var result = korisniciManager.GetAll();
            return result;
        }

        [Route("api/security/korisnik/zemi")]
        [HttpGet]
        public domain::Security.Korisnik Zemi(int id)
        {
            ProveriDaliImaKorisnik();

            var korisniciManager = new managers.Security.KorisnikManager();
            var result = korisniciManager.Get(id);
            return result;
        }

        [Route("api/security/korisnik/nov")]
        [HttpPost]
        public domain::Security.Korisnik nov(domain::Security.Korisnik korisnik)
        {
            ProveriDaliImaKorisnik();

            var korisniciManager = new managers.Security.KorisnikManager();
            var result = korisniciManager.Insert(korisnik);
            return result;
        }

        [Route("api/security/korisnik/Izmeni")]
        [HttpPost]
        public domain::Security.Korisnik izmeni(domain::Security.Korisnik korisnik)
        {
            ProveriDaliImaKorisnik();

            var korisniciManager = new managers.Security.KorisnikManager();
            var result = korisniciManager.Update(korisnik);
            return result;
        }

        [Route("api/security/korisnik/izbrishi")]
        [HttpPost]
        public domain::Security.Korisnik izbrishi(domain::Security.Korisnik korisnik)
        {
            ProveriDaliImaKorisnik();

            var korisniciManager = new managers.Security.KorisnikManager();
            var result = korisniciManager.Delete(korisnik);
            return result;
        }
    }
}