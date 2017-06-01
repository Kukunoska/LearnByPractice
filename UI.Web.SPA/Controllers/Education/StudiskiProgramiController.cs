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
        [Route("api/education/studiskaPrograma/zemi")]
        [HttpGet]
        public domain::Education.StudiskaPrograma Zemi(int id)
        {
            ProveriDaliImaKorisnik();

            var studiskaProgramaManager = new managers::Education.StudiskaProgramaManager();
            var result = studiskaProgramaManager.Get(id);
            return result;
        }

        [Route("api/education/studiskaPrograma/nov")]
        [HttpPost]
        public domain::Education.StudiskaPrograma Nov(domain::Education.StudiskaPrograma studiskaPrograma)
        {
            ProveriDaliImaKorisnik();
            //ProveriDalieEAdministrator();

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
        [Route("api/education/studiskaPrograma/izbrishi")]
        [HttpPost]
        public domain::Education.StudiskaPrograma Izbrishi(domain::Education.StudiskaPrograma studiskaPrograma)
        {
            ProveriDaliImaKorisnik();

            var studiskaProgramaManager = new managers::Education.StudiskaProgramaManager();
            var result = studiskaProgramaManager.Delete(studiskaPrograma);
            return result;
        }
    }
}