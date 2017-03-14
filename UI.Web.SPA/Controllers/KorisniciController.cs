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

namespace LearnByPractice.UI.Web.Controllers
{
    public class KorisniciController : ControllerBase
    {
        [Route("api/security/korisnici/tekoven")]
        [HttpGet]
        public domain::Security.Korisnik TekovenKorisnik()
        {
            domain::Security.Korisnik result = null;
            if ((Thread.CurrentPrincipal != null) && (Thread.CurrentPrincipal.Identity != null))
            {
                var korisnikManager = new managers::Security.KorisnikManager();
                result = korisnikManager.TryGetByKorisnichkoIme(Thread.CurrentPrincipal.Identity.Name);
            }

            return result;
        }
    }
}