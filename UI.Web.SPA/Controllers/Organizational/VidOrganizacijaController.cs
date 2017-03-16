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
    }
}
