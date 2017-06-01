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
        public VidOrganizacija Get(int id)
        {
            var repository = new VidOrganizacijaRespository();
            var result = repository.Get(id);
            return result;
        }

        public VidOrganizacija Update(VidOrganizacija domainObject)
        {
            VidOrganizacijaRespository repository = new VidOrganizacijaRespository();
            VidOrganizacija siteVidoviOrganizacii = repository.Update(domainObject);

            return siteVidoviOrganizacii;
        }

        public VidOrganizacija Delete(VidOrganizacija domainObject)
        {
            var repository = new VidOrganizacijaRespository();
            var izbrishanVidOrganizacija = repository.Delete(domainObject);
            return izbrishanVidOrganizacija;
        }
    }
}

