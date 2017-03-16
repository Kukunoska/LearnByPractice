using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Organizational
{
    public class KompanijaController : ControllerBase
    {
        [Route("api/organizational/kompanija/site")]
        [HttpGet]
        public IEnumerable<domain::Organizational.Kompanija> Site()
        {
            ProveriDaliImaKorisnik();

            var kompanijaManager = new managers::Organizational.KompanijaManager();
            var result = kompanijaManager.GetAll();
            return result;
        }

        [Route("api/organizational/kompanija/zemi")]
        [HttpGet]
        public domain::Organizational.Kompanija Zemi(int id)
        {
            ProveriDaliImaKorisnik();

            var kompanijaManager = new managers::Organizational.KompanijaManager();
            var result = kompanijaManager.Get(id);
            return result;
        }

        [Route("api/organizational/kompanija/nova")]
        [HttpPost]
        public domain::Organizational.Kompanija Nova(domain::Organizational.Kompanija novaKompanija)
        {
            ProveriDaliImaKorisnik();

            var kompanijaManager = new managers::Organizational.KompanijaManager();
            var result = kompanijaManager.Insert(novaKompanija);
            return result;
        }

        [Route("api/organizational/kompanija/izmeni")]
        [HttpPost]
        public domain::Organizational.Kompanija Izmeni(domain::Organizational.Kompanija kompanija)
        {
            ProveriDaliImaKorisnik();

            var kompanijaManager = new managers::Organizational.KompanijaManager();
            var result = kompanijaManager.Update(kompanija);
            return result;
        }

        [Route("api/organizational/kompanija/izbrishi")]
        [HttpPost]
        public domain::Organizational.Kompanija Izbrishi(domain::Organizational.Kompanija kompanija)
        {
            ProveriDaliImaKorisnik();

            var kompanijaManager = new managers::Organizational.KompanijaManager();
            var result = kompanijaManager.Delete(kompanija);
            return result;
        }
    }
}
