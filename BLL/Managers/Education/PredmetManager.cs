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
            PredmetRepository repository = new PredmetRepository();
            PredmetCollection sitePredmeti = repository.GetAll();

            return sitePredmeti;
        }

        public Predmet Insert(Domain.Education.Predmet domainObject)
        {
            PredmetRepository repository = new PredmetRepository();
            Predmet sitePredmeti = repository.Insert(domainObject);

            return sitePredmeti;
        }

      /*  public Predmet Update(Domain.Education.Predmet domainObject)
        {
            PredmetRepository repository = new PredmetRepository();
            Predmet siteOceni = repository.Update(domainObject);

            return siteOceni;
        }*/
    }
}

