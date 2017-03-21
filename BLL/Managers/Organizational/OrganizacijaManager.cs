using System;

namespace LearnByPractice.BLL.Managers.Organizational
{
    using LearnByPractice.Domain.Organizational;
    using LearnByPractice.DAL.Repositories.Organizational;

    public class OrganizacijaManager : ManagerBase
    {
        public OrganizacijaManager()
        {

        }

        public OrganizacijaCollection GetAll()
        {
            OrganizacijaRepository manager = new OrganizacijaRepository();
            OrganizacijaCollection siteOrganizacii = manager.GetAll();

            return siteOrganizacii;
        }

        public Organizacija Get(int id)
        {
            var repository = new OrganizacijaRepository();
            var result = repository.Get(id);
            return result;
        }

        public Organizacija Insert(Organizacija domainObject)
        {
            OrganizacijaRepository repository = new OrganizacijaRepository();
            Organizacija organizacija = repository.Insert(domainObject);

            return organizacija;
        }

        public Organizacija Update(Organizacija domainObject)
        {
            OrganizacijaRepository repository = new OrganizacijaRepository();
            Organizacija organizacija = repository.Update(domainObject);

            return organizacija;
        }

        public Organizacija Delete(Organizacija domainObject)
        {
            var repository = new OrganizacijaRepository();
            var izbrishanaOrganizacija = repository.Delete(domainObject);
            return izbrishanaOrganizacija;
        }
    }
}