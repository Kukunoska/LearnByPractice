using System.Collections.Generic;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Practice
{
    public class TehnologiiController : ControllerBase
    {
        [Route("api/practice/tehnologija/site")]
        [HttpGet]
        public IEnumerable<domain::Practice.Tehnologija> site()
        {
            ProveriDaliImaKorisnik();

            var tehnologiiManager = new managers.Practice.TehnologijaManager();
            var result = tehnologiiManager.GetAll();
            return result;
        }

        [Route("api/practice/tehnologija/zemi")]
        [HttpGet]
        public domain::Practice.Tehnologija Zemi(int id)
        {
            ProveriDaliImaKorisnik();

            var tehnologiiManager = new managers.Practice.TehnologijaManager();
            var result = tehnologiiManager.Get(id);
            return result;
        }

        [Route("api/practice/tehnologija/nov")]
        [HttpPost]
        public domain::Practice.Tehnologija nov(domain::Practice.Tehnologija tehnologija)
        {
            ProveriDaliImaKorisnik();

            var tehnologiiManager = new managers.Practice.TehnologijaManager();
            var result = tehnologiiManager.Insert(tehnologija);
            return result;
        }

        [Route("api/practice/tehnologija/Izmeni")]
        [HttpPost]
        public domain::Practice.Tehnologija izmeni(domain::Practice.Tehnologija tehnologija)
        {
            ProveriDaliImaKorisnik();

            var tehnologiiManager = new managers.Practice.TehnologijaManager();
            var result = tehnologiiManager.Update(tehnologija);
            return result;
        }

        [Route("api/practice/tehnologija/izbrishi")]
        [HttpPost]
        public domain::Practice.Tehnologija izbrishi(domain::Practice.Tehnologija tehnologija)
        {
            ProveriDaliImaKorisnik();

            var tehnologiiManager = new managers.Practice.TehnologijaManager();
            var result = tehnologiiManager.Delete(tehnologija);
            return result;
        }
    }
}