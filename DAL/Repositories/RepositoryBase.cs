

namespace LearnByPractice.DAL.Repositories
{
    using LearnByPractice.DAL.Models;


    public abstract class RepositoryBase
    {

        protected RepositoryBase()
        {
        }

        protected LearnByPracticeDataContext CreateContext()
        {
            LearnByPracticeDataContext context = new LearnByPracticeDataContext();
            context.DeferredLoadingEnabled = false;

            return context;
        }
    }
}
