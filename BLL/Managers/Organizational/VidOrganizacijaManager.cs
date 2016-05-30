using System;

namespace LearnByPractice.BLL.Managers.Organizational
{
    using LearnByPractice.Domain.Organizational;
    using LearnByPractice.DAL.Repositories.Organizational;

    public class VidOrganizacijaManager : ManagerBase
    {
        public VidOrganizacijaManager()
        {

        }

        public VidOrganizacijaCollection GetAll()
        {
            VidOrganizacijaRespository manager = new VidOrganizacijaRespository();
            VidOrganizacijaCollection siteVidOrganizacii = manager.GetAll();

            return siteVidOrganizacii;
        }

        public VidOrganizacija Insert(Domain.Organizational.VidOrganizacija domainObject)
        {
            VidOrganizacijaRespository manager = new VidOrganizacijaRespository();
            VidOrganizacija siteVidOrganizacii = manager.Insert(domainObject);

            return siteVidOrganizacii;
        }

    
    }
}