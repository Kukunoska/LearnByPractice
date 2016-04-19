using System;

namespace LearnByPractice.BLL.Managers.Organizational
{
    using LearnByPractice.Domain.Organizational;
    using DAL.Repositories.Organizational;

    public class VidOrganizacijaManager 
    {
        public VidOrganizacijaManager()
        {

        }

        public VidOrganizacijaCollection GetAll()
        {
            VidOrganizacijaManager repository = new VidOrganizacijaManager();
            VidOrganizacijaCollection siteVidOrganizacii = repository.GetAll();

            return siteVidOrganizacii;
        }

        public VidOrganizacijaCollection Insert()
        {
            VidOrganizacijaManager repository = new VidOrganizacijaManager();
            VidOrganizacijaCollection siteVidOrganizacii = repository.Insert();

            return siteVidOrganizacii;
        }

        /* public VidOrganizacijaCollection Update() 
     {
        VidOrganizacijaManager repository = new VidOrganizacijaManager();
          VidOrganizacijaCollection siteVidOrganizacii = repository.Update();

          return siteVidOrganizacii;
     }*/
    }
}