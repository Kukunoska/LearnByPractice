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

        public Predmet Get(int id)
        {
            PredmetRepository repository = new PredmetRepository();
            var result = repository.Get(id);
            return result;
        }

        public Predmet Insert(Domain.Education.Predmet domainObject)
        {
            PredmetRepository manager = new PredmetRepository();
            Predmet predmet = manager.Insert(domainObject);

            return predmet;
        }

       public Predmet Update(Domain.Education.Predmet domainObject)
        {
            PredmetRepository repository = new PredmetRepository();
            Predmet predmet = repository.Update(domainObject);

            return predmet;
        }

        public Predmet Delete(Domain.Education.Predmet domainObject)
        {
            PredmetRepository repository = new PredmetRepository();
            Predmet izbrishanPredmet = repository.Delete(domainObject);

            return izbrishanPredmet;
        }
    }
}
