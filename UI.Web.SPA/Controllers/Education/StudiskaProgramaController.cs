using System.Collections.Generic;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Education
{
    public class StudiskaProgramaController : ControllerBase
    {
        [Route("api/education/studiskaprograma/site")]
        [HttpGet]
        public IEnumerable<domain::Education.StudiskaPrograma> Site()
        {
            ProveriDaliImaKorisnik();

            var studiskaprogramaManager = new managers::Education.StudiskaProgramaManager();
            var result = studiskaprogramaManager.GetAll();
            return result;
        }

       
        [Route("api/education/studiskaprograma/nov")]
        [HttpPost]
        public domain::Education.StudiskaPrograma Nov(domain::Education.StudiskaPrograma studiskaprograma)
        {
            ProveriDaliImaKorisnik();

            var studiskaprogramaManager = new managers::Education.StudiskaProgramaManager();
            var result = studiskaprogramaManager.Insert(studiskaprograma);
            return result;
        }

        [Route("api/education/studiskaprograma/izmeni")]
        [HttpPost]
        public domain::Education.StudiskaPrograma Izmeni(domain::Education.StudiskaPrograma studiskaprograma)
        {
            ProveriDaliImaKorisnik();

            var studiskaprogramaManager = new managers::Education.StudiskaProgramaManager();
            var result = studiskaprogramaManager.Update(studiskaprograma);
            return result;
        }

       
    }
}
