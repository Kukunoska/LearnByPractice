using System.Collections.Generic;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Education
{
    public class PredmetiController : ControllerBase
    {
        [Route("api/education/predmet/site")]
        [HttpGet]
        public IEnumerable<domain::Education.Predmet> Site()
        {
            ProveriDaliImaKorisnik();

            var predmetiManager = new managers::Education.PredmetManager();
            var result = predmetiManager.GetAll();
            return result;
        }
    }
}
