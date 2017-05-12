using System.Collections.Generic;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Education
{
    public class StudiskiProgramiController : ControllerBase
    {
        [Route("api/education/studiskaPrograma/site")]
        [HttpGet]
        public IEnumerable<domain::Education.StudiskaPrograma> Site()
        {
            ProveriDaliImaKorisnik();

            var studiskiProgramiManager = new managers.Education.StudiskaProgramaManager();
            var result = studiskiProgramiManager.GetAll();
            return result;
        }

        [Route("api/education/studiskaPrograma/nov")]
        [HttpPost]
        public domain::Education.StudiskaPrograma Nov(domain::Education.StudiskaPrograma studiskaPrograma)
        {
            ProveriDaliImaKorisnik();

            var studiskaProgramaManager = new managers.Education.StudiskaProgramaManager();
            var result = studiskaProgramaManager.Insert(studiskaPrograma);
            return result;
        }

        [Route("api/education/studiskaPrograma/izmeni")]
        [HttpPost]
        public domain::Education.StudiskaPrograma Izmeni(domain::Education.StudiskaPrograma studiskaPrograma)
        {
            ProveriDaliImaKorisnik();

            var studiskaProgramaManager = new managers.Education.StudiskaProgramaManager();
            var result = studiskaProgramaManager.Update(studiskaPrograma);
            return result;
        }
    }
}