using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using domain = LearnByPractice.Domain;
using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web.Controllers.Administrator
{
    public class PredmetiController : ControllerBase
    {
        [Route("api/admin/predmeti/site")]
        [HttpGet]
        public IEnumerable<domain::Education.Predmet> Site()
        {
            var predmetiManager = new managers::Education.PredmetManager();
            var result = predmetiManager.GetAll();
            return result;
        }
    }
}
