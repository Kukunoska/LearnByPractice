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

        [Route("api/education/predmet/zemi")]
        [HttpGet]
        public domain::Education.Predmet Zemi(int id)
        {
            ProveriDaliImaKorisnik();

            var predmetManager = new managers::Education.PredmetManager();
            var result = predmetManager.Get(id);
            return result;
        }

        [Route("api/education/predmet/nov")]
        [HttpPost]
        public domain::Education.Predmet Nov(domain::Education.Predmet predmet)
        {
            ProveriDaliImaKorisnik();

            var predmetManager = new managers::Education.PredmetManager();
            var result = predmetManager.Insert(predmet);
            return result;
        }

        [Route("api/education/predmet/izmeni")]
        [HttpPost]
        public domain::Education.Predmet Izmeni(domain::Education.Predmet predmet)
        {
            ProveriDaliImaKorisnik();

            var predmetManager = new managers::Education.PredmetManager();
            var result = predmetManager.Update(predmet);
            return result;
        }

        [Route("api/education/predmet/izbrishi")]
        [HttpPost]
        public domain::Education.Predmet Izbrishi(domain::Education.Predmet predmet)
        {
            ProveriDaliImaKorisnik();

            var predmetManager = new managers::Education.PredmetManager();
            var result = predmetManager.Delete(predmet);
            return result;
        }
    }
}
