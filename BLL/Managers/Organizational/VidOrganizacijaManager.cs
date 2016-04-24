using System;

namespace LearnByPractice.BLL.Managers.Organizational
{
    using LearnByPractice.Domain.Organizational;
    using DAL.Repositories.Organizational;

    public class VidOrganizacijaManager : ManagerBase
    {
        public VidOrganizacijaManager()
        {

        }

        public VidOrganizacijaCollection GetAll()
        {
            VidOrganizacijaRespository repository = new VidOrganizacijaRespository();
            VidOrganizacijaCollection siteVidOrganizacii = repository.GetAll();

            return siteVidOrganizacii;
        }

        public VidOrganizacija Insert(Domain.Organizational.VidOrganizacija domainObject)
        {
            VidOrganizacijaRespository repository = new VidOrganizacijaRespository();
            VidOrganizacija siteVidOrganizacii = repository.Insert(domainObject);

            return siteVidOrganizacii;
        }

        /* public VidOrganizacijaCollection Update() 
     {
        VidOrganizacijaRespository repository = new VidOrganizacijaRespository();
          VidOrganizacijaCollection siteVidOrganizacii = repository.Update();

          return siteVidOrganizacii;
     }*/
    }
}