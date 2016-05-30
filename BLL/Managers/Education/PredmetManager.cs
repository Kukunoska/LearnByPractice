using System;

namespace LearnByPractice.BLL.Managers.Education
{
    using LearnByPractice.Domain.Education;
    using LearnByPractice.DAL.Repositories.Education;

    public class PredmetManager : ManagerBase
    {
        public PredmetManager()
        {

        }

        public PredmetCollection GetAll()
        {
            PredmetRepository manager = new PredmetRepository();
            PredmetCollection sitePredmeti = manager.GetAll();

            return sitePredmeti;
        }

        public Predmet Insert(Domain.Education.Predmet domainObject)
        {
            PredmetRepository manager = new PredmetRepository();
            Predmet sitePredmeti = manager.Insert(domainObject);

            return sitePredmeti;
        }

       public Predmet Update(Domain.Education.Predmet domainObject)
        {
            PredmetRepository repository = new PredmetRepository();
            Predmet siteOceni = repository.Update(domainObject);

            return siteOceni;
        }
    }
}

