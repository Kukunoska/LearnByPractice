using System.Collections.Generic;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Practice
{
    public class OblastiController : ControllerBase
    {

        [Route("api/practice/oblast/site")]
        [HttpGet]
        public IEnumerable<domain::Practice.Oblast> site()
        {
            ProveriDaliImaKorisnik();

            var oblastiManager = new managers.Practice.OblastManager();
            var result = oblastiManager.GetAll();
            return result;
        }

        [Route("api/practice/oblast/nov")]
        [HttpPost]
        public domain::Practice.Oblast nov(domain::Practice.Oblast oblast)
        {
            ProveriDaliImaKorisnik();

            var oblastiManager = new managers.Practice.OblastManager();
            var result = oblastiManager.Insert(oblast);
            return result;
        }

        [Route("api/practice/oblast/izmeni")]
        [HttpPost]
        public domain::Practice.Oblast izmeni(domain::Practice.Oblast oblast)
        {
            ProveriDaliImaKorisnik();

            var oblastiManager = new managers.Practice.OblastManager();
            var result = oblastiManager.Update(oblast);
            return result;
        }
    }
}