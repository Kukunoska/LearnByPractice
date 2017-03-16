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
    }
}