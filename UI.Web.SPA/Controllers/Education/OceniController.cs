using System.Collections.Generic;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Education
{
    public class OceniController : ControllerBase
    {
        [Route("api/education/ocena/site")]
        [HttpGet]
        public IEnumerable<domain::Education.Ocena> Site()
        {
            ProveriDaliImaKorisnik();

            var oceniManager = new managers::Education.OcenaManager();
            var result = oceniManager.GetAll();
            return result;
        }

        [Route("api/education/ocena/nov")]
        [HttpPost]
        public domain::Education.Ocena Nov(domain::Education.Ocena ocena)
        {
            ProveriDaliImaKorisnik();

            var ocenaManager = new managers.Education.OcenaManager();
            var result = ocenaManager.Insert(ocena);
            return result;
        }

        [Route("api/education/ocena/izmeni")]
        [HttpPost]
        public domain::Education.Ocena Izmeni(domain::Education.Ocena ocena)
        {
            ProveriDaliImaKorisnik();

            var ocenaManager = new managers.Education.OcenaManager();
            var result = ocenaManager.Update(ocena);
            return result;
        }

    }
}