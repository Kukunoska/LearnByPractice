using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers
{
    public class VidOrganizacijaController : ControllerBase
    {
        [Route("api/organizational/vidorganizacija/site")]
        [HttpGet]
        public IEnumerable<domain::Organizational.VidOrganizacija> Site()
        {
            ProveriDaliEAdministrator();

            var vidOrgManager = new managers::Organizational.VidOrganizacijaManager();
            var result = vidOrgManager.GetAll();
            return result;
        }
        [Route("api/organizational/vidorganizacija/nov")]
        [HttpPost]
        public domain::Organizational.VidOrganizacija nov(domain::Organizational.VidOrganizacija vidOrganizacija)
        {
            ProveriDaliImaKorisnik();

            var vidOrganizacijaManager = new managers.Organizational.VidOrganizacijaManager();
            var result = vidOrganizacijaManager.Insert(vidOrganizacija);
            return result;
        }
        [Route("api/organizational/vidorganizacija/zemi")]
        [HttpGet]
        public domain::Organizational.VidOrganizacija Zemi(int id)
        {
            ProveriDaliImaKorisnik();

            var vidOrganizacijaManager = new managers.Organizational.VidOrganizacijaManager();
            var result = vidOrganizacijaManager.Get(id);
            return result;
        }

        [Route("api/organizational/vidorganizacija/izmeni")]
        [HttpPost]
        public domain::Organizational.VidOrganizacija izmeni(domain::Organizational.VidOrganizacija vidOrganizacija)
        {
            ProveriDaliImaKorisnik();

            var vidOrganizacijaManager = new managers.Organizational.VidOrganizacijaManager();
            var result = vidOrganizacijaManager.Update(vidOrganizacija);
            return result;
        }
        [Route("api/organizational/vidorganizacija/izbrishi")]
        [HttpPost]
        public domain::Organizational.VidOrganizacija izbrishi(domain::Organizational.VidOrganizacija vidOrganizacija)
        {
            ProveriDaliImaKorisnik();

            var vidOrganizacijaManager = new managers.Organizational.VidOrganizacijaManager();
            var result = vidOrganizacijaManager.Delete(vidOrganizacija);
            return result;
        }
    }
}