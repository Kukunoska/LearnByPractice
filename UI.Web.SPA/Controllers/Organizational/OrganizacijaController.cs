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
    public class OrganizacijaController : ControllerBase
    {
        [Route("api/organizational/organizacija/site")]
        [HttpGet]
        public IEnumerable<domain::Organizational.Organizacija> Site()
        {
            ProveriDaliImaKorisnik();

            var organizacijaManager = new managers::Organizational.OrganizacijaManager();
            var result = organizacijaManager.GetAll();
            return result;
        }

        [Route("api/organizational/organizacija/zemi")]
        [HttpGet]
        public domain::Organizational.Organizacija Zemi(int id)
        {
            ProveriDaliImaKorisnik();

            var organizacijaManager = new managers::Organizational.OrganizacijaManager();
            var result = organizacijaManager.Get(id);
            return result;
        }

        [Route("api/organizational/organizacija/nova")]
        [HttpPost]
        public domain::Organizational.Organizacija Nova(domain::Organizational.Organizacija organizacija)
        {
            ProveriDaliImaKorisnik();

            var organizacijaManager = new managers::Organizational.OrganizacijaManager();
            var result = organizacijaManager.Insert(organizacija);
            return result;
        }

        [Route("api/organizational/organizacija/izmeni")]
        [HttpPost]
        public domain::Organizational.Organizacija Izmeni(domain::Organizational.Organizacija organizacija)
        {
            ProveriDaliImaKorisnik();

            var organizacijaManager = new managers::Organizational.OrganizacijaManager();
            var result = organizacijaManager.Update(organizacija);
            return result;
        }

        [Route("api/organizational/organizacija/izbrishi")]
        [HttpPost]
        public domain::Organizational.Organizacija Izbrishi(domain::Organizational.Organizacija organizacija)
        {
            ProveriDaliImaKorisnik();

            var organizacijaManager = new managers::Organizational.OrganizacijaManager();
            var result = organizacijaManager.Delete(organizacija);
            return result;
        }
    }
}
